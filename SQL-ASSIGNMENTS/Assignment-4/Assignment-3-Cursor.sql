use AssignmentDb;

--Assignment-1

CREATE PROCEDURE sp_DisplayStudentsCursor
AS
BEGIN

DECLARE @StudentID INT
DECLARE @StudentName VARCHAR(100)

DECLARE StudentCursor CURSOR FOR

SELECT StudentID, FirstName + ' ' + LastName
FROM Students

OPEN StudentCursor

FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

WHILE @@FETCH_STATUS = 0
BEGIN

PRINT CAST(@StudentID AS VARCHAR) + ' - ' + @StudentName

FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

END

CLOSE StudentCursor
DEALLOCATE StudentCursor

END;

EXEC sp_DisplayStudentsCursor

--Assignment-2

CREATE PROCEDURE sp_CalculateStudentTotalMarks
AS
BEGIN

DECLARE @StudentID INT
DECLARE @StudentName VARCHAR(100)
DECLARE @TotalMarks INT

DECLARE StudentCursor CURSOR FOR

SELECT StudentID, FirstName + ' ' + LastName
FROM Students

OPEN StudentCursor

FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

WHILE @@FETCH_STATUS = 0
BEGIN

SELECT @TotalMarks = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID

PRINT @StudentName + ' Total Marks = ' + CAST(ISNULL(@TotalMarks,0) AS VARCHAR)

FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

END

CLOSE StudentCursor
DEALLOCATE StudentCursor

END;

--Assignment-3

CREATE PROCEDURE sp_UpdateCourseCredits
AS
BEGIN

DECLARE @CourseID INT
DECLARE @Credits INT

DECLARE CourseCursor CURSOR FOR
SELECT CourseID, Credits
FROM Courses
WHERE Credits < 3

OPEN CourseCursor

FETCH NEXT FROM CourseCursor INTO @CourseID, @Credits

WHILE @@FETCH_STATUS = 0
BEGIN

UPDATE Courses
SET Credits = Credits + 1
WHERE CourseID = @CourseID

FETCH NEXT FROM CourseCursor INTO @CourseID, @Credits

END

CLOSE CourseCursor
DEALLOCATE CourseCursor

END;





