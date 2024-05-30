--practice
select rtrim(vend_name) + ' (' + rtrim(vend_country) + ')' as vend_title
from vendors
order by vend_name;

--math practice
select	prod_id, 
		quantity, 
		item_price,
		quantity * item_price as expanded_price
from orderitems
where order_num = 20008;

--q1
select	vend_id,
		vend_name as vname,
		vend_address as vaddress,
		vend_city as vcity
from Vendors
order by vname;

--q2
select	prod_id,
		prod_price,
		prod_price * .9 as sale_price
from products