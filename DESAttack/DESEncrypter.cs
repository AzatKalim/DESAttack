using System.Collections.Generic;
using System;
namespace DESAttack
{
	public class DESEncrypter 
	{
        public static byte[][] Keys;
        public DESEncrypter()
        {
        }
		public byte[] Encrypt(byte[] message, DESKey key)
		{
			byte[] coded = new byte[message.Length];
			Buffer.BlockCopy(message, 0, coded, 0, message.Length);
			int blocks = message.Length / 8;
			for (int i = 0; i < blocks; i ++)
			{
				byte[] block = new byte[8];
				Buffer.BlockCopy(message, i * 8, block, 0, 8);
				byte[] codedBlock = new byte[8];
				byte[,] schedule = new byte[16, 6];
				DES.KeySchedule(key.GetEncoded(), schedule, DES.ENCRYPT);
                Keys = DES.ToJaggedArray(schedule);
				DES.Crypt(block, codedBlock, DES.ToJaggedArray(schedule));
				Buffer.BlockCopy(codedBlock, 0, coded, i * 8, 8);
			}
			return coded;
		}

     
	}
}
