using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VultrControlPanel
{
    class GeneralMethod
    {

        public bool Check()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Setting.json"))
            {
                return true;
            }
            return false;
        }
    }
}
