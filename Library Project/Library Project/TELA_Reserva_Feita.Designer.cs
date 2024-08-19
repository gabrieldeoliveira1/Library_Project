namespace Library_Project
{
    partial class TELA_Reserva_Feita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TELA_Reserva_Feita));
            panel1 = new Panel();
            BNT_Fazer_outro_ped = new Button();
            panel2 = new Panel();
            BNT_Voltar_catalogo_2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Fazer_outro_ped);
            panel1.Location = new Point(153, 754);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 49);
            panel1.TabIndex = 0;
            // 
            // BNT_Fazer_outro_ped
            // 
            BNT_Fazer_outro_ped.BackColor = Color.Transparent;
            BNT_Fazer_outro_ped.FlatStyle = FlatStyle.Popup;
            BNT_Fazer_outro_ped.Location = new Point(-12, -28);
            BNT_Fazer_outro_ped.Name = "BNT_Fazer_outro_ped";
            BNT_Fazer_outro_ped.Size = new Size(580, 96);
            BNT_Fazer_outro_ped.TabIndex = 1;
            BNT_Fazer_outro_ped.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BNT_Voltar_catalogo_2);
            panel2.Location = new Point(807, 749);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 52);
            panel2.TabIndex = 1;
            // 
            // BNT_Voltar_catalogo_2
            // 
            BNT_Voltar_catalogo_2.FlatStyle = FlatStyle.Popup;
            BNT_Voltar_catalogo_2.Location = new Point(-58, -43);
            BNT_Voltar_catalogo_2.Name = "BNT_Voltar_catalogo_2";
            BNT_Voltar_catalogo_2.Size = new Size(636, 116);
            BNT_Voltar_catalogo_2.TabIndex = 2;
            BNT_Voltar_catalogo_2.UseVisualStyleBackColor = true;
            // 
            // TELA_Reserva_Feita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1515, 945);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TELA_Reserva_Feita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TELA_Reserva_Feita";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BNT_Fazer_outro_ped;
        private Panel panel2;
        private Button BNT_Voltar_catalogo_2;
    }
}