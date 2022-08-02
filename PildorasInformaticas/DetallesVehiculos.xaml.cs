using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace PildorasInformaticas
{
    /// <summary>
    /// Lógica de interacción para DetallesVehiculos.xaml
    /// </summary>
    public partial class DetallesVehiculos : Window
    {
        public DetallesVehiculos()
        {
            InitializeComponent();
        }

        public void LoadData(dynamic data)
        {
            detalle_id.Text = data.id;
            detalle_marca.Text = data.brand;
            detalle_modelo.Text = data.model;
            detalle_motor.Text = data.engine_number;
            detalle_placas.Text = data.plates;
            detalle_serie.Text = data.serie;
            try
            {
                detalle_imagen.Source = data.images[0].url;
            }
            catch(Exception)
            {
                detalle_imagen.Source = data.images;
            }
        }


        private void WindowDetalles_Closing(object sender, CancelEventArgs e)
        {
            /*
             Ayuda a que al cerrar la ventana detalle y al volverla a brir no se produsca la Excepcion: No se puede establecer Visibility ni llamar a Show, 
             ShowDialog o WindowInteropHelper.EnsureHandle después de haberse cerrado un elemento Window.'
             */
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
