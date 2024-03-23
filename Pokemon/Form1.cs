using System; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.CodeDom;
using System.Collections.Generic; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.ComponentModel; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Data; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Drawing; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Linq; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Text; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Threading.Tasks; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.
using System.Windows.Forms; // IMPORTAREMOS TODO LO NECESARIO PARA ESTE PROYECTO EN PARTICULAR.

namespace Pokemon
{
    public partial class Form1 : Form
    {
        // AQUÍ VAMOS A DECLARAR ALGUNAS VARIABLES AL PROYECTO...

        int turn = 1; // VARIABLE PARA TURNARSE 2 JUGADORES ENTRE SÍ.
        int[,] TicTacToe; // VARIABLE MEDIANTE UNA MATRIZ CUADRADA DE 3 * 3.
        int PlayerPoints = 1; // COMIENZA UNA PARTIDA CON 0 PUNTOS PARA EL JUGADOR.
        int PlayerPoints2 = 0; // COMIENZA UNA PARTIDA CON 0 PUNTOS PARA EL RIVAL.
        bool YouHaveAWinner; // VARIABLE BOOLEANA QUE DEFINE UN GANADOR PARA AMBOS JUGADORES CUALQUIERA DEPENDIENDO DEL DESEMPEÑO QUE OBTUVIERON EN UNA PARTIDA.

        public Form1()
        {
            InitializeComponent();
            GameStart();
        }

        // PARA INICIALIZAR EL JUEGO MÁS QUE LOS COMPONENTES DE ARRANQUE DEL PROGRAMA, CREAREMOS UN NUEVO MÉTODO QUE ALUDE A ELLA...

        public void GameStart()
        {
            // ÉSTAS SON LAS VARIABLES A DECLARAR EN ESTE MÉTODO.

            turn = 1; // LA CANTIDAD DE TURNOS SIEMPRE PUEDE VARIAR DE 1 EN 1, DEL JUGADOR AL RIVAL Y DEL RIVAL AL JUGADOR, SIMÉTRICAMENTE.
            TicTacToe = new int[3, 3]; // VARIABLE PARA CREAR UN TABLERO MEDIANTE MATRIZ CUADRADA DE 3 * 3.
            YouHaveAWinner = false; // POR EL MOMENTO NO SE PODRÍA PREDECIR QUIÉN SERÁ EL GANADOR DE ESTE JUEGO.
            ResultadoFinal.Image = Properties.Resources.Pokebola_pokeball_png_0; // LA IMAGEN DEL GANADOR SE PREDICE CON UNA IMAGEN SECRETA.
            Tablero.Controls.Clear(); // EL TABLERO DEL JUEGO COMIENZA VACÍO PARA PODER JUGAR EN COMPETENCIA.

            // CREAREMOS UN ARREGLO MEDIANTE CICLO "for" PARA MOSTRAR FICHAS E INTRODUCIR VALORES EN UNA MATRIZ (TABLERO DEL JUEGO)...

            for (var i = 0; i < 3; i++) // FILAS DE UNA MATRIZ EN 3 CUADROS.
            {
                for (var j = 0; j < 3; j++) // COLUMNAS DE UNA MATRIZ EN 3 CUADROS.
                {
                    // CREAREMOS UN PROCEDIMIENTO DE MANERA DINÁMICA AQUÍ PARA MOSTRAR LAS FICHAS OCULTAS DURANTE LA EJECUCIÓN DEL JUEGO.

                    var CardGame = new PictureBox(); // VARIABLE A DECLARAR PARA LAS FICHAS.
                    CardGame.Image = Properties.Resources.Pokebola_pokeball_png_0; // LAS FICHAS SE OCULTARÁN AL INICIO DEL JUEGO CON UNA IMAGEN DE LA POKEBOLA.
                    CardGame.Name = string.Format("{0}", i + "_" + j); // EL NOMBRE SE MOSTRARÁ DURANTE LA EJECUCIÓN DEL PROGRAMA AL JUGAR.
                    CardGame.Dock = DockStyle.Fill; // NO SE MOSTRARÁN LAS ORILLAS SIN RELLENAR, PARA ESO SE DECLARA ESTA VARIABLE.
                    CardGame.Click += Play; // VAMOS A JUGAR CLIQUEANDO UNAS FICHAS DEL TABLERO.
                    CardGame.Cursor = Cursors.Hand; // EL CURSOR AL CLIQUEAR LAS FICHAS DEL TABLERO SERÁ REEMPLAZADO POR UN DEDO AL TOCAR EN AQUELLO LUGAR.
                    CardGame.SizeMode = PictureBoxSizeMode.StretchImage; // EL TAMAÑO PARA LAS FICHAS SERÁ AUTOMÁTICO.

                    // AÑADIREMOS FICHAS AL TABLERO MEDIANTE MÉTODO DE MATRIZ CUADRADA...

                    Tablero.Controls.Add(CardGame, j, i);
                    TicTacToe[i, j] = 0; // COMIENZA TODO EL TABLERO DESDE EL INICIO EN FILAS Y COLUMNAS.
                }
            }
        }

        // PARA PODER INTERACTUAR CON EL JUGADOR, VAMOS A CREAR UN MÉTODO PARA QUE ÉL MISMO PUEDA JUGAR CON ELLA...

        private void Play(object sender, EventArgs e)
        {
            var CardUserSelected = (PictureBox)sender; // MEDIANTE ESTE COMPONENTE, SE ASOCIARÁ A LA FICHA EN LA QUE EL JUGADOR LO SELECCIONÓ DEL TABLERO.
            CardUserSelected.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turn); // CADA IMAGEN POR DEFECTO DEL TABLERO SE MOSTRARÁ DURANTE SU EJECUCIÓN.
            string[] Position = CardUserSelected.Name.Split("_".ToCharArray()); // MEDIANTE ARREGLOS, SE DEFINE UNA POSICIÓN EN LA CUAL EL JUGADOR LO CLIQUEA POR DICHO TABLERO EN DONDE ÉL MISMO SE ENCUENTRA.
            int Row = Convert.ToInt32(Position[0]); // PARA LAS FILAS DEL TABLERO MATRICIAL.
            int Column = Convert.ToInt32(Position[1]); // PARA LAS COLUMNAS DEL TABLERO MATRICIAL.
            TicTacToe[Row, Column] = turn; // ENTRE EL JUGADOR Y SU RIVAL SE TURNAN ENTRE SÍ.
            turn = (turn == 1) ? 2 : 1; // MEDIANTE ESTA LÍNEA SE REALIZA UN CÁLCULO NO ALGEBRAICO PARA QUE AMBOS JUGADORES (JUGADOR/RIVAL) SE TURNEN ENTRE SÍ.
        }
    }
}