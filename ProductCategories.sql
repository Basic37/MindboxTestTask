SELECT p.[Name] AS ProductName, c.[Name] AS CategoryName
FROM Products AS p
LEFT JOIN ProductCategories AS pc ON p.[Id] = pc.[ProductId]
LEFT JOIN Categories AS c ON pc.[CategoryId] = c.[Id]