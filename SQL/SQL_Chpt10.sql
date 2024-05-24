--q1
select order_num, count(*) as order_lines
from OrderItems
group by order_num
order by order_lines;

--q2
select vend_id, min(prod_price) as cheapest_item
from Products
group by vend_id
order by cheapest_item

--q3
select order_num
from OrderItems
group by order_num
having sum(quantity) >= 100
order by order_num

--q4
select order_num, sum(item_price * quantity) as total
from OrderItems
group by order_num
having sum(item_price * quantity) >= 1000
order by order_num

--q5
--cannot group by aggregator
 