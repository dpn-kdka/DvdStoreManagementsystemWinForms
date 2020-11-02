using System;
using System.Collections.Generic;
using System.Text;

namespace DvdDLL.Common
{
    public class dbConnection
    {
        public static string dbCon
        {
            get { return "Data source = XDARK\\MY_DATABASES; Initial catalog =DVDstore; Integrated security = true"; }
        }
    }
}
