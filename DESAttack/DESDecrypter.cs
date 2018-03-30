namespace DESAttack
{
	public class DESDecrypter 
	{
		public byte[] Decrypt(byte[] message, DESKey key)
		{
			byte[] coded = new byte[message.Length];
			System.Buffer.BlockCopy(message, 0, coded, 0, message.Length);
			int blocks = message.Length / 8;
			for (int i = 0; i < blocks; i++)
			{
				byte[] block = new byte[8];
				System.Buffer.BlockCopy(message, i * 8, block, 0, 8);
				byte[] codedBlock = new byte[8];
				byte[,] schedule = new byte[16, 6];
				DES.KeySchedule(key.GetEncoded(), schedule, DES.DECRYPT);
				DES.Crypt(block, codedBlock, DES.ToJaggedArray(schedule));
				System.Buffer.BlockCopy(codedBlock, 0, coded, i * 8, 8);
			}
			return coded;
		}
	}
}
