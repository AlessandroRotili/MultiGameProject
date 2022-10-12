using LiveCodingClassDesignAndFile.Model;

namespace LiveCodingClassDesignAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeBookOnMemory = new GradeBookOnMemory("Class A");
            //var gradeBookOnFile = new GradeBookOnFile("Grade file");

            var input = Console.ReadLine();
            gradeBookOnMemory.Insert(Double.Parse(input));
            //gradeBookOnFile.Insert(double.Parse(input));

            gradeBookOnMemory.Read();
            //gradeBookOnFile.Read();
             
        }
    }
}