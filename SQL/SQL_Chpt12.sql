--Q1
select cust_name, order_num
from Customers, Orders
where Customers.cust_id = Orders.cust_id
--order by cust_name;
order by order_num;

select cust_name, order_num
from Customers
inner join Orders on Customers.cust_id = Orders.cust_id
order by order_num;

--Q2
select cust_name, order_num, (select sum(quantity * item_price) from OrderItems where Orders.order_num = OrderItems.order_num) as OrderTotal
from Customers, Orders
where Customers.cust_id = Orders.cust_id
order by cust_name, order_num;

select cust_name, Orders.order_num, sum(quantity*item_price) as OrderTotal
from Customers, Orders, OrderItems
where Customers.cust_id = Orders.cust_id
and   Orders.order_num = OrderItems.order_num
group by cust_name, Orders.order_num;

--Q3
select cust_id, order_date
from OrderItems, Orders
where Orders.order_num = OrderItems.order_num
and prod_id = 'BR01'
order by order_date;

--Q4
select cust_email
from Customers
inner join Orders on Customers.cust_id = Orders.cust_id
inner join OrderItems on OrderItems.order_num = Orders.order_num
where OrderItems.prod_id = 'BR01';

 --Q5
 select cust_name, sum(quantity*item_price) as totalPrice
 from Customers, OrderItems, Orders
 where Orders.order_num = OrderItems.order_num
 and   Customers.cust_id = Orders.cust_id
 group by cust_name having sum(quantity*item_price) >= 1000;