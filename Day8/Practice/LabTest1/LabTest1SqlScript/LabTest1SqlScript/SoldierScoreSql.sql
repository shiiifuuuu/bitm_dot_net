CREATE DATABASE FireRange;
USE FireRange;

CREATE TABLE SoldierScore
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
SoldierNo VARCHAR(20) NOT NULL UNIQUE,
SoldierName VARCHAR(30) NOT NULL,
Target1Score decimal,
Target2Score decimal,
Target3Score decimal,
Target4Score decimal
);

SELECT * FROM SoldierScore;

ALTER TABLE SoldierScore
ADD 
AvgScore decimal,
TotalScore decimal;

INSERT INTO SoldierScore
(SoldierNo, SoldierName, Target1Score, Target2Score, Target3Score, Target4Score)
VALUES
('STR-001', 'Shahadat', 30, 40, 40, 50);

INSERT INTO SoldierScore
(AvgScore, TotalScore)
Values
();

UPDATE SoldierScore
SET AvgScore=40, TotalScore=160
WHERE
ID=1;


