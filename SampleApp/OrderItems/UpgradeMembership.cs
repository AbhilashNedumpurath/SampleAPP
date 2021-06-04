using SampleApp.Order;
using SampleApp.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.OrderItems
{
    public class MembershipUpgrade : OrderItem, IOrderItem
    {
        public static List<IRule> Rules
        {
            get;
            set;
        }
        public virtual void ExecuteRules()
        {
            Rules.ForEach(rule => rule.Execute());

        }
    }
}
