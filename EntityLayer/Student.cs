using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StudentIdID { get; set; }
        [Required]
        public string StudentName { get; set; }
        public Nullable<int> Age { get; set; }
        [Required]
        public int Marks { get; set; }
       
        public int subjectId { get; set; }
        [ForeignKey("subjectId")]
        public Subject subject { get; set; }


    }
}
