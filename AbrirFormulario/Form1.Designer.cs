﻿namespace AbrirFormulario
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrirFormulario = new Button();
            SuspendLayout();
            // 
            // btnAbrirFormulario
            // 
            btnAbrirFormulario.Location = new Point(276, 142);
            btnAbrirFormulario.Name = "btnAbrirFormulario";
            btnAbrirFormulario.Size = new Size(226, 88);
            btnAbrirFormulario.TabIndex = 0;
            btnAbrirFormulario.Text = "Abrir Formulario";
            btnAbrirFormulario.UseVisualStyleBackColor = true;
            btnAbrirFormulario.Click += btnAbrirFormulario_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirFormulario);
            Name = "FormularioPrincipal";
            Text = "formularioPrincipal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirFormulario;
    }
}
