------------------SPLIT FUNCTION------------------------

ALTER PROCEDURE GetTeacher
     @STRINGLIST AS VARCHAR(100),
	 @SEPERATOR VARCHAR(1)=','
AS

BEGIN(
    SELECT * FROM STRING_SPLIT(@STRINGLIST,@SEPERATOR)
    )
END

EXEC GetTeacher '1,2,3,4,5'



------------------CREATE FUNCTION FROM TEACHER TABLE----------------------------

CREATE FUNCTION TeacherInformation()
RETURNS table
as
RETURN(SELECT
		VALUE Position
	FROM
		Department
		CROSS APPLY STRING_SPLIT(Position, ' '))

----------------------PROCEDURE FOR FUNCTION-------------------

CREATE PROCEDURE UspGetTeacherDetail
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM TeacherInformation()
END
GO
EXEC UspGetTeacherDetail


---------------------TABLE TYPE----------------------------

CREATE TYPE SubjectType AS TABLE
(SubjectId   INT, 
 SubjectName VARCHAR(100)
)

CREATE TABLE Subject ( 
        Id    INT PRIMARY KEY, 
        SubjectName VARCHAR(50)
                )

CREATE PROCEDURE UspInsertSubject 
@SubjectType SubjectType READONLY
AS
INSERT INTO Subject
SELECT * FROM @SubjectType

DECLARE @VarLessonType AS SubjectType
 
INSERT INTO @VarLessonType
VALUES ( 1, 'Math'
       )
INSERT INTO @VarLessonType
VALUES ( 2, 'Science'
       )
INSERT INTO @VarLessonType
VALUES ( 3, 'Geometry'
       )
INSERT INTO @VarLessonType
VALUES ( 4, 'Hindi'
       )
INSERT INTO @VarLessonType
VALUES ( 5, 'Sanskrit'
       )    
    
EXECUTE UspInsertSubject @VarLessonType

SELECT * FROM Subject


------------------SUBQUERRY----------------

SELECT * 
   FROM TeacherData 
   WHERE TeacherId IN (SELECT TeacherId 
         FROM TeacherData 
         WHERE TeacherSalary > 27000) ;

-------------TEMPTABLE---------------------

SELECT * INTO #temptable FROM TeacherData
SELECT * FROM #temptable


------------MERGE STATEMENT-------------------

CREATE TABLE Products(  
    ID INT,  
    Product_Name VARCHAR(65),  
    Price DECIMAL(9,2)  
)  
      
INSERT INTO Products(ID, Product_Name, Price) VALUES   
(1, 'Table', 150),
(2, 'Desk', 100),  
(3, 'Chair', 75), 
(4, 'Computer', 225); 


CREATE TABLE TargetProducts(  
    ID INT,  
    Product_Name VARCHAR(65),  
    Price DECIMAL(9,2)  
)  
      
INSERT INTO TargetProducts(ID, Product_Name, Price) VALUES  
(1, 'Table', 150),  
(2, 'Desk', 150),  
(5, 'Bed', 100),  
(6, 'Cupboard', 350);  

SELECT * FROM Products  
SELECT * FROM TargetProducts  

MERGE TargetProducts AS Target  
USING Products AS Source  
ON Source.ID = Target.ID  
    -- For Insert 
	

WHEN NOT MATCHED BY Target THEN  
    INSERT (ID, Product_Name, Price)   
    VALUES (Source.ID, Source.Product_Name, Source.Price)  

    -- For Updates  


WHEN MATCHED THEN UPDATE SET  
    Target.Product_Name = Source.Product_Name,  
    Target.Price = Source.Price  

    -- For Deletes  


WHEN NOT MATCHED BY Source THEN  
    DELETE  


-- Summarize the actions performed by MERGE query  


OUTPUT $action,   
DELETED.ID AS Target_ID,   
DELETED.Product_Name AS Target_Product_Name,   
DELETED.Price AS Target_Price,   
INSERTED.ID AS Source_ID,   
INSERTED.Product_Name AS Source_Product_Name,   
INSERTED.Price AS SourcePrice;  

