USE CoffeeShopCRUD;

CREATE TABLE Orders
(
	ID int IDENTITY(1,1) Primary Key,
	OrderItem VARCHAR(15) NOT NULL,
	Quantity INT,
	TotalPrice FLOAT
);

DROP TABLE Orders;

SELECT * FROM Orders;

INSERT INTO 
	Orders (OrderItem, Quantity, TotalPrice)
VALUES
	('Black', 5, 600);

UPDATE Orders
SET
OrderItem = 'Black', Quantity = 6, TotalPrice = 120
WHERE ID = 3;

SELECT * FROM Orders
WHERE OrderItem LIKE 'c%'

DELETE FROM Orders
WHERE ID=1;
