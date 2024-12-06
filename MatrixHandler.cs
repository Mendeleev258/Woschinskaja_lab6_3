using System;
using System.Data;
using System.Windows.Forms;
namespace MatrixProcessingApp
{
    class MatrProcessor
    {
        int n_str;     
        int n_col;
        int[,] matrix; 
        int value;
        public MatrProcessor(int size, int value)
        {
            n_str = size; n_col = size;
            matrix = new int[n_str, n_col];
            this.value = value;
        }
        //заполнение матрицы из DataGridView 
        public void GridToMatrix(DataGridView dgv)
        {

            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = Int32.Parse(s);
                }
            }
        }

        public void RemoveCurrentCols()
        {

            // Проходим по всем столбцам и ищем те, которые нужно удалить
            for (int j = 0; j < n_col; j++)
            {
                bool isFound = false;

                // Проверяем, есть ли в текущем столбце заданное значение
                for (int i = 0; i < n_str; i++)
                {
                    if (matrix[i, j] == value)
                    {
                        isFound = true;
                        break; // Если нашли соответствие, выходим из цикла
                    }
                }

                // Если значение найдено, сдвигаем все последующие столбцы влево
                if (isFound)
                {
                    for (int k = j; k < n_col - 1; k++)
                    {
                        for (int i = 0; i < n_str; i++)
                        {
                            matrix[i, k] = matrix[i, k + 1]; // Сдвигаем столбцы влево
                        }
                    }
                    j--; // Уменьшаем индекс j, чтобы проверить тот же столбец снова
                    n_col--; // Уменьшаем количество столбцов
                }
            }
        }

        public void MatrixToGrid(DataGridView dgv)
        {
            //установка размеров 
            int i;
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col];
            for (i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;
            for (i = 0; i < n_col; i++)
                dgv.Columns[i].Width = 50;
            // занесение значений 
            DataGridViewCell txtCell;
            for (i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = matrix[i, j].ToString();
                }
            }
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false; dgv.ColumnHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
        }
    }
}