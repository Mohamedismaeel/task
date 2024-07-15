using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class TextElement : HTMLELementClass
    {
        public int fontsize { get; set; }
        public string fontcolor { get; set; }
        public override void render()
        {
            Console.WriteLine($"Type: {type}, Value: {value}, Font Size: {fontsize}, Fontcolor: {fontcolor}");
        }
    }
}
