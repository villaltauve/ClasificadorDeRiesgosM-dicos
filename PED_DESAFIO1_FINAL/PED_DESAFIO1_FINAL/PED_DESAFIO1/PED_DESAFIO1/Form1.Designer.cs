namespace PED_DESAFIO1
{
    partial class DESAFIO1_PED
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
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoSangre = new System.Windows.Forms.ComboBox();
            this.comboBoxPresion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.treeViewClasificacion = new System.Windows.Forms.TreeView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(181, 158);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(225, 24);
            this.comboBoxGenero.TabIndex = 0;
            // 
            // comboBoxTipoSangre
            // 
            this.comboBoxTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoSangre.FormattingEnabled = true;
            this.comboBoxTipoSangre.Location = new System.Drawing.Point(181, 209);
            this.comboBoxTipoSangre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoSangre.Name = "comboBoxTipoSangre";
            this.comboBoxTipoSangre.Size = new System.Drawing.Size(225, 24);
            this.comboBoxTipoSangre.TabIndex = 1;
            // 
            // comboBoxPresion
            // 
            this.comboBoxPresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPresion.FormattingEnabled = true;
            this.comboBoxPresion.Location = new System.Drawing.Point(181, 263);
            this.comboBoxPresion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPresion.Name = "comboBoxPresion";
            this.comboBoxPresion.Size = new System.Drawing.Size(225, 24);
            this.comboBoxPresion.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(132, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "REGISTRAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // treeViewClasificacion
            // 
            this.treeViewClasificacion.Location = new System.Drawing.Point(435, 143);
            this.treeViewClasificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewClasificacion.Name = "treeViewClasificacion";
            this.treeViewClasificacion.Size = new System.Drawing.Size(615, 377);
            this.treeViewClasificacion.TabIndex = 4;
            this.treeViewClasificacion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewClasificacion_AfterSelect);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(128, 428);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(181, 108);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(225, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Sangre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Presion Sanguinea:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "CLASIFICACION DE PACIENTES";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DESAFIO1_PED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.treeViewClasificacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBoxPresion);
            this.Controls.Add(this.comboBoxTipoSangre);
            this.Controls.Add(this.comboBoxGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DESAFIO1_PED";
            this.Text = "DESAFIO1_PED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxTipoSangre;
        private System.Windows.Forms.ComboBox comboBoxPresion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TreeView treeViewClasificacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

