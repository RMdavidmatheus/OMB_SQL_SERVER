namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    partial class Calendar_Date_Picker
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DatePicker_Fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardar_Date = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DatePicker_Fecha
            // 
            this.DatePicker_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.DatePicker_Fecha.BorderRadius = 0;
            this.DatePicker_Fecha.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Fecha.ForeColor = System.Drawing.Color.White;
            this.DatePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker_Fecha.FormatCustom = "";
            this.DatePicker_Fecha.Location = new System.Drawing.Point(40, 160);
            this.DatePicker_Fecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DatePicker_Fecha.Name = "DatePicker_Fecha";
            this.DatePicker_Fecha.Size = new System.Drawing.Size(400, 48);
            this.DatePicker_Fecha.TabIndex = 0;
            this.DatePicker_Fecha.Value = new System.DateTime(2019, 1, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(33, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor, seleccione una fecha";
            // 
            // Guardar_Date
            // 
            this.Guardar_Date.Depth = 0;
            this.Guardar_Date.Location = new System.Drawing.Point(140, 231);
            this.Guardar_Date.MouseState = MaterialSkin.MouseState.HOVER;
            this.Guardar_Date.Name = "Guardar_Date";
            this.Guardar_Date.Primary = true;
            this.Guardar_Date.Size = new System.Drawing.Size(202, 53);
            this.Guardar_Date.TabIndex = 2;
            this.Guardar_Date.Text = "Guardar fecha";
            this.Guardar_Date.UseVisualStyleBackColor = true;
            this.Guardar_Date.Click += new System.EventHandler(this.Guardar_Date_Click);
            // 
            // Calendar_Date_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 311);
            this.Controls.Add(this.Guardar_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePicker_Fecha);
            this.Name = "Calendar_Date_Picker";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker DatePicker_Fecha;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton Guardar_Date;
    }
}