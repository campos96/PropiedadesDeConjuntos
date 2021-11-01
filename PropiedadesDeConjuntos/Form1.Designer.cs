
namespace PropiedadesDeConjuntos
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.dvMatrix = new System.Windows.Forms.DataGridView();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRelationships = new System.Windows.Forms.TextBox();
            this.lblReflexiva = new System.Windows.Forms.Label();
            this.lblTransitiva = new System.Windows.Forms.Label();
            this.lblAntisimetrica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSimetrica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conjunto:";
            // 
            // txtMembers
            // 
            this.txtMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMembers.Location = new System.Drawing.Point(133, 18);
            this.txtMembers.Margin = new System.Windows.Forms.Padding(4);
            this.txtMembers.Multiline = true;
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(838, 32);
            this.txtMembers.TabIndex = 1;
            this.txtMembers.Text = "1,2,3,4,5,6";
            // 
            // dvMatrix
            // 
            this.dvMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMatrix.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvMatrix.Location = new System.Drawing.Point(19, 227);
            this.dvMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dvMatrix.Name = "dvMatrix";
            this.dvMatrix.ReadOnly = true;
            this.dvMatrix.RowHeadersWidth = 50;
            this.dvMatrix.Size = new System.Drawing.Size(1206, 308);
            this.dvMatrix.TabIndex = 2;
            this.dvMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellClick);
            this.dvMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellContentClick);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.BackColor = System.Drawing.Color.Black;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(991, 18);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(234, 32);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Dibujar tabla";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relaciones";
            // 
            // txtRelationships
            // 
            this.txtRelationships.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRelationships.Location = new System.Drawing.Point(133, 68);
            this.txtRelationships.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelationships.Multiline = true;
            this.txtRelationships.Name = "txtRelationships";
            this.txtRelationships.Size = new System.Drawing.Size(1092, 94);
            this.txtRelationships.TabIndex = 6;
            // 
            // lblReflexiva
            // 
            this.lblReflexiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReflexiva.BackColor = System.Drawing.Color.LightGreen;
            this.lblReflexiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflexiva.Location = new System.Drawing.Point(193, 182);
            this.lblReflexiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReflexiva.Name = "lblReflexiva";
            this.lblReflexiva.Size = new System.Drawing.Size(211, 31);
            this.lblReflexiva.TabIndex = 7;
            this.lblReflexiva.Text = "Reflexiva";
            this.lblReflexiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReflexiva.Visible = false;
            // 
            // lblTransitiva
            // 
            this.lblTransitiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTransitiva.BackColor = System.Drawing.Color.LightBlue;
            this.lblTransitiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransitiva.Location = new System.Drawing.Point(412, 182);
            this.lblTransitiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransitiva.Name = "lblTransitiva";
            this.lblTransitiva.Size = new System.Drawing.Size(211, 31);
            this.lblTransitiva.TabIndex = 8;
            this.lblTransitiva.Text = "Transitiva";
            this.lblTransitiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTransitiva.Visible = false;
            // 
            // lblAntisimetrica
            // 
            this.lblAntisimetrica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAntisimetrica.BackColor = System.Drawing.Color.Beige;
            this.lblAntisimetrica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntisimetrica.Location = new System.Drawing.Point(850, 182);
            this.lblAntisimetrica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntisimetrica.Name = "lblAntisimetrica";
            this.lblAntisimetrica.Size = new System.Drawing.Size(211, 31);
            this.lblAntisimetrica.TabIndex = 9;
            this.lblAntisimetrica.Text = "Antisimetrica";
            this.lblAntisimetrica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAntisimetrica.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 100);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Propiedades de los conjuntos";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSimetrica);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMembers);
            this.panel2.Controls.Add(this.lblAntisimetrica);
            this.panel2.Controls.Add(this.dvMatrix);
            this.panel2.Controls.Add(this.lblTransitiva);
            this.panel2.Controls.Add(this.btnAnalyze);
            this.panel2.Controls.Add(this.lblReflexiva);
            this.panel2.Controls.Add(this.txtRelationships);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 554);
            this.panel2.TabIndex = 11;
            // 
            // lblSimetrica
            // 
            this.lblSimetrica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSimetrica.BackColor = System.Drawing.Color.MistyRose;
            this.lblSimetrica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimetrica.Location = new System.Drawing.Point(631, 182);
            this.lblSimetrica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimetrica.Name = "lblSimetrica";
            this.lblSimetrica.Size = new System.Drawing.Size(211, 31);
            this.lblSimetrica.TabIndex = 10;
            this.lblSimetrica.Text = "Simetrica";
            this.lblSimetrica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSimetrica.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Propiedades de los conjuntos";
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.DataGridView dvMatrix;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRelationships;
        private System.Windows.Forms.Label lblReflexiva;
        private System.Windows.Forms.Label lblTransitiva;
        private System.Windows.Forms.Label lblAntisimetrica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSimetrica;
    }
}

