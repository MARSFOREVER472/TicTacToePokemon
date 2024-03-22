namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tablero = new TableLayoutPanel();
            Jugador = new PictureBox();
            Rival = new PictureBox();
            ReiniciarPartida = new PictureBox();
            contra = new Label();
            ResultadoFinal = new PictureBox();
            puntosJugador = new Label();
            puntosRival = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Jugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rival).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReiniciarPartida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultadoFinal).BeginInit();
            SuspendLayout();
            // 
            // Tablero
            // 
            Tablero.BackColor = Color.Transparent;
            Tablero.ColumnCount = 3;
            Tablero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tablero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tablero.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            Tablero.Location = new Point(12, 12);
            Tablero.Name = "Tablero";
            Tablero.RowCount = 3;
            Tablero.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tablero.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tablero.RowStyles.Add(new RowStyle(SizeType.Absolute, 177F));
            Tablero.Size = new Size(550, 550);
            Tablero.TabIndex = 0;
            // 
            // Jugador
            // 
            Jugador.BackColor = Color.Transparent;
            Jugador.Location = new Point(643, 12);
            Jugador.Name = "Jugador";
            Jugador.Size = new Size(150, 150);
            Jugador.TabIndex = 1;
            Jugador.TabStop = false;
            // 
            // Rival
            // 
            Rival.BackColor = Color.Transparent;
            Rival.Location = new Point(882, 12);
            Rival.Name = "Rival";
            Rival.Size = new Size(150, 150);
            Rival.TabIndex = 2;
            Rival.TabStop = false;
            // 
            // ReiniciarPartida
            // 
            ReiniciarPartida.BackColor = Color.Transparent;
            ReiniciarPartida.Location = new Point(36, 593);
            ReiniciarPartida.Name = "ReiniciarPartida";
            ReiniciarPartida.Size = new Size(500, 100);
            ReiniciarPartida.TabIndex = 3;
            ReiniciarPartida.TabStop = false;
            // 
            // contra
            // 
            contra.AutoSize = true;
            contra.BackColor = Color.Transparent;
            contra.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            contra.ForeColor = Color.White;
            contra.Location = new Point(809, 67);
            contra.Name = "contra";
            contra.Size = new Size(53, 38);
            contra.TabIndex = 4;
            contra.Text = "VS";
            // 
            // ResultadoFinal
            // 
            ResultadoFinal.BackColor = Color.Transparent;
            ResultadoFinal.Location = new Point(1140, 16);
            ResultadoFinal.Name = "ResultadoFinal";
            ResultadoFinal.Size = new Size(300, 300);
            ResultadoFinal.TabIndex = 5;
            ResultadoFinal.TabStop = false;
            // 
            // puntosJugador
            // 
            puntosJugador.AutoSize = true;
            puntosJugador.BackColor = Color.Transparent;
            puntosJugador.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            puntosJugador.ForeColor = Color.White;
            puntosJugador.Location = new Point(705, 165);
            puntosJugador.Name = "puntosJugador";
            puntosJugador.Size = new Size(34, 38);
            puntosJugador.TabIndex = 6;
            puntosJugador.Text = "0";
            // 
            // puntosRival
            // 
            puntosRival.AutoSize = true;
            puntosRival.BackColor = Color.Transparent;
            puntosRival.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            puntosRival.ForeColor = Color.White;
            puntosRival.Location = new Point(937, 165);
            puntosRival.Name = "puntosRival";
            puntosRival.Size = new Size(34, 38);
            puntosRival.TabIndex = 7;
            puntosRival.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1233, 319);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 8;
            label1.Text = "Winner";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pokemon_chromebook_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1478, 744);
            Controls.Add(label1);
            Controls.Add(puntosRival);
            Controls.Add(puntosJugador);
            Controls.Add(ResultadoFinal);
            Controls.Add(contra);
            Controls.Add(ReiniciarPartida);
            Controls.Add(Rival);
            Controls.Add(Jugador);
            Controls.Add(Tablero);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Jugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rival).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReiniciarPartida).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultadoFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel Tablero;
        private PictureBox Jugador;
        private PictureBox Rival;
        private PictureBox ReiniciarPartida;
        private Label contra;
        private PictureBox ResultadoFinal;
        private Label puntosJugador;
        private Label puntosRival;
        private Label label1;
    }
}