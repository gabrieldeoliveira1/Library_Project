namespace Library_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BNT_Voltar_ao_inicio = new Button();
            BNT_Reservar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BNT_Voltar_ao_inicio
            // 
            BNT_Voltar_ao_inicio.BackColor = Color.Transparent;
            BNT_Voltar_ao_inicio.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Voltar_ao_inicio.FlatStyle = FlatStyle.Popup;
            BNT_Voltar_ao_inicio.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Voltar_ao_inicio.Location = new Point(-66, -29);
            BNT_Voltar_ao_inicio.Name = "BNT_Voltar_ao_inicio";
            BNT_Voltar_ao_inicio.Size = new Size(792, 108);
            BNT_Voltar_ao_inicio.TabIndex = 0;
            BNT_Voltar_ao_inicio.UseVisualStyleBackColor = false;
            // 
            // BNT_Reservar
            // 
            BNT_Reservar.BackColor = Color.Transparent;
            BNT_Reservar.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Reservar.FlatStyle = FlatStyle.Popup;
            BNT_Reservar.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Reservar.Location = new Point(-114, -30);
            BNT_Reservar.Name = "BNT_Reservar";
            BNT_Reservar.Size = new Size(798, 111);
            BNT_Reservar.TabIndex = 1;
            BNT_Reservar.UseVisualStyleBackColor = false;
            BNT_Reservar.Click += BNT_Reservar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Voltar_ao_inicio);
            panel1.Location = new Point(655, 825);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 37);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BNT_Reservar);
            panel2.Location = new Point(679, 765);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 42);
            panel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1497, 898);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BNT_Voltar_ao_inicio;
        private Button BNT_Reservar;
        private Panel panel1;
        private Panel panel2;
    }
}
