use AssignmentDb;

--Assignment3-Alter Table

--1.Add PhoneNumber
ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

--2.Add Salary
ALTER TABLE Teachers
ADD Salary INT;

--3.Modify Salary datatype
ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(10,2);

--4.Add CHECK constraint
ALTER TABLE Teachers
ADD CONSTRAINT CHK_Salary CHECK (Salary > 20000);

--5.Drop PhoneNumber
ALTER TABLE Students
DROP COLUMN PhoneNumber;

--6.Rename Column
EXEC sp_rename 'Teachers.TeacherName','FullName','COLUMN';