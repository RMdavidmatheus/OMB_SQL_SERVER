﻿namespace Proyecto_Omb_SQL_SERVER.Vistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.PDF = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DataGrid_Listado_Vig_SOAT = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.BackColor = System.Drawing.Color.White;
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
            this.PDF.Location = new System.Drawing.Point(12, 149);
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
            this.pictureBox1.Location = new System.Drawing.Point(62, 149);
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
            this.Buscar.Location = new System.Drawing.Point(97, 156);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.PasswordChar = '\0';
            this.Buscar.SelectedText = "";
            this.Buscar.SelectionLength = 0;
            this.Buscar.SelectionStart = 0;
            this.Buscar.Size = new System.Drawing.Size(1164, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseSystemPasswordChar = false;
            // 
            // DataGrid_Listado_Vig_SOAT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Listado_Vig_SOAT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Listado_Vig_SOAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Listado_Vig_SOAT.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Listado_Vig_SOAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Listado_Vig_SOAT.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Listado_Vig_SOAT.DoubleBuffered = true;
            this.DataGrid_Listado_Vig_SOAT.EnableHeadersVisualStyles = false;
            this.DataGrid_Listado_Vig_SOAT.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Listado_Vig_SOAT.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(107)))));
            this.DataGrid_Listado_Vig_SOAT.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Vig_SOAT.Location = new System.Drawing.Point(12, 206);
            this.DataGrid_Listado_Vig_SOAT.Name = "DataGrid_Listado_Vig_SOAT";
            this.DataGrid_Listado_Vig_SOAT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Vig_SOAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // Listado_reporte_SOAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Superior);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}