using System;
using System.Data;
using System.Windows.Forms;

namespace MatrixProcessingApp
{
    public partial class Form1 : Form
    {
        private int N; // Size of the matrix
        private int value;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxN_TextChanged(object sender, EventArgs e)
        {
            // Set the size of the matrix and initialize DataGridView
            if (int.TryParse(txtBoxN.Text, out N) && N > 0)
            {
                InitializeMatrixGrid();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtBoxN.Text))
                    MessageBox.Show("Пожалуйста, введите корректное значение для размера матрицы.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out value))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                    MessageBox.Show("Пожалуйста, введите целое число.");
            }
        }

        private void InitializeMatrixGrid()
        {
            DataTable matr = new DataTable("Matrix");
            for (int i = 0; i < N; i++)
            {
                matr.Columns.Add(i.ToString());
            }

            // Clear existing rows if any
            matr.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                matr.Rows.Add(matr.NewRow());
            }

            dataGridViewInput.DataSource = matr;
            dataGridViewInput.AllowUserToAddRows = false; // Prevent adding new rows
            dataGridViewInput.AllowUserToDeleteRows = false; // Prevent deleting existing rows
            dataGridViewInput.RowHeadersVisible = false;       // Hide row headers
            dataGridViewInput.ColumnHeadersVisible = false;    // Hide column headers
            foreach (DataGridViewColumn column in dataGridViewInput.Columns)
            {
                column.Width = 50;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            MatrProcessor processor = new MatrProcessor(N, value);

            try
            {
                processor.GridToMatrix(dataGridViewInput);

                processor.RemoveCurrentCols();

                processor.MatrixToGrid(dataGridViewResult);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }
    }
}