use AssignmentDb;

--Assignment6-Group By

--1.Count students in each department
SELECT DepartmentID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DepartmentID;

--2.Average marks per exam
SELECT ExamID, AVG(MarksObtained) AS AvgMarks
FROM Marks
GROUP BY ExamID;

--3.Students per course
SELECT CourseID, COUNT(StudentID)
FROM Enrollments
GROUP BY CourseID;

--4.Maximum marks in each exam
SELECT ExamID, MAX(MarksObtained)
FROM Marks
GROUP BY ExamID;

--5.Minimum marks per course
SELECT C.CourseName, MIN(M.MarksObtained)
FROM Courses C
JOIN Exams E ON C.CourseID=E.CourseID
JOIN Marks M ON E.ExamID=M.ExamID
GROUP BY C.CourseName;

--6.Departments having more than 5 students
SELECT DepartmentID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) >5;