namespace P1AFormNaser
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ingreso = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.Label();
            this.textBoxusr = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(323, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 37);
            this.lbl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Padre:Form1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P1AFormNaser.Properties.Resources.battle;
            this.pictureBox1.Location = new System.Drawing.Point(40, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ingreso
            // 
            this.ingreso.Location = new System.Drawing.Point(475, 183);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(150, 58);
            this.ingreso.TabIndex = 3;
            this.ingreso.Text = "INGRESO";
            this.ingreso.UseVisualStyleBackColor = true;
            this.ingreso.Click += new System.EventHandler(this.ingreso_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(361, 71);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(64, 20);
            this.usuario.TabIndex = 4;
            this.usuario.Text = "Usuario";
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.Location = new System.Drawing.Point(361, 132);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(89, 20);
            this.contra.TabIndex = 5;
            this.contra.Text = "contraseña";
            // 
            // textBoxusr
            // 
            this.textBoxusr.Location = new System.Drawing.Point(475, 68);
            this.textBoxusr.Name = "textBoxusr";
            this.textBoxusr.Size = new System.Drawing.Size(100, 26);
            this.textBoxusr.TabIndex = 6;
            this.textBoxusr.TextChanged += new System.EventHandler(this.textBoxusr_TextChanged);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(475, 126);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(100, 26);
            this.textBoxpassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusr);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My App";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingreso;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.TextBox textBoxusr;
        private System.Windows.Forms.TextBox textBoxpassword;
    }
}

