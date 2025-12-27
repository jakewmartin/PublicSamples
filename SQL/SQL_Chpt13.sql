--Q1
select cust_name, order_num
from Customers
inner join orders on Customers.cust_id = Orders.cust_id;

--Q2
select cust_name, order_num
from Customers
left outer join orders on Customers.cust_id = Orders.cust_id;

--Q3
select prod_name, order_num
from Products
left outer join OrderItems on Products.prod_id = OrderItems.prod_id;

--Q4
select Products.prod_name, count(order_num) as orders
from OrderItems
right outer join Products on Products.prod_id = OrderItems.prod_id
group by Products.prod_name;

SELECT prod_name, COUNT(order_num) AS orders
FROM Products LEFT OUTER JOIN OrderItems
 ON Products.prod_id = OrderItems.prod_id
GROUP BY prod_name
ORDER BY prod_name;