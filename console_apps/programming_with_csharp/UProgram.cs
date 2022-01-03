using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOfEdx
{
    public class UProgram
    {
        public string ProgramName { get; set; }
        public List<string> DegreesOffered { get; set; }
        public string DepartmentHead { get; set; }
        public List<Degree> Degrees { get; set; }

        //Constructor
        public UProgram(string programName) 
        { 
            ProgramName = programName;
        }

    }
}
