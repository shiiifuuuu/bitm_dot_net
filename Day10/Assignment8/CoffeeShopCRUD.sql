CREATE DATABASE CoffeeShopCRUD;
USE CoffeeShopCRUD;

CREATE TABLE Customers
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(25) NOT NULL,
	Contact VARCHAR(11) NOT NULL,
	Address VARCHAR(100) NOT NULL
);
CREATE TABLE Items
(
	Id INT IDENTITY(1,1) Primary Key,
	Name VARCHAR(15) NOT NULL,
	Price FLOAT
);
CREATE TABLE Orders
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Quantity INT,
	Price FLOAT,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	ItemId INT FOREIGN KEY REFERENCES Items(Id)
);

DROP TABLE Customers
DROP TABLE Items
DROP TABLE Orders

SELECT * FROM Customers
SELECT * FROM Items
SELECT * FROM Orders


INSERT INTO Customers (Name, Address, Contact) VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers VALUES ('Rafi', 'BNorisal' ,'01811369369')
INSERT INTO Customers VALUES ('Rafiul', 'Shamoly' ,'524545369369')

INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Regular', 80)
INSERT INTO Items (Name, Price) Values ('Cold', 100)
INSERT INTO Items (Name, Price) Values ('Hot', 90)

INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (1, 1 , 5, 600)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (1, 2 , 3, 240)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (1, 3 , 2, 200)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (2, 2 , 2, 160)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (2, 3 , 3, 300)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (2, 4 , 4, 400)
INSERT INTO Orders (CustomerId, ItemId, Quantity, Price) VALUES (4, 4 , 4, 400)


SELECT o.Id, c.Name AS Customer, i.Name AS Item, Quantity, o.Price AS TotalPrice FROM Orders AS o
LEFT JOIN Customers AS c ON c.Id = o.CustomerId
LEFT JOIN Items AS i ON i.Id = o.ItemId