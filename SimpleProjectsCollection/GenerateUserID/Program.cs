using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUserID
{
    class Program
    {
        static void Main(string[] args)
        {
            var GetID = new GenerateUniqueID();
          
            Console.WriteLine("Your UserID : {0}", GetID.GenerateUserID());
          
            Console.WriteLine("Your BillNo : {0}", GetID.GenerateBillID());
            Console.ReadLine();
        }
    }
}
