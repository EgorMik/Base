using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
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


            var result = ct2019.Select(pupil => new
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
