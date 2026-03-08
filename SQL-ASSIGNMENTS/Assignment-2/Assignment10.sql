use AssignmentDb;

--Assignment10-Indexes

--1.Index on student lastname
CREATE INDEX idx_student_lastname
ON Students(LastName);

--2.Index on teacher email
CREATE INDEX idx_teacher_email
ON Teachers(Email);

--3.Composite index
CREATE INDEX idx_enrollment_student_course
ON Enrollments(StudentID,CourseID);

--4.Unique index
CREATE UNIQUE INDEX idx_department_name
ON Departments(DepartmentName);

--5.Drop index
DROP INDEX idx_student_lastname
ON Students;