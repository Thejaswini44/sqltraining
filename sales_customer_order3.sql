create database Sales
drop table Salesman
create table Salesman(
salesman_id int primary key,
name varchar(40),
city varchar(40),
commission real
)
select *  from Salesman
insert into Salesman values(5001,'James Hoog','Newyork',0.15)
insert into Salesman values(5002,'Nail Knite','Paris',0.13)
insert into Salesman values(5005,'Pit Alex','London',0.11)
insert into Salesman values(5006,'Mc Lyon','Paris',0.14)
insert into Salesman values(5007,'Paul Adam','Rome',0.13)
insert into Salesman values(5003,'Lauson','San Jose',0.12)