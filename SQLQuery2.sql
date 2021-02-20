-- Select orijinal adını da değiştirebiliyoruz. 
select CompanyName Dukkan, ContactName Aracı, City Vilayet from Customers

Select*from Customers where City = 'London'

-- case insensetivedir, ayrıca bunlar e ticaret sitelerinde sorugu yaptığımızda arkada yazan kodlar bunlar. 

select * from Products where CategoryID=1 or CategoryID=3 and UnitPrice>=10 

select * from Products	where CategoryID=1 order by UnitPrice desc

-- group by:

select count (*) from Products -- tüm kategory sorgusu

select CategoryID, count(*) from Products group by CategoryID having COUNT(*) <10

-- Joinler; 

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories  --Category ile Productsların birleşimi
on Products.CategoryID = Categories.CategoryID
where UnitPrice>10

-- inner join eşleşen dataları birleştirir ancak eşleşmeyenler için aşağıdaki kod yazılır. 
-- C# da DTO data transformation object 
-- boşluk var diye köşeli paranteze aldı otomatik . 

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID                               --solda olup sağda olmayanları şeçmek

select * from Customers c left join Orders	o			-- solda olup sağda olmayan ve CustomerID si olmayan vatandaş. bunu bulup kampanya yapacağız o kişilere. iki kişi mesela hiç müşteri olmamış. 
on c.CustomerID=o.CustomerID
where o.CustomerID is null 



