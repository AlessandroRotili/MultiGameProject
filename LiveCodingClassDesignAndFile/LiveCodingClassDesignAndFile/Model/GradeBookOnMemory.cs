
using LiveCodingClassDesignAndFile.Interfaces;

namespace LiveCodingClassDesignAndFile.Model
{
    public class GradeBookOnMemory : IWrite, IRead
    {
        private List<double> _grades;
        public string Name { get; set; }

        public GradeBookOnMemory(string name)
        {
            Name = name;
            _grades = new List<double>();
        }

        public void Insert(double grade)
        {
            _grades.Add(grade);            
        }

        public List<double> Read()
        {
            foreach(var grade in _grades)
            {
                Console.WriteLine(grade);
            }
            return _grades;
        }

        //public string PrintGrades(List<double> grades)
        //{
        //    string ris = "";
        //    for (int i = 0; i < grades.Count; i++)
        //    {
        //        ris += grades[i];
        //    }
        //    return ris;
        //}
    }
 }

