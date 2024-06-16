using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2024_Day3.Models
{
    public partial class person
    {
        public string FUO
        {
            get
            {
                return $"{firstname} {lastname} {middlename}";
            }
        }
    }
}
