using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PT_LAB_3
{
    [XmlRoot(ElementName = "engine")]
    public class Engine
    {
        public double displacement;

        public double horsePower;

        [XmlAttribute]
        public string model;


        public Engine() { }
        public Engine(double displacement, double horsePower, string model)
        {
            this.displacement = displacement;
            this.horsePower = horsePower;
            this.model = model;
        }

    }
}
