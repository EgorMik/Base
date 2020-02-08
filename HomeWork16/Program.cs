using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> ct2019 = new List<Pupil>();
            ct2019.Add(new Pupil()
            {
                LastName = "Иванов",
                SchoolNumber = 28,
                CTPoints = "90 100 100"
            });

            ct2019.Add(new Pupil()
            {
                LastName = "Петров",
                SchoolNumber = 40,
                CTPoints = "80 80 80"
            });

            ct2019.Add(new Pupil()
            {
                LastName = "Сидоров",
                SchoolNumber = 50,
                CTPoints = "80 80 80"
            });

            ct2019.Add(new Pupil()
            {
                LastName = "Скворцов",
                SchoolNumber = 99,
                CTPoints = "100 100 100"
            });

            ct2019.Add(new Pupil()
            {
                LastName = "Дроздов",
                SchoolNumber = 99,
                CTPoints = "100 100 100"
            });


            using (StreamWriter strWriter = new StreamWriter(@"Pupil.txt", false))
            {
                for (int i = 0; i < ct2019.Count; i++)
                {
                    strWriter.WriteLine($"{ct2019[i].LastName} {ct2019[i].SchoolNumber} : {ct2019[i].CTPoints}");
                }
            }


            XmlSerializer xml = new XmlSerializer(typeof(Pupil[]));
            using (StreamWriter xmlWriter = new StreamWriter(@"Pupil.xml", false))
            {

                xml.Serialize(xmlWriter, ct2019.ToArray());
            }


            Pupil[] deserialized;
            using (StreamReader xmlReader = new StreamReader(@"Pupil.xml"))
            {
                deserialized = (Pupil[])xml.Deserialize(xmlReader);
            }


            var result = deserialized.Select(pupil => new
            {
                LastName = pupil.LastName,
                SchoolNumber = pupil.SchoolNumber,
                CTPoints = pupil.CTPoints.Split(new[] { ' ' })
                                    .Select(p => Convert.ToInt32(p))
                                    .Sum()
            });

            int minPoints = result.GroupBy(pupil => pupil.CTPoints).Min(p => p.Key);
            Console.WriteLine($"Минимальный балл в {minPoints} получили :");
            var minResult = result.Where(p => p.CTPoints == minPoints)
                                  .Select(s => new
                                  {
                                      LastName = s.LastName,
                                      SchoolNumber = s.SchoolNumber
                                  });

            foreach (var pupil in minResult)
            {
                Console.WriteLine($"{pupil.LastName} из {pupil.SchoolNumber} школы");
            }
        }
    }
    
}
