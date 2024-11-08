using System;
using Banking;
using Penalty;
using Taxation;

namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object creation
            Account act = new Account(56000);

            // event registration
            act.underBalance += PenaltyHandler.ServiceDisconnecionPenaltyCharges;
            act.underBalance += PenaltyHandler.NotificationPenaltyCharges;

            // object invocation
            act.Withdraw(50000);


            Console.WriteLine(act.Balance + " amount");
            act.overBalance += TaxHandler.PayGST;
            act.overBalance += TaxHandler.PayIncomeTax;
            act.overBalance += TaxHandler.PayServiceTax;

            act.Deposit(600000);
            Console.WriteLine(act.Balance + " amount");


            Console.ReadLine();
        }
    }
}


/*
            // compile time, early binding, static linking

            Handler.PayProfessionalTax();
            Handler.PayIncomeTax();
            Handler.PayServiceTax();
            Handler.PayGST();



//dynamic linking, 
//delegate

// register method with delegate instance
Operation opn1 = new Operation(TaxHandler.PayProfessionalTax);
Operation opn2 = new Operation(TaxHandler.PayIncomeTax);
Operation opn3 = new Operation(TaxHandler.PayGST);

//opn1.Invoke(40);
//opn2.Invoke(20);
//opn3.Invoke(30);

Operation masterOperation = null;
masterOperation += opn1;
masterOperation += opn2;
masterOperation += opn3;

masterOperation.Invoke(22);

// dechained operation 3
masterOperation -= opn3;
// after de chaining 
masterOperation.Invoke(89);



*/