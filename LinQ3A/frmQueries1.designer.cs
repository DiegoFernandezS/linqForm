namespace EjemplosWin
{
    partial class frmQueries1
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
            this.grvResultados = new System.Windows.Forms.DataGridView();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // grvResultados
            // 
            this.grvResultados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvResultados.Location = new System.Drawing.Point(12, 12);
            this.grvResultados.Name = "grvResultados";
            this.grvResultados.Size = new System.Drawing.Size(694, 316);
            this.grvResultados.TabIndex = 0;
            // 
            // btnQuery1
            // 
            this.btnQuery1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuery1.Location = new System.Drawing.Point(572, 343);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(134, 57);
            this.btnQuery1.TabIndex = 1;
            this.btnQuery1.Text = "Ver todos los datos";
            this.btnQuery1.UseVisualStyleBackColor = false;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(432, 343);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(134, 58);
            this.btnQuery2.TabIndex = 1;
            this.btnQuery2.Text = "Ver a todos listados por nombre";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Location = new System.Drawing.Point(292, 343);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(134, 57);
            this.btnQuery3.TabIndex = 1;
            this.btnQuery3.Text = "Ver id Listado por nombre de forma descendente";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Location = new System.Drawing.Point(12, 342);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(134, 58);
            this.btnQuery4.TabIndex = 1;
            this.btnQuery4.Text = "Ver nombre y Salario ordenado por salario de forma descendente";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver empleados con salarios entre 50000 y 80000";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // frmQueries1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.grvResultados);
            this.Name = "frmQueries1";
            this.Text = "Queries 1";
            this.Load += new System.EventHandler(this.frmQueries1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvResultados;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button button1;
    }
}