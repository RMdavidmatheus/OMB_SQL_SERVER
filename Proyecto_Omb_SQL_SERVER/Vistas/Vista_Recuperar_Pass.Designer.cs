namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    partial class Vista_Recuperar_Pass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Recuperar_Pass));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Txt_Doc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Enviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Txt_Doc
            // 
            this.Txt_Doc.Depth = 0;
            this.Txt_Doc.Hint = "Ingrese su documento";
            this.Txt_Doc.Location = new System.Drawing.Point(12, 292);
            this.Txt_Doc.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Doc.Name = "Txt_Doc";
            this.Txt_Doc.PasswordChar = '\0';
            this.Txt_Doc.SelectedText = "";
            this.Txt_Doc.SelectionLength = 0;
            this.Txt_Doc.SelectionStart = 0;
            this.Txt_Doc.Size = new System.Drawing.Size(313, 23);
            this.Txt_Doc.TabIndex = 0;
            this.Txt_Doc.UseSystemPasswordChar = false;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Depth = 0;
            this.btn_Enviar.Location = new System.Drawing.Point(75, 331);
            this.btn_Enviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Primary = true;
            this.btn_Enviar.Size = new System.Drawing.Size(190, 42);
            this.btn_Enviar.TabIndex = 1;
            this.btn_Enviar.Text = "Recuperar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Vista_Recuperar_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.Txt_Doc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Recuperar_Pass";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación de contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Txt_Doc;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Enviar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}