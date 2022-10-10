using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214058
{
    public class Product_1214058 //product ini base class
    {
        //public string myType = "Book";
        private string myType;
        private string myTitle;
        public Product_1214058()
        {

     
        }
        
        public Product_1214058(string type, string title) //method constructor punya 2 parameter yaitu type & title
        {
            this.myType = type;
            this.myTitle = title;
        }
        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
