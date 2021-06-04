using SampleApp.Order;
using SampleApp.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.OrderItems
{
    public class PhysicalItem : OrderItem, IOrderItem
    {
        public static List<IRule> Rules
        {
            get;
            set;
        }
        public void ExecuteRules()
        {
            Rules.ForEach(rule => rule.Execute());

        }
    }
}
