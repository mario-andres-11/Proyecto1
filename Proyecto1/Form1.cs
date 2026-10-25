using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private static readonly Random rnd = new Random();

        private int num1 = 0;
        private int num2 = 0;
        private int resultado = 0;
        private char operador = ' ';

        // Control de modos de juego
        private int modoJuego = 1; // 1 = Individual, 2 = Dos Jugadores
        private string jactual = "Jugador 1";

        // Estadísticas Jugador 1
        private int conterroresJ1 = 0;
        private int contnivelJ1 = 0;
        private int aciertosJ1 = 0;

        // Estadísticas Jugador 2 (Modo Acompañado)
        private int conterroresJ2 = 0;
        private int contnivelJ2 = 0;
        private int aciertosJ2 = 0;
        private string nombreJ2 = "Jugador 2";

        // Requerimiento 4: Arreglos para el historial
        private const int maximo = 100;
        private string[] hjugadores = new string[maximo];
        private int[] hpuntajes = new int[maximo];
        private int historial = 0;

        public Form1()
        {
            InitializeComponent();
            ConfigurarInicioJuego();
        }

        // Configuración de partida usando MessageBox nativo
        private void ConfigurarInicioJuego()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea jugar en Modo Dos Jugadores?\n\n[Sí] = 2 Jugadores (Turnos alternados)\n[No] = Modo Individual",
                "Seleccionar Modo de Juego",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                modoJuego = 2;
                nombreJ2 = "Jugador 2";
            }
            else
            {
                modoJuego = 1;
            }

            jactual = "Jugador 1";
            IniciarNuevaOperacion();
        }

        private void IniciarNuevaOperacion()
        {
            // Validar fin de partida
            if (modoJuego == 1 && conterroresJ1 >= 4)
            {
                MessageBox.Show($"¡Juego terminado, {jactual}! Acumulaste {aciertosJ1} aciertos.", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarPuntajeSesion("Jugador 1", aciertosJ1);
                ReiniciarEstadisticas();
            }
            else if (modoJuego == 2 && conterroresJ1 >= 4 && conterroresJ2 >= 4)
            {
                MessageBox.Show($"¡Partida Finalizada!\nJugador 1: {aciertosJ1} aciertos\n{nombreJ2}: {aciertosJ2} aciertos", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarPuntajeSesion("Jugador 1", aciertosJ1);
                GuardarPuntajeSesion(nombreJ2, aciertosJ2);
                ReiniciarEstadisticas();
            }

            int nivelActual = (jactual == "Jugador 1") ? contnivelJ1 : contnivelJ2;
            int N = 10;

            if (nivelActual >= 3 && nivelActual < 6)
            {
                N = 101;
            }
            else if (nivelActual >= 6)
            {
                N = 1001;
            }

            num1 = rnd.Next(1, N);
            num2 = rnd.Next(1, N);
            int op = rnd.Next(1, 5);

            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    operador = '+';
                    break;
                case 2:
                    resultado = num1 - num2;
                    operador = '-';
                    break;
                case 3:
                    resultado = num1 * num2;
                    operador = '*';
                    break;
                case 4:
                    if (num2 == 0) num2 = 1;
                    resultado = num1 / num2;
                    operador = '/';
                    break;
            }

            lnum1.Text = num1.ToString();
            lop.Text = operador.ToString();
            lnum2.Text = num2.ToString();

            ActualizarInterfazVisual();

            trespuesta.Clear();
            trespuesta.Focus();
        }

        private void ActualizarInterfazVisual()
        {
            int nivelActual = 0;

            if (jactual == "Jugador 1")
            {
                nivelActual = contnivelJ1 + 1;
                lnivel.Text = nivelActual.ToString();
                laciertos.Text = aciertosJ1.ToString();
                lerrores.Text = conterroresJ1.ToString();
            }
            else
            {
                nivelActual = contnivelJ2 + 1;
                lnivel.Text = nivelActual.ToString();
                laciertos.Text = aciertosJ2.ToString();
                lerrores.Text = conterroresJ2.ToString();
            }

            // Mostrar el turno actual en pantalla
            lturno.Text = $"Turno de: {jactual}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(trespuesta.Text, out float usuarioRespuesta))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trespuesta.Clear();
                trespuesta.Focus();
                return;
            }

            if (usuarioRespuesta == resultado)
            {
                MessageBox.Show($"¡Correcto, {jactual}!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (jactual == "Jugador 1")
                {
                    contnivelJ1++;
                    aciertosJ1++;
                }
                else
                {
                    contnivelJ2++;
                    aciertosJ2++;
                }
            }
            else
            {
                MessageBox.Show($"Incorrecto, {jactual}. La respuesta era: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (jactual == "Jugador 1")
                {
                    conterroresJ1++;
                }
                else
                {
                    conterroresJ2++;
                }
            }

            // Alternar turno en Modo 2 Jugadores
            if (modoJuego == 2)
            {
                if (jactual == "Jugador 1" && conterroresJ2 < 4)
                {
                    jactual = nombreJ2;
                }
                else if (jactual == nombreJ2 && conterroresJ1 < 4)
                {
                    jactual = "Jugador 1";
                }
            }

            IniciarNuevaOperacion();
        }

        private void GuardarPuntajeSesion(string nombre, int puntajeFinal)
        {
            if (historial < maximo)
            {
                hjugadores[historial] = nombre;
                hpuntajes[historial] = puntajeFinal;
                historial++;
            }
        }

        public void MostrarTablaClasificacion()
        {
            if (historial == 0)
            {
                MessageBox.Show("Aún no hay registros en la sesión.", "Tabla de Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ordenamiento Burbuja descendente sobre arreglos estáticos corregido
            for (int i = 0; i < historial - 1; i++)
            {
                for (int j = 0; j < historial - i - 1; j++)
                {
                    if (hpuntajes[j] < hpuntajes[j + 1])
                    {
                        int tempP = hpuntajes[j];
                        hpuntajes[j] = hpuntajes[j + 1];
                        hpuntajes[j + 1] = tempP;

                        string tempN = hjugadores[j];
                        hjugadores[j] = hjugadores[j + 1];
                        hjugadores[j + 1] = tempN;
                    }
                }
            }

            string ranking = "--- TABLA DE CLASIFICACIÓN ---\n\n";
            for (int i = 0; i < historial; i++)
            {
                ranking += $"{i + 1}. {hjugadores[i]} - {hpuntajes[i]} aciertos\n";
            }

            MessageBox.Show(ranking, "Ranking Local", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReiniciarEstadisticas()
        {
            conterroresJ1 = 0;
            aciertosJ1 = 0;
            contnivelJ1 = 0;
            conterroresJ2 = 0;
            aciertosJ2 = 0;
            contnivelJ2 = 0;
            jactual = "Jugador 1";
        }

        // Eventos de los Botones
        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            MostrarTablaClasificacion();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarEstadisticas();
            ConfigurarInicioJuego();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}