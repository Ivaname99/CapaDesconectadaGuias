﻿using AccesoDatos;
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
        private void RellenarForm(Customer cliente)
        {
            if (cliente != null)
            {
                tboxCustomerID.Text = cliente.CustomerID;
                tboxCompanyName.Text = cliente.CompanyName;
                tboxContactName.Text = cliente.ContactName;
                tboxContactTitle.Text = cliente.ContactTitle;
                tboxAddress.Text = cliente.Address;
            }
            if (cliente == null)
            {
                MessageBox.Show("objeto null");
            }
        }

        #region No Tipado

        public CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }
        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.obtenerPorId(tboxBusquedaNt.Text);
            RellenarForm(cliente);
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
        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actualizadas = customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
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
                RellenarForm(objeto1);
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
        private void btnActualizarT_Click(object sender, EventArgs e)
        {
            var fila = adaptador.GetDataByCustomerID(tboxCustomerID.Text);


            if (fila != null)
            {
                var datoOriginal = customerRepository.ExtraerInformacionCliente(fila);
                var datosModificados = CrearCliente();
                /*var filas = adaptador.Update(
                    datosModificados.CustomerID,
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax,
                    datoOriginal.CustomerID,
                    datoOriginal.CompanyName,
                    datoOriginal.ContactName,
                    datoOriginal.ContactTitle,
                    datoOriginal.Address,
                    datoOriginal.City,
                    datoOriginal.Region,
                    datoOriginal.PostalCode,
                    datoOriginal.Country,
                    datoOriginal.Phone,
                    datoOriginal.Fax
                    );*/

                /*var filas = adaptador.ActualizarCliente(
                    datosModificados.CustomerID,
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax,
                    datoOriginal.CustomerID
                    );*/

                var filas = adaptador.ActualizarClienteV1Object(
                    datosModificados.CustomerID,
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax
                    );
                MessageBox.Show($"{filas} filas actualizadas");
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

    }
}
