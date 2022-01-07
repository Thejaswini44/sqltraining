use Sales
create table Orders(
ord_no  numeric(5)  ,
purch_amt  decimal(8,2),
ord_date date,
customer_id int references Customer(customer_id) ,
salesman_id int references Salesman(salesman_id)
)

select *  from Orders
insert into Orders values(70001    ,   150.5     ,  '2012-10-05 ' ,3005     ,    5002)
insert into Orders values(70009   ,    270.65   ,   '2012-09-10 ' ,3001      ,   5005)
insert into Orders values(70002   ,    65.26    , '2012-10-05 ' ,3002       ,  5001)
insert into Orders values(70004   ,    110.5     ,  '2012-08-17 ' ,3009      ,   5003)
insert into Orders values(70007   ,    948.5      , '2012-09-10 ' ,3005       ,  5002)
insert into Orders values(70005    ,   2400.6      , '2012-07-27 ' ,3007       ,  5001)
insert into Orders values(70008   ,    5760        , '2012-09-10 ' ,3002       ,  5001)
insert into Orders values(70010    ,   1983.43     , '2012-10-10 ' ,3004        , 5006)         
insert into Orders values(70003    ,   2480.4      , '2012-10-10 ' ,3009        , 5003)
insert into Orders values(70012     , 250.45      , '2012-06-27  ',3008        , 5002)
insert into Orders values(70011    ,   3045.6      , '2012-04-25  ',3002         ,5001)
