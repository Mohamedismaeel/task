using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class HTMLELementClass
    {
        public string type {  get; set; }
        public string value { get; set; }
        public virtual void render()
        {
            Console.WriteLine($"Type: {type}, Value: {value}");
        }
    }
}
