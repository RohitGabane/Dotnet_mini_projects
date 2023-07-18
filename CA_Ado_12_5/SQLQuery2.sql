CREATE PROCEDURE Deletedata
@pid int
As
Begin
Delete from dbo.Account where id=@pid
END