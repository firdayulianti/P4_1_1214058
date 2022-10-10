using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214058
{
    internal class DVD_1214058 : Product_1214058
    {
        protected string duration;

        public DVD_1214058(string title, string duration) //method constractor dengan dua parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD!!!");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
