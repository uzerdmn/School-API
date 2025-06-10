
DROP DATABASE IF EXISTS [SchoolDataBase]
GO
CREATE DATABASE [SchoolDataBase]
GO

USE [SchoolDataBase]


CREATE TABLE [Users] (
    [Id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
    [Name] nvarchar(255),
    [Surnames] nvarchar(255),
    [Email] nvarchar(255),
    [Enrollment] nvarchar(255),
    [Salt] varbinary(50),
    [Password] varbinary(50),
    [Role] nvarchar(255),
    [IsActive] bit
)
GO


CREATE TABLE [Careers] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255)
)
GO


CREATE TABLE [Students] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [UserId] int,
    [CareerId] int,

    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (CareerId) REFERENCES Careers(Id)
)
GO


CREATE TABLE [Teachers] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Title] nvarchar(255),
    [Speciality] nvarchar(255),
    [UserId] int,

    FOREIGN KEY (UserId) REFERENCES Users(Id)
)
GO


CREATE TABLE [Groups] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255)
)
GO


CREATE TABLE [Periods] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255)
)
GO


CREATE TABLE [Subjects] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255)
)
GO


CREATE TABLE [Grades] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Unit1] decimal,
    [Unit2] decimal,
    [Unit3] decimal
)
GO


CREATE TABLE [Curriculums] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255),
    [CareerId] int

    FOREIGN KEY (CareerId) REFERENCES Careers(Id)
)
GO


CREATE TABLE [Semesters] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [Name] nvarchar(255)
)
GO


CREATE TABLE [CurriculumSubjects] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [CurriculumId] int,
    [SubjectId] int,
    [SemesterId] int,

    FOREIGN KEY (CurriculumId) REFERENCES Curriculums(Id),
    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
    FOREIGN KEY (SemesterId) REFERENCES Semesters(Id)
)
GO


CREATE TABLE [PeriodsGroups] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [GroupId] int,
    [PeriodId] int,

    FOREIGN KEY (GroupId) REFERENCES Groups(Id),
    FOREIGN KEY (PeriodId) REFERENCES Periods(Id)
)
GO


CREATE TABLE [TeacherSubjects] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [TeacherId] int,
    [SubjectId] int,
    [PeriodGroupId] int,

    FOREIGN KEY (TeacherId) REFERENCES Teachers(Id),
    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
    FOREIGN KEY (PeriodGroupId) REFERENCES PeriodsGroups(Id)
)
GO


CREATE TABLE [StudentsSubjects] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [TeacherSubjectId] int,
    [GradesId] int,

    FOREIGN KEY (TeacherSubjectId) REFERENCES TeacherSubjects(Id),
    FOREIGN KEY (GradesId) REFERENCES Grades(Id)
)
GO


CREATE TABLE [StudentsGroups] (
    [Id] int PRIMARY KEY IDENTITY(1, 1),
    [StudentId] int,
    [PeriodGroupId] int,
    [StudentSubjectsId] int,

    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    FOREIGN KEY (PeriodGroupId) REFERENCES PeriodsGroups(Id),
    FOREIGN KEY (StudentSubjectsId) REFERENCES StudentsSubjects(Id)
)
GO
