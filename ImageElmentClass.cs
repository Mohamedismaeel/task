using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class ImageElmentClass : HTMLELementClass
    {
        public string src {  get; set; }
        public override void render()
        {
            Console.WriteLine($"Type: {type}, Value: {value}, src: {src}");
        }
    }
}
