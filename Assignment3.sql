USE Northwind
GO

--1
SELECT DISTINCT City
FROM Employees 
WHERE City IN (
    SELECT City FROM Customers 
)

--2.a
SELECT DISTINCT City
FROM Customers  
WHERE City NOT IN (
    SELECT City FROM Employees 
)
--2.b
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City=e.City
WHERE e.City IS NULL


--3
SELECT p.ProductName, SUM(OD.Quantity) AS TotalQuantity
FROM [Order Details] od JOIN Products p ON od.ProductID = p.ProductID
GROUP BY P.ProductName

--4 
SELECT c.City, COUNT(od.ProductID) AS TotalProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od 
ON o.OrderID = od.OrderID
GROUP BY c.City

--5
SELECT city, COUNT(CustomerID) AS TotalCustomers
FROM Customers
GROUP BY city
HAVING COUNT(CustomerID) >= 2

--6
SELECT c.City, COUNT(od.ProductID) AS TotalProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od 
ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID)>=2

--7
SELECT DISTINCT c.CustomerID, c.ContactName
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8
CREATE FUNCTION GetTotalRevenue(@price money, @discount real, @quantity smallint)
RETURNS MONEY
AS
BEGIN
    DECLARE @Revenue Money
    SET @Revenue = @price * (1 - @discount) * @quantity
    RETURN @Revenue
END
CREATE FUNCTION GetAvgPrice(@total money, @quantity smallint)
RETURNS MONEY
AS
BEGIN
    DECLARE @AvgPrice Money
    SET @AvgPrice = @total / @quantity
    RETURN @AvgPrice
END

WITH MostPopularItem
AS(
    SELECT TOP 5 p.ProductName,od.ProductId, 
    SUM(dbo.GetTotalRevenue(od.UnitPrice, od.Discount, od.Quantity)) As TotalRevenue , 
    SUM(od.Quantity) AS TotalQuantity
    FROM [Order Details] od JOIN Products p ON od.ProductID = p.ProductID
    GROUP BY od.ProductId,p.ProductName
    ORDER BY TotalQuantity
)
SELECT m.ProductName,dbo.GetAvgPrice(m.TotalRevenue,m.TotalQuantity) AS AvgPrice, dt.city
FROM MostPopularItem m JOIN 
    (SELECT c.City,od.ProductID, SUM(od.Quantity) AS TotalQuant, RANK() OVER(PARTITION  BY od.ProductID ORDER BY SUM(od.Quantity) DESC) RNK 
    FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od 
    ON o.OrderID = od.OrderID
    GROUP BY c.City,od.ProductID) dt  
ON m.ProductId = dt.ProductID
WHERE dt.RNK = 1


--9
--Sub-Query
SELECT DISTINCT City 
FROM Employees
WHERE City NOT IN(
    SELECT City FROM Customers
)

--Without subQuery
SELECT e.City 
FROM Employees e LEFT JOIN Customers c ON e.City = c.City 
WHERE c.City IS NULL

--10
SELECT dt.City
FROM(
SELECT c.City, RANK() OVER (ORDER BY COUNT(o.OrderId) DESC) RNK, 
RANK() OVER (ORDER BY SUM(od.Quantity) DESC) QRNK
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
) dt 
WHERE dt.RNK = 1 and dt.QRNK = 1


--11
--We can use cte to assign a row number to all the duplicates record, then delete 
--the record in the cte where row number is greater than 1.


