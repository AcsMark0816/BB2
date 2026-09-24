using System.Security.Cryptography.X509Certificates;

namespace BB2
{
    public class Program
    {
        static void Main(string[] args)
        {
            menuItem u = new menuItem("valami", "ize", 500);
            menuItem i = new menuItem("balami", "bizee", 501);
            menuItem p= new menuItem("balami", "bizeee", 501);
            menuItem l = new menuItem("balami", "bizeeee", 501);

            menuItem m = new menuItem("balami", "bizeeee", 501);


            ConsoleView o = new ConsoleView();
           

            List<menuItem> I = new List<menuItem>();
            I.Add(i);
            I.Add(u);
            I.Add(p);
            I.Add(l);
            I.Add(m);
            o.ShowItem(I);
            o.ShowMassage(menuItem.count.ToString());

            Menu menu = new Menu("ize");
            menu.ADDItem(i);
            if(menu.Find("b") != null && menu.Find("b").Desc()== "A")
            {
                o.menuTems(menu.Find("b"));
            }
            else
            {
                o.ShowMassage("nincs ilyen");
            }
            
            

           


    }
       
    }
}
