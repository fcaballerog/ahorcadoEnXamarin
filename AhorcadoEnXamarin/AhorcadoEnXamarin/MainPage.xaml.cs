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
        public MainPage()
        {
            InitializeComponent();
            Inicializae();
        }

        private void Inicializae()
        {
            //throw new NotImplementedException();
            imageAhorcado.Source = ImageSource.FromResource("AhorcadoEnXamarin.img.1.png");
        }
    }
}
