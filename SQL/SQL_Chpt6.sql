--Q1
select prod_name, prod_desc
from products
where prod_desc like '%toy%';

--Q2
SELECT prod_name, prod_desc
FROM Products
WHERE NOT prod_desc LIKE '%toy%'
ORDER BY prod_name;

--Q3
select prod_name, prod_desc
from Products
where prod_desc like '%toy%' and 
prod_desc like '%carrot%';

--Q4
select prod_name, prod_desc
from products
where prod_desc like '%toy%carrot%';