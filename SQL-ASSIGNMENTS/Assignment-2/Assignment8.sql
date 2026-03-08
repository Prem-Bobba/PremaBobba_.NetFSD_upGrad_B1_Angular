use AssignmentDb;

--Assignment8-Subqueries

--1.Students marks greater than average
SELECT *
FROM Marks
WHERE MarksObtained >
(SELECT AVG(MarksObtained) FROM Marks);

--2.Courses with maximum credits
SELECT *
FROM Courses
WHERE Credits =
(SELECT MAX(Credits) FROM Courses);

--3.Students enrolled in more than 2 courses
SELECT StudentID
FROM Enrollments
GROUP BY StudentID
HAVING COUNT(CourseID) >2;

--4.Teachers in same department as John
SELECT *
FROM Teachers
WHERE DepartmentID =
(SELECT DepartmentID FROM Teachers WHERE FullName='John');

--5.Students with highest marks
SELECT *
FROM Marks
WHERE MarksObtained =
(SELECT MAX(MarksObtained) FROM Marks);

--6.Department with maximum students
SELECT TOP 1 DepartmentID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DepartmentID
ORDER BY TotalStudents DESC;
