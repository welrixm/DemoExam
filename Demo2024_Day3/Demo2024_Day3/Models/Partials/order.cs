using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo2024_Day3.Models
{
    public partial class order
    {
        public Visibility Visible
        {
            get
            {
                if(CurrentUser.AuthUser.userroleid == 1)
                {
                    return Visibility.Hidden;
                }
                else if(CurrentUser.AuthUser.userroleid == 2)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
    }
}
