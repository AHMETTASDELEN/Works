--Select
Select * from Customers

Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by CategoryID,ProductName

Select * from Products where CategoryID=1 order by UnitPrice desc

Select count(*) Adet from Products where CategoryID=2

Select CategoryID,count(*) from Products group by CategoryID

Select CategoryID,count(*) Adet from Products where UnitPrice>5 
group by CategoryID having count(*)<10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID

Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null