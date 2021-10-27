
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.dvMatrix = new System.Windows.Forms.DataGridView();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conjunto:";
            // 
            // txtMembers
            // 
            this.txtMembers.Location = new System.Drawing.Point(106, 27);
            this.txtMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(148, 26);
            this.txtMembers.TabIndex = 1;
            this.txtMembers.Text = "1,2,3,4,5,6";
            // 
            // dvMatrix
            // 
            this.dvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMatrix.Location = new System.Drawing.Point(28, 63);
            this.dvMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvMatrix.Name = "dvMatrix";
            this.dvMatrix.ReadOnly = true;
            this.dvMatrix.Size = new System.Drawing.Size(956, 429);
            this.dvMatrix.TabIndex = 2;
            this.dvMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellClick);
            this.dvMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMatrix_CellContentClick);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(271, 23);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(234, 32);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "button1";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(28, 512);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(234, 32);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "button1";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 587);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.dvMatrix);
            this.Controls.Add(this.txtMembers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

