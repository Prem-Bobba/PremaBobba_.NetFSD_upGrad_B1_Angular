use AssignmentDb;

--Assignment-1

CREATE TABLE StudentAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ActionType VARCHAR(20),
    ActionDate DATETIME
);

CREATE TRIGGER trg_StudentInsertAudit
ON Students
AFTER INSERT
AS
BEGIN
INSERT INTO StudentAudit (StudentID, ActionType, ActionDate)
SELECT StudentID, 'INSERT', GETDATE()
FROM inserted;
END;

INSERT INTO Students
(FirstName, LastName, Gender, DepartmentID, AdmissionDate)
VALUES
('Arjun','Reddy','M',1,GETDATE());

SELECT * FROM StudentAudit;

--Assignment-2

CREATE TRIGGER trg_PreventStudentDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN

IF EXISTS (
    SELECT 1
    FROM Enrollments e
    INNER JOIN deleted d
    ON e.StudentID = d.StudentID
)
BEGIN
RAISERROR ('Student has course enrollments and cannot be deleted',16,1);
ROLLBACK TRANSACTION;
END
ELSE
BEGIN
DELETE FROM Students
WHERE StudentID IN (SELECT StudentID FROM deleted);
END

END;

--Assignment-3

CREATE TABLE MarksAudit
(
    AuditID INT IDENTITY(1,1),
    StudentID INT,
    ExamID INT,
    OldMarks INT,
    NewMarks INT,
    UpdatedDate DATETIME
);

CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN

INSERT INTO MarksAudit
(StudentID, ExamID, OldMarks, NewMarks, UpdatedDate)

SELECT 
d.StudentID,
d.ExamID,
d.MarksObtained,
i.MarksObtained,
GETDATE()

FROM deleted d
INNER JOIN inserted i
ON d.MarkID = i.MarkID;

END;








