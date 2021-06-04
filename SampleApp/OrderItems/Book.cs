using SampleApp.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Order
{
    public abstract class OrderItem
    {
        

       
    }
    public class Book : OrderItem, IOrderItem
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
