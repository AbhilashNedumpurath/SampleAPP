using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class AddFreeVideo : IRule
    {
        public void Execute()
        {
            Console.WriteLine("Executing Add Free Video");
        }
    }
}
