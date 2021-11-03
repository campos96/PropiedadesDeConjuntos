
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
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.dvMatrix = new System.Windows.Forms.DataGridView();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtRelationships = new System.Windows.Forms.TextBox();
            this.lblReflexiva = new System.Windows.Forms.Label();
            this.lblTransitiva = new System.Windows.Forms.Label();
            this.lblAntisimetrica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSimetrica = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMembers
            // 
            this.txtMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMembers.Location = new System.Drawing.Point(23, 44);
            this.txtMembers.Margin = new System.Windows.Forms.Padding(4);
            this.txtMembers.Multiline = true;
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(948, 32);
            this.txtMembers.TabIndex = 1;
            this.txtMembers.Text = "1,2,3,4,5,6";
            this.txtMembers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembers_KeyPress);
            // 
            // dvMatrix
            // 
            this.dvMatrix.AllowUserToAddRows = false;
            this.dvMatrix.AllowUserToDeleteRows = false;
            this.dvMatrix.AllowUserToResizeColumns = false;
            this.dvMatrix.AllowUserToResizeRows = false;
            this.dvMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMatrix.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvMatrix.EnableHeadersVisualStyles = false;
            this.dvMatrix.Location = new System.Drawing.Point(19, 152);
            this.dvMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dvMatrix.MultiSelect = false;
            this.dvMatrix.Name = "dvMatrix";
            this.dvMatrix.ReadOnly = true;
            this.dvMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvMatrix.RowHeadersWidth = 50;
            this.dvMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvMatrix.RowTemplate.ReadOnly = true;
            this.dvMatrix.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvMatrix.ShowCellErrors = false;
            this.dvMatrix.ShowCellToolTips = false;
            this.dvMatrix.ShowEditingIcon = false;
            this.dvMatrix.ShowRowErrors = false;
            this.dvMatrix.Size = new System.Drawing.Size(1206, 338);
            this.dvMatrix.TabIndex = 2;
            this.dvMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellClick);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.BackColor = System.Drawing.Color.Black;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(991, 44);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(234, 32);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Dibujar tabla";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtRelationships
            // 
            this.txtRelationships.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRelationships.Enabled = false;
            this.txtRelationships.Location = new System.Drawing.Point(19, 519);
            this.txtRelationships.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelationships.Multiline = true;
            this.txtRelationships.Name = "txtRelationships";
            this.txtRelationships.Size = new System.Drawing.Size(1206, 64);
            this.txtRelationships.TabIndex = 6;
            // 
            // lblReflexiva
            // 
            this.lblReflexiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReflexiva.BackColor = System.Drawing.Color.LightGreen;
            this.lblReflexiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReflexiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflexiva.Location = new System.Drawing.Point(192, 86);
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
            this.lblTransitiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransitiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransitiva.Location = new System.Drawing.Point(411, 86);
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
            this.lblAntisimetrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntisimetrica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntisimetrica.Location = new System.Drawing.Point(849, 86);
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
            this.panel1.Size = new System.Drawing.Size(1267, 58);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 9);
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblSimetrica);
            this.panel2.Controls.Add(this.txtMembers);
            this.panel2.Controls.Add(this.lblAntisimetrica);
            this.panel2.Controls.Add(this.dvMatrix);
            this.panel2.Controls.Add(this.lblTransitiva);
            this.panel2.Controls.Add(this.btnAnalyze);
            this.panel2.Controls.Add(this.lblReflexiva);
            this.panel2.Controls.Add(this.txtRelationships);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 599);
            this.panel2.TabIndex = 11;
            // 
            // lblSimetrica
            // 
            this.lblSimetrica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSimetrica.BackColor = System.Drawing.Color.MistyRose;
            this.lblSimetrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSimetrica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimetrica.Location = new System.Drawing.Point(630, 86);
            this.lblSimetrica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimetrica.Name = "lblSimetrica";
            this.lblSimetrica.Size = new System.Drawing.Size(211, 31);
            this.lblSimetrica.TabIndex = 10;
            this.lblSimetrica.Text = "Simetrica";
            this.lblSimetrica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSimetrica.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "1.- Ingresa el conjunto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(987, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "2.- Genera la tabla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "3.- Da click en la tabla para generar los pares.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 494);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "2.- Pares generados";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Simetrica";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(849, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Antisimetrica";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Transitiva";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "Reflexiva";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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
        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtRelationships;
        private System.Windows.Forms.Label lblReflexiva;
        private System.Windows.Forms.Label lblTransitiva;
        private System.Windows.Forms.Label lblAntisimetrica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSimetrica;
        private System.Windows.Forms.DataGridView dvMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

