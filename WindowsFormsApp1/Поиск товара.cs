﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Поиск_товара : Form
    {
        public Поиск_товара()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView4.RowCount; i++)
                {
                    main.dataGridView4.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView4.ColumnCount; j++)
                        if (main.dataGridView4.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.dataGridView4.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
