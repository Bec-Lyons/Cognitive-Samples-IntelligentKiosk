using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentKioskSample.Model
{
    class ObjectDataHelper
    {
        public ObjectDataHelper() { }

        public List<Object> Initialise()
        {
            //if the name created on the ADmin portal matches the dummmy data it will link the face with this data (simulation of hooking it up to an existing AD
            List<Object> list = new List<Object>();
            //other
            list.Add(new Object("Pocari Sweat", 0));
            list.Add(new Object("Welchs Something", 3));
            list.Add(new Object("Bottle", 2));

            return list;
        }
    }
}

