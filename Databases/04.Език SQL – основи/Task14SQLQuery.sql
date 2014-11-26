/*Write a SQL query to find the names of all employees whose
 salary is 25000, 14000, 12500 or 23600.*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name], e.Salary
FROM [TelerikAcademy].[dbo].Employees e
WHERE Salary IN (25000, 14000, 12500, 23600) 
ORDER BY Salary