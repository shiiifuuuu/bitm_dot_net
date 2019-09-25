CREATE DATABASE CoffeeShop;
USE CoffeeShop;

CREATE TABLE CustomerInformation 
(
ID int IDENTITY(1,1), Name varchar(20), ContactNo varchar(11), Address varchar(30)
PRIMARY KEY (ID, ContactNo)
);

SELECT * FROM CustomerInformation;

DROP TABLE CustomerInformation;

INSERT INTO CustomerInformation (Name, ContactNo, Address)
VALUES ('Shahadat', '01757814608', 'Dania, Dhaka');

DESC CustomerInformation;

