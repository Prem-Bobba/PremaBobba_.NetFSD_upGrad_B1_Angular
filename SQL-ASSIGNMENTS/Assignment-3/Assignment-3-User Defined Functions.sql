use AssignmentDb;

--Assignment-1

CREATE FUNCTION fn_GetGrade
(
@Marks INT
)
RETURNS VARCHAR(10)
AS
BEGIN
DECLARE @Grade VARCHAR(10)

IF @Marks >= 90
SET @Grade = 'A'
ELSE IF @Marks >= 75
SET @Grade = 'B'
ELSE IF @Marks >= 60
SET @Grade = 'C'
ELSE
SET @Grade = 'Fail'

RETURN @Grade
END;

SELECT 
MarksObtained,
dbo.fn_GetGrade(MarksObtained) AS Grade
FROM Marks;

--Assignment-2

CREATE FUNCTION fn_GetStudentAge
(
@DateOfBirth DATE
)
RETURNS INT
AS
BEGIN
RETURN DATEDIFF(YEAR, @DateOfBirth, GETDATE())
END;

--Assignment-3

CREATE FUNCTION fn_GetTotalMarks
(
@StudentID INT
)
RETURNS INT
AS
BEGIN
DECLARE @Total INT

SELECT @Total = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID

RETURN @Total
END;

--Assignment-4

CREATE FUNCTION fn_GetStudentCourses
(
@StudentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
c.CourseName,
e.EnrollmentDate
FROM Enrollments e
INNER JOIN Courses c
ON e.CourseID = c.CourseID
WHERE e.StudentID = @StudentID
);

SELECT *
FROM fn_GetStudentCourses(5);

--Assignment-5

CREATE FUNCTION fn_GetDepartmentStudents
(
@DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID
);
SELECT *
FROM fn_GetDepartmentStudents(2);



