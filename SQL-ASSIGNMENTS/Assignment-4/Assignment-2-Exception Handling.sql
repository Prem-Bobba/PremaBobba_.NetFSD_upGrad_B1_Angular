use AssignmentDb;

--Assignment-1

CREATE PROCEDURE sp_AddStudent
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@DepartmentID INT,
@Gender CHAR(1),
@AdmissionDate DATE
AS
BEGIN

BEGIN TRY

INSERT INTO Students
(FirstName,LastName,DepartmentID,Gender,AdmissionDate)

VALUES
(@FirstName,@LastName,@DepartmentID,@Gender,@AdmissionDate)

END TRY

BEGIN CATCH

PRINT ERROR_MESSAGE();

END CATCH

END;

--Assignment-2

CREATE PROCEDURE sp_InsertMarks
@StudentID INT,
@ExamID INT,
@MarksObtained INT
AS
BEGIN

IF @MarksObtained < 0 OR @MarksObtained > 100
BEGIN
RAISERROR ('Invalid Marks',16,1);
RETURN;
END

INSERT INTO Marks
(StudentID,ExamID,MarksObtained)

VALUES
(@StudentID,@ExamID,@MarksObtained)

END;

--Assignment-3

CREATE PROCEDURE sp_DeleteStudent
@StudentID INT
AS
BEGIN

BEGIN TRY

DELETE FROM Students
WHERE StudentID = @StudentID

END TRY

BEGIN CATCH

PRINT ERROR_MESSAGE()

END CATCH

END;


