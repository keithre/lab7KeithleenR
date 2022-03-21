
namespace lab7KeithleenR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMam = new System.Windows.Forms.Button();
            this.btnMostrarMayor = new System.Windows.Forms.Button();
            this.labelM = new System.Windows.Forms.Label();
            this.labelme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(401, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(58, 267);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 55);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Enabled = false;
            this.btnOrdenar.Location = new System.Drawing.Point(236, 267);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(145, 55);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMam
            // 
            this.btnMam.Enabled = false;
            this.btnMam.Location = new System.Drawing.Point(424, 267);
            this.btnMam.Name = "btnMam";
            this.btnMam.Size = new System.Drawing.Size(133, 55);
            this.btnMam.TabIndex = 6;
            this.btnMam.Text = "Mostrar de Mayor a menor";
            this.btnMam.UseVisualStyleBackColor = true;
            this.btnMam.Click += new System.EventHandler(this.btnMam_Click);
            // 
            // btnMostrarMayor
            // 
            this.btnMostrarMayor.Enabled = false;
            this.btnMostrarMayor.Location = new System.Drawing.Point(601, 267);
            this.btnMostrarMayor.Name = "btnMostrarMayor";
            this.btnMostrarMayor.Size = new System.Drawing.Size(129, 55);
            this.btnMostrarMayor.TabIndex = 7;
            this.btnMostrarMayor.Text = "Mostar Cuota mas alta";
            this.btnMostrarMayor.UseVisualStyleBackColor = true;
            this.btnMostrarMayor.Click += new System.EventHandler(this.btnMostrarMayor_Click);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(658, 89);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(0, 15);
            this.labelM.TabIndex = 3;
            // 
            // labelme
            // 
            this.labelme.AutoSize = true;
            this.labelme.Location = new System.Drawing.Point(658, 136);
            this.labelme.Name = "labelme";
            this.labelme.Size = new System.Drawing.Size(0, 15);
            this.labelme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propietario:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mayor";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menor";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarMayor);
            this.Controls.Add(this.btnMam);
            this.Controls.Add(this.labelme);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMam;
        private System.Windows.Forms.Button btnMostrarMayor;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

