using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DESAttack
{
    class LinearCryptanalysis
    {
        const int COUNT = 64;
        const int TEXT_COUNT = 2097152;
        static BinaryReader textFile = new BinaryReader(new FileStream("text.txt",FileMode.Open));
        static BinaryReader codeFile = new BinaryReader(new FileStream("code.txt", FileMode.Open));

        public static void Attack()
        {
            var t = new int[COUNT];
            for (int j = 0; j < TEXT_COUNT; j++)
            {
                var tmp = ReadPair();
                var p = new BitArray(tmp.Item1);
                var c = new BitArray(tmp.Item2);
                var cRight = BitConverter.ToUInt32(tmp.Item2, 4);

                for (ulong i = 0; i < COUNT; i++)
                {
                    var key = BitConverter.GetBytes(i);
                    var f = new BitArray(BitConverter.GetBytes(DES.F(cRight, key)));
                    if (p[7] ^ p[18] ^ p[24] ^ p[43] ^ p[47] ^ c[15] ^ c[38] ^ c[49] ^ c[55] ^ c[60] ^ f[15])
                    {
                        t[i]++;
                    }
                }
            }
            
            var indexes = FindMinMax(t);
            if (Math.Abs(t[indexes.Item2] - TEXT_COUNT / 2) > Math.Abs(t[indexes.Item1] - TEXT_COUNT / 2))
            {
                Console.WriteLine("{0} кандидат max: {1} ",t[indexes.Item2],indexes.Item2);
                Console.WriteLine("{0} кандидат min: {1} ", t[indexes.Item1], indexes.Item1);

            }
            else
            {
                Console.WriteLine("{0} кандидат min: {1} ", t[indexes.Item1], indexes.Item1);
                Console.WriteLine("{0} кандидат max: {1} ", t[indexes.Item2], indexes.Item2);
            }
        }

        public static Tuple<byte[], byte[]> ReadPair()
        {
            var text=textFile.ReadBytes(8);
            var code = codeFile.ReadBytes(8);
            return new Tuple<byte[], byte[]>(text, code);
        }

        public static Tuple<int,int> FindMinMax(int [] array)
        {
            int minIndex= 0;
            int maxIndex = 0;
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    maxIndex = i;
                    max = array[i];
                    continue;
                }
                if (array[i] < min)
                {
                    minIndex = i;
                    min = array[i];
                }
            }
            return new Tuple<int,int>(minIndex,maxIndex);
        }
    }
}
