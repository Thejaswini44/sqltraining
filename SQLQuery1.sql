
create database TutDB
use TutDB
create table Tutorial
(
TutorialId int primary key ,
TutorialName varchar(100),
TutorialDesc varchar(max),
Published int
)

alter table Tutorial add Author varchar(100)
alter table Tutorial  drop column Author

insert into Tutorial values(1,'C#','Multithreading',0,'Raj')
insert into Tutorial values(2,'SQL','SQL Commands',1,'Ram')
insert into Tutorial values(3,'Java','Java hybernate',1,'Mahima')
insert into Tutorial values(4,'C','OOPS',1,'Sunny')
insert into Tutorial values(5,'python','File Handling',1,'Lily')
insert into Tutorial values(6,'Java','Java MVC',0,'Rita')

delete from Tutorial where published=0 and TutorialName='Java'

update Tutorial set Author='Raj' , published=0 where TutorialName='C#'
 select * from tutorial