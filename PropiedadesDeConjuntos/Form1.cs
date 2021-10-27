using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropiedadesDeConjuntos
{
    public partial class Form1 : Form
    {
        string[] members;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            members = txtMembers.Text.Split(',');

            dvMatrix.RowCount = members.Count();
            dvMatrix.ColumnCount = members.Count();

            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    dvMatrix[j, i].Value = 0;
                }
            }

            for (int i = 0; i < members.Count(); i++)
            {
                dvMatrix.Columns[i].HeaderText = members[i];
                dvMatrix.Rows[i].HeaderCell.Value = members[i];
            }

            ShowRelationships();
        }

        private void dvMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvMatrix_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dvMatrix[e.ColumnIndex, e.RowIndex].Value.ToString() == "0")
            {
                dvMatrix[e.ColumnIndex, e.RowIndex].Value = 1;
            }
            else
            {
                dvMatrix[e.ColumnIndex, e.RowIndex].Value = 0;
            }

            ShowRelationships();
            IsReflexive();
        }

        private void ShowRelationships()
        {
            txtRelationships.Text = "";
            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    if (dvMatrix[j, i].Value.ToString() == "1")
                    {
                        txtRelationships.Text += $"({members[i]},{members[j]}), ";
                    }
                }
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (IsReflexive())
            {
                MessageBox.Show("Es reflexiva");
            }
            else
            {
                MessageBox.Show("No es reflexiva");
            }
        }

        private bool IsTransitive()
        {
            bool IsTransitive = true;


            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    if (i != j)
                    {
                        if (dvMatrix[j, i].Value.ToString() == "1")
                        {
                            
                        }
                    }
                }
            }
            return IsTransitive;
        }

        private int con(int element)
        {
            for (int i = 0; i < members.Count(); i++)
            {
                if (dvMatrix[element, i].Value.ToString() == "1")
                {
                    //ok = true;
                }
            }
            return 0;
        }

        private bool IsReflexive()
        {
            bool IsReflexive = true;
            if (dvMatrix.RowCount > 0)
            {
                for (int i = 0; i < dvMatrix.RowCount; i++)
                {
                    if (dvMatrix[i, i].Value.ToString() == "0")
                    {
                        IsReflexive = false;
                    }
                }
            }

            if (IsReflexive)
            {
                for (int i = 0; i < dvMatrix.RowCount; i++)
                {
                    dvMatrix[i, i].Style.BackColor = Color.LightGreen;
                }
            }
            else
            {
                for (int i = 0; i < dvMatrix.RowCount; i++)
                {
                    dvMatrix[i, i].Style.BackColor = Color.White;
                }
            }

            return IsReflexive;
        }
    }
}
