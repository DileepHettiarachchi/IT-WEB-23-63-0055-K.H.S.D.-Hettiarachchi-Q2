using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model
{
    public class Course_Info
    {
        [Key]
        public String Course_Id { get; set; }
        public string Name { get; set; }
        public string Lecturer_Name { get; set; }
        

    }
}
