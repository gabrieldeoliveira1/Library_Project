namespace Library_Project
{
    partial class INFO_Unidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INFO_Unidade));
            BNT_Confirmar_Unidade = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BNT_Confirmar_Unidade
            // 
            BNT_Confirmar_Unidade.BackColor = Color.Transparent;
            BNT_Confirmar_Unidade.BackgroundImageLayout = ImageLayout.Stretch;
            BNT_Confirmar_Unidade.FlatStyle = FlatStyle.Popup;
            BNT_Confirmar_Unidade.ForeColor = Color.FromArgb(9, 90, 162);
            BNT_Confirmar_Unidade.Location = new Point(-36, -15);
            BNT_Confirmar_Unidade.Name = "BNT_Confirmar_Unidade";
            BNT_Confirmar_Unidade.Size = new Size(792, 108);
            BNT_Confirmar_Unidade.TabIndex = 1;
            BNT_Confirmar_Unidade.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BNT_Confirmar_Unidade);
            panel1.Location = new Point(820, 742);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 60);
            panel1.TabIndex = 2;
            // 
            // INFO_Unidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1497, 878);
            Controls.Add(panel1);
            Name = "INFO_Unidade";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BNT_Confirmar_Unidade;
        private Panel panel1;
    }
}