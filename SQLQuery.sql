create database products
go
use products
go
create table Product
(
	Id int primary key identity(1,1),
	Name nvarchar(50)
)
create table Category
(
	Id int primary key identity(1,1),
	Name nvarchar(50)
)
create table Product_of_Category
(
	Id int primary key identity(1,1),
	ProductId int not null foreign key references Product(Id),
	CategoryId int foreign key references Category(Id),
	Product_Count int not null default(0) check(Product_Count >= 0)
)

insert into Product values 
	(N'Pineapple'),
	(N'Audi A7'),
	(N'Volvo S90'),
	(N'Samsung S20 Ultra'),
	(N'Other')

insert into Category values 
	(N'Fruit'),
	(N'Car'),
	(N'Telephone')

insert into Product_of_Category(ProductId, CategoryId, Product_Count) values 
	(1,1,20),
	(2,2,5),
	(3,2,10),
	(4,3,100),
	(5, null,10)

select Product.Name, Category.Name 
from Product left outer join (Category join Product_of_Category on Category.Id = Product_of_Category.CategoryId) on Product.Id = Product_of_Category.ProductId;


	