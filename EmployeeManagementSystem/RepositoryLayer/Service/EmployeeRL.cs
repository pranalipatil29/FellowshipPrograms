// ******************************************************************************
//  <copyright file="EmployeeRL.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  EmployeeRL.cs
//  
//     Purpose:  Creating interface for employee repository
//     @author  Pranali Patil
//     @version 1.0
//     @since  7 -12-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************
namespace RepositoryLayer.Service
{
    // Including the requried assemblies in to the program
    using CommonLayer.Constant;
    using CommonLayer.Model;
    using RepositoryLayer.Interface;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this class contains diffrent methods for performing different operations
    /// </summary>
    /// <seealso cref="RepositoryLayer.Interface.IEmployeeRL" />
    public class EmployeeRL : IEmployeeRL
    {
        /// <summary>
        /// The connection string
        /// </summary>
        string connectionString = @"Data Source=(localDB)\Election; Initial Catalog=EmployeeDB; Integrated Security=true";

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns>returns the message indicating whether the operation is done or not</returns>
        public string AddEmployee(EmployeeModel employeeModel)
        {
            // creting a connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // defining a command to perform operation
                SqlCommand sqlCommand = new SqlCommand("AddEmployee", connection);

                // defining a type of stored procedure
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // adding value to employee parameter
                sqlCommand.Parameters.AddWithValue("@EmployeeName", employeeModel.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@EmailID", employeeModel.EmailID);
                sqlCommand.Parameters.AddWithValue("@Password", employeeModel.Password);
                sqlCommand.Parameters.AddWithValue("@Designation", employeeModel.Designation);
                sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);

                connection.Open();

                //  executing a query
                sqlCommand.ExecuteNonQuery();
            }

            return ErrorMessages.Added;
        }

        /// <summary>
        /// Deletes the employee information.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>
        /// returns the message indicating whether the operation is done or not
        /// </returns>
        public string DeleteEmployeeInfo(int employeeID)
        {
            // check whether the user entered id is present in database or not
            if (FindEmployee(employeeID))
            {
                // creting a connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // defining a command to perform operation
                    SqlCommand sqlCommand = new SqlCommand("DeleteEmployee", connection);

                    // defining a type of stored procedure
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    sqlCommand.Parameters.AddWithValue("@EmployeeID", employeeID);

                    //  executing a query
                    sqlCommand.ExecuteNonQuery();
                }
                return ErrorMessages.Deleted;
            }
            else
            {
                return ErrorMessages.NotFound;
            }
        }

        /// <summary>
        /// Updates the employee information.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>
        /// returns the message indicating whether the operation is done or not
        /// </returns>
        public string UpdateEmployeeInfo(EmployeeModel employeeModel, int employeeID)
        {
            if (FindEmployee(employeeID))
            {
                // creting a connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // defining a command to perform operation
                    SqlCommand sqlCommand = new SqlCommand("UpdateEmployeeInfo", connection);

                    // defining a type of stored procedure
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    sqlCommand.Parameters.AddWithValue("@EmployeeName", employeeModel.EmployeeName);
                    sqlCommand.Parameters.AddWithValue("@EmailID", employeeModel.EmailID);
                    sqlCommand.Parameters.AddWithValue("@Designation", employeeModel.Designation);
                    sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);

                    connection.Open();

                    //  executing a query
                    sqlCommand.ExecuteNonQuery();
                }

                return ErrorMessages.Updated;
            }
            else
            {
                return ErrorMessages.NotFound;
            }
        }

        /// <summary>
        /// Displays the employee information.
        /// </summary>
        /// <returns>
        /// returns the list of employee information
        /// </returns>
        public IList<EmployeeModel> DisplayEmployeeInfo()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            // creting a connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // defining a command to perform operation
                SqlCommand sqlCommand = new SqlCommand("DisplayEmployeeInfo", connection);

                // defining a type of stored procedure
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                // creating a datareader object to read data
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                // iterates the loop for all data 
                while (dataReader.Read())
                {
                    // creating object of employee model class
                    EmployeeModel employee = new EmployeeModel();

                    // adding values to employee object parameters
                    employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"]);
                    employee.EmployeeName = dataReader["EmployeeName"].ToString();
                    employee.EmailID = dataReader["EmailID"].ToString();
                    employee.Designation = dataReader["Designation"].ToString();
                    employee.Salary = Convert.ToInt32(dataReader["Salary"]);

                    // adding all values to employee object
                    employees.Add(employee);
                }
                connection.Close();
            }
            return employees;
        }

        /// <summary>
        /// Finds the employee.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns> returns true if id is found otherwise false</returns>
        public bool FindEmployee(int employeeID)
        {
            // creting a connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("DisplayEmployeeInfo", connection);

                // defining a type of stored procedure
                sqlCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                // iterates the loop for all data
                while (dataReader.Read())
                {
                    // creating object of employee model class
                    EmployeeModel employee = new EmployeeModel();

                    // check whether user entered id is matching with id in database
                    if (employeeID == Convert.ToInt32(dataReader["EmployeeID"]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
