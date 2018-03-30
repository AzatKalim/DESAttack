using System;
using System.Collections;

namespace DESAttack
{
	public class DESKey 
	{
		private ulong key;
        public static ulong LastKey;

		public DESKey(ulong key)
		{
			this.key = key;
            LastKey = key;
		}

		public byte[] GetEncoded()
		{
			return BitConverter.GetBytes(key);
		}

        public static DESKey RandomKey()
        {
            Random random = new Random();
            byte[] buffer = new byte[8];
            random.NextBytes(buffer);
            var bits = new BitArray(buffer);
            for (int i = 0; i < bits.Count; i += 8)
            {
                byte counter = 0;
                for (int j = 0; j < 7; j++)
                    if (bits[i + j] == true)
                        counter++;
                if (counter % 2 == 0)
                    bits[i + 7] = true;
                else
                    bits[i + 7] = false;
            }
            bits.CopyTo(buffer, 0);

            return new DESKey(BitConverter.ToUInt64(buffer, 0));
        }
	}
}
