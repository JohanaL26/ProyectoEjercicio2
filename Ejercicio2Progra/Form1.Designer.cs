namespace Ejercicio2Progra
{
    partial class Form1
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListadolistBox = new System.Windows.Forms.ListBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.Color.Honeydew;
            this.NombretextBox.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombretextBox.Location = new System.Drawing.Point(226, 45);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(124, 25);
            this.NombretextBox.TabIndex = 0;
            this.NombretextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.BackColor = System.Drawing.Color.Honeydew;
            this.EdadtextBox.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EdadtextBox.Location = new System.Drawing.Point(227, 83);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(123, 25);
            this.EdadtextBox.TabIndex = 1;
            this.EdadtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(92, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(92, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la Edad";
            // 
            // ListadolistBox
            // 
            this.ListadolistBox.Enabled = false;
            this.ListadolistBox.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListadolistBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ListadolistBox.FormattingEnabled = true;
            this.ListadolistBox.ItemHeight = 18;
            this.ListadolistBox.Location = new System.Drawing.Point(173, 167);
            this.ListadolistBox.Name = "ListadolistBox";
            this.ListadolistBox.Size = new System.Drawing.Size(220, 76);
            this.ListadolistBox.TabIndex = 4;
            this.ListadolistBox.Visible = false;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackColor = System.Drawing.Color.SeaGreen;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Agregarbutton.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Agregarbutton.ForeColor = System.Drawing.Color.White;
            this.Agregarbutton.Location = new System.Drawing.Point(395, 56);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(79, 32);
            this.Agregarbutton.TabIndex = 5;
            this.Agregarbutton.Text = "AGREGAR";
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(142, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "LISTADO DE NOMBRE Y EDAD CONCATENADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(569, 270);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.ListadolistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NombretextBox;
        private TextBox EdadtextBox;
        private Label label1;
        private Label label2;
        private ListBox ListadolistBox;
        private Button Agregarbutton;
        private Label label3;
    }
}