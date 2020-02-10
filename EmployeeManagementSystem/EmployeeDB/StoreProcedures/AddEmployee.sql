CREATE PROCEDURE [dbo].[AddEmployee]
	
	@EmployeeName varchar(50),
	@EmailId varchar(50),
	@Salary int,
	@Designation varchar(50)
	
AS
BEGIN
	Insert into EmployeeInfoTable (EmployeeName, EmailID, Salary, Designation)
	Values (@EmployeeName, @EmailId, @Salary, @Designation)

END
