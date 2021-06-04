using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class CommitionPayment : IRule
    {
        public void Execute()
        {
            Console.WriteLine("Executing Commition Payment");
        }
    }
}
