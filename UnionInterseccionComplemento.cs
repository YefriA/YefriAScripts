using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Program
  {
    static void Main()
    {
        int[] A = { 0, 15, 6, 6, 12, 3, 0, 12, 18, 12, 18, 9, 6 };
        int[] B = { 0, 6, 12, 18, 4, 6, 2, 2, 0, 10, 12, 18, 16, 6, 14, 8 };
        int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };


        //UNION

        List<int> juntos = new List<int>();

        for (int i = 0; i < A.Length; i++)
        {
            juntos.Add(A[i]);
        }

        for (int i = 0; i < B.Length; i++)
        {
            juntos.Add(B[i]);
        }

        for (int i = 0; i <= juntos.Count; i++)
        {
            for (int n = 0; n < juntos.Count - 1; n++)
            {
                if (juntos[n] > juntos[n + 1])
                {
                    int guardar = juntos[n];
                    juntos[n] = juntos[n + 1];
                    juntos[n + 1] = guardar;
                }

                if (juntos[n] == juntos[n + 1])
                {
                    juntos.RemoveAt(n);
                    n = 0;
                }
            }
        }

        for (int i = 0; i < juntos.Count; i++)
        {
            Console.Write(juntos[i] + ", ");
        }
        Console.WriteLine();

        //INTERSECCION

        List<int> inters = new List<int>();

        for (int i = 0; i < A.Length; i++)
        {
            for (int n = 0; n < B.Length - 1; n++)
            {
                if (A[i] == B[n])
                {
                    inters.Add(A[i]);
                }
            }
        }

        for (int i = 0; i <= inters.Count; i++)
        {
            for (int n = 0; n < inters.Count - 1; n++)
            {
                if (inters[n] > inters[n + 1])
                {
                    int guardar = inters[n];
                    inters[n] = inters[n + 1];
                    inters[n + 1] = guardar;
                }

                if (inters[n] == inters[n + 1])
                {
                    inters.RemoveAt(n);
                    n = 0;
                }
            }
        }

        for (int i = 0; i < inters.Count; i++)
        {
            Console.Write(inters[i] + ", ");
        }
        Console.WriteLine();

        //COMPLEMENTO

        List<int> complemento = new List<int>();

        for (int i = 0; i < U.Length; i++)
        {
            complemento.Add(U[i]);
        }

        for (int i = 0; i < complemento.Count; i++)
        {
            for (int j = 0; j < A.Length; j++)
            {
                if (A[j]==complemento[i])
                {
                    complemento.RemoveAt(i);
                    i = 0;
                }
            }
        }

        for (int i = 0; i < complemento.Count; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                if (B[j] == complemento[i])
                {
                    complemento.RemoveAt(i);
                    i = 0;
                }
            }
        }


        for (int i = 0; i < complemento.Count; i++)
        {
            Console.Write(complemento[i] + ", ");
        }
    }
  }
