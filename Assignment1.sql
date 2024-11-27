USE AdventureWorks2019
GO
--1.1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
--1.2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice !=0
--1.3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL
--1.4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL
--1.5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice>0
--1.6
SELECT Name + ' '+ Color AS Name_Color
FROM Production.Product
WHERE  Color IS NOT NULL
--1.7
SELECT 'NAME: ' +Name +' -- COLOR: ' + Color
FROM Production.Product
WHERE  Color IS NOT NULL
--1.8
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500
--1.9
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black','Blue')
--1.10
SELECT *
FROM Production.Product
WHERE Name Like 'S%'
--1.11
SELECT TOP 6 Name,ListPrice
FROM Production.Product
WHERE Name Like 'S%'
ORDER BY Name
--1.12
SELECT Name,ListPrice
FROM Production.Product
WHERE Name LIKE 'S%' OR Name LIKE 'A%'
ORDER BY Name
--1.13
SELECT *
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%' 
ORDER BY Name
--1.14
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC