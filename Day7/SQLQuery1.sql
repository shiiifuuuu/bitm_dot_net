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


CREATE TABLE customer
(
ID int IDENTITY(1,1),
Name varchar(20),
Contact varchar(11),
Address varchar(30)
)

SELECT * FROM customer

INSERT INTO customer (Name, Contact, Address)
VALUES ('Shahadat', 01757814608, 'Dhaka')
INSERT INTO customer VALUES ('Adnan', '01236547851', 'Shamoly')
INSERT INTO customer VALUES ('Saykat', '32132543131', 'Kollanpur')
INSERT INTO customer VALUES ('Raqib', '16541341645', 'Dhanmondi')
INSERT INTO customer VALUES ('Shad', '017578456408', 'Mirpur')

DROP TABLE customer

INSERT INTO customer VALUES ('Adnan', '01236547851', 'Shamoly')
INSERT INTO customer VALUES ('Saykat', '32132543131', 'Kollanpur')
INSERT INTO customer VALUES ('Raqib', '16541341645', 'Dhanmondi')
INSERT INTO customer VALUES ('Shad', '017578456408', 'Mirpur')

UPDATE customer 
SET Name = 'AAAA'
WHERE ID = 5