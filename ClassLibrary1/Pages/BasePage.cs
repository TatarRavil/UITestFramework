using CommonLibs.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Pages
{
    public class BasePage
    {
        public CommonElement CommonElement { get; set; }

        public BasePage()
        {
            CommonElement = new CommonElement();
        }
    }
}