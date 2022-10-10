using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214058
{
    internal class Book_1214058 : Product_1214058 //ini adalah Inheritance
    {
        protected string pageCount;

        public Book_1214058(string type, string title, string pagecount) : base(type, title) //disini terdapat 3 parameter, type, title,dan pagecount
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
