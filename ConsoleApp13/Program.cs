using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string[] arr = { "flower", "flow", "flight" };
            //string[] arr = { "dog", "racecar", "car" };
            //string[] arr = {"","a"};
            string[] arr = {"aaa", "aa","aaa"};
            Console.WriteLine(LongestCommonPrefix(arr));
            Console.ReadLine();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string temp = strs[0];
            string temp2 = "";
            string tempstr = "";
            string mainStr = "";
            if (strs.Length>1)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    tempstr = strs[i];
                    for (int j = 0; j < tempstr.Length; j++)
                    {
                        if (temp.Length > 0)
                        {
                            if (temp[j] == tempstr[j]  )
                            {
                                temp2 += tempstr[j];
                            }
                            else
                            {
                                break;
                            }
                        }
                       
                    }
                    mainStr = temp2;
                    temp2 = "";
                }
            }
            else
            {
                mainStr=strs[0];
            }
            
            return mainStr;

        }
    }
}
