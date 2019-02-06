namespace Proyecto_Omb_SQL_SERVER.Alert
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_Alert = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Timeout = new System.Windows.Forms.Timer(this.components);
            this.Show = new System.Windows.Forms.Timer(this.components);
            this.CloseAlert = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Label_Alert
            // 
            this.Label_Alert.AutoSize = true;
            this.Label_Alert.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alert.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Alert.Location = new System.Drawing.Point(65, 44);
            this.Label_Alert.Name = "Label_Alert";
            this.Label_Alert.Size = new System.Drawing.Size(248, 29);
            this.Label_Alert.TabIndex = 0;
            this.Label_Alert.Text = "Ingresó correctamente";
            this.Label_Alert.Click += new System.EventHandler(this.Label_Alert_Click);
            // 
            // Icon
            // 
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(11, 17);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(48, 73);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 1;
            this.Icon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Timeout
            // 
            this.Timeout.Enabled = true;
            this.Timeout.Interval = 7000;
            this.Timeout.Tick += new System.EventHandler(this.Timeout_Tick);
            // 
            // Show
            // 
            this.Show.Tick += new System.EventHandler(this.Show_Tick);
            // 
            // CloseAlert
            // 
            this.CloseAlert.Tick += new System.EventHandler(this.CloseAlert_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CERRAR3.png");
            this.imageList1.Images.SetKeyName(1, "Checkmark_100px.png");
            this.imageList1.Images.SetKeyName(2, "Error_100px.png");
            this.imageList1.Images.SetKeyName(3, "Info_100px.png");
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(452, 105);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.Label_Alert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.94D;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Label_Alert;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Icon;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer Timeout;
        private System.Windows.Forms.Timer Show;
        private System.Windows.Forms.Timer CloseAlert;
        private System.Windows.Forms.ImageList imageList1;
    }
}