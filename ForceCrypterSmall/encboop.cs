using System;
using System.Text;
using System.Security.Cryptography;

namespace ForceCrypterSmall
{

    
    public class Encboop
    {
        public static byte[] PolyBabyEncrypt(byte[] input, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            byte[] Out = new byte[input.Length + 1];
            int x = new Random().Next(1, 255);
            for (int i = 0; i <= input.Length - 1; i++) Out[i] = (byte)(input[i] ^ (key[i % key.Length] + x) & 255);
            Out[input.Length] = (byte)x;
            return Out;
        }
        public static byte[] PolyBabyDecrypt(byte[] input, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            byte[] Out = new byte[input.Length - 1];
            int x = input[input.Length - 1];
            for (int i = 0; i <= Out.Length - 1; i++) Out[i] = (byte)(input[i] ^ (key[i % key.Length] + x) & 255);
            return Out;
        }
        public static byte[] PolyDexEncrypt(byte[] plain, string Key)
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
            byte magic = (byte)new Random().Next(byte.MaxValue);
            Array.Resize(ref wholeState, plain.Length + 1);
            wholeState[wholeState.Length - 1] = magic;
            for (int i = 0; i < wholeState.Length - 1; i++) wholeState[i] = (byte)(wholeState[i] ^ expandedKey[i] ^ magic);
            return wholeState;
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
        public static byte[] StairsEncrypt(byte[] Data, string Key)
        {
            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
            for (int i = 0; i <= (Data.Length * 2) + key.Length; i++)
            {
                Data[i % Data.Length] = (byte)((byte)((int)((Data[i % Data.Length]) + (int)(Data[(i + 1) % Data.Length])) % 256) ^ key[i % key.Length]);
            }
            return Data;
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
    }
}
