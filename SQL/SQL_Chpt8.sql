 --Q1
 select cust_id, cust_name, Upper(substring(cust_name,1,2) + substring(cust_city,1,3)) as user_login 
 from Customers;

 --Q2
 select order_num, order_date
 from orders
 where DATEPART(mm, order_date) = 01
 and   DATEPART(yy, order_date) = 2020
 order by order_date;