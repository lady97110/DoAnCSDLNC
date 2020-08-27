CREATE DATABASE DoAnCSDLNC;
GO
USE DoAnCSDLNC
GO

CREATE TABLE tbTour(
TourID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
StartLocation NVARCHAR(30) NOT NULL,
Destination NVARCHAR(30) NOT NULL,
StartDate DATE NOT NULL CHECK(StartDate > GETDATE()),
EndDate DATE NOT NULL,
TotalSeat INT NOT NULL CHECK(TotalSeat>0),
EmptySeat INT NOT NULL,
Price INT NOT NULL
);
ALTER TABLE tbTour ADD CONSTRAINT CheckDateTour CHECK (EndDate > StartDate);
ALTER TABLE tbTour ADD CONSTRAINT CheckSeatTour CHECK (EmptySeat <= TotalSeat);

CREATE TABLE tbCustomer(
CustomerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(50) NOT NULL,
DOB DATE NOT NULL CHECK(YEAR(GETDATE())-YEAR(DOB)>=15),
PhoneNumber NVARCHAR(10) NOT NULL,
Identification NVARCHAR(20) NOT NULL,
AccountNumber NVARCHAR(20) NOT NULL,
Address NVARCHAR(50)
);

CREATE TABLE tbContract(
ContractID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
CustomerID INT NOT NULL FOREIGN KEY REFERENCES tbCustomer(CustomerID),
TourID INT NOT NULL FOREIGN KEY REFERENCES tbTour(TourID),
DraftDate DATE NOT NULL DEFAULT(GETDATE()),
TerminationDate DATE NOT NULL,
StartTime DATE NOT NULL CHECK (StartTime > GETDATE()),
Quantity INT NOT NULL CHECK (Quantity > 0),
QuantityDiscount INT NOT NULL CHECK (QuantityDiscount >= 0),
TotalMoney INT NOT NULL DEFAULT (0) CHECK (TotalMoney >=0),
Deposit INT NOT NULL DEFAULT (0),
Note NVARCHAR(1000),
State INT DEFAULT (1)
);
ALTER TABLE tbContract ADD CONSTRAINT CheckContractDate CHECK (TerminationDate > DraftDate);

CREATE TABLE tbMember(
ContractID INT NOT NULL FOREIGN KEY REFERENCES tbContract(ContractID),
MemberID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(50) NOT NULL,
DOB DATE NOT NULL CHECK (DOB < GETDATE()),
Identification NVARCHAR(20),
AgeDiscount INT DEFAULT(0) CHECK (AgeDiscount >= 0),
MemberPrice INT DEFAULT(0) CHECK (MemberPrice >= 0)
);

CREATE TABLE tbAccident(
AccidentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ContractID INT FOREIGN KEY REFERENCES tbContract(ContractID),
Accident NVARCHAR(100) NOT NULL,
DraftDate DATE NOT NULL DEFAULT (GETDATE()),
PayDamage INT DEFAULT (0) CHECK (PayDamage >=0)
);

CREATE TABLE tbRefundContract(
RefundID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ContractID INT FOREIGN KEY REFERENCES tbContract(ContractID),
RefundedDate DATE NOT NULL DEFAULT(GETDATE()),
RefundedRate INT
);

CREATE TABLE tbQuantityDiscount(
DiscountID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MinQuantity INT NOT NULL CHECK (MinQuantity >= 0),
MaxQuantity INT NOT NULL,
Discount INT NOT NULL CHECK (Discount <= 100)
);
ALTER TABLE tbQuantityDiscount ADD CONSTRAINT CheckQuantity CHECK (MaxQuantity >= MinQuantity);

CREATE TABLE tbAgeDiscount(
DiscountID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MinAge INT NOT NULL CHECK (MinAge >= 0),
MaxAge INT NOT NULL,
Discount INT NOT NULL CHECK (Discount <= 100)
);
ALTER TABLE tbAgeDiscount ADD CONSTRAINT CheckAge CHECK (MaxAge >= MinAge);

CREATE TABLE tbRefund(
RefundID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MinDay INT NOT NULL CHECK (MinDay >= 0),
MaxDay INT NOT NULL,
RefundRate INT NOT NULL CHECK (RefundRate <= 100)
);
ALTER TABLE tbRefund ADD CONSTRAINT CheckDay CHECK (MaxDay >= MinDay);

CREATE TABLE tbUsers(
UserID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
UserName NVARCHAR(50) NOT NULL UNIQUE,
Password NVARCHAR(50) NOT NULL,
UserType INT
);

---------------

