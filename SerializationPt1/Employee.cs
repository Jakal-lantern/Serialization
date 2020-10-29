using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationPt1
{
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlAttribute("Full name")]
        public string Name { get; set; }
        [XmlAttribute("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlAttribute("Today's Date")]
        public DateTime EntryDate { get; set; }
    }
}
