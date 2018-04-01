using System;
using System.Collections;
using System.Text;

namespace DESAttack
{
    static class BitArrayOperations
    {

        public static BitArray ToBitArray(this string text)
        {
            var result = new BitArray(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]=='1')
                {
                    result[i] = true;
                }
            }
            return result;
        }
        public static String ToView(this BitArray array)
        {
            var buffer = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i])
                {
                    buffer.Append('1');
                }
                else
                {
                    buffer.Append('0');
                }
            }
            return buffer.ToString();
        }
        public static void GetRightLeftParts(this BitArray array, ref BitArray leftPart, ref BitArray rightPArt)
        {
            for (int i = 0; i <array.Length/2; i++)
            {
                leftPart[i] = array[i];
                rightPArt[i] = array[i + array.Length / 2];
            }
        }
        
        public static BitArray GetRightPart(this BitArray array)
        {
            var rigthPart= new BitArray(array.Length/2);
            for (int i = 0; i <array.Length/2; i++)
            {
                rigthPart[i] = array[i + array.Length / 2];
            }
            return rigthPart;
        }
        public static BitArray[] GetBlocks(this BitArray array,int blockLength)
        {
            var result = new BitArray[8];
            for (int i = 0; i < result.Length; i++)
			{
			    result[i]=new BitArray(blockLength);
			}
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < blockLength; j++)
                {
                    result[i][j] = array[blockLength *i+j];
                }
            }
            return result;
        }

        public static BitArray UnionArrays(this BitArray[] arrays)
        {
            var length = arrays.Length * arrays[0].Length;
            var index = 0;
            var result = new BitArray(length);
            for (int i = 0; i <arrays.Length; i++)
            {
                for (int j = 0; j < arrays[0].Length; j++)
                {
                    result[index++] = arrays[i][j];
                }
            }
            return result;
        }

        public static BitArray AddBitArray(this BitArray array, BitArray newArray)
        {
            var result = new BitArray(array.Length + newArray.Length);
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result[index++] = array[i];
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                result[index++] = newArray[i];
            }
            return result;
        }

        public static BitArray LeftShift(this BitArray array, int shift)
        {
            var result = new BitArray(array);
            for (int j = 0; j < shift; j++)
            {
                var tmp = result[0];
                for ( var  i = 0; i<array.Length-1; i++) 
                    result[i] = result[i+1];
                result[array.Length-1] = tmp;
            }
            return result;
        }

        public static byte ConvertToByte(this BitArray bits)
        {
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }

        public static String BitArrayToStr(this BitArray array)
        {
            var strArr = new byte[array.Length / 8];

            var temp = array.GetBlocks(8);
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = ConvertToByte(temp[i]);
            }

            var res=Encoding.Unicode.GetString(strArr);
            return res;
        }

        public static BitArray ToBitArray(this int number)
        {
            var result  = new BitArray(4);
            var index = result.Length - 1;
            while (number != 0)
            {
                if (number % 2==1)
                {
                    result[index--]=true;
                }
                else
                {
                    index--;
                }
                number /= 2;
            }
            return result;
        }

        public static void AddOne(ref BitArray array)
        {
            bool mind=true;
            for (int i = array.Length-1; i!=0; i--)
            {
                if (array[i] && mind)
                {
                    array[i] = false;
                    mind = true;
                }
                else
                {
                    if (mind)
                        array[i] = true;
                    break;
                }
            }
        }
    }
}
