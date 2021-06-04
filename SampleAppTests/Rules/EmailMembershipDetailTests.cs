using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleApp.Order;
using SampleApp.OrderItems;
using SampleApp.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Rules.Tests
{
    [TestClass()]
    public class EmailMembershipDetailTests
    {
        [TestMethod()]
        public void Verify_EmailMembershipRule_IsExecuted_IfAssigned_Test()
        {
            //Arrange
            var mockPackingSlip = new Mock<UpgradeMembership>();            
            mockPackingSlip.Setup(rule => rule.Execute());

            MembershipUpgrade.Rules = new List<IRule> { mockPackingSlip.Object };
            var customer = new Customer();
           
            customer.Order(new MembershipUpgrade());

            //Act
            customer.DoPayment();

            //Assett
            mockPackingSlip.Verify(rule => rule.Execute());
        }
        [TestMethod()]
        public void Verify_EmailMembershipRule_IsNotExecuted_IfNotAssigned_Test()
        {
            //Arrange
            var mockPackingSlip = new Mock<UpgradeMembership>();
            mockPackingSlip.Setup(rule => rule.Execute());

            MembershipUpgrade.Rules = new List<IRule> { new EmailMembershipDetail() };
            var customer = new Customer();

            customer.Order(new MembershipUpgrade());

            //Act
            customer.DoPayment();

            //Assett
            mockPackingSlip.Verify(rule => rule.Execute(), Times.Never);
        }

    }
}