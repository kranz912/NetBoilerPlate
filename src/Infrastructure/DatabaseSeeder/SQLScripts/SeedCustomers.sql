 CREATE TABLE IF NOT EXISTS Customers (
                Id INTEGER PRIMARY KEY,
                Name TEXT NOT NULL,
                Email TEXT NOT NULL
            );

REPLACE INTO Customers (Id, Name, Email) VALUES (1, 'Alice Johnson', 'alice@example.com');
REPLACE INTO Customers (Id, Name, Email) VALUES (2, 'Ace Acer', 'ace@example.com');
