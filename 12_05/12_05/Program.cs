using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05
{
    internal class Program
    {
       static Dictionary<string, int> dict = new Dictionary<string, int>();

        static bool IsEmpty(string name)
        {
            if (name == null || name.Length == 0)
                return true;
            else
            {
                return false;
            }
        }
        static string Entry(string name)
        {
            if (IsEmpty(name))
            {
                return "Name error";
            }

            if (dict.ContainsKey(name)) {
                dict[name]++;
                return "I’m watching you!";
                    }
            else
            {
               dict.Add(name, 1);
                return "The addition was successful.";
            }
        }
        static string Exit(string name)
        {
            if (IsEmpty(name))
            {
                return "Name error";
            }
            if (dict.ContainsKey(name))
            {
                dict[name]--;               
            }
            if (dict[name] != 0)
            {
                return "I’m watching you!";
            }
            else
            {
                dict.Remove(name);
                return "good bye";
            }
        }

        static Dictionary<string, int> clearTheDict()
        {
            dict.Clear();
            return dict;
        }
        static Dictionary<string, int> getTheDict()
        {
            return dict;
        }
                static void Main(string[] args)
                {
            
              switch
                }
    }
}
