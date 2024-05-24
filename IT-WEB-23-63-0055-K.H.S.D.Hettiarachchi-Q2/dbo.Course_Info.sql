CREATE TABLE [dbo].[Course_Info] (
    [Course_Id]     NVARCHAR (450) NOT NULL,
    [Course_No]          INT NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    [Lecturer_Name] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Course_Info] PRIMARY KEY CLUSTERED ([Course_Id] ASC)
);

