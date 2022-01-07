use Sales
create table Customer(
Customer_id int primary key,
Customer_name varchar(30),
city varchar(15),
grade int ,
salesman_id int references Salesman(salesman_id)
)
select *  from Customer
insert into Customer values(3002 ,'Nick Rimando ',  'New York'  ,  100   ,   5001)
 insert into Customer values  (    3007 ,' Brad Davis'     , 'New York ',     200  ,      5001)
 insert into Customer values   (   3005  ,'Graham Zusi'  ,   'California' ,   200  ,       5002)
 insert into Customer values     (  3008  ,'Julian Green'    ,'London'  ,      300   ,      5002)
 insert into Customer values ( 3004  ,'Fabian Johnson',  'Paris'       ,  300       ,  5006)
 insert into Customer values(3009,  'Geoff Cameron',   'Berlin'    ,    100   ,      5003)
 insert into Customer values(3003 , 'Jozy Altidor ',   'Moscow '   ,    200    ,     5007)
 insert into Customer values   (3001  ,'Brad Guzan'  ,    'London '    ,  100 ,       5005)
select name,commission from Salesman
select ord_date,salesman_id,ord_no,purch_amt from Orders
	 select name,city from Salesman where city='Paris'
	 select * from Customer where grade=200
	 select ord_no,ord_date,purch_amt from Orders where salesman_id=5001