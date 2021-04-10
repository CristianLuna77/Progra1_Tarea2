
namespace Arreglos
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNames = new System.Windows.Forms.Button();
            this.buttonPromGeneral = new System.Windows.Forms.Button();
            this.buttonPromParcial1 = new System.Windows.Forms.Button();
            this.buttonPromPacial2 = new System.Windows.Forms.Button();
            this.buttonPromParcial3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDATOSTOTAL = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(12, 12);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(51, 25);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arrgelo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Visible = false;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(3, 7);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(60, 30);
            this.listBoxResultado.TabIndex = 1;
            this.listBoxResultado.Visible = false;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(12, 12);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(399, 314);
            this.textBoxResultado.TabIndex = 2;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(22, 346);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(145, 51);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNames
            // 
            this.buttonNames.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNames.Location = new System.Drawing.Point(581, 254);
            this.buttonNames.Name = "buttonNames";
            this.buttonNames.Size = new System.Drawing.Size(120, 52);
            this.buttonNames.TabIndex = 4;
            this.buttonNames.Text = "Nombres";
            this.buttonNames.UseVisualStyleBackColor = true;
            this.buttonNames.Click += new System.EventHandler(this.buttonNames_Click);
            // 
            // buttonPromGeneral
            // 
            this.buttonPromGeneral.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromGeneral.Location = new System.Drawing.Point(716, 251);
            this.buttonPromGeneral.Name = "buttonPromGeneral";
            this.buttonPromGeneral.Size = new System.Drawing.Size(112, 60);
            this.buttonPromGeneral.TabIndex = 6;
            this.buttonPromGeneral.Text = "Promedio General";
            this.buttonPromGeneral.UseVisualStyleBackColor = true;
            this.buttonPromGeneral.Click += new System.EventHandler(this.buttonPromGeneral_Click);
            // 
            // buttonPromParcial1
            // 
            this.buttonPromParcial1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromParcial1.Location = new System.Drawing.Point(491, 364);
            this.buttonPromParcial1.Name = "buttonPromParcial1";
            this.buttonPromParcial1.Size = new System.Drawing.Size(124, 74);
            this.buttonPromParcial1.TabIndex = 7;
            this.buttonPromParcial1.Text = "Promedio Parcial 1";
            this.buttonPromParcial1.UseVisualStyleBackColor = true;
            this.buttonPromParcial1.Click += new System.EventHandler(this.buttonPromParcial1_Click);
            // 
            // buttonPromPacial2
            // 
            this.buttonPromPacial2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromPacial2.Location = new System.Drawing.Point(621, 334);
            this.buttonPromPacial2.Name = "buttonPromPacial2";
            this.buttonPromPacial2.Size = new System.Drawing.Size(124, 74);
            this.buttonPromPacial2.TabIndex = 9;
            this.buttonPromPacial2.Text = "Promedio Parcial 2";
            this.buttonPromPacial2.UseVisualStyleBackColor = true;
            this.buttonPromPacial2.Click += new System.EventHandler(this.buttonPromPacial2_Click);
            // 
            // buttonPromParcial3
            // 
            this.buttonPromParcial3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromParcial3.Location = new System.Drawing.Point(751, 364);
            this.buttonPromParcial3.Name = "buttonPromParcial3";
            this.buttonPromParcial3.Size = new System.Drawing.Size(124, 74);
            this.buttonPromParcial3.TabIndex = 10;
            this.buttonPromParcial3.Text = "Promedio Parcial 3";
            this.buttonPromParcial3.UseVisualStyleBackColor = true;
            this.buttonPromParcial3.Click += new System.EventHandler(this.buttonPromParcial3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(540, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "¿Que deseas cargar?";
            // 
            // listBoxDATOSTOTAL
            // 
            this.listBoxDATOSTOTAL.FormattingEnabled = true;
            this.listBoxDATOSTOTAL.Location = new System.Drawing.Point(456, 40);
            this.listBoxDATOSTOTAL.Name = "listBoxDATOSTOTAL";
            this.listBoxDATOSTOTAL.Size = new System.Drawing.Size(418, 186);
            this.listBoxDATOSTOTAL.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.listBoxDATOSTOTAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPromParcial3);
            this.Controls.Add(this.buttonPromPacial2);
            this.Controls.Add(this.buttonPromParcial1);
            this.Controls.Add(this.buttonPromGeneral);
            this.Controls.Add(this.buttonNames);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNames;
        private System.Windows.Forms.Button buttonPromGeneral;
        private System.Windows.Forms.Button buttonPromParcial1;
        private System.Windows.Forms.Button buttonPromPacial2;
        private System.Windows.Forms.Button buttonPromParcial3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDATOSTOTAL;
    }
}

