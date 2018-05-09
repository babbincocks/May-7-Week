USE Sandbox

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


CREATE TABLE ZBabcock_MemberTestTable
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate VARCHAR(50),
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate VARCHAR(50)
)

GO

CREATE TABLE ZBabcock_MemberRealTable
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate DATE,
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate DATE
)

BULK INSERT ZBabcock_MemberTestTable
FROM 'C:\Users\Cyberadmin\Downloads\MemberSort.csv'
WITH
(
FIRSTROW = 1, -- second row if header row in file
FIELDTERMINATOR = ',',  --CSV field delimiter
ROWTERMINATOR = '\n',   --Use to shift the control to next row
ERRORFILE = 'C:\Users\Cyberadmin\Downloads\memberserr.csv',
TABLOCK
)




GO
CREATE FUNCTION [dbo].[Standardized_Dates]
(@inputDate AS VARCHAR(255)) 
RETURNS date
AS
BEGIN

 DECLARE @result date = null;
 DECLARE @reverseIn varchar(255) = '';
 DECLARE @yearLength int = 0;
 DECLARE @yearValue INT = 0;
 
 IF LEN(@inputDate) > 0
 BEGIN

	 -- Trim leading spaces
	 SET @inputDate = LTRIM(RTRIM(@inputDate))

	 -- Trim starting 0 if there is one.
	 IF LEFT(@inputDate, 1) = '0' 
		 BEGIN
		 SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1); 
		 END

	 -- Replace dashes and periods

	 SET @inputDate = REPLACE(@inputDate, '-', '/');
	 SET @inputDate = REPLACE(@inputDate, '.', '/');

	 -- Isolate and process year value
	 -- First, get year string by reversing string and finding first (last) separator.
	 SET @reverseIn = REVERSE(@inputDate);
	 SET @yearLength = CHARINDEX('/', @reverseIn) - 1;

	 -- Get the year value from the last two digits ...
	 SET @yearValue = CONVERT(INT, REVERSE(LEFT(@reverseIn, 2)));

	 -- If the year value is greater than or equal to the current year, assume last century, else this century.
	 IF @yearLength > 0 AND @yearLength < 4
	 BEGIN
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

	 
 
	 -- Remove extra zeroes
 
	 SET @inputDate = REPLACE(@inputDate, '/0', '/');

	 --@f retrieves the first number in the date string , while @s retrieves the second number.
	 DECLARE @f VARCHAR(5) = SUBSTRING(@inputDate, 1, CHARINDEX('/', @inputDate, 0) - 1)
	 DECLARE @s VARCHAR(5) = SUBSTRING(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, 
	 (CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, 0) + 1)) - CHARINDEX('/', @inputDate, 0)  - 1))
		
		--Check if both values retrieved are numeric
	 IF ISNUMERIC(@s) = 1 AND ISNUMERIC(@f) = 1
		BEGIN

		--If the format is like this: DD/MM/YYYY and is solely numeric...
	 IF @f > 12 AND @s <= 12
	 BEGIN
		--...the DD and the MM are switched around.
			SET @inputDate = STUFF(@inputDate, 1, 2, @s)
			SET @inputDate = STUFF(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, LEN(@s), @f)
	 END

	 END

	--Numeric month name (0 - 12) / Day of month as numeric (0 - 31) / Year as 4 digit numeric
	 SET @result = CONVERT(DATE, @inputDate, 101);
 

END
 
 RETURN @result;

END

GO



INSERT INTO ZBabcock_MemberRealTable
SELECT FirstName, LastName, dbo.Standardized_Dates(BirthDate), City, [State], dbo.Standardized_Dates(JoinDate)
FROM ZBabcock_MemberTestTable

