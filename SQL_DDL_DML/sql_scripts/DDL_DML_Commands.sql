-- SQL DDL commands
-- The DDL commands in SQL are used to create database schema and to define the type and structure of the data that will be stored in a database. SQL DDL commands are further divided into the following major categories:

-- CREATE
-- ALTER
-- DROP
-- TRUNCATE
-- CREATE
-- The CREATE query is used to create a database or objects such as tables, views, stored procedures, etc.

-- Creating a database
-- syntax : CREATE DATABASENAME
CREATE DATABASE LibraryDB

-- The CREATE query is also used to add tables in an existing database as shown in the following script:

-- syntax: 
-- CREATE TABLE [Table Name]
-- (
--     Column_Name1 Data_Type(Size) [NULL | NOT NULL],
--     Column_Name2 Data_Type(Size) [NULL | NOT NULL],
--      …
--     Column_NameN Data_Type(Size) [NULL | NOT NULL]
-- );

USE LibraryDB
CREATE TABLE Books
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR (50) NOT NULL,
Price INT
)

-- To view all the tables in the LibraryDB, execute the following QL DDL script:

USE LibraryDB
GO
SELECT * FROM INFORMATION_SCHEMA.TABLES 
GO

-- To see all the columns in the Books table, run the following script:

SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME='Books'

-- ALTER
-- The ALTER command in SQL DDL is used to modify the structure of an already existing table.

USE LibraryDB
ALTER TABLE Books
ADD ISBN INT NOT NULL;


SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME='Books'


-- Modifying an existing column
-- Another case where ALTER command can be useful. Suppose, instead of adding a new column to a table, you want to modify an existing column. For example, you want to change the data type of the ISBN column from INT to VARCHAR (50). The ALTER query can be used as follows:

-- SQL Alter table Add New Column
-- ALTER TABLE [Table_Name]
-- ALTER [New_Column_Name] Data_Type (Length) NULL | NOT NULL
USE LibraryDB
ALTER TABLE Books
ALTER COLUMN ISBN VARCHAR(50);


-- DROP
-- The DROP command is a type of SQL DDL command, that is used to delete an existing database or an object within a database.

-- Deleting a database
-- The following DROP command deletes the LibraryDB database that we created earlier:
-- Syntax: DROP DatabaseObject DBObjectName
-- DROP DATABASE LibraryDB

-- Deleting a table
-- The DROP command is a type of SQL DDL command that is used to delete an existing table. For instance, the following command will delete the Books table:

-- DROP TABLE Books

-- Deleting a column
-- To delete a column within a database, the DROP query is used in combination with the ALTER query. The ALTER query specifies the table that you want to delete whereas the DROP query specifies the column to delete within the table specified by the ALTER query. Let’s drop the ISBN column from the Books:

ALTER TABLE Books
DROP COLUMN ISBN

-- TRUNCATE
-- The TRUNCATE command in SQL DDL is used to remove all the records from a table. Let’s insert a few records in the Books table:

-- INSERT :
-- To insert records into a table
-- SQL Server INSERT Syntax
-- INSERT INTO [Destination Table] ([Column1], [Column2],..., [ColumnN])
-- VALUES ([Column1_Value], [Column2_Value],..., [ColumnN_Value])

INSERT INTO Books 
VALUES ('Book-A', 100),
('Book-B', 200),
('Book-C', 150)

-- SELECT 
-- To retreive records from a table
-- syntax: SELECT col1, col2 ..... FROM tblName
SELECT * FROM Books

-- UPDATE
-- SQL Server UPDATE Syntax
-- UPDATE [Table_Name] 
-- SET [Column1] = [Value1], 
--     [Column2] = [Value2],
--     [ColumnN] = [ValueN]
-- WHERE Condition
UPDATE Books
SET NAME='Book-D'
WHERE Id = 1

-- DELETE : To Delete single or multiple record from table
-- DELETE FROM Books WHERE Id = 3

-- Synatx : TRUNCATE TABLE Database_Name.Schema_Name.Table_Name
-- TRUNCATE command will remove all the records from the table
-- TRUNCATE TABLE Books

-- The sp_rename is a stored procedure which helps to rename tables in SQL Server and the usage syntax will be like the below:

-- sp_rename 'old_table_name', 'new_table_name'

DROP TABLE IF EXISTS TestOrderList;
DROP TABLE IF EXISTS NewTestOrderList
GO
CREATE TABLE TestOrderList
( 
Id INT PRIMARY KEY IDENTITY(1, 1), 
OrderCode VARCHAR(100), 
OrderName VARCHAR(100), DueDate DATETIME
)
INSERT INTO  TestOrderList
VALUES
( 'X120', 'Notebook', '20191212' ), 
( 'W201', 'PC', '20191120' ), 
( 'KWW901', 'Printer', '20191001' )
GO 
SELECT * FROM TestOrderList

-- sp_rename 'dbo.TestOrderList' ,'NewTestOrderList'
