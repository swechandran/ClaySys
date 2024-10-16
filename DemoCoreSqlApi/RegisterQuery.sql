CREATE TABLE RegisteredUsers (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Gender VARCHAR(10),
    PhoneNumber VARCHAR(20),
    EmailAddress VARCHAR(100),
    Address VARCHAR(200),
    Username VARCHAR(50),
    Password VARCHAR(100)
)
INSERT INTO RegisteredUsers (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, EmailAddress, Address, Username, Password)
VALUES 
('Ravi', 'Chandran', '1990-05-15', 'Male', '123-456-7890', 'ravi@example.com', '123 Main St', 'Ravi', 'Ravi@123'),
('Sara', 'Smith', '1985-07-22', 'Female', '987-654-3210', 'sara@example.com', '456 Park Ave', 'Sara', 'Sara@123');

select * from RegisteredUsers;

CREATE PROCEDURE SPI_RegisteredUsers
    @UserID INT= NULL,@FirstName VARCHAR(50),@LastName VARCHAR(50),@DateOfBirth DATE,@Gender VARCHAR(10),@PhoneNumber VARCHAR(15),
    @EmailAddress VARCHAR(100),@Address VARCHAR(255),@Username VARCHAR(50),
    @Password VARCHAR(100)
AS
BEGIN
    INSERT INTO RegisteredUsers(FirstName,LastName,DateOfBirth,Gender,PhoneNumber,EmailAddress,Address,Username,Password)
    VALUES (@FirstName,@LastName,@DateOfBirth,@Gender,@PhoneNumber,@EmailAddress,@Address,@Username,@Password)
END;

CREATE PROCEDURE SPR_GetAllRegisteredUsers
AS
BEGIN
    SELECT 
        UserID,FirstName,LastName,DateOfBirth,Gender,PhoneNumber,EmailAddress,Address,Username,Password
    FROM RegisteredUsers;
END;

CREATE PROCEDURE SPR_GetRegisteredUsersbyId
@UserID int  
AS
BEGIN
    SELECT 
        UserID,FirstName,LastName,DateOfBirth,Gender,PhoneNumber,EmailAddress,Address,Username,Password
    FROM RegisteredUsers WHERE UserID=@UserID
END;

CREATE PROCEDURE SPU_EditRegisteredUsers
    @UserID INT,@FirstName VARCHAR(50),@LastName VARCHAR(50),@DateOfBirth DATE,@Gender VARCHAR(10),@PhoneNumber VARCHAR(15),
    @EmailAddress VARCHAR(100),@Address VARCHAR(255),@Username VARCHAR(50),
    @Password VARCHAR(100)
AS
BEGIN
    UPDATE RegisteredUsers
    SET 
        FirstName = @FirstName,LastName = @LastName,DateOfBirth = @DateOfBirth,Gender = @Gender,PhoneNumber = @PhoneNumber,
        EmailAddress = @EmailAddress,Address = @Address,Username = @Username,Password = @Password
    WHERE 
        UserID = @UserID ;
END;

CREATE PROCEDURE SPD_DeleteRegisteredUsers
    @UserID INT
AS
BEGIN
    DELETE FROM RegisteredUsers
    WHERE UserID = @UserID  
END;

SELECT * 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'SPI_RegisteredUsers';


CREATE TABLE Signup (
    Id INT PRIMARY KEY IDENTITY(1,1),  
    Username VARCHAR(100) NOT NULL,   
    Email VARCHAR(100) NOT NULL UNIQUE, 
    Password VARCHAR(255) NOT NULL,   
);
INSERT INTO Signup (Username, Email, Password) 
VALUES ('John', 'john@example.com', 'john123');

CREATE PROCEDURE Signup_Insert
    @Username VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(255)
AS
BEGIN
    INSERT INTO Signup (Username, Email, Password)
    VALUES (@Username, @Email, @Password);
END;

CREATE PROCEDURE Signup_SelectAll
AS
BEGIN
    SELECT Id, Username, Email
    FROM Signup;
END;

CREATE PROCEDURE Signup_SelectById
    @Id INT
AS
BEGIN
    SELECT Id, Username, Email
    FROM Signup
    WHERE Id = @Id;
END;

CREATE PROCEDURE Signup_Update
    @Id INT,
    @Username VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(255)
AS
BEGIN
    UPDATE Signup
    SET Username = @Username, Email = @Email, Password = @Password
    WHERE Id = @Id;
END;

CREATE PROCEDURE Signup_Delete
    @Id INT
AS
BEGIN
    DELETE FROM Signup
    WHERE Id = @Id;
END;



