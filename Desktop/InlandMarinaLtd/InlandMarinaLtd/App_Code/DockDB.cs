using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InlandMarinaLtd.App_Code
{
    [DataObject(true)]
    public class DockDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        // retrieve customer with given ID
        public static Dock GetDock(int dockID)
        {
            Dock dc = null;

            // create connection
            SqlConnection connection = MarinaDB.GetConnection();

            // create SELECT command
            string query = "SELECT ID,Name,WaterService,ElectricalService " +
                           "FROM Dock " +
                           "WHERE ID = @DockID";
            SqlCommand cmd = new SqlCommand(query, connection);
            // supply parameter value
            cmd.Parameters.AddWithValue("@DockID", dockID);

            // run the SELECT query
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                // build customer object to return
                if (reader.Read()) // if there is a customer with this ID
                {
                    dc = new Dock();
                    dc.DockID = (int)reader["ID"];
                    dc.Name = reader["Name"].ToString();
                    dc.WaterService = (byte)reader["WaterService"];
                    dc.ElectricalService =(byte) reader["ElectricalService"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return dc;
        }
       /* [DataObjectMethod(DataObjectMethodType.Select)]
        // retrieve customer with given ID
        public static List<Dock> GetDockByState(string stateCode)
        {
            List<Customer> customers = new List<Customer>();
            Customer cust = null;

            // create connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // create SELECT command
            string query = "SELECT CustomerID, Name,Address, City, State, ZipCode " +
                           "FROM Customers " +
                           "WHERE State = @State";
            SqlCommand cmd = new SqlCommand(query, connection);
            // supply parameter value
            cmd.Parameters.AddWithValue("@State", stateCode);

            // run the SELECT query
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //add customers to the list
            while (reader.Read()) //while there are customers
            {
                cust = new Customer();
                cust.CustomerID = (int)reader["CustomerID"];
                cust.Name = reader["Name"].ToString();
                cust.Address = reader["Address"].ToString();
                cust.City = reader["City"].ToString();
                cust.State = reader["State"].ToString();
                cust.ZipCode = reader["ZipCode"].ToString();
                customers.Add(cust);
            }
            reader.Close();
            return customers;
        }

        // insert new row to table Customers
        // return new CustomerID
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int AddCustomer(Customer cust)
        {
            int custID = 0;

            // create connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // create INSERT command
            // CustomerID is IDENTITY so no value provided
            string insertStatement =
                "INSERT INTO Customers(Name, Address, City, State, ZipCode) " +
                "OUTPUT inserted.CustomerID " +
                "VALUES(@Name, @Address, @City, @State, @ZipCode)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@Name", cust.Name);
            cmd.Parameters.AddWithValue("@Address", cust.Address);
            cmd.Parameters.AddWithValue("@City", cust.City);
            cmd.Parameters.AddWithValue("@State", cust.State);
            cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
            try
            {
                connection.Open();

                // execute insert command and get inserted ID
                custID = (int)cmd.ExecuteScalar();
                //cmd.ExecuteNonQuery();

                // retrieve generate customer ID to return
                //string selectStatement =
                //    "SELECT IDENT_CURRENT('Customers')";
                //SqlCommand selectCmd = new SqlCommand(selectStatement, connection);
                //custID = Convert.ToInt32(selectCmd.ExecuteScalar()); // returns single value
                //         // (int) does not work in this case
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return custID;
        }

        // delete customer
        // return indiucator of success
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static bool DeleteCustomer(Customer cust)
        {
            bool success = false;

            // create connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // create DELETE command
            string deleteStatement =
                "DELETE FROM Customers " +
                "WHERE CustomerID = @CustomerID " + // needed for identification
                "AND Name = @Name " + // the rest - for optimistic concurrency
                "AND Address = @Address " +
                "AND City = @City " +
                "AND State = @State " +
                "AND ZipCode = @ZipCode";
            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@CustomerID", cust.CustomerID);
            cmd.Parameters.AddWithValue("@Name", cust.Name);
            cmd.Parameters.AddWithValue("@Address", cust.Address);
            cmd.Parameters.AddWithValue("@City", cust.City);
            cmd.Parameters.AddWithValue("@State", cust.State);
            cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
            try
            {
                connection.Open();

                // execute the command
                int count = cmd.ExecuteNonQuery();
                // check if successful
                if (count > 0)
                    success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        // update customer
        // retirn indicator of success
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static bool UpdateCustomer(Customer old_Customer, Customer customer)
        {
            bool success = false; // did not update

            // connection
            SqlConnection connection = MMABooksDB.GetConnection();
            // update command
            string updateStatement =
                "UPDATE Customers SET " +
                "Name = @NewName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
                "WHERE CustomerID = @OldCustomerID " + // identifies ccustomer
                "AND Name = @OldName " + // remaining - for otimistic concurrency
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode";
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewName", customer.Name);
            cmd.Parameters.AddWithValue("@NewAddress", customer.Address);
            cmd.Parameters.AddWithValue("@NewCity", customer.City);
            cmd.Parameters.AddWithValue("@NewState", customer.State);
            cmd.Parameters.AddWithValue("@NewZipCode", customer.ZipCode);
            cmd.Parameters.AddWithValue("@OldCustomerID", old_Customer.CustomerID);
            cmd.Parameters.AddWithValue("@OldName", old_Customer.Name);
            cmd.Parameters.AddWithValue("@OldAddress", old_Customer.Address);
            cmd.Parameters.AddWithValue("@OldCity", old_Customer.City);
            cmd.Parameters.AddWithValue("@OldState", old_Customer.State);
            cmd.Parameters.AddWithValue("@OldZipCode", old_Customer.ZipCode);

            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    success = true; // updated
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }*/
    }
}