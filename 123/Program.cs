using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{

    class Program
    {
        class X
        {
        public string returnSign(int type)//获取符号
        {
            switch (type)
            {
                case 1:
                    return "+";
                case 2:
                    return "-";
                case 3:
                    return "*";
                case 4:
                    return "÷";
            }
            return "";
        }
    }
        static void Main(string[] args)
        {

            List<int> asd = new List<int>();//储存题目中的数字
            Console.Write("请输出出题的数目：");
            int x = Convert.ToInt32(Console.ReadLine());//获得题目的数量
            Random RA = new Random();
            X d = new X();
            for (int i = 0; i < x; i++)
            {

                int g = Convert.ToInt32(RA.Next(2, 4));//获得题目中数字的个数
                switch (g)
                {
                    case 2:
                        for (int time1 = 0; time1 < 2; time1++)
                        {
                            asd.Add(RA.Next(1, 100));
                        }
                        break;
                    case 3:
                        for (int time2 = 0; time2 < 3; time2++)
                        {
                            asd.Add(RA.Next(1, 100));
                        }
                        break;
                    default:
                        break;
                }

                if (g == 2)
                {
                    int h = RA.Next(1, 5);
                    switch (h)
                    {
                        case 1:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + "=");
                            Console.WriteLine(asd[0] + asd[1]);
                            break;
                        case 2:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + "=");
                            int temp0;
                            if (asd[0] < asd[1])
                            {
                                temp0 = asd[0];
                                asd[0] = asd[1];
                                asd[1] = temp0;
                            }
                            Console.WriteLine(asd[0] - asd[1]);
                            break;
                        case 3:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + "=");
                            Console.WriteLine(asd[0] * asd[1]);
                            break;
                        case 4:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + "=");
                            int temp1;
                            if (asd[0] < asd[1])
                            {
                                temp1 = asd[0];
                                asd[0] = asd[1];
                                asd[1] = temp1;
                            }

                            
                            Console.WriteLine(asd[0] / asd[1]);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    int h = RA.Next(1, 5);
                    int j = RA.Next(1, 5);
                    switch (h)
                    {
                        case 1:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + d.returnSign(j) + " " + asd[2] + "=");
                            if (j == 1)
                                Console.WriteLine(asd[0] + asd[1] + asd[2]);
                            else if (j == 2)
                                Console.WriteLine(asd[0] + asd[1] - asd[2]);
                            else if (j == 3)
                                Console.WriteLine(asd[0] + asd[1] * asd[2]);
                            else
                                Console.WriteLine(asd[0] + asd[1] / asd[2]);
                            break; 
                        case 2:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + d.returnSign(j)+" "+asd[2]+ "=");
                            if (j == 1)
                                Console.WriteLine(asd[0] - asd[1] + asd[2]);
                            else if (j == 2)
                                Console.WriteLine(asd[0] - asd[1] - asd[2]);
                            else if (j == 3)
                                Console.WriteLine(asd[0] - asd[1] * asd[2]);
                            else
                                Console.WriteLine(asd[0] - asd[1] / asd[2]);

                            break;
                        case 3:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + d.returnSign(j) + " " + asd[2] + "=");
                            if (j == 1)
                                Console.WriteLine(asd[0] * asd[1] + asd[2]);
                            else if (j == 2)
                                Console.WriteLine(asd[0] * asd[1] - asd[2]);
                            else if (j == 3)
                                Console.WriteLine(asd[0] * asd[1] * asd[2]);
                            else
                                Console.WriteLine(asd[0] * asd[1] / asd[2]);

                            break;
                        case 4:
                            Console.WriteLine(asd[0] + " " + d.returnSign(h) + asd[1] + " " + d.returnSign(j) + " " + asd[2] + "=");
                            if (j == 1)
                                Console.WriteLine(asd[0] / asd[1] + asd[2]);
                            else if (j == 2)
                                Console.WriteLine(asd[0] / asd[1] - asd[2]);
                            else if (j == 3)
                                Console.WriteLine(asd[0] / asd[1] * asd[2]);
                            else
                                Console.WriteLine(asd[0] / asd[1] / asd[2]);


                            break;
                        default:
                            break;
                    }

                }
                asd.Clear();
            }
            
            


        }


        }
    }
