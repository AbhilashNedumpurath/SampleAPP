using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules
{
    public class UpgradeMembership : IRule
    {
        public virtual void Execute()
        {
            Console.WriteLine("Executing Upgrade Membership");
        }
    }
}
