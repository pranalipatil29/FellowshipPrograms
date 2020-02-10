CREATE PROCEDURE [dbo].[DeleteEmployee]
	@EmployeeID int
AS
BEGIN
	
	Delete from EmployeeInfoTable 
	where EmployeeID = @EmployeeID
END