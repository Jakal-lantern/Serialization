using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SerializationPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //emp.ID = 123;
            //emp.Name = "Alex Sarene";
            //emp.SSNumber = 123456789;
            //emp.EntryDate = DateTime.Now;
            //emp.JobRole = "Ninja";

            Console.WriteLine($"Employee ID: {emp.ID}\n" +
                                $"Employee Name: {emp.Name}\n" +
                                $"Employee SS#: {emp.SSNumber}\n" +
                                $"Date Created: {emp.EntryDate}");

            string FilePath = "C:/Temp/";
            string FileName = "Samurai.xml";

            //TextWriter writer = new StreamWriter(FilePath + FileName);

            //XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"Employee ID: {emp.ID}\n" +
                                $"Employee Name: {emp.Name}\n" +
                                $"Employee SS#: {emp.SSNumber}\n" +
                                $"Date Created: {emp.EntryDate}");
            }

            Console.ReadLine();
        }
    }
}
