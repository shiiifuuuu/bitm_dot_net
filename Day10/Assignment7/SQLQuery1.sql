USE CoffeeShopCRUD;

CREATE TABLE Customers
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(25) NOT NULL,
	Contact VARCHAR(11) NOT NULL,
	Address VARCHAR(100) NOT NULL
)
CREATE TABLE Items
(
	ID int IDENTITY(1,1) Primary Key,
	Name VARCHAR(15) NOT NULL,
	Price FLOAT
);
CREATE TABLE Orders
(
ID INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT FOREIGN KEY REFERENCES Customers(ID) ,
ItemId INT FOREIGN KEY REFERENCES Items(ID),
Quantity INT,
TotalPrice FLOAT
)



DROP TABLE Customers
DROP TABLE Items
DROP TABLE Orders



SELECT * FROM Customers
SELECT * FROM Items
SELECT * FROM Orders



INSERT INTO Customers VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers VALUES ('Rafi', 'BNorisal' ,'01811369369')
INSERT INTO Customers VALUES ('Rafiul', 'Shamoly' ,'524545369369')


INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Regular', 80)
INSERT INTO Items (Name, Price) Values ('Cold', 100)
INSERT INTO Items (Name, Price) Values ('Hot', 90)


INSERT INTO Orders VALUES (1, 1 , 5, 600)
INSERT INTO Orders VALUES (1, 2 , 3, 240)
INSERT INTO Orders VALUES (1, 3 , 2, 200)
INSERT INTO Orders VALUES (2, 2 , 2, 160)
INSERT INTO Orders VALUES (2, 3 , 3, 300)
INSERT INTO Orders VALUES (2, 4 , 4, 400)
INSERT INTO Orders VALUES (4, 4 , 4, 400)


SELECT ID, CustomerId, ItemId, Quantity, TotalPrice FROM Orders AS o