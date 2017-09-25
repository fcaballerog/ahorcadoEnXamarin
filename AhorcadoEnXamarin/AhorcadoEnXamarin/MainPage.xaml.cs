using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AhorcadoEnXamarin
{
    public partial class MainPage : ContentPage
    {
        readonly string[] ALFABETO = { "A", "B", "C", "D", "E", "F", "G" };
        public MainPage()
        {
            InitializeComponent();
            Inicializae();
        }

        private void Inicializae()
        {
            //throw new NotImplementedException();
            imageAhorcado.Source = ImageSource.FromResource("AhorcadoEnXamarin.img.1.png");

            int fila = 0;
            for (int columna = 0; columna < 7; columna++)
            {
                gridBotonera.Children.Add(new Button
                {
                    Text = "A"
                }, columna, fila);
            }
            
        }
    }
}
