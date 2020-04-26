using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUserID
{
    public class GenerateUniqueID
    {

        public string GenerateUserID ()
        {
            string UserId = "UR" + DateTime.Now.ToString("yyMMddhhmmssfffff");
            return UserId;
            //return Guid.NewGuid().ToString("N");
        }

        public string GenerateBillID()
        {
            string BillId = "BL" + DateTime.Now.ToString("yyMMddhhmmssfffff");
            return BillId;
            //return Guid.NewGuid().ToString("N");
        }
    }
}
