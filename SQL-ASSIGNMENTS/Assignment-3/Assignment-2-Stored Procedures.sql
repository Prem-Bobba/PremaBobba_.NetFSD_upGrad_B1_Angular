use AssignmentDb;

--Assignment-1

CREATE PROCEDURE sp_InsertStudent
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender VARCHAR(10),
    @DepartmentID INT,
    @AdmissionDate DATE
AS
BEGIN
    INSERT INTO Students
    (FirstName, LastName, Gender, DepartmentID, AdmissionDate)
    VALUES
    (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate);
END;
EXEC sp_InsertStudent
'Rahul',
'Kumar',
'Male',
2,
'2025-01-10';

--Assignment-2

CREATE PROCEDURE sp_GetStudentsByDepartment
@DepartmentID INT
AS
BEGIN
SELECT 
    StudentID,
    FirstName + ' ' + LastName AS StudentName,
    AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID;
END;
EXEC sp_GetStudentsByDepartment 2;
EXEC sp_GetStudentsByDepartment 3;

--Assignment-3

CREATE PROCEDURE sp_EnrollStudent
@StudentID INT,
@CourseID INT
AS
BEGIN
INSERT INTO Enrollments
(StudentID, CourseID, EnrollmentDate)
VALUES
(@StudentID, @CourseID, GETDATE());
END;

--Assignment-4

CREATE PROCEDURE sp_GetStudentMarks
@StudentID INT
AS
BEGIN
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.ExamType,
    m.MarksObtained
FROM Students s
INNER JOIN Marks m
ON s.StudentID = m.StudentID
INNER JOIN Exams e
ON m.ExamID = e.ExamID
INNER JOIN Courses c
ON e.CourseID = c.CourseID
WHERE s.StudentID = @StudentID;
END;

--Assignment-5

CREATE PROCEDURE sp_UpdateMarks
@MarkID INT,
@NewMarks INT
AS
BEGIN
UPDATE Marks
SET MarksObtained = @NewMarks
WHERE MarkID = @MarkID;

SELECT *
FROM Marks
WHERE MarkID = @MarkID;
END;

--Assignment-6

CREATE PROCEDURE sp_DeleteEnrollment
@EnrollmentID INT
AS
BEGIN
DELETE FROM Enrollments
WHERE EnrollmentID = @EnrollmentID;
END;





