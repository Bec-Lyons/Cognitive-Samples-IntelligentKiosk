using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentKioskSample.Model
{
    class Object
    {
        public Object(string v1, int auth)
        {
            Name = v1;
            Authorization = auth;
        }


        public int Authorization { get; set; }
      

        public string Name { get; set; }

    }
}
