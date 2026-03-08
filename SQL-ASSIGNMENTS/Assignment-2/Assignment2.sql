use AssignmentDb;

--Assignment2-Constraints

ALTER TABLE Departments
ADD CONSTRAINT UQ_Department UNIQUE(DepartmentName);

ALTER TABLE Students
ADD CONSTRAINT CHK_Gender CHECK (Gender IN ('M','F'));

ALTER TABLE Courses
ADD CONSTRAINT CHK_Credits CHECK (Credits BETWEEN 1 AND 5);

ALTER TABLE Marks
ADD CONSTRAINT CHK_Marks CHECK (MarksObtained BETWEEN 0 AND 100);

ALTER TABLE Teachers
ADD CONSTRAINT UQ_Email UNIQUE(Email);

ALTER TABLE Enrollments
ADD CONSTRAINT DF_EnrollDate DEFAULT GETDATE() FOR EnrollmentDate;