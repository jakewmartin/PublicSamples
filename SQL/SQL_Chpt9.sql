--q1
select sum(quantity) as items_sold
from OrderItems;

--q2
select sum(quantity) as items_sold
from OrderItems
where prod_id = 'BR01';

--q3
select max(prod_price) as max_price
from Products
where (prod_price <= 10);