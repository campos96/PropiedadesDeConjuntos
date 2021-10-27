
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.dvMatrix = new System.Windows.Forms.DataGridView();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRelationships = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conjunto:";
            // 
            // txtMembers
            // 
            this.txtMembers.Location = new System.Drawing.Point(132, 30);
            this.txtMembers.Margin = new System.Windows.Forms.Padding(4);
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(541, 26);
            this.txtMembers.TabIndex = 1;
            this.txtMembers.Text = "1,2,3,4,5,6";
            // 
            // dvMatrix
            // 
            this.dvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvMatrix.Location = new System.Drawing.Point(28, 126);
            this.dvMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dvMatrix.Name = "dvMatrix";
            this.dvMatrix.ReadOnly = true;
            this.dvMatrix.RowHeadersWidth = 50;
            this.dvMatrix.Size = new System.Drawing.Size(956, 460);
            this.dvMatrix.TabIndex = 2;
            this.dvMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellClick);
            this.dvMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellContentClick);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(750, 26);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(234, 32);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "button1";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(750, 594);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(234, 32);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "button1";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relaciones";
            // 
            // txtRelationships
            // 
            this.txtRelationships.Location = new System.Drawing.Point(132, 74);
            this.txtRelationships.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelationships.Name = "txtRelationships";
            this.txtRelationships.Size = new System.Drawing.Size(852, 26);
            this.txtRelationships.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 666);
            this.Controls.Add(this.txtRelationships);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.dvMatrix);
            this.Controls.Add(this.txtMembers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.DataGridView dvMatrix;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRelationships;
    }
}

