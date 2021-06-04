using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class ActivateMembership : IRule
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activate Membership");
        }
    }
}
