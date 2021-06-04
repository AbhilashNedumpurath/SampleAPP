using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class GenerateDuplicatePackingSlip : IRule
    {
        public void Execute()
        {
            Console.WriteLine("Executing Generate Duplicate Packing Slip");
        }
    }
}
