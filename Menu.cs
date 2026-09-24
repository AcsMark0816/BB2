    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB2
{
    public class Menu
    {
        public string NAME { get; set; }
        List<menuItem> items;

        public Menu(string namE)
        {
            NAME = namE;
            items = new List<menuItem>();
        }

        public void ADDItem(menuItem item)
        {
            items.Add(item);
        }
        public menuItem Find(string nAme)
        {
            foreach(var i in items)
            {
                if (i.name == nAme)
                {
                    return i;
                }
              
               
            }
            return null;

        }
        public List<menuItem> Avaiable()
        {
            List<menuItem> list = new List<menuItem>();
            foreach (menuItem item in items)
            {
                if(item.isAvaiable)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
