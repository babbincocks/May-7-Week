--Want this to be saved to the Sandbox.
USE Sandbox

--Gets rid of tables and the function created in this script, so it can be repeatedly run.
IF (SELECT COUNT(*) FROM sys.tables WHERE name = 'ZBabcock_MemberTestTable') > 0
BEGIN
DROP TABLE ZBabcock_MemberTestTable
END

IF (SELECT COUNT(*) FROM sys.tables WHERE name = 'ZBabcock_MemberRealTable') > 0
BEGIN
DROP TABLE ZBabcock_MemberRealTable
END

IF (SELECT COUNT(*) FROM sys.all_objects WHERE type_desc = 'SQL_SCALAR_FUNCTION' AND name = 'Standardized_Dates') > 0
BEGIN
DROP FUNCTION dbo.Standardized_Dates
END


--Create a table to hold unedited data.
CREATE TABLE ZBabcock_MemberTestTable
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate VARCHAR(50),
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate VARCHAR(50)
)

GO
--Create a table to hold edited data.
CREATE TABLE ZBabcock_MemberRealTable
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate DATE,
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate DATE
)

	--Settings to insert data. NEEDS TO BE UNCOMMENTED AND THE FROM STRING AND THE ERRORFILE STRING NEED TO BE CHANGED.
--BULK INSERT ZBabcock_MemberTestTable
--FROM 'C:\Users\Cyberadmin\Downloads\MemberSort.csv'
--WITH
--(
--FIRSTROW = 1, -- second row if header row in file
--FIELDTERMINATOR = ',',  --CSV field delimiter
--ROWTERMINATOR = '\n',   --Use to shift the control to next row
--ERRORFILE = 'C:\Users\Cyberadmin\Downloads\memberserr.csv',
--TABLOCK
--)

GO

--Function that accepts VARCHAR, and returns a date.
CREATE FUNCTION [dbo].[Standardized_Dates]
(@inputDate AS VARCHAR(50)) 
RETURNS DATE
AS
BEGIN

--Variables to hold various aspects are declared.
 DECLARE @result DATE = NULL;
 DECLARE @yearLength INT = 0;
 DECLARE @yearValue INT = 0;
 --DECLARE @proper BIT = 0;
 
 --Make sure the input actually exists.
 IF LEN(@inputDate) > 0
 BEGIN

	--IF TRY_CONVERT(DATE, @inputDate, 101) IS NOT NULL
	--BEGIN
	--SET @proper = 1;
	--END

	--IF @proper = 0
	--BEGIN

		 --First we get rid of any leading spaces.
		 SET @inputDate = LTRIM(RTRIM(@inputDate))

		 --If there's a leading zero, this gets rid of it.
		 IF LEFT(@inputDate, 1) = '0' 
			 BEGIN
			 SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1); 
			 END


			 --Hyphens and periods show up as separators, so it's better to have them be one uniform character.
		 SET @inputDate = REPLACE(@inputDate, ' ', '/');
		 SET @inputDate = REPLACE(@inputDate, '-', '/');
		 SET @inputDate = REPLACE(@inputDate, '.', '/');

			--In the event of multiple slashes after the separator conversion, they're cut down until there aren't
			--repeats.
			WHILE CHARINDEX('//', @inputDate) != 0
				BEGIN
				SET @inputDate = REPLACE(@inputDate, '//', '/')
				END


				--The date is reversed so as to more easily retrieve the physical length of the year.
		 DECLARE @reverseIn VARCHAR(255) = REVERSE(@inputDate); 
		 SET @yearLength = CHARINDEX('/', @reverseIn) - 1;

		 --The year value (the last two digits of the year) is put into a variable.
		 SET @yearValue = CONVERT(INT, REVERSE(LEFT(@reverseIn, 2)));

		 --If the year format is (most likely) two digits, this ensues.
		 IF @yearLength > 0 AND @yearLength < 4
		 BEGIN
			--If the last two digits of the inputted year is less than the last two digits of the current year, 
			--it's assumed to be a date from this century; otherwise, it's formatted to be of last century.
		   IF @yearValue < 10
			   BEGIN
				 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '200', @yearValue);
				 END
		   ELSE IF @yearValue >=  YEAR(GETDATE()) % 100
			   BEGIN
				 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '19', @yearValue); 
				 END
		   ELSE    
			   BEGIN
				 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '20', @yearValue);
			   END
		 END

	 
 
		 
		--If there's a leading zero in the second number slot, it gets taken out.
		 SET @inputDate = REPLACE(@inputDate, '/0', '/');

		 --@f retrieves the first number in the date string , while @s retrieves the second number.
		 DECLARE @f VARCHAR(5) = SUBSTRING(@inputDate, 1, CHARINDEX('/', @inputDate, 0) - 1)
		 DECLARE @s VARCHAR(5) = SUBSTRING(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, (CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, 0) + 1)) - CHARINDEX('/', @inputDate, 0)  - 1))
		
			--Checks if both values retrieved are numeric
		 IF ISNUMERIC(@s) = 1 AND ISNUMERIC(@f) = 1
			BEGIN

			--If the format is like this: DD/MM/YYYY, and is solely numeric...
		 IF @f > 12 AND @s <= 12
		 BEGIN
			--...the DD and the MM are switched around.
				SET @inputDate = STUFF(@inputDate, 1, 2, @s)
				SET @inputDate = STUFF(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, LEN(@s), @f)
		 END

		 END
		 
	--END

	--At this point, the date should be in a suitable format, and it is then converted to a date data type, and put into the result variable.
	 SET @result = CONVERT(DATE, @inputDate, 101);

	 --IF DATEPART(YEAR, @result) > GETDATE()
	 --BEGIN
	 --SET @result = DATEADD(YEAR, -100, @result)
	 --END
 

END
 
 RETURN @result;

END

GO

--INSERT INTO ZBabcock_MemberRealTable
--SELECT FirstName, LastName, dbo.Standardized_Dates(BirthDate), City, [State], dbo.Standardized_Dates(JoinDate)
--FROM ZBabcock_MemberTestTable

--SELECT * FROM ZBabcock_MemberRealTable WHERE BirthDate BETWEEN '1-1-1920' AND '12-31-1998' AND JoinDate > '01-01-2000'


