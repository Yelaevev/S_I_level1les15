using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool LineAnalysis(string line)
        {
            bool Answer = true;
            int check = 0;
            int len = 0;
            int temp = 0;

            for (int i=0;i<line.Length;i++)
            {
                //Console.Write(line[i] + "проверка на левак");
                //char t = line[i];
                if ((line[i] != '*')&&(line[i] != '.')) 
                {
                    return false;
                }

            }

            if ((line[0] != '*') || (line[line.Length - 1] != '*'))
            {
                char test1 = line[0];
                char test2 = line[line.Length - 1];
                //Console.WriteLine(test1 + "=первый элемент" + test2 + "=последний");
                Answer = false;
                return Answer;
            }

            
            var Index = new List<int>();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '*')
                {
                    Index.Add(i);
                    check = check + 1;

                }
            }

            if (line.Length == check)
            {
                Answer = true;
                return Answer; ;
            }

            //foreach (int t in Index) Console.Write(t + " ");
            if (check > 2)
            {
                temp = Index[0];
                len = Index[1] - Index[0];

                for (int i = 2; i < check; i++)
                {
                    temp = Index[i - 1];
                    if (len != Index[i] - Index[i - 1])
                    {
                        Answer = false;
                        return Answer;
                    }
                }

            }
           
            return Answer;
        }
        //static void Main(string[] args)
        //{
        //    string line = "*";
        //    Console.WriteLine(line);
        //    Console.WriteLine();
        //    bool Answer = LineAnalysis(line);

        //    Console.WriteLine("\n"+Answer);
        //}
    }
}
