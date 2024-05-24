--Q1
select cust_id from Orders
where (order_num in (select order_num from OrderItems where item_price > 10))

--Q2
select cust_id, order_date
from Orders
where order_num in (select order_num
		from OrderItems
		where prod_id in ('BR01'))
order by order_date

--Q3
select cust_email
from Customers
where cust_id in (select cust_id
				  from Orders
				  where order_num in (select order_num
									from OrderItems
									where prod_id in ('BR01')))

--Q4
select cust_id, (select sum(quantity) from OrderItems where Orders.order_num = OrderItems.order_num) as total_ordered
from Orders
order by total_ordered desc

--Q5
select prod_name, (select sum(quantity) from OrderItems where OrderItems.prod_id = Products.prod_id) as quant_sold
from Products