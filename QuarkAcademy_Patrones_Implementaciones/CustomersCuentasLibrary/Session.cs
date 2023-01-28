using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersCuentasLibrary
{
    public abstract class Session
    {
        public static bool CanSave { get; set; }
        public static bool CanGetAll { get; set; }
    }
}
