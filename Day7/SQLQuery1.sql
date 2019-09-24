CREATE DATABASE	coffeeShop
USE coffeeShop

CREATE TABLE item(

ID	INT,
name	VARCHAR(50),
price	FLOAT

)

SELECT * FROM item

INSERT INTO item (ID, name, price) VALUES (1, 'Black', 120)
INSERT INTO item VALUES (2, 'Cold', 100)
INSERT INTO item VALUES (3, 'Hot', 90)

DROP TABLE item

CREATE TABLE items
(
ID	INT IDENTITY(1,1),
name	VARCHAR(50),
price	FLOAT
)

SELECT * FROM items

INSERT INTO items VALUES ('Black', 120)
INSERT INTO items VALUES ('Cold', 100)
INSERT INTO items VALUES ('Hot', 90)

UPDATE items 
SET Name = 'Regular', Price = 80
WHERE ID = 4

UPDATE items 
SET Name = 'Normal', Price = 60
WHERE ID = 5

UPDATE items 
SET Name = 'Cuppochino', Price = 160
WHERE ID = 6

SELECT name, price FROM items where  price >= 80 order by price desc