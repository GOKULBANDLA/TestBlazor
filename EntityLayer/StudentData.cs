using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StudentData
    {
        public int ID { get; set; }
       public int StudentIdID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> Age { get; set; }
        public int Marks { get; set; }
        public int subjectId { get; set; }
        public string subject { get; set; }
    }
}
