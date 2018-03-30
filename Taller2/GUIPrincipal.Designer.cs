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
            this.rbtArbol = new System.Windows.Forms.RichTextBox();
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
            this.butModificar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtArbol
            // 
            this.rbtArbol.Location = new System.Drawing.Point(254, 23);
            this.rbtArbol.Name = "rbtArbol";
            this.rbtArbol.Size = new System.Drawing.Size(234, 91);
            this.rbtArbol.TabIndex = 2;
            this.rbtArbol.Text = "";
            // 
            // butArriba
            // 
            this.butArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butArriba.Location = new System.Drawing.Point(346, 138);
            this.butArriba.Name = "butArriba";
            this.butArriba.Size = new System.Drawing.Size(47, 23);
            this.butArriba.TabIndex = 8;
            this.butArriba.Text = "^";
            this.butArriba.UseVisualStyleBackColor = true;
            // 
            // butIzq
            // 
            this.butIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIzq.Location = new System.Drawing.Point(299, 167);
            this.butIzq.Name = "butIzq";
            this.butIzq.Size = new System.Drawing.Size(47, 23);
            this.butIzq.TabIndex = 9;
            this.butIzq.Text = "<";
            this.butIzq.UseVisualStyleBackColor = true;
            // 
            // butDer
            // 
            this.butDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDer.Location = new System.Drawing.Point(393, 167);
            this.butDer.Name = "butDer";
            this.butDer.Size = new System.Drawing.Size(47, 23);
            this.butDer.TabIndex = 10;
            this.butDer.Text = ">";
            this.butDer.UseVisualStyleBackColor = true;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(30, 31);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 11;
            this.labNombre.Text = "Nombre:";
            // 
            // labEstatura
            // 
            this.labEstatura.AutoSize = true;
            this.labEstatura.Location = new System.Drawing.Point(30, 67);
            this.labEstatura.Name = "labEstatura";
            this.labEstatura.Size = new System.Drawing.Size(49, 13);
            this.labEstatura.TabIndex = 12;
            this.labEstatura.Text = "Estatura:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(106, 64);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(100, 20);
            this.txtEstatura.TabIndex = 1;
            // 
            // butAddIzq
            // 
            this.butAddIzq.Location = new System.Drawing.Point(129, 108);
            this.butAddIzq.Name = "butAddIzq";
            this.butAddIzq.Size = new System.Drawing.Size(98, 23);
            this.butAddIzq.TabIndex = 4;
            this.butAddIzq.Text = "Agregar Izquierda";
            this.butAddIzq.UseVisualStyleBackColor = true;
            // 
            // butAddDer
            // 
            this.butAddDer.Location = new System.Drawing.Point(25, 108);
            this.butAddDer.Name = "butAddDer";
            this.butAddDer.Size = new System.Drawing.Size(98, 23);
            this.butAddDer.TabIndex = 3;
            this.butAddDer.Text = "Agregar Derecha";
            this.butAddDer.UseVisualStyleBackColor = true;
            this.butAddDer.Click += new System.EventHandler(this.butAddDer_Click);
            // 
            // butMostrar
            // 
            this.butMostrar.Location = new System.Drawing.Point(74, 167);
            this.butMostrar.Name = "butMostrar";
            this.butMostrar.Size = new System.Drawing.Size(98, 23);
            this.butMostrar.TabIndex = 7;
            this.butMostrar.Text = "Mostrar";
            this.butMostrar.UseVisualStyleBackColor = true;
            this.butMostrar.Click += new System.EventHandler(this.butMostrar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(25, 138);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(98, 23);
            this.butModificar.TabIndex = 5;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(129, 138);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(98, 23);
            this.butEliminar.TabIndex = 6;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(510, 207);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
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
            this.Controls.Add(this.rbtArbol);
            this.Name = "GUIPrincipal";
            this.Text = "Arboles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbtArbol;
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
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butEliminar;
    }
}

