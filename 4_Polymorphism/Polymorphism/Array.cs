using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Array
    {
        public static int size;

        public static List<TrafficLights> mas=new List<TrafficLights>();
        public string status;
        public string type;

        public Array() { }

        public void Add()
        {
            if (type == "Пешеходный")
                mas.Add(new DoubleLight(type, status));
            if (type=="Автомобильный")
                mas.Add(new TripleLight(type, status));
            if (type == "Со стрелкой")
                mas.Add(new ArrowLight(type, status));
        }

        public static bool TryToAdd()
        {
            return size <= mas.Count ? false : true;
        }
    }
}
