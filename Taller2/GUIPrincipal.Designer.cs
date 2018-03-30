namespace Taller2
{
    partial class GUIPrincipal
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butArriba = new System.Windows.Forms.Button();
            this.butIzq = new System.Windows.Forms.Button();
            this.butDer = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.labEstatura = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.butAddIzq = new System.Windows.Forms.Button();
            this.butAddDer = new System.Windows.Forms.Button();
            this.butMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(254, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 91);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butArriba
            // 
            this.butArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butArriba.Location = new System.Drawing.Point(346, 138);
            this.butArriba.Name = "butArriba";
            this.butArriba.Size = new System.Drawing.Size(47, 23);
            this.butArriba.TabIndex = 1;
            this.butArriba.Text = "^";
            this.butArriba.UseVisualStyleBackColor = true;
            // 
            // butIzq
            // 
            this.butIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIzq.Location = new System.Drawing.Point(299, 167);
            this.butIzq.Name = "butIzq";
            this.butIzq.Size = new System.Drawing.Size(47, 23);
            this.butIzq.TabIndex = 2;
            this.butIzq.Text = "<";
            this.butIzq.UseVisualStyleBackColor = true;
            // 
            // butDer
            // 
            this.butDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDer.Location = new System.Drawing.Point(393, 167);
            this.butDer.Name = "butDer";
            this.butDer.Size = new System.Drawing.Size(47, 23);
            this.butDer.TabIndex = 3;
            this.butDer.Text = ">";
            this.butDer.UseVisualStyleBackColor = true;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(30, 41);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "Nombre:";
            // 
            // labEstatura
            // 
            this.labEstatura.AutoSize = true;
            this.labEstatura.Location = new System.Drawing.Point(30, 84);
            this.labEstatura.Name = "labEstatura";
            this.labEstatura.Size = new System.Drawing.Size(49, 13);
            this.labEstatura.TabIndex = 5;
            this.labEstatura.Text = "Estatura:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(106, 81);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(100, 20);
            this.txtEstatura.TabIndex = 7;
            // 
            // butAddIzq
            // 
            this.butAddIzq.Location = new System.Drawing.Point(125, 138);
            this.butAddIzq.Name = "butAddIzq";
            this.butAddIzq.Size = new System.Drawing.Size(98, 23);
            this.butAddIzq.TabIndex = 8;
            this.butAddIzq.Text = "Agregar Izquierda";
            this.butAddIzq.UseVisualStyleBackColor = true;
            // 
            // butAddDer
            // 
            this.butAddDer.Location = new System.Drawing.Point(21, 138);
            this.butAddDer.Name = "butAddDer";
            this.butAddDer.Size = new System.Drawing.Size(98, 23);
            this.butAddDer.TabIndex = 9;
            this.butAddDer.Text = "Agregar Derecha";
            this.butAddDer.UseVisualStyleBackColor = true;
            // 
            // butMostrar
            // 
            this.butMostrar.Location = new System.Drawing.Point(69, 167);
            this.butMostrar.Name = "butMostrar";
            this.butMostrar.Size = new System.Drawing.Size(98, 23);
            this.butMostrar.TabIndex = 10;
            this.butMostrar.Text = "Mostrar";
            this.butMostrar.UseVisualStyleBackColor = true;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 207);
            this.Controls.Add(this.butMostrar);
            this.Controls.Add(this.butAddDer);
            this.Controls.Add(this.butAddIzq);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labEstatura);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.butDer);
            this.Controls.Add(this.butIzq);
            this.Controls.Add(this.butArriba);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GUIPrincipal";
            this.Text = "Arboles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butArriba;
        private System.Windows.Forms.Button butIzq;
        private System.Windows.Forms.Button butDer;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labEstatura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Button butAddIzq;
        private System.Windows.Forms.Button butAddDer;
        private System.Windows.Forms.Button butMostrar;
    }
}

