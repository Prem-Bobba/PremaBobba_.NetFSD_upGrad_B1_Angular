use AssignmentDb;

--Assignment7-Joins

--1.Students with department name
SELECT S.FirstName,S.LastName,D.DepartmentName
FROM Students S
JOIN Departments D
ON S.DepartmentID=D.DepartmentID;

--2.Courses with teacher name
SELECT C.CourseName,T.FullName
FROM Courses C
JOIN Teachers T
ON C.TeacherID=T.TeacherID;

--3.Student name and enrolled courses
SELECT S.FirstName,C.CourseName
FROM Students S
JOIN Enrollments E ON S.StudentID=E.StudentID
JOIN Courses C ON E.CourseID=C.CourseID;

--4.Students with exam marks
SELECT S.FirstName,E.ExamType,M.MarksObtained
FROM Students S
JOIN Marks M ON S.StudentID=M.StudentID
JOIN Exams E ON M.ExamID=E.ExamID;

--5.All courses and teachers (LEFT JOIN)
SELECT C.CourseName,T.FullName
FROM Courses C
LEFT JOIN Teachers T
ON C.TeacherID=T.TeacherID;

--6.Teachers not assigned to course
SELECT *
FROM Teachers
WHERE TeacherID NOT IN
(SELECT TeacherID FROM Courses);