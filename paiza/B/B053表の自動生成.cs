﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

#region
/*
 入力例1
5 5
1 2
3 4

出力例1
1 2 3 4 5 
3 4 5 6 7 
5 6 7 8 9 
7 8 9 10 11 
9 10 11 12 13

入力例2
5 7 
1 5 
-2 1

出力例2
1 5 9 13 17 21 25 
-2 1 4 7 10 13 16 
-5 -3 -1 1 3 5 7 
-8 -7 -6 -5 -4 -3 -2 
-11 -11 -11 -11 -11 -11 -11
     
     */
#endregion


namespace paiza3
{
    class B053表の自動生成
    {
        public void Do()
        {
            List<int> input_1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            List<int> input_2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            List<int> input_3 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            
            int[,] table = new int[input_1[0], input_1[1]];
            
            setTableVal(input_1,input_2,input_3,ref table);

            for(int i = 0; i < table.GetLength(0); i++)
            {
                string output = "";
                for(int j= 0; j < table.GetLength(1); j++)
                {
                    if (String.IsNullOrEmpty(output))
                    {
                        output += table[i, j].ToString();
                    }
                    else
                    {
                        output += " " + table[i, j].ToString();
                    }
                }
                Console.WriteLine(output);
            }
        }
        private void setTableVal(List<int> lst,List<int> lst0,List<int> lst1,ref int[,] t)
        {
            ////1行目
            //int r0d = lst0[1] - lst0[0]; //等差
            //setRowVal(lst0[0], r0d, 0, ref t);

            ////2行目
            //int r1d = lst1[1] - lst1[0];
            //setRowVal(lst1[0], r1d, 1, ref t);
            
            for (int row_num = 0; row_num < t.GetLength(0); row_num++)
            {
                int d;
                switch (row_num)
                {
                    case 0:
                        d = lst0[1] - lst0[0];
                        setRowVal(lst0[0], d, row_num, ref t);
                        break;
                    case 1:
                        d = lst1[1] - lst1[0];
                        setRowVal(lst1[0], d, row_num, ref t);
                        break;
                    default:
                        //int x_0 = t[row_num - 2,0] + t[row_num - 1,0];
                        //int x_1 = t[row_num - 2, 1] + t[row_num - 1, 1];
                        //d = x_1 - x_0;
                        int d_tate0 = t[row_num - 1, 0] - t[row_num - 2, 0];
                        int d_tate1 = t[row_num - 1, 1] - t[row_num - 2, 1];
                        int x_0 = t[row_num - 1, 0] + d_tate0;
                        int x_1 = t[row_num - 1, 1] + d_tate1;
                        d = x_1 - x_0;
                        setRowVal(x_0, d, row_num, ref t);
                        break;
                }  
            }
        }
        private void setRowVal(int a,int d,int rowCnt,ref int[,] t)
        {
            for(int col_num = 0;col_num < t.GetLength(1); col_num++)
            {
                t[rowCnt, col_num] = a + ( d * col_num);
            }
        }

        //2次元配列用に入れ物を用意する
        //public struct IndexedItem2<T>
        //{
        //    public T Element { get; }
        //    public int X { get; }
        //    public int Y { get; }
        //    internal IndexedItem2(T element, int x, int y)
        //    {
        //        this.Element = element;
        //        this.X = x;
        //        this.Y = y;
        //    }
        //}

        //拡張メソッド
        //public static IEnumerable<IndexedItem2<T>> WithIndex<T>(this T[,] self)
        //{
        //    if(self == null)
        //    {
        //        throw new ArgumentNullException(nameof(self));
        //    }
        //    for (int x = 0; x < self.GetLength(0); x++)
        //        for (int y = 0; y < self.GetLength(1); y++)
        //            yield return new IndexedItem2<T>(self[x, y], x, y);
        //}
        //
        public  void Do1()
        {
            //input 1st row [0]に行数　[1]に列数が入る
            List<int> LstArr_1stRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            DataTable dataTable = new DataTable("table1");
            DataRow dr;

            //DataTableの列を生成
            for(int i = 0; i < LstArr_1stRow[1]; i++)
            {
                string columnName = "coiumn" + i.ToString();
                dataTable.Columns.Add(columnName,Type.GetType("System.Int32"));
            }

            //2nd row
            List<int> LstArr_2ndRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            //3rd row
            List<int> LstArr_3rdRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            //行（横方向）の等差を取得


            //列（縦方向）の等差を取得


            //DataTableに値をセット
        }
        ///// <summary>
        ///// 横方向の等差を返す
        ///// </summary>
        ///// <param name="arg_lst2ndrow"></param>
        ///// <returns>横の等差</returns>
        //private int getHorizonTousa(List<int> arg_lst2ndrow,int arg_rownum)
        //{
            
        //    return arg_lst2ndrow[1] - arg_lst2ndrow[0];
        //}
        /// <summary>
        /// 1,2行目をセット
        /// </summary>
        /// <param name="arg_lst2ndrow"></param>
        /// <param name="arg_lst3rdrow"></param>
        /// <returns>縦の等差</returns>
        private void set12row(List<int> arg_lst1strow,ref List<int> arg_lst2ndrow, ref List<int> arg_lst3rdrow,ref DataTable dataTable)
        {
            int colcnt = arg_lst1strow[1];
            int rowcnt = arg_lst1strow[0];

            int row1diff = arg_lst2ndrow[1] - arg_lst2ndrow[0];
            int row2diff = arg_lst3rdrow[1] - arg_lst3rdrow[0];

            for(int i = 1; i < rowcnt-1; i++)
            {
                arg_lst2ndrow.Add(arg_lst2ndrow[i] + row1diff);
                arg_lst3rdrow.Add(arg_lst3rdrow[i] + row2diff);
            }
            DataRow dr;
            for(int i = 0; i < 2; i++)
            {
                dr = dataTable.NewRow();

            }
        }



    }
}
