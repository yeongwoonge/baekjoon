using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text; // StringBuilder 쓰려면 이거 필수
using System.Threading.Tasks;

namespace baekjoon_solution
{
    internal class Program
    {
        public static int zerocount;
        public static int pluscount;
        public static int minuscount;
        static void Book(int x, int y, int size, int[,] b)
        {
            if (size == 1)
            {
                if (b[x, y] == -1) minuscount++; 
                if (b[x, y] == 1) pluscount++;
                if (b[x, y] == 0) zerocount++;
                return;
            }
            for (int i = x; i < x + size; i++)
            {
                for (int j = y; j < y + size; j++)
                {
                    if (b[x, y] != b[i, j])
                    {
                        int newsize = size / 3;
                        for (int o = 0; o < 3; o++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                Book(x + o * newsize, y + p * newsize, newsize, b);
                            }
                            
                        }
                        return;
                    }
                }
                
            }
            if (b[x, y] == -1) minuscount++;
            if (b[x, y] == 1) pluscount++;
            if (b[x, y] == 0) zerocount++;


        }


                static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); // [출력용]
                                                    //int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
                                                    //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
                                                    //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
                                                    // ------------------------------------------

            int a = int.Parse(Console.ReadLine());
            int[,] b = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < a; j++)
                {
                    b[i, j] = c[j];
                }
            }
            Book(0, 0, a, b);
            sb.Append(minuscount+"\n");
            sb.Append(zerocount+"\n");
            sb.Append(pluscount+"\n");







            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}
