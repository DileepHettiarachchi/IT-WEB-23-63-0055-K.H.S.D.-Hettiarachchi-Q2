using System.ComponentModel.DataAnnotations.Schema;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model
{
    public class All_info
    {
        
        public int Id { get; set; }
        [ForeignKey("Student_No")]
        public string Student_No { get; set; }
        public virtual Students_InformationNew Students_InformationNew { get; set; }
        [ForeignKey("Course_Id")]
        public string Course_Id { get; set; }
        public virtual CoursesNew CoursesNew { get; set; }
        public string Name { get; set; }
        public string Lecturer_Name { get; set; }
        public string Course_Name { get; set; }

        public String City { get; set; }



    }
}
