using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB2
{
    public class ConsoleView
    {


        public void ShowItem(List<menuItem> I)
        {
            foreach(menuItem item in I)
            {
                Console.WriteLine(item.Desc());
            }
        }
        public void ShowMassage(string message)
        {
            Console.WriteLine(message);
        }

        public void menuTems(menuItem i)
        {
            Console.WriteLine(i.Desc());
        }

    }
}
