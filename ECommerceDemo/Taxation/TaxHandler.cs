using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public class TaxHandler
    {
        public static void PayIncomeTax(float factor)
        {
            // modify and logic for IT deduction
            Console.WriteLine("Income tax " + factor + " has been deducted from your account!!!!");
        }

        public static void PayGST(float factor)
        {
            Console.WriteLine("GST tax " + factor + " has been deducted from your account!!!");
        }

        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Professional tax " + factor + " has been deducted from your account!!!");
        }

        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Service tax " + factor + " had been deducted from your account!!!");
        }
    }
}
