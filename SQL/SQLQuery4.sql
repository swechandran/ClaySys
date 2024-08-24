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







