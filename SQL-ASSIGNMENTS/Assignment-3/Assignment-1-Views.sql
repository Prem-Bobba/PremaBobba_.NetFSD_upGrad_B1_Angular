use AssignmentDb;

--Assignment 1 

CREATE VIEW vw_StudentDepartment AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    d.DepartmentName,
    s.AdmissionDate
FROM Students s
INNER JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

SELECT * FROM vw_StudentDepartment;

SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science';

DROP VIEW vw_StudentDepartment;

--Assignment 2 

CREATE VIEW vw_StudentCourses AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.EnrollmentDate
FROM Students s
INNER JOIN Enrollments e
ON s.StudentID = e.StudentID
INNER JOIN Courses c
ON e.CourseID = c.CourseID;

SELECT *
FROM vw_StudentCourses
WHERE StudentName IN
(
    SELECT FirstName + ' ' + LastName 
    FROM Students
    WHERE StudentID = 5
);

SELECT 
    StudentName,
    COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName;

SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-01-01';

--Assignment 3

CREATE VIEW vw_ExamResults AS
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
ON e.CourseID = c.CourseID;

SELECT *
FROM vw_ExamResults
WHERE MarksObtained > 80;

SELECT *
FROM vw_ExamResults
WHERE MarksObtained = (
    SELECT MAX(MarksObtained)
    FROM vw_ExamResults
);

SELECT *
FROM vw_ExamResults
WHERE MarksObtained < 40;

--Assignment 4 

CREATE VIEW vw_DepartmentStudentCount AS
SELECT 
    d.DepartmentName,
    COUNT(s.StudentID) AS TotalStudents
FROM Departments d
LEFT JOIN Students s
ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName;

SELECT *
FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;
