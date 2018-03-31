using System.IO;
using System.Text;
using System.Collections.Generic;
using System;

namespace DESAttack
{
	public class Encryptor
	{
        public const ulong TEXT_COUNT = 2097152;
        public const int BYTES_COUNT = 8;
		private DESKey key;
		private DESEncrypter encrypter;
		private DESDecrypter decrypter;
        Encoding encoding = Encoding.Default;

		public Encryptor()
		{
            using (var keyfile = new BinaryWriter(new FileStream("key.txt", FileMode.Create)))
            {
                key = DESKey.RandomKey();
                keyfile.Write(key.GetEncoded());
            }
			encrypter = new DESEncrypter();
			decrypter = new DESDecrypter();
		}

        public string EncodeString(string text)
        {
            text = DES.GetMessageRightLength(text);
            var bytes = Encoding.Default.GetBytes(text);
            return Encoding.Default.GetString(Encode(bytes));
        }

        public string DecodeString(string text)
        {

            var bytes = Encoding.Default.GetBytes(text);
            return Encoding.Default.GetString(Decode(bytes));
        }

		public byte[] Encode(byte[] msg)
		{
			return encrypter.Encrypt(msg, key);
		}

		public byte[] Decode(byte[] msg)
		{
			return decrypter.Decrypt(msg, key);
		}

		public void FileEncode(string path)
		{
			var bytes = File.ReadAllBytes(path);
			var encoded = Encode(bytes);
			File.WriteAllBytes("encodeFile.txt", encoded);
		}

		public void FileDecode(string path)
		{
			var bytes = File.ReadAllBytes(path);
			var decoded = Decode(bytes);
			var outputName ="decripted.txt";
			int tryed = 1;
			while (File.Exists(outputName))
			{
                outputName ="_" + tryed + outputName;
				tryed++;
			}
			File.WriteAllBytes(outputName, decoded);
		}

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
