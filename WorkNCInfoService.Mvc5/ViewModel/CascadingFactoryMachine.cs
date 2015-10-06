using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNCInfoService.Mvc5.ViewModel
{
    public class CascadingFactoryMachine
    {
        public int selectedFactory { get; set; }
        public int selectedMachine { get; set; }

        public System.Web.Mvc.SelectList factory;
        public System.Web.Mvc.SelectList machine;
    }
}
