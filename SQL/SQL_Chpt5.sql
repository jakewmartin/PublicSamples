--Q1
select vend_name from Vendors
where vend_state in ('CA')
AND   vend_country in ('USA')

--Q2
select order_num, prod_id, quantity from OrderItems
where  quantity >= 100
and    prod_id in ('BR01', 'BR02', 'BR03')

--Q3
select prod_name, prod_price from Products
where prod_price between 3 and 6
order by prod_price

--Q4
--'order by' is before 'where' and 'where' statement does not have ()