
/* SQL Questions */

--1. Retrieve all the columns from the Customers table for customers who are from the UK.
SELECT *
FROM Customers
WHERE Country = 'UK';

--2. Using the Products table, list the product names and their unit prices where the unit price is greater than 30.
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice < 30;

--3. Count the number of products in the Products table that have been discontinued.
SELECT COUNT(*)
FROM Products
WHERE Discontinued = 1

--4. Find the average, maximum, and minimum unit prices from the Products table.
SELECT AVG(UnitPrice),MAX(UnitPrice),MIN(UnitPrice)
FROM Products

--5. Retrieve the names of categories and the count of products in each category from the Categories and Products tables.
SELECT CategoryName, COUNT(*) AS UnitsInStock
FROM Categories, Products
Group By CategoryName


--6. List the suppliers (SupplierID and CompanyName) from the Suppliers table who are not from USA, Germany, or UK.
SELECT SupplierID, CompanyName
FROM Suppliers
WHERE Country <> 'USA, Germany, UK'

--7. Retrieve all the distinct countries from the Customers table.
SELECT DISTINCT(Country)
FROM Customers
Order BY Country

--8. Find the top 5 most expensive products (Product name and Unit price) from the Products table.
SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC


--9. Using the Orders and Order Details tables, calculate the total revenue for each order (OrderID).
SELECT OrderID, SUM(Quantity * UnitPrice) AS TotalRevenue
FROM [Order Details]
GROUP BY OrderID;


--10. List all employees (FirstName and LastName) and the count of orders they have taken from the Employees and Orders tables.
SELECT E.EmployeeID, E.FirstName, E.LastName As EmployeeName, SUM(OrderID) As TotalOrders
FROM Employees E
JOIN Orders o ON o.EmployeeID = E.EmployeeID
Group BY E.EmployeeID, E.FirstName, E.LastName
Order By TotalOrders DESC;

--11. Retrieve customers (CustomerID and CompanyName) who have placed more than 10 orders using the Customers and Orders tables.
SELECT c.CustomerID, c.CompanyName
FROM Customers c
WHERE c.CustomerID IN (
SELECT o.CustomerID
FROM Orders o
Group BY o.CustomerID
Having COUNT(DISTINCT o.OrderID) > 10
);

--12. From the Products table, retrieve the names of products that are out of stock (units in stock is 0).
SELECT ProductName
FROM Products
WHERE UnitsInStock = '0'

--13. Using the Products and Categories tables, list the names of products and their respective categories where the category is either 'Beverage' or 'Confectionery'.
SELECT p.ProductName, c.CategoryName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE c.CategoryName IN ('Beverages', 'Confections');

--14. Identify which supplier (SupplierID and CompanyName from Suppliers table) has the highest number of products in the Products table.
SELECT TOP 1 p.CompanyName, c.SupplierID
FROM Suppliers p
JOIN Products c ON p.SupplierID = c.SupplierID
Group By p.CompanyName, c.SupplierID
Order By COUNT(p.SupplierID) DESC;

--15. List all the products (ProductID and ProductName) which have never been ordered. Use the Products and Order Details tables.
SELECT p.ProductName, p.ProductID
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
WHERE od.ProductID IS NULL

--16. Retrieve all orders (OrderID from Orders table) that were placed in December 1997.
SELECT OrderID
FROM Orders
WHERE OrderDate = '1997'

--17. Using the Employees and Orders tables, find out which employee has processed the most number of orders in 1998.
SELECT c.FirstName,c.LastName, c.EmployeeID,COUNT(p.OrderID) AS TotalProducts
FROM Employees c
JOIN Orders p ON c.EmployeeID = p.EmployeeID
WHERE Year(p.OrderDate) = 1998
GROUP BY c.EmployeeID,c.FirstName,c.LastName
Order BY TotalProducts DESC

--18. Find the customer (CustomerID and CompanyName from Customers table) who has purchased the most by quantity in the Order Details table.
SELECT c.CustomerID, CompanyName
FROM Customers c
JOIN Orders p ON c.CustomerID = c.CustomerID
JOIN [Order Details] od ON p.OrderID = od.OrderID
GROUP BY c.CustomerID, CompanyName
ORDER BY SUM(od.Quantity) DESC

--19. From the Shippers and Orders tables, determine which shipper has delivered the most number of orders.
SELECT TOP 1 s.ShipperID, s.CompanyName
FROM Shippers s
JOIN Orders o ON s.ShipperID = s.ShipperID
GROUP BY s.ShipperID, CompanyName
ORDER BY COUNT(o.OrderID) DESC;


--20. Identify the top 3 categories in terms of the number of products they have using the Categories and Products tables.
SELECT TOP 3 s.CategoryName, COUNT(*) AS TotalProduct
FROM Products o
JOIN Categories s ON s.CategoryID = o.CategoryID
GROUP BY CategoryName
ORDER BY TotalProduct DESC
