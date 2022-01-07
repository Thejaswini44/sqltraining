create database TutorialDB
use TutorialDB
create table Tutorial
(
TutorialId int,
TutorialName varchar(100),
TutorialDesc varchar(max),
Published int
)

alter table Tutorial add Author varchar(100)

insert into Tutorial values(1,'C#','Multithreading',0)
insert into Tutorial values(2,'SQL','SQL Commands',1)
insert into Tutorial values(3,'Java','Java hybernate',1)
insert into Tutorial values(4,'C','OOPS',1)
insert into Tutorial values(5,'python','File Handling',1)
insert into Tutorial values(6,'Java','Java MVC',0)

delete from Tutorial where published=0 and TutorialName='Java'

update Tutorial set Author='Raj' , published=0 where TutorialName='C#'

select * from tutorial
