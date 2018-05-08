USE Sandbox

--CREATE TABLE MemberTestTable
--(FirstName VARCHAR(40),
--LastName VARCHAR(50),
--BirthDate VARCHAR(50),
--City VARCHAR(50),
--[State] VARCHAR(50),
--JoinDate VARCHAR(50)
--)

--GO

--CREATE TABLE MemberRealTable
--(FirstName VARCHAR(40),
--LastName VARCHAR(50),
--BirthDate DATE,
--City VARCHAR(50),
--[State] VARCHAR(50),
--JoinDate DATE
--)

--BULK INSERT MemberTestTable
--FROM 'C:\Users\Cyberadmin\Downloads\MemberSort.csv'
--WITH
--(
--FIRSTROW = 1, -- second row if header row in file
--FIELDTERMINATOR = ',',  --CSV field delimiter
--ROWTERMINATOR = '\n',   --Use to shift the control to next row
--ERRORFILE = 'C:\Users\Cyberadmin\Downloads\memberserr.csv',
--TABLOCK
--)


SELECT dbo.standard_date_convert('18.Feb.45')



GO
CREATE FUNCTION [dbo].[standard_date_convert]
(@inputDate AS VARCHAR(255)) 
RETURNS date
AS
BEGIN
 
 DECLARE @output DATE = null;
 DECLARE @result date = null;
 DECLARE @r_input varchar(255) = '';
 DECLARE @y_length int = 0;
 DECLARE @y_value INT = 0;
 
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
	 SET @r_input = REVERSE(@inputDate);
	 SET @y_length = CHARINDEX('/', @r_input) - 1;

	 -- Get the year value from the last two digits ...
	 SET @y_value = CONVERT(INT, REVERSE(LEFT(@r_input, 2)));

	 -- If the year value is greater than or equal to the current year, assume last century, else this century.
	 IF @y_length > 0 AND @y_length < 4
	 BEGIN
	   IF @y_value < 10
		   BEGIN
			 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '200', @y_value);
			 END
	   ELSE IF @y_value >=  YEAR(GETDATE()) % 100
		   BEGIN
			 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '19', @y_value); 
			 END
	   ELSE    
		   BEGIN
			 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '20', @y_value);
		   END
	 END

	 
 
	 -- Remove extra zeroes
 
	 SET @inputDate = REPLACE(@inputDate, '/0', '/');
	--Numeric month name (0 - 12) / Day of month as numeric (0 - 31) / Year as 4 digit numeric
	 SET @result = CONVERT(DATE, @inputDate, 101);
 
	 IF @result IS NOT NULL
	   SET @output = @result;
	 ELSE
	   SET @output = '00/00/0000';
END
 
 RETURN @output;

END

GO