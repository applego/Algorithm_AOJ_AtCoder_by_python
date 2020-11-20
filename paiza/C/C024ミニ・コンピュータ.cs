﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza3
{
    class C024
    {
        public void Do(string[] args)
        {
            int intCnt = int.Parse( Console.ReadLine());
            string answer = "";

            int i1 = 0;
            int i2 = 0;

            for (int i = 0; i < intCnt; i++)
            {
                //List<string> inputlist = new List<string>();
                //string tempinputstr = Console.ReadLine();
                List<string> inputlist = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                

                switch (inputlist[0])
                {
                    case "SET":
                        switch (inputlist[1])
                        {
                            case "1":
                                i1 = int.Parse(inputlist[2]);
                                break;
                            case "2":
                                i2 = int.Parse(inputlist[2]);
                                break;
                        }
                        break;
                    case "ADD":
                        i2 = i1+ int.Parse(inputlist[1]);
                        break;
                    case "SUB":
                        i2 = i1- int.Parse(inputlist[1]);
                        break;
                }
            }
            Console.WriteLine($"{i1} {i2}");
        }

        protected static string JudgeKanzensuu(int num)
        {
            string retStr = "";

            int SumOfYakusuu = GetYakusuu(num);
            //int AbsSumOfYakusuu = 0;
            if (SumOfYakusuu == num)
            {
                retStr = "perfect";
            }
            else
            {
                //AbsSumOfYakusuu = System.Math.Abs(SumOfYakusuu);
                if(System.Math.Abs(num - SumOfYakusuu) == 1)
                {
                    retStr = "nearly";
                }
                else
                {
                    retStr = "neither";
                }
            }
            return retStr;
        }

        protected static int GetYakusuu(int num)
        {
            int retNum = 0;
            for(int i = 1; i <= 1000 && i < num; i++)
            {
                if(num%i == 0)
                {
                    retNum += i;
                }
            }
            //retNum -= num;
            return retNum;
        }
    }
}

/*
 * N を 2 以上の整数とし、N の約数のうち N 自身を除いたものの和を S とします。 このとき 

・N = S となるような N を完全数
・|N-S| = 1 となるような N をほぼ完全数
 * 
 期待する出力
各 N_i に対して

・N_i が完全数であれば "perfect"
・N_i がほぼ完全数であれば "nearly"
・どちらでもなければ "neither"

と 1 行に出力してください。

最後は改行し、余計な文字、空行を含んではいけません。
条件
すべてのテストケースで以下の条件を満たします。

・1 ≦ Q ≦ 50
・2 ≦ N_i ≦ 1000 (i=1, 2, ..., Q)

入力例1
3
28
16
777
出力例1
perfect
nearly
neither
入力例2
4
3
4
5
6
出力例2
neither
nearly
neither
perfect
  */
