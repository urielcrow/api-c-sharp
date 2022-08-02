using PildorasInformaticas.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace PildorasInformaticas
{

    public partial class MainWindow : Window
    {
        DBApi dBApi = new DBApi();
        DetallesVehiculos detalles = new DetallesVehiculos();

        public MainWindow()
        {
            InitializeComponent();

            dynamic respuesta = dBApi.Get("/vehicles",true);

            miListBox.DisplayMemberPath = "brand";
            miListBox.SelectedValuePath = "id";
            miListBox.ItemsSource = respuesta.result.msg.vehiculos_por_pagina;

            miListBox2.ItemsSource = respuesta.result.msg.vehiculos_por_pagina;
            //MessageBox.Show(respuesta.ToString());
        }

        private void miListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = (miListBox.SelectedItem as dynamic).id;
            dynamic respuesta = dBApi.Get($"/vehicles?id={id}", true);
            miId.Text = respuesta.result.msg.id.ToString();
            miMarca.Text = respuesta.result.msg.brand;
            miModelo.Text = respuesta.result.msg.model;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            var id = ((Button)sender).Tag;
            dynamic respuesta = dBApi.Get($"/vehicles?id={id}", true);
            detalles.LoadData(respuesta.result.msg);
            //detalles.ShowDialog();//Mustra ventana modal y detiene el flujo de ejecución hasta que se cierra
            detalles.Show();
            detalles.Focus();
            //detalles.Topmost = true;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).Tag.ToString());
        }

        private void MAinWindow_Closed(object sender, EventArgs e)
        {
            detalles.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            miListBox2.Visibility = Visibility.Visible;
            miListBox3.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            miListBox2.Visibility = Visibility.Hidden;
            miListBox3.Visibility = Visibility.Visible;
        }
    }
}
