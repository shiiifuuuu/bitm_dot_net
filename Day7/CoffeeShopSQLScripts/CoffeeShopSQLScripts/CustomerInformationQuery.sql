CREATE DATABASE CoffeeShop;
USE CoffeeShop;

CREATE TABLE CustomerInformation 
(
ID INT IDENTITY(1,1) NOT NULL,
Name VARCHAR(MAX) NOT NULL,
Phone DECIMAL NOT NULL PRIMARY KEY, 
Address VARCHAR(MAX) NOT NULL
);

SELECT * FROM CustomerInformation;

INSERT INTO 
CustomerInformation (Name, Phone, Address)
VALUES 
('Shahadat Hossain', 01757814608, 'Shani Akhra');

INSERT INTO 
CustomerInformation (ID, Name, Phone, Address)
VALUES 
(1, 'Ibrahim', '+8801757811236', 'Shani Akhra');


DELETE FROM CustomerInformation WHERE ID=2;

DROP TABLE CustomerInformation;