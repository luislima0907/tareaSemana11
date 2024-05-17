using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Partidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Juego> Juegos = new List<Juego>();
            Juegos.Add(new Juego { EquipoUno = "Barcelona", EquipoDos = "Real Madrid", PuntajeUno = 3, PuntajeDos = 2, Progreso = 85 });
            Juegos.Add(new Juego { EquipoUno = "PSG", EquipoDos = "Bayer Munich", PuntajeUno = 3, PuntajeDos = 5, Progreso = 55 });
            Juegos.Add(new Juego { EquipoUno = "BVB Dormunt", EquipoDos = "As Roma", PuntajeUno = 0, PuntajeDos = 1, Progreso = 25 });
            Juegos.Add(new Juego { EquipoUno = "Man United", EquipoDos = "Ajax", PuntajeUno = 1, PuntajeDos = 1, Progreso = 15 });

            lbJuego.ItemsSource = Juegos;
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            if(lbJuego.SelectedItem != null)
            {
                MessageBox.Show($"Juego Seleccionado: {(lbJuego.SelectedItem as Juego).EquipoUno} " +
                    $"{(lbJuego.SelectedItem as Juego).PuntajeUno} {(lbJuego.SelectedItem as Juego).EquipoDos} " +
                    $"{(lbJuego.SelectedItem as Juego).PuntajeDos}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbJuego.SelectedItem != null)
            {
                var partidoSeleccionado = $"Juego Seleccionado: {(lbJuego.SelectedItem as Juego).EquipoUno} " +
                    $"{(lbJuego.SelectedItem as Juego).PuntajeUno} {(lbJuego.SelectedItem as Juego).EquipoDos} " +
                    $"{(lbJuego.SelectedItem as Juego).PuntajeDos}";

                MessageBox.Show($"{partidoSeleccionado}\n\nEsto se guardara en un archivo de texto");

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"pon el path del archivo de texto y lo reemplazas aca, dentro de las comillas", true))
                {
                    file.WriteLine(partidoSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("Error: Debes seleccionar un partido para actualizar el archivo de texto.");
            }
        }
    }
}