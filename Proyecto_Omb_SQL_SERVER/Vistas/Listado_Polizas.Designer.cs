namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    partial class Listado_Polizas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Polizas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Panel_Inferior = new System.Windows.Forms.Panel();
            this.DataGrid_Listado_Polizas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Delete_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Edit_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Insert_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Listado_Polizas)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Insert_btn);
            this.Panel_Superior.Controls.Add(this.Edit_btn);
            this.Panel_Superior.Controls.Add(this.Delete_btn);
            this.Panel_Superior.Controls.Add(this.pictureBox2);
            this.Panel_Superior.Controls.Add(this.pictureBox1);
            this.Panel_Superior.Controls.Add(this.Buscar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(1280, 200);
            this.Panel_Superior.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1280, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Depth = 0;
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Hint = "Buscar...";
            this.Buscar.Location = new System.Drawing.Point(695, 156);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.PasswordChar = '\0';
            this.Buscar.SelectedText = "";
            this.Buscar.SelectionLength = 0;
            this.Buscar.SelectionStart = 0;
            this.Buscar.Size = new System.Drawing.Size(582, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseSystemPasswordChar = false;
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            // 
            // Panel_Inferior
            // 
            this.Panel_Inferior.Controls.Add(this.DataGrid_Listado_Polizas);
            this.Panel_Inferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Inferior.Location = new System.Drawing.Point(0, 200);
            this.Panel_Inferior.Name = "Panel_Inferior";
            this.Panel_Inferior.Size = new System.Drawing.Size(1280, 520);
            this.Panel_Inferior.TabIndex = 1;
            // 
            // DataGrid_Listado_Polizas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Listado_Polizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Listado_Polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Listado_Polizas.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Polizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Listado_Polizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Polizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Listado_Polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Listado_Polizas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Listado_Polizas.DoubleBuffered = true;
            this.DataGrid_Listado_Polizas.EnableHeadersVisualStyles = false;
            this.DataGrid_Listado_Polizas.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Listado_Polizas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.DataGrid_Listado_Polizas.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Polizas.Location = new System.Drawing.Point(12, 6);
            this.DataGrid_Listado_Polizas.Name = "DataGrid_Listado_Polizas";
            this.DataGrid_Listado_Polizas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Polizas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_Listado_Polizas.Size = new System.Drawing.Size(1256, 511);
            this.DataGrid_Listado_Polizas.TabIndex = 0;
            this.DataGrid_Listado_Polizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGrid_Listado_Polizas_CellFormatting);
            // 
            // Delete_btn
            // 
            this.Delete_btn.ActiveBorderThickness = 1;
            this.Delete_btn.ActiveCornerRadius = 20;
            this.Delete_btn.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Delete_btn.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.BackColor = System.Drawing.Color.White;
            this.Delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btn.BackgroundImage")));
            this.Delete_btn.ButtonText = "Eliminar";
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Delete_btn.IdleBorderThickness = 1;
            this.Delete_btn.IdleCornerRadius = 20;
            this.Delete_btn.IdleFillColor = System.Drawing.Color.White;
            this.Delete_btn.IdleForecolor = System.Drawing.Color.DarkRed;
            this.Delete_btn.IdleLineColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.Location = new System.Drawing.Point(447, 140);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(204, 56);
            this.Delete_btn.TabIndex = 6;
            this.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.ActiveBorderThickness = 1;
            this.Edit_btn.ActiveCornerRadius = 20;
            this.Edit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.Edit_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Edit_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.Edit_btn.BackColor = System.Drawing.Color.White;
            this.Edit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_btn.BackgroundImage")));
            this.Edit_btn.ButtonText = "Editar";
            this.Edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_btn.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Edit_btn.IdleBorderThickness = 1;
            this.Edit_btn.IdleCornerRadius = 20;
            this.Edit_btn.IdleFillColor = System.Drawing.Color.White;
            this.Edit_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.Edit_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.Edit_btn.Location = new System.Drawing.Point(231, 140);
            this.Edit_btn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(204, 56);
            this.Edit_btn.TabIndex = 7;
            this.Edit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.ActiveBorderThickness = 1;
            this.Insert_btn.ActiveCornerRadius = 20;
            this.Insert_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Insert_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Insert_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Insert_btn.BackColor = System.Drawing.Color.White;
            this.Insert_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Insert_btn.BackgroundImage")));
            this.Insert_btn.ButtonText = "Agregar";
            this.Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_btn.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Insert_btn.IdleBorderThickness = 1;
            this.Insert_btn.IdleCornerRadius = 20;
            this.Insert_btn.IdleFillColor = System.Drawing.Color.White;
            this.Insert_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Insert_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Insert_btn.Location = new System.Drawing.Point(12, 140);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(207, 56);
            this.Insert_btn.TabIndex = 8;
            this.Insert_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Listado_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Panel_Inferior);
            this.Controls.Add(this.Panel_Superior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado_Polizas";
            this.Text = "Listado_Polizas";
            this.Load += new System.EventHandler(this.Listado_Polizas_Load);
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Inferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Listado_Polizas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_Inferior;
        private System.Windows.Forms.Panel Panel_Superior;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Listado_Polizas;
        private MaterialSkin.Controls.MaterialSingleLineTextField Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip Mensaje;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Edit_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Insert_btn;
    }
}