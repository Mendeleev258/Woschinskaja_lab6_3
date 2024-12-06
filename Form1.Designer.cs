namespace MatrixProcessingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxN
            // 
            this.txtBoxN.Location = new System.Drawing.Point(12, 25);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(49, 20);
            this.txtBoxN.TabIndex = 0;
            this.txtBoxN.TextChanged += new System.EventHandler(this.txtBoxN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(45, 88);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(344, 306);
            this.dataGridViewInput.TabIndex = 2;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(482, 88);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(341, 306);
            this.dataGridViewResult.TabIndex = 3;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(131, 22);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(134, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Обработать матрицу";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxN);
            this.Name = "Form1";
            this.Text = "Matrix Processing App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}