namespace CRUDado
{
    partial class Notificacion
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
            this.pTop = new System.Windows.Forms.Panel();
            this.pbSuc = new System.Windows.Forms.PictureBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(311, 5);
            this.pTop.TabIndex = 0;
            // 
            // pbSuc
            // 
            this.pbSuc.Image = global::CRUDado.Properties.Resources.suc;
            this.pbSuc.Location = new System.Drawing.Point(10, 10);
            this.pbSuc.Name = "pbSuc";
            this.pbSuc.Size = new System.Drawing.Size(60, 60);
            this.pbSuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuc.TabIndex = 1;
            this.pbSuc.TabStop = false;
            // 
            // pbInfo
            // 
            this.pbInfo.Image = global::CRUDado.Properties.Resources.info;
            this.pbInfo.Location = new System.Drawing.Point(10, 10);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(60, 60);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 2;
            this.pbInfo.TabStop = false;
            // 
            // pbDel
            // 
            this.pbDel.Image = global::CRUDado.Properties.Resources.del;
            this.pbDel.Location = new System.Drawing.Point(10, 10);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(60, 60);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 3;
            this.pbDel.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Gray;
            this.lblMensaje.Location = new System.Drawing.Point(96, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(69, 26);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 75);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.pbSuc);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notificacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notificacion_FormClosing);
            this.Load += new System.EventHandler(this.Notificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.PictureBox pbSuc;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timer1;
    }
}