USE productsdb

--INSERT INTO Products 
--VALUES 
--('iPhone 6', 'Apple', 3, 36000),
--('Galaxy S8', 'Samsung', 2, 46000),
--('Galaxy S8 Plus', 'Samsung', 1, 56000)

--SELECT ProductName + ' (' + Manufacturer + ')' AS 'Model Name', Price, Price * 0.75 AS 'Discount'
--FROM Products

--SELECT DISTINCT Manufacturer
--FROM Products

--SELECT ProductName + ' (' + Manufacturer + ')' AS ModelName, Price
--INTO ProductSummary
--FROM Products
 
--SELECT * FROM ProductSummary

--INSERT INTO ProductSummary
--SELECT ProductName + ' (' + Manufacturer + ')' AS ModelName, Price
--FROM Products

--SELECT *
--FROM Products
--ORDER BY ProductName

--SELECT ProductName, Price AS 'Total Sum'
--FROM Products
--ORDER BY 'Total Sum' ASC, ProductName

--SELECT TOP 75 PERCENT ProductName
--FROM Products

--SELECT * FROM Products
--ORDER BY Id 
--    OFFSET 2 ROWS;

--SELECT * FROM Products
--ORDER BY Id 
--    OFFSET 2 ROWS
--    FETCH NEXT 2 ROWS ONLY;

--SELECT * FROM Products
--ORDER BY Id 
--    OFFSET 2 ROWS
--    FETCH FIRST 2 ROWS ONLY;

--SELECT * 
--FROM Products
--WHERE Manufacturer = 'Samsung' AND Price < 50000

--SELECT * FROM Products
--WHERE NOT Manufacturer = 'Apple'

--SELECT * FROM Products
--WHERE Manufacturer <> 'Apple'

--SELECT * FROM Products
--WHERE (Manufacturer = 'Samsung' OR Price > 30000) AND ProductCount > 2

--SELECT * FROM Products
--WHERE ProductCount IS NULL

--SELECT * FROM Products
--WHERE ProductCount IS NOT NULL

--SELECT * FROM Products
--WHERE Manufacturer IN ('Samsung', 'Xiaomi', 'Huawei')

--SELECT * FROM Products
--WHERE Price BETWEEN 20000 AND 40000
--SELECT * FROM Products
--WHERE Price NOT BETWEEN 20000 AND 40000

--SELECT * FROM Products
--WHERE ProductName LIKE 'Galaxy%'
--SELECT * FROM Products
--WHERE ProductName LIKE 'iPhone [6-8]'
--SELECT * FROM Products
--WHERE ProductName LIKE 'iPhone [^1-6]%'

--UPDATE Products
--SET Manufacturer = 'Samsung Inc.'
--WHERE Manufacturer = 'Samsung'

--UPDATE Products
--SET Manufacturer = 'Apple Inc.'
--FROM
--(SELECT TOP 2 FROM Products WHERE Manufacturer='Apple') AS Selected
--WHERE Products.Id = Selected.Id

--DELETE Products
--WHERE Manufacturer='Xiaomi' AND ProductName = 'Mi8'

--DELETE Products FROM
--(SELECT TOP 2 * FROM Products
--WHERE Manufacturer='Apple]') AS Selected
--WHERE Products.Id = Selected.Id


--SELECT AVG(Price) AS Average_Price FROM Products

--SELECT AVG(Price) FROM Products
--WHERE Manufacturer='Apple'
	
--SELECT COUNT(Manufacturer) FROM Products

--SELECT SUM(ProductCount * Price) FROM Products

--SELECT AVG(DISTINCT ProductCount) AS Average_Price FROM Products

--SELECT COUNT(*) AS ProdCount,
--       SUM(ProductCount) AS TotalCount,
--       MIN(Price) AS MinPrice,
--       MAX(Price) AS MaxPrice,
--       AVG(Price) AS AvgPrice
--FROM Products

--SELECT Manufacturer, COUNT(*) AS ModelsCount
--FROM Products
--GROUP BY Manufacturer

--SELECT Manufacturer, ProductCount, COUNT(*) AS ModelsCount
--FROM Products
--GROUP BY Manufacturer, ProductCount

--SELECT Manufacturer, COUNT(*) AS ModelsCount
--FROM Products
--WHERE Price > 30000
--GROUP BY Manufacturer
--ORDER BY ModelsCount DESC

--SELECT Manufacturer, ProductCount, COUNT(*) AS ModelsCount
--FROM Products
--GROUP BY Manufacturer, ProductCount

--SELECT Manufacturer, COUNT(*) AS Models, SUM(ProductCount) AS Units
--FROM Products
--WHERE Price * ProductCount > 80000
--GROUP BY Manufacturer
--HAVING SUM(ProductCount) > 2
--ORDER BY Units DESC

--SELECT Manufacturer, COUNT(*) AS Models, SUM(ProductCount) AS Units
--FROM Products
--GROUP BY Manufacturer WITH ROLLUP

--SELECT Manufacturer, COUNT(*) AS Models, SUM(ProductCount) AS Units
--FROM Products
--GROUP BY Manufacturer, ProductCount WITH ROLLUP

--SELECT Manufacturer, COUNT(*) AS Models, SUM(ProductCount) AS Units
--FROM Products
--GROUP BY Manufacturer, ProductCount WITH CUBE

--SELECT Manufacturer, COUNT(*) AS Models, ProductCount
--FROM Products
--GROUP BY GROUPING SETS(Manufacturer, ProductCount)

SELECT ProductName, Manufacturer, ProductCount,
        COUNT(*) OVER (PARTITION BY Manufacturer) AS Models,
        SUM(ProductCount) OVER (PARTITION BY Manufacturer) AS Units
FROM Products

