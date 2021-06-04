using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class EmailMembershipDetail : IRule
    {
        public void Execute()
        {
            Console.WriteLine("Executing Email Membership Details");
        }
    }
}
