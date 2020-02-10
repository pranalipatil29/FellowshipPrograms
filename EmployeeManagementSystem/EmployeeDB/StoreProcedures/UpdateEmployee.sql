CREATE PROCEDURE [dbo].[UpdateEmployee]
	@EmployeeID int,
	@EmployeeName varchar(50)=null,
	@EmailID varchar(50)=null,
	@Salary int=null,
	@Designation varchar(50)=null

AS
BEGIN
	
	Update EmployeeInfoTable
	 set
	 EmployeeName =ISNULL(@EmployeeName,EmployeeName),
	 EmailID = ISNULL(@EmailID,EmailID),
	 Salary = ISNULL(@Salary,Salary),
	 Designation = ISNULL(@Designation,Designation)
	 where EmployeeID = @EmployeeID 
END