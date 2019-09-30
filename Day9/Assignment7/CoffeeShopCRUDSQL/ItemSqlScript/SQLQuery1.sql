CREATE DATABASE CoffeeShopCRUD;
USE CoffeeShopCRUD;

CREATE TABLE Item
(
	ID int IDENTITY(1,1) Primary Key,
	ItemName VARCHAR(15) NOT NULL,
	Price FLOAT
);

SELECT * FROM Item;

INSERT INTO 
	ITEM (ItemName, Price)
VALUES
	('Black', 120);

DELETE FROM Item
WHERE ID=1;

UPDATE Item
SET ItemName='Hot', Price=100
WHERE ID=2;

SELECT * FROM Item
WHERE ItemName LIKE 'a%';