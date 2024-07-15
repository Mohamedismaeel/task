using System.Globalization;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HTMLELementClass html = new HTMLELementClass();

            html.type = "buttun";
            html.value = "submit";

            ImageElmentClass img = new ImageElmentClass();

            img.type = "image";
            img.value = "image.png";
            img.src = "http://....";

            TextElement txt = new TextElement();

            txt.type = "text";
            txt.value = "description";
            txt.fontsize = 35;
            txt.fontcolor = "black";

            H1Element h1 = new H1Element();

            h1.type = "H1";
            h1.value = "site title";
            h1.fontcolor = "Red";

            H2Element h2 = new H2Element();

            h1.type = "H2";
            h1.value = "Welecome";
            h1.fontcolor = "Blue";

            List<HTMLELementClass> htmllist = new List<HTMLELementClass>();

            htmllist.Add(html);
            htmllist.Add(img);
            htmllist.Add(txt);
            htmllist.Add(h1);
            htmllist.Add(h2);

            foreach(var item in htmllist)
            {
                item.render();
                Console.WriteLine("-------------------------------------------------------------------------");
            }





        }
    }
}
