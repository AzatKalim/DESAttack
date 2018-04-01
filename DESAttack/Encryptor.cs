using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System;

namespace DESAttack
{
	public class Encryptor
	{
        public const ulong TEXT_COUNT = 2097152;
        public const int BYTES_COUNT = 8;
        Encoding encoding = Encoding.Default;
        BitArray key;
        DES des = new DES();
		public Encryptor()
		{
            using (var keyfile = new StreamWriter("key.txt"))
            {
                key = des.GenerateKeys();
                keyfile.Write(key.ToView());
            }
		}

        public string EncodeString(string text)
        {
            return des.Encrypt(new StringBuilder(text)).ToString();
        }

        public string DecodeString(string text)
        {

            return des.Decrypt(new StringBuilder(text)).ToString();
        }

		public byte[] Encode(byte[] msg)
		{
			return des.Encrypt(msg);
		}


        //public byte[] Decode(byte[] msg)
        //{
        //    return des.Decrypt(msg);
        //}

		public void FileEncode(string path)
		{
			var bytes = File.ReadAllBytes(path);
			var encoded = Encode(bytes);
			File.WriteAllBytes("encodeFile.txt", encoded);
		}

        //public void FileDecode(string path)
        //{
        //    var bytes = File.ReadAllBytes(path);
        //    var decoded = Decode(bytes);
        //    var outputName ="decripted.txt";
        //    int tryed = 1;
        //    while (File.Exists(outputName))
        //    {
        //        outputName ="_" + tryed + outputName;
        //        tryed++;
        //    }
        //    File.WriteAllBytes(outputName, decoded);
        //}

        public void PrepairData()
        {
            var textFile= new BinaryWriter(new FileStream("text.txt", FileMode.Create));
            var codefile = new BinaryWriter(new FileStream("code.txt", FileMode.Create));
            for (ulong i = 0; i < TEXT_COUNT; i++)
            {
                var tmp = BitConverter.GetBytes(i);
                textFile.Write(tmp);
                var result = Encode(tmp);
                codefile.Write(result);
            }
            textFile.Close();
            codefile.Close();
        }

	}
}
