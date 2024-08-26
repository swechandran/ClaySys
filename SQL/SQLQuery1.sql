CREATE TABLE student(student_id INT ,first_name VARCHAR(50),last_name VARCHAR(50),age INT,grade CHAR(2));
--inserting values
INSERT INTO student(student_id, first_name, last_name, age, grade)
VALUES(1,'swetha','chandran',15,'A'),
(2, 'sri','hari',16,'B'),
(3, 'sri','ram',17,'A'),
(4, 'harish','raja', 15, 'C'),
(5, 'Daniel','manoj',16,'B');
--select
SELECT * FROM student;
--distinct
SELECT DISTINCT age FROM student;
--where
SELECT * FROM student WHERE grade='A';
--and,or,not
SELECT * FROM student WHERE age = 15 AND grade = 'C';
SELECT * FROM student WHERE age = 16 OR grade = 'B';
SELECT * FROM student WHERE NOT age = 16;
--order by
SELECT * FROM student ORDER BY first_name asc;
--null values
INSERT INTO student (student_id, first_name, last_name, age, grade)
VALUES (6, 'Sara','ravi',null,null);
SELECT * FROM student WHERE age IS null;
--update
UPDATE student SET age=17 WHERE first_name='Sara';
UPDATE student SET grade='C' WHERE student_id='6';
--select top
SELECT TOP 3 * from student;
--MIN MAX(aggregate)
SELECT MIN(age) AS youngest FROM student;
SELECT MAX(age) AS older from student;
--count,avg,sum
SELECT COUNT(*) AS first_name FROM student; 
SELECT AVG(age) FROM student;
SELECT SUM(age) FROM student;
--like
SELECT * FROM student where first_name like 's%';
--in
SELECT * FROM student where grade IN ('A', 'C');
--between
SELECT * FROM student where age between 15 and 17;
--alias
SELECT first_name AS "First Name", last_name AS "Last Name" FROM student;

--second largest
-- Create employee table
CREATE TABLE Employees (
  EmployeeID int,
  Name varchar(255),
  Salary decimal(10, 2)
);
-- Insert data into the table
INSERT INTO Employees (EmployeeID, Name, Salary)
VALUES
  (1, 'Swetha', 50000.00),
  (2, 'Shree', 60000.00),
  (3, 'Smitha', 70000.00),
  (4, 'Harish', 55000.00),
  (5, 'jeeva', 65000.00);

--second largest salary
SELECT Salary AS SecondLargestSalary
FROM Employees
WHERE Salary < (SELECT MAX(Salary) FROM Employees);

SELECT MAX(Salary) AS SecondLargestSalary
FROM Employees
WHERE Salary < (SELECT MAX(Salary) FROM Employees);

--pivot and unpivot





