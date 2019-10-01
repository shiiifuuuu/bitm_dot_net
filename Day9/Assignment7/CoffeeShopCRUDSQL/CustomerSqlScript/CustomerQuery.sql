USE CoffeeShopCRUD;

CREATE TABLE Customers
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(25) NOT NULL,
	Contact VARCHAR(11) NOT NULL,
	Address VARCHAR(100) NOT NULL
);

SELECT * FROM Customers;

DROP TABLE Customers;

INSERT INTO
Customers (CustomerName, Contact, Address)
VALUES
('Shahadat', '01757814608', 'Dania, Dhaka');

UPDATE Customers
SET
CustomerName = 'Samira', Contact = '036543165', Address = 'Dhaka'
WHERE ID = 3;

SELECT * FROM Customers
WHERE CustomerName LIKE 'c%'

DELETE FROM Customers
WHERE ID=1;
