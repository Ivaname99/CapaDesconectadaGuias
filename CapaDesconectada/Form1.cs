using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        #region No Tipado
        public CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }
        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.obtenerPorId(tboxBusquedaNt.Text);
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customer> { cliente };
                gridNoTipado.DataSource = listaClientes;
            }
        }
        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }
        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContactName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
            };
            return cliente;
        }
        #endregion

        #region Tipado

        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(tboxBuscarTipado.Text);
            if (customer != null)
            {
                var objeto1 = customerRepository.ExtraerInformacionCliente(customer);
                Console.WriteLine(customer);
                var listaClientes = new List<Customer> { objeto1 };
                gridTipado.DataSource = listaClientes;

            }
        }
        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone,
            cliente.Fax);
            MessageBox.Show("Proceso realizado correctamente");
        }


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

    }
}
