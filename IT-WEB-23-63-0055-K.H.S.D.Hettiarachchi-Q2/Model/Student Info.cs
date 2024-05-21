using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model
{
    public class Student_Info
    {
        [Key]
        public string Student_Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Course_Id { get; set; }

    }
}
