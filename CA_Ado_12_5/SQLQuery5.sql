CREATE PROCEDURE Updatedata
@pname Nvarchar(Max),
@pBalance float
AS
BEGIN
INSERT INTO dbo.Account(Name,Balance) Values(@pname,@pBalance)
END