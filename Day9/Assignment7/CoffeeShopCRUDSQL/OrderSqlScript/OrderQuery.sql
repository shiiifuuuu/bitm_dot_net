USE CoffeeShopCRUD;

CREATE TABLE Orders
(
	ID int IDENTITY(1,1) Primary Key,
	ItemName VARCHAR(15) NOT NULL,
	Quantity INT,
	TotalPrice FLOAT
);

CREATE TABLE Orders
(
ID INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT FOREIGN KEY REFERENCES Customers(ID) ,
ItemId INT,
Quantity INT,
TotalPrice FLOAT
)

DROP TABLE Orders;
SELECT * FROM Customers;
SELECT * FROM Orders;

INSERT INTO 
	Orders (ItemName, Quantity, TotalPrice)
VALUES
	('Black', 5, 600);

UPDATE Orders
SET
ItemName = 'Black', Quantity = 6, TotalPrice = 120
WHERE ID = 3;

SELECT * FROM Orders
WHERE ItemName LIKE 'c%'

DELETE FROM Orders
WHERE ID=1;
