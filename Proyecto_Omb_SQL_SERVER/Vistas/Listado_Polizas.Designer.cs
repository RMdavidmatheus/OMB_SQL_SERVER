﻿namespace Proyecto_Omb_SQL_SERVER.Vistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Polizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Editar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Añadir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Panel_Inferior = new System.Windows.Forms.Panel();
            this.DataGrid_Listado_Polizas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Panel_Superior.SuspendLayout();
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
            this.Panel_Superior.Controls.Add(this.pictureBox1);
            this.Panel_Superior.Controls.Add(this.Buscar);
            this.Panel_Superior.Controls.Add(this.Eliminar);
            this.Panel_Superior.Controls.Add(this.Editar);
            this.Panel_Superior.Controls.Add(this.Añadir);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(1280, 180);
            this.Panel_Superior.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 131);
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
            this.Buscar.Location = new System.Drawing.Point(686, 137);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.PasswordChar = '\0';
            this.Buscar.SelectedText = "";
            this.Buscar.SelectionLength = 0;
            this.Buscar.SelectionStart = 0;
            this.Buscar.Size = new System.Drawing.Size(591, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseSystemPasswordChar = false;
            // 
            // Eliminar
            // 
            this.Eliminar.Depth = 0;
            this.Eliminar.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(431, 121);
            this.Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Primary = true;
            this.Eliminar.Size = new System.Drawing.Size(204, 51);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar Poliza";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Depth = 0;
            this.Editar.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.Location = new System.Drawing.Point(221, 121);
            this.Editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Editar.Name = "Editar";
            this.Editar.Primary = true;
            this.Editar.Size = new System.Drawing.Size(204, 51);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar Poliza";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Añadir
            // 
            this.Añadir.Depth = 0;
            this.Añadir.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Añadir.Location = new System.Drawing.Point(11, 121);
            this.Añadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.Añadir.Name = "Añadir";
            this.Añadir.Primary = true;
            this.Añadir.Size = new System.Drawing.Size(204, 51);
            this.Añadir.TabIndex = 0;
            this.Añadir.Text = "Agregar Poliza";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // Panel_Inferior
            // 
            this.Panel_Inferior.Controls.Add(this.DataGrid_Listado_Polizas);
            this.Panel_Inferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Inferior.Location = new System.Drawing.Point(0, 180);
            this.Panel_Inferior.Name = "Panel_Inferior";
            this.Panel_Inferior.Size = new System.Drawing.Size(1280, 540);
            this.Panel_Inferior.TabIndex = 1;
            // 
            // DataGrid_Listado_Polizas
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Listado_Polizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_Listado_Polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Listado_Polizas.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Polizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Listado_Polizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Polizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid_Listado_Polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Listado_Polizas.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid_Listado_Polizas.DoubleBuffered = true;
            this.DataGrid_Listado_Polizas.EnableHeadersVisualStyles = false;
            this.DataGrid_Listado_Polizas.GridColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_Listado_Polizas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(107)))));
            this.DataGrid_Listado_Polizas.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_Listado_Polizas.Location = new System.Drawing.Point(12, 0);
            this.DataGrid_Listado_Polizas.Name = "DataGrid_Listado_Polizas";
            this.DataGrid_Listado_Polizas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Listado_Polizas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_Listado_Polizas.Size = new System.Drawing.Size(1256, 537);
            this.DataGrid_Listado_Polizas.TabIndex = 0;
            // 
            // Listado_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Panel_Inferior);
            this.Controls.Add(this.Panel_Superior);
            this.Name = "Listado_Polizas";
            this.Text = "Listado_Polizas";
            this.Load += new System.EventHandler(this.Listado_Polizas_Load);
            this.Panel_Superior.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialRaisedButton Añadir;
        private MaterialSkin.Controls.MaterialRaisedButton Eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton Editar;
        private MaterialSkin.Controls.MaterialSingleLineTextField Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}