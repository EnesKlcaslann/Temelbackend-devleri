SELECT o.ShippedDate , 
o.OrderDate,
DATEDIFF(DAY, o.OrderDate ,o.ShippedDate) AS [TeslimSuresi] ,
SUM(DATEDIFF(DAY, o.OrderDate ,o.ShippedDate))


FROM Orders o
WHERE o.ShippedDate IS NOT NULL
GROUP BY o.ShippedDate ,  o.OrderDate

ORDER BY 3 DESC


