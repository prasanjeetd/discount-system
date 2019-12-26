using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.OOPS
{
    interface IOffer
    {
        string Offer();
    }

    interface ICalculation
    {
        double Calculate();
    }

    interface IBillingSystem : IOffer, ICalculation
    {
    }

    public class BillingSystem : IBillingSystem
    {
        public double Calculate()
        {
            return 0;
        }

        public string Offer()
        {
            return "bs";
        }
    }

    interface IRegulalBillingSystem : ICalculation
    {
    }

    public class RegularBillingSystem : IRegulalBillingSystem
    {
        BillingSystem billingSystem = new BillingSystem();

        public double Calculate()
        {
            return Discount(billingSystem.Calculate());
        }

        private double Discount(double amount)
        {
            return amount;
        }
    }

    public class RegularBillingSystemByInheritance : BillingSystem, IRegulalBillingSystem
    {

        public new double Calculate()
        {
            return Discount(base.Calculate());
        }

        private double Discount(double amount)
        {
            return amount;
        }
    }

    public class Test
    {

        public void Run()
        {
            var rbs= new  RegularBillingSystem();
            //rbs.Get

            var rbsi = new RegularBillingSystemByInheritance();
            rbsi.Offer();
        }
    }
}
