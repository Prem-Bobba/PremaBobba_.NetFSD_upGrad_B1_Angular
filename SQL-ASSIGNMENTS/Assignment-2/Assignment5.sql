use AssignmentDb;

--Assignment5-Filtering data

--1.Students from Computer Science
SELECT *
FROM Students S
JOIN Departments D
ON S.DepartmentID=D.DepartmentID
WHERE D.DepartmentName='Computer Science';

--2.Teachers hired after 2022
SELECT *
FROM Teachers
WHERE HireDate > '2022-01-01';

--3.Students name starts with A
SELECT *
FROM Students
WHERE FirstName LIKE 'A%';

--4.Courses credits >3
SELECT *
FROM Courses
WHERE Credits >3;

--5.Students born between 2005 and 2008
SELECT *
FROM Students
WHERE DateOfBirth BETWEEN '2005-01-01' AND '2008-12-31';

--6.Students not in Mechanical
SELECT *
FROM Students
WHERE DepartmentID NOT IN
(SELECT DepartmentID FROM Departments WHERE DepartmentName='Mechanical');

--7.Teachers salary between 40000 and 70000
SELECT *
FROM Teachers
WHERE Salary BETWEEN 40000 AND 70000;

--8.Courses not taught by TeacherID=3
SELECT *
FROM Courses
WHERE TeacherID <>3;