USE AdventureWorks2019
GO

--1
SELECT COUNT(ProductID) AS TotalProduct
FROM Production.Product

--2
SELECT COUNT(ProductID) AS TotalNumInSubcat
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3
SELECT ProductSubcategoryID, COUNT(ProductID) AS CountedProducts
FROM Production.Product 
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID
--with Subcategory name
SELECT p.ProductSubcategoryID, s.Name,COUNT(p.ProductID) AS CountedProducts
FROM Production.Product p JOIN Production.ProductSubcategory s ON p.ProductSubcategoryID = s.ProductSubcategoryID
WHERE p.ProductSubcategoryID IS NOT NULL
GROUP BY p.ProductSubcategoryID,s.Name

--4
SELECT COUNT(ProductID) AS TotalNumNotInSub
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5
SELECT SUM(Quantity) AS ToalQuantity
FROM Production.ProductInventory
GROUP BY ProductID;

--6
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID=40 
GROUP BY ProductID
HAVING SUM(Quantity)<100

--7
SELECT Shelf, ProductID,SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID=40 
GROUP BY ProductID,Shelf
HAVING SUM(Quantity)<100


--8 
SELECT AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID=10



--9
SELECT ProductID,Shelf, AVG(Quantity) TheAvg
FROM Production.ProductInventory
GROUP BY ProductID,Shelf


--10  WHERE VS HAVING
SELECT ProductID,Shelf, AVG(Quantity) TheAvg
FROM Production.ProductInventory
WHERE Shelf !='N/A'
GROUP BY ProductID,Shelf

--11
SELECT Color, Class, SUM(ProductID) TheCount,AVG(ListPrice) AvfPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12
SELECT c.Name Country ,s.Name Province
FROM person. CountryRegion c JOIN  person. StateProvince s ON c.CountryRegionCode=s.CountryRegionCode


--13
SELECT c.Name Country,s.Name Province
FROM person. CountryRegion c JOIN  person. StateProvince s ON c.CountryRegionCode=s.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')


--NorthWind 
USE Northwind
GO
--14
SELECT DISTINCT p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID 
Join Products p ON od.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR,-27,GETDATE())


--15
SELECT TOP 5 ShipPostalCode, Count(OrderID) TotalOrderNum
FROM Orders
WHERE ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode
ORDER BY TotalOrderNum DESC

--16
SELECT TOP 5 ShipPostalCode, Count(OrderID) TotalOrderNum
FROM Orders
WHERE ShipPostalCode IS NOT NULL AND OrderDate >= DATEADD(YEAR,-27,GETDATE())
GROUP BY ShipPostalCode
ORDER BY TotalOrderNum DESC

--17 
SELECT City, COUNT(CustomerID) TotalCustomers
FROM Customers
GROUP BY City

--18
SELECT City, COUNT(CustomerID) TotalCustomers
FROM Customers
GROUP BY City,Country
HAVING COUNT(CustomerID) > 2

--19
SELECT DISTINCT c.ContactName,o.OrderDate
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID
WHERE o.OrderDate >'1998-01-01'

--20
SELECT c.ContactName, MAX(o.OrderDate) MostRecentOrder
FROM Customers c JOIN Orders o ON o.CustomerID=c.CustomerID
GROUP BY c.ContactName

--21
SELECT c.ContactName,COUNT(od.ProductID) NumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID=o.CustomerID 
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

--22
SELECT o.CustomerID, Count(od.ProductID) NumOfProducts
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.CustomerID
HAVING Count(od.ProductID) > 100

--23
SELECT  sp.CompanyName [Supplier Company Name],s.CompanyName [Shipping Company Name]
FROM Suppliers sp CROSS JOIN Shippers s 

--24
SELECT o.OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID =od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY o.OrderDate,p.ProductName 

--25 *
SELECT e.FirstName,e.LastName,m.FirstName,m.LastName
FROM Employees e INNER JOIN Employees m ON e.Title=m.Title
WHERE e.EmployeeID > m.EmployeeID


--26
SELECT m.FirstName, m.LastName
FROM Employees m JOIN
(SELECT e.ReportsTo,COUNT(EmployeeID) NumOfEmployee
FROM Employees e
GROUP BY e.ReportsTo
HAVING COUNT(EmployeeID)>2) dt
ON m.EmployeeID=dt.ReportsTo

--27
SELECT City,ContactName, 'Customer' AS Type
FROM Customers
UNION 
SELECT City,ContactName, 'Supplier' AS Type
FROM Suppliers
