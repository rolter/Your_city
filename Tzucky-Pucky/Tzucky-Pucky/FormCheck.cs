using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tzucky_Pucky
{
    class FormCheck
    {
        public static First_Page _page;
        public static Inregistrare _inregistrare;

        public static First_Page page
        {
            get
            {
                if (_page == null)
                {
                    _page = new First_Page();
                }
                return _page;
            }
        }

        public static Inregistrare inregis
        {
            get
            {
                    if (_inregistrare == null)
                    {
                    _inregistrare = new Inregistrare();
                    }
                return _inregistrare;
            }
        }

    }
}
