using System.ComponentModel.DataAnnotations.Schema;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model
{
    public class StudentsInfo_New
    {
        public int Id { get; set; }
        public string Student_No { get; set; }
        public string Name { get; set; }
        public String City { get; set; }
        public String Course_Id { get; set; }

        [ForeignKey("CoursesNewForeignKey")]
        public int CoursesNewForeignKey { get; set; }

        public CoursesNew CoursesNew { get; set; }
    }
}
