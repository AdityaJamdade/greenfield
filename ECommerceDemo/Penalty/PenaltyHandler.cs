using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public class PenaltyHandler
    {
        public static void ServiceDisconnecionPenaltyCharges(float amount)
        {
            Console.WriteLine("Disconnection charges applied = " + amount);
        }
        public static void NotificationPenaltyCharges(float amount)
        {
            Console.WriteLine("Notification charges applied = " + amount);
        }
    }
}
