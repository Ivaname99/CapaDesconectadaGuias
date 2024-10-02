using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();

            String select = "";
            select = select + "SELECT [CustomerID] " + "\n";
            select = select + "      ,[CompanyName] " + "\n";
            select = select + "      ,[ContactName] " + "\n";
            select = select + "      ,[ContactTitle] " + "\n";
            select = select + "      ,[Address] " + "\n";
            select = select + "      ,[City] " + "\n";
            select = select + "      ,[Region] " + "\n";
            select = select + "      ,[PostalCode] " + "\n";
            select = select + "      ,[Country] " + "\n";
            select = select + "      ,[Phone] " + "\n";
            select = select + "      ,[Fax] " + "\n";
            select = select + "  FROM [dbo].[Customers]";

            SqlDataAdapter adapter = new SqlDataAdapter(select, DataBase.ConnectionString);
            adapter.Fill(dataTable);

            return dataTable;
        }

        public Customer obtenerPorId(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var dataTable = new DataTable();
                String selectPorId = "";
                selectPorId = selectPorId + "SELECT [CustomerID] " + "\n";
                selectPorId = selectPorId + "      ,[CompanyName] " + "\n";
                selectPorId = selectPorId + "      ,[ContactName] " + "\n";
                selectPorId = selectPorId + "      ,[ContactTitle] " + "\n";
                selectPorId = selectPorId + "      ,[Address] " + "\n";
                selectPorId = selectPorId + "      ,[City] " + "\n";
                selectPorId = selectPorId + "      ,[Region] " + "\n";
                selectPorId = selectPorId + "      ,[PostalCode] " + "\n";
                selectPorId = selectPorId + "      ,[Country] " + "\n";
                selectPorId = selectPorId + "      ,[Phone] " + "\n";
                selectPorId = selectPorId + "      ,[Fax] " + "\n";
                selectPorId = selectPorId + "  FROM [dbo].[Customers] " + "\n";
                selectPorId = selectPorId + "  WHERE CustomerID = @CustomerID";

                using (SqlCommand comando = new SqlCommand(selectPorId, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dataTable);
                    Customer cliente = ExtraerInformacionCliente(dataTable);
                    return cliente;
                }
            }
        }

        public Customer ExtraerInformacionCliente(DataTable table)
        {
            Customer customer = new Customer();
            foreach (DataRow fila in table.Rows)
            {
                customer.CustomerID = fila.Field<string>("CustomerID");
                customer.CompanyName = fila.Field<string>("CompanyName");
                customer.ContactName = fila.Field<string>("ContactName");
                customer.ContactTitle = fila.Field<string>("ContactTitle");
                customer.Address = fila.Field<string>("Address");
                customer.City = fila.Field<string>("City");
                customer.Region = fila.Field<string>("Region");
                customer.PostalCode = fila.Field<string>("PostalCode");
                customer.Country = fila.Field<string>("Country");
                customer.Phone = fila.Field<string>("Phone");
                customer.Fax = fila.Field<string>("Fax");
            }
            return customer;
        }

        public int InsertarCliente(Customer cliente) 
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String InsertIntoPorId = "";
                InsertIntoPorId = InsertIntoPorId + "INSERT INTO [dbo].[Customers] " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ([CustomerID] " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,[CompanyName] " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,[ContactName] " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,[ContactTitle] " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,[Address]) " + "\n";
                InsertIntoPorId = InsertIntoPorId + "     VALUES " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           (@CustomerID " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,@CompanyName " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,@ContactName " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,@ContactTitle " + "\n";
                InsertIntoPorId = InsertIntoPorId + "           ,@Address)";

                using (var commando = new SqlCommand(InsertIntoPorId, conexion))
                {
                    SqlCommand comando = ParametrosSqlCustomers(commando, cliente);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.InsertCommand = comando;
                    return adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }

        public int ActualizarCliente(Customer cliente)
        {
            using (var conexion= DataBase.GetSqlConnection())
            {
                String UpdateUser = "";
                UpdateUser = UpdateUser + "UPDATE [dbo].[Customers] " + "\n";
                UpdateUser = UpdateUser + "   SET [CustomerID] = @CustomerID " + "\n";
                UpdateUser = UpdateUser + "      ,[CompanyName] = @CompanyName " + "\n";
                UpdateUser = UpdateUser + "      ,[ContactName] = @ContactName " + "\n";
                UpdateUser = UpdateUser + "      ,[ContactTitle] = @ContactTitle " + "\n";
                UpdateUser = UpdateUser + "      ,[Address] = @Address " + "\n";
                UpdateUser = UpdateUser + " WHERE CustomerID = @CustomerID";

                using (var commando = new SqlCommand(UpdateUser, conexion))
                {
                    SqlCommand comando = ParametrosSqlCustomers(commando, cliente);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.UpdateCommand = comando;
                   return adapter.UpdateCommand.ExecuteNonQuery();
                }
            }
        }

        private SqlCommand ParametrosSqlCustomers(SqlCommand commando, Customer cliente)
        {
            commando.Parameters.AddWithValue("CustomerID", cliente.CustomerID);
            commando.Parameters.AddWithValue("CompanyName", cliente.CompanyName);
            commando.Parameters.AddWithValue("ContactName", cliente.ContactName);
            commando.Parameters.AddWithValue("ContactTitle", cliente.ContactTitle);
            commando.Parameters.AddWithValue("Address", cliente.Address);
            return commando;
        }
    }
}
