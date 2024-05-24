CREATE TABLE Students(
Student_Id int NOT NULL Primary Key,
_Name varchar(255),
City varchar(255),
Course_Id int FOREIGN KEY REFERENCES Courses(Course_Id)
)