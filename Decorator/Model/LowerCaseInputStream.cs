using System;
using System.IO;
using System.Text;

namespace Decorator.Model
{
    public class LowerCaseInputStream: StreamReader
    {
        public LowerCaseInputStream(string path) : base(path)
        {
        }
        
        public override string ReadLine()
        {
            var line = base.ReadLine();
            
            return line?.ToLower();
            
            // lesser method
            // return base?.ReadLine();
        }
    }
}