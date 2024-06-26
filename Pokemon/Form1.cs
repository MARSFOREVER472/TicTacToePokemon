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
        // AQU� VAMOS A DECLARAR ALGUNAS VARIABLES AL PROYECTO...

        int turn = 1; // VARIABLE PARA TURNARSE 2 JUGADORES ENTRE S�.
        int[,] TicTacToe; // VARIABLE MEDIANTE UNA MATRIZ CUADRADA DE 3 * 3.
        int PlayerPoints = 1; // COMIENZA UNA PARTIDA CON 0 PUNTOS PARA EL JUGADOR.
        int PlayerPoints2 = 0; // COMIENZA UNA PARTIDA CON 0 PUNTOS PARA EL RIVAL.
        bool YouHaveAWinner; // VARIABLE BOOLEANA QUE DEFINE UN GANADOR PARA AMBOS JUGADORES CUALQUIERA DEPENDIENDO DEL DESEMPE�O QUE OBTUVIERON EN UNA PARTIDA.

        public Form1()
        {
            InitializeComponent();
            GameStart();
        }

        // PARA INICIALIZAR EL JUEGO M�S QUE LOS COMPONENTES DE ARRANQUE DEL PROGRAMA, CREAREMOS UN NUEVO M�TODO QUE ALUDE A ELLA...

        public void GameStart()
        {
            // �STAS SON LAS VARIABLES A DECLARAR EN ESTE M�TODO.

            turn = 1; // LA CANTIDAD DE TURNOS SIEMPRE PUEDE VARIAR DE 1 EN 1, DEL JUGADOR AL RIVAL Y DEL RIVAL AL JUGADOR, SIM�TRICAMENTE.
            TicTacToe = new int[3, 3]; // VARIABLE PARA CREAR UN TABLERO MEDIANTE MATRIZ CUADRADA DE 3 * 3.
            YouHaveAWinner = false; // POR EL MOMENTO NO SE PODR�A PREDECIR QUI�N SER� EL GANADOR DE ESTE JUEGO.
            ResultadoFinal.Image = Properties.Resources.Pokebola_pokeball_png_0; // LA IMAGEN DEL GANADOR SE PREDICE CON UNA IMAGEN SECRETA.
            Tablero.Controls.Clear(); // EL TABLERO DEL JUEGO COMIENZA VAC�O PARA PODER JUGAR EN COMPETENCIA.

            // CREAREMOS UN ARREGLO MEDIANTE CICLO "for" PARA MOSTRAR FICHAS E INTRODUCIR VALORES EN UNA MATRIZ (TABLERO DEL JUEGO)...

            for (var i = 0; i < 3; i++) // FILAS DE UNA MATRIZ EN 3 CUADROS.
            {
                for (var j = 0; j < 3; j++) // COLUMNAS DE UNA MATRIZ EN 3 CUADROS.
                {
                    // CREAREMOS UN PROCEDIMIENTO DE MANERA DIN�MICA AQU� PARA MOSTRAR LAS FICHAS OCULTAS DURANTE LA EJECUCI�N DEL JUEGO.

                    var CardGame = new PictureBox(); // VARIABLE A DECLARAR PARA LAS FICHAS.
                    CardGame.Image = Properties.Resources.Pokebola_pokeball_png_0; // LAS FICHAS SE OCULTAR�N AL INICIO DEL JUEGO CON UNA IMAGEN DE LA POKEBOLA.
                    CardGame.Name = string.Format("{0}", i + "_" + j); // EL NOMBRE SE MOSTRAR� DURANTE LA EJECUCI�N DEL PROGRAMA AL JUGAR.
                    CardGame.Dock = DockStyle.Fill; // NO SE MOSTRAR�N LAS ORILLAS SIN RELLENAR, PARA ESO SE DECLARA ESTA VARIABLE.
                    CardGame.Click += Play; // VAMOS A JUGAR CLIQUEANDO UNAS FICHAS DEL TABLERO.
                    CardGame.Cursor = Cursors.Hand; // EL CURSOR AL CLIQUEAR LAS FICHAS DEL TABLERO SER� REEMPLAZADO POR UN DEDO AL TOCAR EN AQUELLO LUGAR.
                    CardGame.SizeMode = PictureBoxSizeMode.StretchImage; // EL TAMA�O PARA LAS FICHAS SER� AUTOM�TICO.

                    // A�ADIREMOS FICHAS AL TABLERO MEDIANTE M�TODO DE MATRIZ CUADRADA...

                    Tablero.Controls.Add(CardGame, j, i);
                    TicTacToe[i, j] = 0; // COMIENZA TODO EL TABLERO DESDE EL INICIO EN FILAS Y COLUMNAS.
                }
            }
        }

        // PARA PODER INTERACTUAR CON EL JUGADOR, VAMOS A CREAR UN M�TODO PARA QUE �L MISMO PUEDA JUGAR CON ELLA...

        private void Play(object sender, EventArgs e)
        {
            var CardUserSelected = (PictureBox)sender; // MEDIANTE ESTE COMPONENTE, SE ASOCIAR� A LA FICHA EN LA QUE EL JUGADOR LO SELECCION� DEL TABLERO.
            CardUserSelected.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turn); // CADA IMAGEN POR DEFECTO DEL TABLERO SE MOSTRAR� DURANTE SU EJECUCI�N.
            string[] Position = CardUserSelected.Name.Split("_".ToCharArray()); // MEDIANTE ARREGLOS, SE DEFINE UNA POSICI�N EN LA CUAL EL JUGADOR LO CLIQUEA POR DICHO TABLERO EN DONDE �L MISMO SE ENCUENTRA.
            int Row = Convert.ToInt32(Position[0]); // PARA LAS FILAS DEL TABLERO MATRICIAL.
            int Column = Convert.ToInt32(Position[1]); // PARA LAS COLUMNAS DEL TABLERO MATRICIAL.
            TicTacToe[Row, Column] = turn; // ENTRE EL JUGADOR Y SU RIVAL SE TURNAN ENTRE S�.
            turn = (turn == 1) ? 2 : 1; // MEDIANTE ESTA L�NEA SE REALIZA UN C�LCULO NO ALGEBRAICO PARA QUE AMBOS JUGADORES (JUGADOR/RIVAL) SE TURNEN ENTRE S�.
        }
    }
}