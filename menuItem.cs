using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BB2
{
    public class menuItem
    {
        public static int count;
        public string name {  get; set; }
        public string property { get; set; }

        private int price;

      public int Price
        {
            get { return price; }
            set 
            { 
               price = value < 0 ? 0 : value;
            }
        }

        public bool isAvaiable { get; set; }

       

        public menuItem(string Name, string Property, int Pricee)
        {
            name = Name;
            property = Property;
            price = Pricee;
            isAvaiable = true;
            count++;
           


        }
        public void sellOUT()
        {
            isAvaiable = false;
        }
        public void  reStock()
        {
            isAvaiable = true;
        }
        public string Desc()
        {
            return $"{name},{property},{price}";
        }
        
        

    }
}
