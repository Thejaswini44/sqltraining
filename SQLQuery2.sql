create database Tutorial
use Tutorial
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

update Tutorial set Author='tina' , published=0 where TutorialName='python'

select * from tutorial
SELECT ASCII('A') AS A, ASCII('B') AS B,   
ASCII('a') AS a, ASCII('b') AS b,  
ASCII(1) AS [1], ASCII(2) AS [2]; 

SELECT ASCII('P') AS [ASCII], ASCII('æ') AS [Extended_ASCII];

SELECT NCHAR(80) AS [CHARACTER], NCHAR(230) AS [CHARACTER];

SELECT LTRIM('         Five spaces are at the beginning of this string.');  

SELECT RTRIM('Removes trailing spaces.   ');  

SELECT SUBSTRING(TutorialName, 0,3) AS TutName, TutorialId  
FROM Tutorial 
WHERE CAST(TutorialId  AS int) LIKE '33%'; 



SET TEXTSIZE 0;  
-- Create variables for the character string and for the current   
-- position in the string.  
DECLARE @position INT, @string CHAR(8);  
-- Initialize the current position and the string variables.  
SET @position = 1;  
SET @string = 'New Moon';  
WHILE @position <= DATALENGTH(@string)  
   BEGIN  
   SELECT ASCII(SUBSTRING(@string, @position, 1)),   
      CHAR(ASCII(SUBSTRING(@string, @position, 1)))  
   SET @position = @position + 1  
   END;  