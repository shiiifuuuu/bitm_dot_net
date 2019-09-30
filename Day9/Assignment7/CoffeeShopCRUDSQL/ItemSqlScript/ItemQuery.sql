CREATE DATABASE CoffeeShopCRUD;
USE CoffeeShopCRUD;

CREATE TABLE Items
(
	ID int IDENTITY(1,1) Primary Key,
	ItemName VARCHAR(15) NOT NULL,
	Price FLOAT
);

DROP TABLE Items;

SELECT * FROM Items;

INSERT INTO 
	Items (ItemName, Price)
VALUES
	('Black', 120);

DELETE FROM Items
WHERE ID=1;

UPDATE Items
SET ItemName='Hot', Price=100
WHERE ID=2;

SELECT * FROM Items
WHERE ItemName LIKE 'a%';