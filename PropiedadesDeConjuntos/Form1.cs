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
        int relations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            DrawTable();
        }

        private void DrawTable()
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
                dvMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dvMatrix.Rows[i].HeaderCell.Value = members[i];
            }

            dvMatrix.DefaultCellStyle.Font = new Font("Arial", 18);
            dvMatrix.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18);
            dvMatrix.RowHeadersDefaultCellStyle.Font = new Font("Arial", 18);

            ShowRelationships();
        }

        private void dvMatrix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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
            }
            else
            {
                return;
            }
        }

        private void IsAntisimetric()
        {
            bool IsSimetric = false;
            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    if (i != j)
                    {
                        if (dvMatrix[j, i].Value.ToString() == "1" && dvMatrix[i, j].Value.ToString() == "1")
                        {
                            dvMatrix[j, i].Style.BackColor = Color.MistyRose;
                            dvMatrix[i, j].Style.BackColor = Color.MistyRose;
                            IsSimetric = true;
                        }
                    }
                }
            }
            if (IsSimetric)
            {
                lblAntisimetrica.Visible = false;
                lblSimetrica.Visible = true;
            }
            else
            {
                if (relations > 0)
                {
                    lblAntisimetrica.Visible = true;
                }
                lblSimetrica.Visible = false;
            }
        }

        private void ShowRelationships()
        {
            int counter = 0;
            txtRelationships.Text = "";
            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    dvMatrix[j, i].Style.BackColor = Color.White;
                    if (dvMatrix[j, i].Value.ToString() == "1")
                    {
                        txtRelationships.Text += $"({members[i]},{members[j]}), ";
                        counter++;
                    }
                }
            }
            relations = counter;
            IsTransitive();
            IsReflexive();
            IsAntisimetric();
        }

        private bool IsTransitive()
        {
            bool IsTransitive = false;

            for (int i = 0; i < dvMatrix.RowCount; i++)
            {
                for (int j = 0; j < dvMatrix.ColumnCount; j++)
                {
                    if (i != j)
                    {
                        if (dvMatrix[j, i].Value.ToString() == "1")
                        {
                            if (con(i).Any(x => con(j).Any(y => y == x)))
                            {
                                dvMatrix[j, i].Style.BackColor = Color.LightBlue;
                                dvMatrix[i, con(i).Where(x => con(j).Any(y => y == x)).First()].Style.BackColor = Color.LightBlue;
                                dvMatrix[j, con(j).Where(x => con(i).Any(y => y == x)).First()].Style.BackColor = Color.LightBlue;
                                IsTransitive = true;
                            }
                        }
                    }
                }
            }

            if (IsTransitive)
            {
                lblTransitiva.Visible = true;
            }
            else
            {
                lblTransitiva.Visible = false;
            }
            return IsTransitive;
        }

        private List<int> con(int element)
        {
            List<int> ad = new List<int>();
            for (int i = 0; i < members.Count(); i++)
            {
                if (element != i)
                {
                    if (dvMatrix[element, i].Value.ToString() == "1")
                    {
                        ad.Add(i);
                    }
                }
            }

            return ad;
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
                lblReflexiva.Visible = true;
            }
            else
            {
                lblReflexiva.Visible = false;
            }

            return IsReflexive;
        }

        private void txtMembers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                DrawTable();
                e.Handled = true;
            }
        }
    }
}
