namespace lists_p2.Forms;
#nullable disable

public partial class ArrayEnterForm : Form
{
    private int[] array;
    public int[] Array { get => array; }

    public ArrayEnterForm()
    {
        InitializeComponent();
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        bool canClose = true;

        array = new int[ArrayGrid.Rows.Count - 1];
        for (int i = 0; i < ArrayGrid.Rows.Count - 1; i++)
            if (int.TryParse(ArrayGrid.Rows[i].Cells["column"].Value.ToString(), out int res))
                array[i] = res;
            else
            {
                MessageBox.Show($"Текст в строке {i} не соответствует формату числа.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canClose = false;
            }

        if (canClose) Close();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        ArrayGrid.Rows.Clear();
    }
}
