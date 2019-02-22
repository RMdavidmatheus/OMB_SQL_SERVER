namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    partial class Listado_reporte_SOAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_reporte_SOAT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.PDF = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DataGrid_Listado_Vig_SOAT = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DP_Mes = new Bunifu.Framework.UI.BunifuDropdown();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Listado_Vig_SOAT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.DataGrid_Listado_Vig_SOAT;
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.BackColor = System.Drawing.Color.White;
            this.Panel_Superior.Controls.Add(this.DP_Mes);
            this.Panel_Superior.Controls.Add(this.PDF);
            this.Panel_Superior.Controls.Add(this.pictureBox2);
            this.Panel_Superior.Controls.Add(this.pictureBox1);
            this.Panel_Superior.Controls.Add(this.Buscar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(1264, 200);
            this.Panel_Superior.TabIndex = 10;
            // 
            // PDF
            // 
            this.PDF.BackColor = System.Drawing.Color.White;
            this.PDF.Image = ((System.Drawing.Image)(resources.GetObject("PDF.Image")));
            this.PDF.ImageActive = null;
            this.PDF.Location = new System.Drawing.Point(435, 151);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(33, 30);
            this.PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PDF.TabIndex = 6;
            this.PDF.TabStop = false;
            this.PDF.Zoom = 10;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1264, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 151);
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
            this.Buscar.Location = new System.Drawing.Point(513, 156);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.PasswordChar = '\0';
            this.Buscar.SelectedText = "";
            this.Buscar.SelectionLength = 0;
            this.Buscar.SelectionStart = 0;
            this.Buscar.Size = new System.Drawing.Size(748, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseSystemPasswordChar = false;
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            // 
            // DataGrid_Listado_Vig_SOAT
            // 
            this.DataGrid_Listado_Vig_SOAT.AllowUserToAddRows = false;
            this.DataGrid_Listado_Vig_SOAT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Listado_Vig_SOAT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGrid_Listado_Vig_SOAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Listado_Vig_SOAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Listado_Vig_SOAT.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersHeight = 75;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Listado_Vig_SOAT.DefaultCellStyle = dataGridViewCellStyle19;
            this.DataGrid_Listado_Vig_SOAT.DoubleBuffered = true;
            this.DataGrid_Listado_Vig_SOAT.EnableHeadersVisualStyles = false;
            this.DataGrid_Listado_Vig_SOAT.GridColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.DataGrid_Listado_Vig_SOAT.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.Location = new System.Drawing.Point(12, 206);
            this.DataGrid_Listado_Vig_SOAT.Name = "DataGrid_Listado_Vig_SOAT";
            this.DataGrid_Listado_Vig_SOAT.ReadOnly = true;
            this.DataGrid_Listado_Vig_SOAT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Vig_SOAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.DividerHeight = 1;
            this.DataGrid_Listado_Vig_SOAT.RowTemplate.Height = 42;
            this.DataGrid_Listado_Vig_SOAT.Size = new System.Drawing.Size(1240, 472);
            this.DataGrid_Listado_Vig_SOAT.TabIndex = 0;
            this.DataGrid_Listado_Vig_SOAT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGrid_Listado_Vig_SOAT_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DataGrid_Listado_Vig_SOAT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 11;
            // 
            // DP_Mes
            // 
            this.DP_Mes.BackColor = System.Drawing.Color.Transparent;
            this.DP_Mes.BorderRadius = 3;
            this.DP_Mes.ForeColor = System.Drawing.Color.White;
            this.DP_Mes.Items = new string[] {
        "ENERO",
        "FEBRERO",
        "MARZO",
        "ABRIL",
        "MAYO",
        "JUNIO",
        "JULIO",
        "AGOSTO",
        "SEPTIEMBRE",
        "OCTUBRE",
        "NOVIEMBRE",
        "DICIEMBRE"};
            this.DP_Mes.Location = new System.Drawing.Point(12, 139);
            this.DP_Mes.Name = "DP_Mes";
            this.DP_Mes.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(47)))));
            this.DP_Mes.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.DP_Mes.selectedIndex = 0;
            this.DP_Mes.Size = new System.Drawing.Size(417, 57);
            this.DP_Mes.TabIndex = 7;
            this.DP_Mes.onItemSelected += new System.EventHandler(this.DP_Mes_onItemSelected);
            // 
            // Listado_reporte_SOAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Superior);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado_reporte_SOAT";
            this.Text = "Listado_reporte_SOAT";
            this.Load += new System.EventHandler(this.Listado_reporte_SOAT_Load);
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Listado_Vig_SOAT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_Superior;
        private Bunifu.Framework.UI.BunifuImageButton PDF;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Buscar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_Listado_Vig_SOAT;
        private Bunifu.Framework.UI.BunifuDropdown DP_Mes;
    }
}