-- Создание и вставка тестовых данных
CREATE TABLE Products (Id int IDENTITY(1,1), Name nvarchar(50), PRIMARY KEY(Id));
CREATE TABLE Categories (Id int IDENTITY(1,1), Name nvarchar(50), PRIMARY KEY(Id));
CREATE TABLE ProductCategories (ProductId int, CategoryId int, 
PRIMARY KEY(ProductId, CategoryId), FOREIGN KEY(ProductId) REFERENCES Products(Id), FOREIGN KEY(CategoryId) REFERENCES Categories(Id));

INSERT INTO Products (Name) VALUES ('Бумага'), ('Портфель'), ('Плюшевый мишка'), ('Дневник'), ('Пенал-игрушка'), ('Бумажный журавлик'), ('Айфон');
INSERT INTO Categories (Name) VALUES ('Канцелярия'), ('Для школы'), ('Игрушки');
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1,1), (2,2), (3,3), (4,1), (4,2), (5,2), (5,3), (6,1), (6,3);

-----------------------------------------

-- Сам запрос
SELECT p.Name AS ProductName, c.Name AS CategoryName 
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;