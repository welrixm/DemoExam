using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2024_Day3.Models
{
    public partial class user
    {
        public string Status
        {
            get
            {
               if(status  == null)
                {
                   return "работает";

                }
                else
                {
                    return "уволен";
                }
            }
        }
    }
}
