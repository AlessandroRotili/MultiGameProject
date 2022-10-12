using LiveCodingClassDesignAndFile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingClassDesignAndFile.Model
{
    public class GradeBookOnFile : IWrite, IRead
    {
        private List<double> _grades;
        public string Name { get; set; }

        public const string FilePath = "C:\\Users\\aroti\\source\\repos\\LiveCodingClassDesignAndFile\\LiveCodingClassDesignAndFile\\res\\grades.txt";

        public GradeBookOnFile(string name)
        {
            Name = name;
            _grades = new List<double>();
        }

        public void Insert(double grade)
        {
            File.AppendAllText(FilePath, grade.ToString());
            //using var sw = File.AppendText(FilePath);
            //sw.WriteLine(grade);
        }

        public List<double> Read()
        {
            using(var reader = new StreamReader(FilePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    _grades.Add(double.Parse(line));
                    Console.WriteLine(line);
                    line = reader.ReadLine();   
                }
            }
            return _grades;
        }
    }
}
