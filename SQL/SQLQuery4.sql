--joins
-- Creating employee table
CREATE TABLE employee (employee_id int PRIMARY KEY,first_name VARCHAR(50),last_name VARCHAR(50));
-- Creating salary table 
CREATE TABLE salary (employee_id int, monthly_salary int);
--join
-- Insert data into employee table
INSERT INTO employee (employee_id, first_name, last_name)
VALUES
(1, 'shree', 'nithi'),
(2, 'harsh', 'veena'),
(3, 'Charu', 'mathi'),
(4, 'David', 'Watson');
INSERT INTO salary (employee_id, monthly_salary)
VALUES
(1, 5000),
(2, 6000),
(3, 5500),
(5, 7000);
--join
SELECT e.employee_id, e.first_name, e.last_name, salary.monthly_salary 
FROM employee as e
INNER JOIN salary ON e.employee_id = salary.employee_id;
--left outer
SELECT e.employee_id, e.first_name, e.last_name, salary.monthly_salary
FROM employee as e
LEFT JOIN salary ON e.employee_id = salary.employee_id;
--right outer
SELECT e.employee_id, e.first_name, e.last_name, salary.monthly_salary
FROM employee as e
RIGHT JOIN salary ON e.employee_id = salary.employee_id;
--FULL JOIN
SELECT e.employee_id, e.first_name, e.last_name, salary.monthly_salary
FROM employee as e
FULL OUTER JOIN salary ON e.employee_id = salary.employee_id;
--CROSS JOIN
SELECT employee.employee_id, employee.first_name, employee.last_name, salary.monthly_salary
FROM employee
CROSS JOIN salary;

--PROCEDURES
--Student admission form
--Creating table
CREATE TABLE StudentAdmission (
  StudentID int PRIMARY KEY,
  Name varchar(50),
  Email varchar(100),
  Phone varchar(20)
);
INSERT INTO StudentAdmission (StudentID, Name, Email, Phone)
VALUES
  (1, 'Shree', 'shree@example.com', '1234567890'),
  (2, 'Smitha', 'smitha@example.com', '0987654321'),
  (3, 'Victor', 'victor@example.com', '5551234567');
--Creating procedures
CREATE PROCEDURE sp_StudentAdmission
  @StudentID int,
  @Name varchar(50),
  @Email varchar(100),
  @Phone varchar(20),
  @Operation varchar(10)
AS
BEGIN
  IF @Operation = 'CREATE'
    INSERT INTO StudentAdmission (StudentID, Name, Email, Phone)
    VALUES (@StudentID, @Name, @Email, @Phone);
  ELSE IF @Operation = 'READ'
    SELECT * FROM StudentAdmission WHERE StudentID = @StudentID;
  ELSE IF @Operation = 'UPDATE'
    UPDATE StudentAdmission
    SET Name = @Name, Email = @Email, Phone = @Phone
    WHERE StudentID = @StudentID;
  ELSE IF @Operation = 'DELETE'
    DELETE FROM StudentAdmission WHERE StudentID = @StudentID;
END;
--Create
EXEC sp_StudentAdmission 4, 'Swetha', 'swetha@example.com', '1112223333', 'CREATE';
--Read
EXEC sp_StudentAdmission 2, '', '', '', 'READ';
--Update
EXEC sp_StudentAdmission 4, 'ravi Updated', 'ravi.updated@example.com', '1234567890', 'UPDATE';
select * from StudentAdmission;
--delete
EXEC sp_StudentAdmission 3, '', '', '', 'DELETE';

--Signup and Login
-- Create database
CREATE DATABASE MyDatabase;
-- Use new database
USE MyDatabase;
-- Create Signup table
CREATE TABLE Signup (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL
);
-- Create Login table
CREATE TABLE Login (
    LoginID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    LoginTime DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Signup(UserID)
);
--insert
-- Insert Signup table
INSERT INTO Signup (FirstName, LastName, Email, Password)
VALUES ('Swetha', 'Ravi', 'swetha@example.com', 'Swetha@123');
INSERT INTO Signup (FirstName, LastName, Email, Password)
VALUES ('sara', 'jeo', 'sara@example.com', 'Sara@123');
-- Insert a new login record for the user
INSERT INTO Login (UserID)
VALUES (1);
INSERT INTO Login (UserID)
VALUES (2);
--select
SELECT * FROM Signup;
SELECT * FROM Login WHERE UserID = 1;
--Update
--UPDATE Signup
UPDATE Signup SET Password = 'newpassword123'
WHERE Email = 'swetha@example.com';
-- Update the last login time for a specific user
UPDATE Login SET LoginTime = GETDATE()
WHERE UserID = 1;
--delete
DELETE FROM Login WHERE UserID = 2; 

--KEYS
-- primary and foreeign key
-- Department table
CREATE TABLE Department (
  DepartmentID INT PRIMARY KEY,
  DepartmentName VARCHAR(255) NOT NULL
);

-- Create an Employee table with primary key,foreign key
CREATE TABLE Employees (
  EmployeeID INT PRIMARY KEY,
  FirstName VARCHAR(255) NOT NULL,
  LastName VARCHAR(255) NOT NULL,
  Email VARCHAR(255) NOT NULL,
  DepartmentID INT,
  FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);
--inserting values
-- Insert values into the Department table
INSERT INTO Department (DepartmentID, DepartmentName)
VALUES
(1, 'Sales'),
(2, 'Marketing'),
(3, 'IT'),
(4, 'HR'),
(5, 'Finance');

-- Insert values into the Employee table
INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, DepartmentID)
VALUES
(1, 'Shree', 'Nithi', 'shree@example.com', 1),
(2, 'Ravi', 'Chandran', 'ravi@example.com', 2),
(3, 'raja', 'victor', 'raja@example.com', 3),
(4, 'karthi', 'keyan', 'karthi@example.com', 4),
(5, 'gayathri', 'sri', 'sri@example.com', 5);
--unique key
ALTER TABLE Employees
ADD CONSTRAINT Employees_Email UNIQUE (Email);
--check constraint
ALTER TABLE Employees
ADD CONSTRAINT Employees_DepartmentID
CHECK (DepartmentID IN (SELECT DepartmentID FROM Department));
ALTER TABLE Employees
ADD CONSTRAINT CK_Employees_Email
CHECK (Email LIKE '%_@__%.__%');
select * from Employees;
select * from Department;

UPDATE Employees SET LastName='Shree' WHERE EmployeeID=5;










