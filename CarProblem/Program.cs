using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*April 1st to Sept 30th*/
/*Pattern1: 1, 3, 7, 13, 21 seperated by multiples of 2*/
/*Pattern2: 1, 3, 5, 7, 9 (odd number sequence)*/
/*Assuming pattern2*/

namespace CarProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,int> dict = new Dictionary<String, int>() { ["January"] = 31, ["February"] = 29, ["March"] =31, ["April"] = 30, ["May"] = 31, ["June"] = 30, ["July"] = 31, ["August"] = 31, ["September"] = 30, ["October"] = 31, ["November"] = 30, ["December"] = 31 };
            Console.WriteLine("Enter start month and end month");
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            List<String> list = dict.Keys.ToList();

            List<String> list2 = new List<String>();

            for (int i= 0;i < list.Count;i++)
            {
                if (list[i] == start)
                {
                    while (list[i] != end) { 
                        list2.Add(list[i]);
                        i++;
                    }
                    list2.Add(list[i]);
                }
            }

            Console.WriteLine("Number of Vehicles sold each month: ");
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            int retail = 0;
            int corp = 0;
            foreach (string month in list2)
            {
                int k = 1;
                int mretail = 0;
                int mcorp = 0;
                for(int i = 1; i <= dict[month]; i++)
                {
                    if (i < 5)
                    {
                        mretail += k; continue;
                    }
                    if(i%2==1) mcorp+=k;
                    else
                    {
                        mretail += k;
                    }
                    k += 2;
                }
                dict2.Add(month, mretail+mcorp);
                retail += mretail;
                corp += mcorp;
            }
            foreach (string month in list2)
            {
                Console.WriteLine($"{month} : {dict2[month]}");
            }
            Console.WriteLine($"Number of vehicles sold to retail customers: {retail}");
            Console.WriteLine($"Number of vehicles sold to corporate customers: {corp}");
            Console.WriteLine("Vehicles sold from Aug 15 to Sept 15: ");
            int veh = 0;
            int p = 1;
            for(int i = 1; i <= dict["August"]; i++)
            {
                if (i > 14) veh += p;
                p++;
            }
            p = 1;
            for (int i = 1; i <= dict["August"]; i++)
            {
                if (i <= 15) veh += p;
                p++;
            }
            Console.WriteLine(veh);
        }
    }
}
