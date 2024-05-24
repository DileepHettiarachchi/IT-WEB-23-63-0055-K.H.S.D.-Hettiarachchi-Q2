CREATE TABLE [dbo].[Student_Info] (
    [Student_Id] NVARCHAR (450) NOT NULL,
    [Student_No]       INT NOT NULL,
    [Name]       NVARCHAR (MAX) NOT NULL,
    [City]  NVARCHAR (MAX) NOT NULL,
    [Course_Id] INT NULL, 
    CONSTRAINT [PK_Student_Info] PRIMARY KEY CLUSTERED ([Student_Id] ASC)
);

