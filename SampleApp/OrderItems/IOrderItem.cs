using SampleApp.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Order
{
    public interface IOrderItem
    {
        public static List<IRule> Rules
        {
            get;
            set;
        }
        public void ExecuteRules();

        
    }
}
