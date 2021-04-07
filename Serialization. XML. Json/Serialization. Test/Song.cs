using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization._Test
{
    [Serializable]
    public class Song // public !!!! for xmlserialer-a
    {
        // [NonSerialized]
        // [XmlElement("ID")]
        private int id = ++lastId;
        static int lastId = 0;
        public string Name { get; set; }
        // [XmlAttribute("Singer")]
        public string Singer { get; set; }
        // [XmlIgnore]
        public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            return $"{id, -4}. Song : {Name, -10}, Singer : {Singer, -10}, Duration : {Duration, -10}.";
        }
        // default ctor must be for xmlserialer-a !!!
    }
}
