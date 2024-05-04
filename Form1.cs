using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSFDSF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            int[,] aMatrix = {
                //0  1  2  3  4  5  6
                { 0, 0, 1, 0, 1, 0, 0},//0
                { 0, 0, 1, 0, 0, 0, 0},//1
                { 1, 1, 0, 1, 0, 0, 0},//2
                { 0, 0, 1, 0, 0, 0, 0},//3
                { 1, 0, 0, 0, 0, 1, 1},//4
                { 0, 0, 0, 0, 1, 0, 0},//5
                { 0, 0, 0, 0, 1, 0, 0} //6
            };
            dgv.ColumnCount = aMatrix.GetLength(0);
            dgv.RowCount = aMatrix.GetLength(1);



            for (int i=0; i<aMatrix.GetLength(0); i++)
            {
                dgv.Columns[i].Width = 40;

                for (int j=0; j<aMatrix.GetLength(1); j++) 
                {
                    dgv.Rows[i].Cells[j].Value = aMatrix[i,j];
                }  
            }
            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            var g = new Graph();

            int[,] aMatrix = new int[dgv.ColumnCount, dgv.ColumnCount];

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 40;

                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value!=null)
                     aMatrix[i, j] = int.Parse(dgv.Rows[i].Cells[j].Value.ToString());
                }
            }

            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                g.AddVertex(Convert.ToString(i));
            }
            for (int i = 0; i < aMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < aMatrix.GetLength(1); j++)
                {
                    if (aMatrix[i, j] != 0)
                        g.AddEdge(Convert.ToString(i), Convert.ToString(j), aMatrix[i, j]);
                }
            }

            var dijkstra = new Dijkstra(g);
            var bfs = new BFS(g);
            var dfs = new DFS(g);

            string first = num_first.Value.ToString();
            string end = num_end.Value.ToString();

            var path = dijkstra.FindShortestPath(first, end);
            var path_bfs = bfs.FindAllPaths("0");
            var path_dfs = dfs.FindAllPaths("0");

            lb2.Text = "";
            lb2.Text=($"Dijkstra:    {path}");

            lb.Text = "";
            lb.Text+=($"BFS:    {path_bfs}\n");
            lb.Text += ($"DFS:    {path_dfs}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount > 1)
            {
                int lastRowIndex = dgv.Rows.Count - 2;
                int lastColumnIndex = dgv.Columns.Count - 2;
                dgv.Rows.RemoveAt(lastRowIndex);
                dgv.Columns.RemoveAt(lastColumnIndex);
                num_first.Maximum = dgv.Rows.Count;
                num_end.Maximum = dgv.Rows.Count;
            }
            else
            {

            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создать новую строку и столбец
            DataGridViewRow newRow = new DataGridViewRow();
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Width = 40;
            // Добавить строку и столбец в DataGridView
            dgv.Rows.Add(newRow);
            dgv.Columns.Add(newColumn);
            num_first.Maximum = dgv.Rows.Count;
            num_end.Maximum = dgv.Rows.Count;
        }


    }
}
