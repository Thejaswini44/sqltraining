create database Sales
drop table Salesman
create table Salesman(
salesman_id int primary key,
name varchar(40),
city varchar(40),
commission real
)
 --1.	Write a SQL statement to display all the information of all salesmen
select *  from Salesman

insert into Salesman values(5001,'James Hoog','Newyork',0.15)
insert into Salesman values(5002,'Nail Knite','Paris',0.13)
insert into Salesman values(5005,'Pit Alex','London',0.11)
insert into Salesman values(5006,'Mc Lyon','Paris',0.14)
insert into Salesman values(5007,'Paul Adam','Rome',0.13)
insert into Salesman values(5003,'Lauson','San Jose',0.12)

--write a SQL query to find the salesperson and customer who belongs to same city. Return Salesman, cust_name and city
Select Salesman.name,Customer.Customer_name,Customer.city 
from  Salesman,Customer
where Salesman.city = Customer.city

Select Salesman.name,Customer.Customer_name,Customer.city 
from  Salesman inner join Customer on Salesman.city=Customer.city

--write a SQL query to find those orders where order amount exists between 500 and 2000. Return ord_no, purch_amt, cust_name, city
Select ord_no, purch_amt, Customer_name, city
from  Customer,Orders
where purch_amt between 500 and 2000

Select ord_no, purch_amt, Customer_name, city
from  Orders  between 500 and 2000

--write a SQL query to find the salesperson(s) and the customer(s) he handle. Return Customer Name, city, Salesman, commission


--write a SQL query to find those salespersons who received a commission from the company more than 12%. Return Customer Name, customer city, Salesman, commission



--write a SQL query to find those salespersons do not live in the same city where their customers live and received a commission from the company more than 12%. 
--Return Customer Name, customer city, Salesman, salesman city, commission