SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Product p LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON pc.CategoryId = c.Id
ORDER BY p.Name, c.Name