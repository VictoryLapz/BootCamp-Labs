--1. Select all the rows from the "Customers" table. 
SELECT *
FROM Customers

--2. Get distinct countries from the Customers table. (Hint: research the DISTINCT keyword.)
SELECT DISTINCT Country
FROM Customers;

--3. Get all the rows from the table Customers where the Customer’s ID starts with “BL”.
SELECT *
FROM Customers
WHERE CustomerID LIKE 'BL%'

--4. Get the first 100 records of the orders table. (Hint: research the TOP keyword.) DISCUSS: Why would you do this? What else would you likely need to include in this query?
--Would do this to Narrow down the search and you would include the * for All.
SELECT TOP 100 *
FROM Orders;

--5. Get all customers that live in the postal codes 1010, 3012, 12209, and 05023. (Hint: research the IN keyword.)
SELECT *
FROM Customers
WHERE PostalCode IN ('1010', '3012', '12209', '05023');

--6. Get all orders where the ShipRegion is not equal to NULL.
SELECT *
FROM Orders
WHERE ShipRegion is NOT NULL;

--7. Get all customers ordered by the country, then by the city.
SELECT *
FROM Customers
ORDER BY Country, City

--8. Add a new customer to the customers table. You can use whatever values.
INSERT INTO Customers(CustomerID, ContactName, ContactTitle)
VALUES ('AZPHX','Freddie Hicks','DEVOPS');

--9. Update all ShipRegion to the value ‘EuroZone’ in the Orders table, where the ShipCountry is equal to France.  
SELECT * 
FROM Orders
WHERE ShipCountry = 'France';

--10. Delete all orders from OrderDetails that have quantity of 1. 
DELETE FROM [Order Details]
Where Quantity = 1;

--11. Find the CustomerID that placed order 10290 (orders table).
SELECT CustomerID
FROM [Orders]
WHERE OrderID = '10290'

--12.Join the orders table to the customers table.
SELECT OrderID, Customers.CustomerID
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID

--13.Get employees’ firstname for all employees who report to no one.
SELECT FirstName
FROM Employees
WHERE [ReportsTo] Is NULL

--14.Get employees’ firstname for all employees who report to Andrew.
SELECT FirstName
FROM Employees
WHERE ReportsTo = '2'

--15. Write an SQL command to create an index on the CustomerID column in the Customers table.
SELECT CustomerID
FROM Customers

/*Extra Challenge*/

--1. Calculate the average, max, and min of the quantity at the orderdetails table, grouped by the orderid. 
SELECT AVG(Quantity), MAX(Quantity), MIN(Quantity)
FROM [Order Details]
GROUP BY OrderID

--2. Calculate the average, max, and min of the quantity at the orderdetails table.
SELECT AVG(Quantity), MAX(Quantity), MIN(Quantity)
FROM [Order Details]


