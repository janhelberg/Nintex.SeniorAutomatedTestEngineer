----------------------------------------YE OLDE NURSERY-----------------------------------------------------
----------------------------------------CREATE SCHEMA-----------------------------------------------------
CREATE TABLE SalesPerson(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SalesPerson NVARCHAR(100) NOT NULL
)

CREATE TABLE Product(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    ProductPrice DECIMAL(10, 2)
)

CREATE TABLE Invoice(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceNum NVARCHAR(10) NOT NULL,
    SalesPersonId INT REFERENCES SalesPerson(id)
)

CREATE TABLE InvoiceItem(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT FOREIGN KEY REFERENCES Invoice(id),
    ProductId INT FOREIGN KEY REFERENCES Product(id),
    Quantity INT
)

----------------------------------------SEED DATA-----------------------------------------------------
INSERT INTO SalesPerson(SalesPerson) VALUES
    ('Bob'),
    ('Holly')

INSERT INTO Product(ProductName, ProductPrice) VALUES
    ('Tree', 4209.74),
    ('Shrub', 521.25),
    ('Flower', 110.60)

INSERT INTO Invoice(InvoiceNum, salesPersonId) VALUES
    ('ABC123', 1),
    ('ABC125', 2),
    ('ABC124', 1),
    ('ABC126', NULL)

INSERT INTO InvoiceItem(invoiceId, productId, quantity) VALUES
    (1, 1, 2),
    (1, 2, 15),

    (2, 2, 25),
    (2, 3, 312),

    (3, 1, 3),
    (3, 2, 43),
    (3, 3, 97),

    (4, 3, 48)

----------------------------------------QUESTIONS-----------------------------------------------------

/*
    Write a query to return a list of each invoice that contains flowers, sorted by invoice number
    Tests simple join, where and ordering
*/

/*
    Write a query to return a list of product names and the amount of each product sold
    Tests aggregation
*/