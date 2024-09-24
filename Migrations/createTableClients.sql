CREATE DATABASE ClientDB;
USE ClientDB;

CREATE TABLE Clients (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Street NVARCHAR(200),
    Neighborhood NVARCHAR(100),
    Number NVARCHAR(10),
    City NVARCHAR(100),
    PostalCode NVARCHAR(10)
);