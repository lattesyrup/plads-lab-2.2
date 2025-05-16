namespace lists_p2.Forms;

partial class ArrayEnterForm
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
        label = new Label();
        ConfirmButton = new Button();
        ArrayGrid = new DataGridView();
        column = new DataGridViewTextBoxColumn();
        ResetButton = new Button();
        ((System.ComponentModel.ISupportInitialize)ArrayGrid).BeginInit();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Location = new Point(12, 9);
        label.Name = "label";
        label.Size = new Size(166, 20);
        label.TabIndex = 0;
        label.Text = "Введите массив чисел:";
        // 
        // ConfirmButton
        // 
        ConfirmButton.Location = new Point(222, 226);
        ConfirmButton.Name = "ConfirmButton";
        ConfirmButton.Size = new Size(94, 29);
        ConfirmButton.TabIndex = 2;
        ConfirmButton.Text = "Ввести";
        ConfirmButton.UseVisualStyleBackColor = true;
        ConfirmButton.Click += ConfirmButton_Click;
        // 
        // ArrayGrid
        // 
        ArrayGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ArrayGrid.Columns.AddRange(new DataGridViewColumn[] { column });
        ArrayGrid.Location = new Point(16, 32);
        ArrayGrid.Name = "ArrayGrid";
        ArrayGrid.RowHeadersWidth = 51;
        ArrayGrid.Size = new Size(300, 188);
        ArrayGrid.TabIndex = 3;
        // 
        // column
        // 
        column.HeaderText = "Массив";
        column.MinimumWidth = 6;
        column.Name = "column";
        column.Width = 125;
        // 
        // ResetButton
        // 
        ResetButton.Location = new Point(16, 226);
        ResetButton.Name = "ResetButton";
        ResetButton.Size = new Size(94, 29);
        ResetButton.TabIndex = 4;
        ResetButton.Text = "Заново";
        ResetButton.UseVisualStyleBackColor = true;
        ResetButton.Click += ResetButton_Click;
        // 
        // ArrayEnterForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(338, 296);
        Controls.Add(ResetButton);
        Controls.Add(ArrayGrid);
        Controls.Add(ConfirmButton);
        Controls.Add(label);
        Name = "ArrayEnterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ввод массива чисел";
        ((System.ComponentModel.ISupportInitialize)ArrayGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label;
    private Button ConfirmButton;
    private DataGridView ArrayGrid;
    private DataGridViewTextBoxColumn column;
    private Button ResetButton;
}