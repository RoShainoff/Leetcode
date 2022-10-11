SELECT c.name AS Customers
FROM Customers c
WHERE c.id not in
    (SELECT customerId
     FROM Orders);
