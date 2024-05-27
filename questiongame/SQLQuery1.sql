-- Create the Category table
CREATE TABLE Category (
    id INT PRIMARY KEY,
    description NVARCHAR(50) NOT NULL
);

-- Create the Product table
CREATE TABLE Product (
    id INT PRIMARY KEY,
    description NVARCHAR(50) NOT NULL,
    unitPrice FLOAT NOT NULL,
    catID INT,
    FOREIGN KEY (catID) REFERENCES Category(id)
);

-- Create the Customer table
CREATE TABLE Customer (
    id INT PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    phoneNumber NCHAR(9)
);

-- Create the Order table
CREATE TABLE [Order] (
    CustID INT,
    PID INT,
    OrderDate DATE NOT NULL,
    Quantity INT NOT NULL,
    PRIMARY KEY (CustID, PID, OrderDate),
    FOREIGN KEY (CustID) REFERENCES Customer(id),
    FOREIGN KEY (PID) REFERENCES Product(id)
);
