namespace CRUDado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pTop = new System.Windows.Forms.Panel();
            this.pBtns = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvEjemplo = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCorreo = new System.Windows.Forms.PictureBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbApellido = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbCaja = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.pTop.SuspendLayout();
            this.pBtns.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.pTop.Controls.Add(this.pBtns);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(645, 40);
            this.pTop.TabIndex = 7;
            // 
            // pBtns
            // 
            this.pBtns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBtns.Controls.Add(this.btnC);
            this.pBtns.Location = new System.Drawing.Point(491, 1);
            this.pBtns.Name = "pBtns";
            this.pBtns.Size = new System.Drawing.Size(154, 39);
            this.pBtns.TabIndex = 3;
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Image = ((System.Drawing.Image)(resources.GetObject("btnC.Image")));
            this.btnC.Location = new System.Drawing.Point(101, 1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 35);
            this.btnC.TabIndex = 2;
            this.btnC.TabStop = false;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.Controls.Add(this.btnEliminar);
            this.pContainer.Controls.Add(this.btnEditar);
            this.pContainer.Controls.Add(this.btnGuardar);
            this.pContainer.Controls.Add(this.btnNuevo);
            this.pContainer.Controls.Add(this.dgvEjemplo);
            this.pContainer.Controls.Add(this.txtCorreo);
            this.pContainer.Controls.Add(this.lblCorreo);
            this.pContainer.Controls.Add(this.pictureBox2);
            this.pContainer.Controls.Add(this.pbCorreo);
            this.pContainer.Controls.Add(this.txtApellido);
            this.pContainer.Controls.Add(this.lblApellido);
            this.pContainer.Controls.Add(this.pictureBox1);
            this.pContainer.Controls.Add(this.pbApellido);
            this.pContainer.Controls.Add(this.txtNom);
            this.pContainer.Controls.Add(this.lblNombre);
            this.pContainer.Controls.Add(this.pbCaja);
            this.pContainer.Controls.Add(this.pbNombre);
            this.pContainer.Location = new System.Drawing.Point(6, 45);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(633, 242);
            this.pContainer.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(574, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(574, 122);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(574, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(574, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvEjemplo
            // 
            this.dgvEjemplo.AllowUserToAddRows = false;
            this.dgvEjemplo.AllowUserToDeleteRows = false;
            this.dgvEjemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplo.Location = new System.Drawing.Point(12, 64);
            this.dgvEjemplo.Name = "dgvEjemplo";
            this.dgvEjemplo.Size = new System.Drawing.Size(556, 161);
            this.dgvEjemplo.TabIndex = 12;
            this.dgvEjemplo.TabStop = false;
            this.dgvEjemplo.DoubleClick += new System.EventHandler(this.dgvEjemplo_DoubleClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(396, 31);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(147, 21);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Tag = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(402, 6);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 19);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(389, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 40);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pbCorreo
            // 
            this.pbCorreo.BackColor = System.Drawing.Color.Black;
            this.pbCorreo.Location = new System.Drawing.Point(387, 16);
            this.pbCorreo.Name = "pbCorreo";
            this.pbCorreo.Size = new System.Drawing.Size(181, 44);
            this.pbCorreo.TabIndex = 9;
            this.pbCorreo.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(209, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 21);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Tag = "Apellido";
            this.txtApellido.Enter += new System.EventHandler(this.txt_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(215, 6);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 19);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(202, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbApellido
            // 
            this.pbApellido.BackColor = System.Drawing.Color.Black;
            this.pbApellido.Location = new System.Drawing.Point(200, 16);
            this.pbApellido.Name = "pbApellido";
            this.pbApellido.Size = new System.Drawing.Size(181, 44);
            this.pbApellido.TabIndex = 5;
            this.pbApellido.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(21, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(147, 21);
            this.txtNom.TabIndex = 1;
            this.txtNom.Tag = "Nombre";
            this.txtNom.Enter += new System.EventHandler(this.txt_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(27, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // pbCaja
            // 
            this.pbCaja.BackColor = System.Drawing.Color.White;
            this.pbCaja.Location = new System.Drawing.Point(14, 18);
            this.pbCaja.Name = "pbCaja";
            this.pbCaja.Size = new System.Drawing.Size(177, 40);
            this.pbCaja.TabIndex = 0;
            this.pbCaja.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.BackColor = System.Drawing.Color.Black;
            this.pbNombre.Location = new System.Drawing.Point(12, 16);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(181, 44);
            this.pbNombre.TabIndex = 0;
            this.pbNombre.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 301);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pTop.ResumeLayout(false);
            this.pBtns.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pBtns;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvEjemplo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbApellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbCaja;
        private System.Windows.Forms.PictureBox pbNombre;
    }
}

