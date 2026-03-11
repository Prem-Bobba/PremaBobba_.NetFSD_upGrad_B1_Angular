use AssignmentDb;

--Assignment-1

CREATE PROCEDURE sp_EnrollStudentTransaction
@StudentID INT,
@CourseID INT
AS
BEGIN

BEGIN TRANSACTION

BEGIN TRY

INSERT INTO Enrollments
(StudentID,CourseID,EnrollmentDate)

VALUES
(@StudentID,@CourseID,GETDATE())

COMMIT TRANSACTION

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT ERROR_MESSAGE()

END CATCH

END;

--Assignment-2

CREATE PROCEDURE sp_RecordExamMarks
@StudentID INT,
@ExamID INT,
@Marks INT
AS
BEGIN

BEGIN TRANSACTION

BEGIN TRY

INSERT INTO Marks
(StudentID,ExamID,MarksObtained)
VALUES
(@StudentID,@ExamID,@Marks)

UPDATE Exams
SET ExamType = ExamType
WHERE ExamID = @ExamID

COMMIT

END TRY

BEGIN CATCH

ROLLBACK
PRINT ERROR_MESSAGE()

END CATCH

END;

--Assignment-3

CREATE PROCEDURE sp_TransferStudentDepartment
@StudentID INT,
@NewDepartmentID INT
AS
BEGIN

BEGIN TRANSACTION

BEGIN TRY

IF NOT EXISTS
(
SELECT * FROM Departments
WHERE DepartmentID = @NewDepartmentID
)

BEGIN
RAISERROR('Department does not exist',16,1)
ROLLBACK
RETURN
END

UPDATE Students
SET DepartmentID = @NewDepartmentID
WHERE StudentID = @StudentID

COMMIT

END TRY

BEGIN CATCH

ROLLBACK
PRINT ERROR_MESSAGE()

END CATCH

END;

--

