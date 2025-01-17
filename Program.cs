using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region level 1 number 3
            Console.WriteLine("--------level 1 number 3--------");
            int n = 4, m = 4;
            double[,] matrix = new double[n, m];
            double x;
            double summ = 0;
            Console.WriteLine("Enter elements of array:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                    if(i==j) summ += matrix[i, j];
                }
            }
            Console.WriteLine("Sum = {0}", summ);

            #endregion
            #region level 1 number 6
            Console.WriteLine("--------level 1 number 6--------");
            n = 4;
            m = 7;

            matrix = new double[n, m];

            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            double[] array = new double[n];
            int index_min;
            double mini;
            for (int i = 0; i < n; i++)
            {
                mini = matrix[i, 0];
                index_min = 0;

                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < mini)
                    {
                        mini = matrix[i, j];
                        index_min = j;
                    }

                }
                array[i] = index_min;
            }
            Console.WriteLine("Your array:");
            foreach (double el in array) Console.Write($"{el} ");
            Console.WriteLine();
            #endregion
            #region level 1 number 12
            Console.WriteLine("--------level 1 number 12--------");
            n = 6;
            m = 7;
            matrix = new double[n, m];

            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            double maxi = matrix[0, 0];
            int index_max = 0, index_maxj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > maxi)
                    {
                        index_max = i;
                        index_maxj = j;
                        maxi = matrix[i, j];
                    }
                }
            }
            for (int i = index_max; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++) matrix[i, j] = matrix[i + 1, j];
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = index_maxj; j < m - 1; j++) matrix[i, j] = matrix[i, j + 1];
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 1 number 13
            Console.WriteLine("--------level 1 number 13--------");
            n = 5;
            m = 5;
            matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            maxi = matrix[0, 0];
            index_max = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] > maxi)
                {
                    index_max = i;
                    maxi = matrix[i, i];
                }
            }
            double temp;
            for (int i = 0; i < n; i++)
            {
                temp = matrix[i, 3];
                matrix[i, 3] = matrix[i, index_max];
                matrix[i, index_max] = temp;
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 1 number 17
            Console.WriteLine("--------level 1 number 17--------");
            Console.WriteLine("Enter n and m");
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            while (n <= 0 || m <= 0)
            {
                Console.WriteLine("Enter n and m >0");
                int.TryParse(Console.ReadLine(), out n);
                int.TryParse(Console.ReadLine(), out m);

            }
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;

                }
            }
            for (int i = 0; i < n; i++)
            {
                mini = matrix[i, 0];
                index_min = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mini > matrix[i, j])
                    {
                        mini = matrix[i, j];
                        index_min = j;
                    }
                }
                for (int j = index_min; j > 0; j--) matrix[i, j] = matrix[i, j - 1];
                matrix[i, 0] = mini;
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 1 number 29
            Console.WriteLine("--------level 1 number 29--------");
            n = 5;
            m = 7;
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            mini = Math.Abs(matrix[1, 0]);
            index_min = 0;
            for(int j = 0; j < m; j++)
            {
                if (mini > Math.Abs(matrix[1, j]))
                {
                    mini = Math.Abs(matrix[1, j]);
                    index_min = j;
                }
            }
            for(int i = 0; i < n; i++)
            {
                for (int j = index_min + 1; j < m - 1; j++) matrix[i, j] = matrix[i, j + 1];
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 1 number 31
            Console.WriteLine("--------level 1 number 31--------");
            n = 5;
            m = 8;
            matrix = new double[n, m];
            array = new double[n];
            Console.WriteLine("Enter elements of array");
            for(int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            Console.WriteLine("Enter elements of matrix");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m-1; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            index_min = 0;
            mini = matrix[4, 0];
            for(int i = 1; i < m - 1; i++)
            {
                if (matrix[4, i] < mini)
                {
                    index_min = i;
                    mini = matrix[4, i];
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = m - 1; j > index_min; j--)
                {
                    if (j == index_min+1)
                    {
                        matrix[i, j] = array[i];
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 1];
                    }
                }
            }
            Console.WriteLine("Your array:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 2 number 7
            Console.WriteLine("--------level 2 number 7--------");
            n = 6;
            m = 6;
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            maxi = matrix[0, 0];
            index_max = 0;
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > maxi)
                {
                    maxi = matrix[i, i];
                    index_max = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (i < index_max) matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 2 number 8
            Console.WriteLine("--------level 2 number 8--------");
            n = 6;
            m = 6;
            int max_index_int;
            matrix = new double[n, m];
            int[] array2 = new int[n];
            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            for (int i = 0; i < n; i++)
            {
                maxi = matrix[i, 0];
                max_index_int = 0;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > maxi)
                    {
                        maxi = matrix[i, j];
                        max_index_int = j;
                    }
                }
                array2[i] = max_index_int;
            }

            double temp1 = matrix[0, array2[0]];
            matrix[0, array2[0]] = matrix[1, array2[1]];
            matrix[1, array2[1]] = temp1;

            temp1 = matrix[2, array2[2]];
            matrix[2, array2[2]] = matrix[3, array2[3]];
            matrix[3, array2[3]] = temp1;

            temp1 = matrix[4, array2[4]];
            matrix[4, array2[4]] = matrix[5, array2[5]];
            matrix[5, array2[5]] = temp1;

            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 2 number 9
            Console.WriteLine("--------level 2 number 9--------");
            n = 6;
            m = 7;
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m/2; j++){
                    temp = matrix[i, m - 1 - j];
                    matrix[i, m - 1 - j] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
            Console.WriteLine("Your matrix:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 3 number 1
            Console.WriteLine("--------level 3 number 1--------");
            n = 7;
            m = 5;
            matrix = new double[n, m];
            double[,] res = new double[n, m];
            double[,] matr = new double[n, 2];
            Console.WriteLine("Enter elements of matrix");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            
            int temp2;
            double tempr1;
            double tempr2;
            double ind;
            for(int i = 0; i < n; i++)
            {
                mini = matrix[i, 0];
                for(int j = 0; j < m; j++)
                {
                    if (mini > matrix[i, j]) mini = matrix[i, j];
                }
                matr[i, 0] = i;
                matr[i, 1] = mini;
            }
            for(int i= 0; i < n; i++)
            {
                ind = matr[i,0];
                maxi = matr[i,1];
                temp2 = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (matr[j,1] > maxi)
                    {
                        maxi = matr[j,1];
                        ind = matr[j,0];
                        temp2 = j;
                    }
                }
                tempr1 = matr[i,0];
                matr[i,0] = ind;
                matr[temp2,0] = tempr1;
                tempr2 = matr[i, 1];
                matr[i, 1] = maxi;
                matr[temp2, 1] = tempr2;

            }
            for(int i = 0; i < n; i++)
            {
                temp2 = (int)matr[i, 0];
                for (int j = 0; j < m; j++) res[i, j] = matrix[temp2, j];
            }
            Console.WriteLine("Your matrix:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }
            
            #endregion
            #region level 3 number 2
            Console.WriteLine("--------level 3 number 2--------");
            Console.WriteLine("Enter n:");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("Enter n>0");
                int.TryParse(Console.ReadLine(), out n);
            }
            m = n;
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                    if (i == 0 || j == 0 || i == n - 1 || j == m - 1) matrix[i, j] = 0;
                }
            }
            Console.WriteLine("Your matrix:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 3 number 3
            Console.WriteLine("--------level 3 number 3--------");
            Console.WriteLine("Enter n:");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("Enter n>0");
                int.TryParse(Console.ReadLine(), out n);
            }
            m = n;
            array = new double[n * 2 - 1];
            matrix = new double[n, m];
            
            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[j - i + n - 1] += matrix[i, j];
                }
            }
            Console.WriteLine("Your array:");
            foreach (double el in array) Console.Write("{0}", el);
            Console.WriteLine();
            #endregion
            #region level 3 number 4
            Console.WriteLine("--------level 3 number 4--------");
            Console.WriteLine("Enter n:");
            int.TryParse(Console.ReadLine(), out n);
            while (n <= 0)
            {
                Console.WriteLine("Enter n>0");
                int.TryParse(Console.ReadLine(), out n);
            }
            m = n;
            matrix = new double[n, m];

            Console.WriteLine("Enter elements of matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j <= i)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 3 number 8
            Console.WriteLine("--------level 3 number 8--------");
            n = 7;
            m = 5;
            matrix = new double[n, m];
            res = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            matr = new double[n, 2];
            int k = 0;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        k++;
                    }
                }
                matr[i, 0] = i;
                matr[i, 1] = k;
                k = 0;
            }
            for (int i = 0; i < n; i++)
            {
                maxi = matr[i, 1];
                temp2 = i;
                for (int j = 1 + i; j < n; j++)
                {
                    if (matr[j, 1] > maxi)
                    {
                        maxi = matr[j, 1];
                        temp2 = j;
                    }
                }
                temp = matr[i, 0];
                matr[i, 0] = temp2;
                matr[temp2, 0] = temp;
                temp1 = matr[i, 1];
                matr[i, 1] = maxi;
                matr[temp2, 1] = temp1;
            }
            for (int i = 0; i < n; i++)
            {
                temp2 = (int)matr[i, 0];
                for (int j = 0; j < m; j++)
                {
                    res[i, j] = matrix[temp2, j];
                }
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }



            #endregion
            #region level 3 number 10
            Console.WriteLine("--------level 3 number 10--------");
            Console.WriteLine("Enter n and m >0");
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            while (n <= 0 || m <= 0)
            {
                Console.WriteLine("Enter another n and m");
                int.TryParse(Console.ReadLine(), out n);
                int.TryParse(Console.ReadLine(), out m);
            }
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                }
            }
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j = 0; j < m - 1; j++)
                    {
                        maxi = matrix[i, j];
                        index_max = j;
                        for(k = j + 1; k < m; k++)
                        {
                            if (matrix[i, k] > maxi)
                            {
                                maxi = matrix[i, k];
                                index_max = k;
                            }
                        }
                        matrix[i, index_max] = matrix[i, j];
                        matrix[i, j] = maxi;
                    }
                }
                else
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        mini = matrix[i, j];
                        index_min = j;
                        for (k = j + 1; k < m; k++)
                        {
                            if (matrix[i, k] < mini)
                            {
                                mini = matrix[i, k];
                                index_min = k;
                            }
                        }
                        matrix[i, index_min] = matrix[i, j];
                        matrix[i, j] = mini;
                    }
                }
            }
            Console.WriteLine("Your matrix:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region level 3 number 11
            Console.WriteLine("--------level 3 number 11--------");
            Console.WriteLine("Enter n and m >0");
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            while (n <= 0 || m <= 0)
            {
                Console.WriteLine("Enter another n and m");
                int.TryParse(Console.ReadLine(), out n);
                int.TryParse(Console.ReadLine(), out m);
            }
            matrix = new double[n, m];
            Console.WriteLine("Enter elements of matrix");

            k = 0;
            int num = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double.TryParse(Console.ReadLine(), out x);
                    matrix[i, j] = x;
                    if (matrix[i, j] == 0) k++;
                }
                if (k == 0) count++;
                k = 0;
            }
            res = new double[count, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 0) k++;
                }
                if (k == 0)
                {
                    for (int j = 0; j < m; j++) res[num, j] = matrix[i, j];
                    num++;
                }
                k = 0;
            }
            Console.WriteLine("Your matrix:");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
