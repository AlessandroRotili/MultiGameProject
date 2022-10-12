using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    public static class Searcher
    {
        public static bool IsBombFound(int n, FileInfo[] files )
        {
            string result = "";
  
            using (var reader = new StreamReader(files[n].FullName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    result = line;
                    if (result.Contains("bomb"))
                        return true;
                    line = reader.ReadLine();                   
                }
                
            }
            return false;
        }  
    }
}
