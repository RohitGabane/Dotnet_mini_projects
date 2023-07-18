CREATE PROCEDURE Updatedata
@pname Nvarchar(Max),
@psalary float
AS
BEGIN
INSERT INTO dbo.Employee(Name,Salary) Values(@pname,@psalary)
END