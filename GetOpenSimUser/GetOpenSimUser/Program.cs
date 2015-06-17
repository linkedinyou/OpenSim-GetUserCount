using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace GetOpenSimUser
{
    class Program
    {
        static string getUserCount(string json)
        {
            string r = "";

            string nj = json.Replace("{", "");
            nj = nj.Replace("}", "");
            nj = nj.Replace("\"", "");
            string[] njl = nj.Split(',');

            foreach(string line in njl)
            {
                string[] ar = line.Split(':');

                if (ar[0].Equals("AgntUp"))
                {
                    return ar[1];
                }

            }

            return r;
        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(args[0]);

            Console.Write(getUserCount(text));
        }
    }
}


