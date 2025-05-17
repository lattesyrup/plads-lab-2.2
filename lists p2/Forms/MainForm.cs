using Microsoft.VisualBasic;
using lists_p2.Classes;

namespace lists_p2.Forms;

public partial class MainForm : Form
{
    private readonly CycledDoubleLinkedList
        L1 = new(), L2 = new(), L3 = new();

    private readonly AboutForm AboutForm = new();

    #region form methods

    public MainForm() => InitializeComponent();

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Hide();
        AboutForm.ShowDialog();
        Show();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    => Close();

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите выйти?", "Выход",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
            e.Cancel = true;
    }

    #endregion

    #region list methods

    private void Create1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L1.Create(GetArray());
        ListBox1.Visible = true;
        Label1.Visible = true;
    }

    private void Create2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L2.Create(GetArray());
        ListBox2.Visible = true;
        Label2.Visible = true;
    }

    private void Create3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L3.Create(GetArray());
        ListBox3.Visible = true;
        Label3.Visible = true;
    }

    private void ClearAllButton_Click(object sender, EventArgs e)
    {
        DestroyFirstToolStripMenuItem_Click(sender, e);
        DestroySecondToolStripMenuItem_Click(sender, e);
        DestroyThirdToolStripMenuItem_Click(sender, e);
        DestroyChangedToolStripMenuItem_Click(sender, e);

        HideClearAllButton();
    }

    private void DestroyFirstToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L1.Destroy();
        ListBox1.Visible = false;
        Label1.Visible = false;
        ListBox1.Items.Clear();

        if (ClearAllButton.Visible) HideClearAllButton();
    }

    private void DestroySecondToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L2.Destroy();
        ListBox2.Visible = false;
        Label2.Visible = false;
        ListBox2.Items.Clear();

        if (ClearAllButton.Visible) HideClearAllButton();
    }

    private void DestroyThirdToolStripMenuItem_Click(object sender, EventArgs e)
    {
        L3.Destroy();
        ListBox3.Visible = false;
        Label3.Visible = false;
        ListBox3.Items.Clear();

        if (ClearAllButton.Visible) HideClearAllButton();
    }

    private void DestroyChangedToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ListBox1Changed.Visible = false;
        Label1Changed.Visible = false;
        ListBox1Changed.Items.Clear();
    }

    #endregion

    #region task performing

    private void TaskReplaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!(L1.IsFilled() && L2.IsFilled() && L3.IsFilled()))
            MessageBox.Show("Есть несозданные списки.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            ListBox1Changed.Visible = true;
            Label1Changed.Visible = true;

            L1.FillListBox(ListBox1);
            L2.FillListBox(ListBox2);
            L3.FillListBox(ListBox3);
            
            L1.Replace(L2, L3);
            L1.FillListBox(ListBox1Changed);

            ShowClearAllButton();
        }
    }

    private void ShowClearAllButton()
    {
        CreateToolStripMenuItem.Enabled = false;
        EditToolStripMenuItem.Enabled = false;
        TaskReplaceToolStripMenuItem.Enabled = false;
        ClearAllButton.Visible = true;
    }

    private void HideClearAllButton()
    {
        CreateToolStripMenuItem.Enabled = true;
        EditToolStripMenuItem.Enabled = true;
        TaskReplaceToolStripMenuItem.Enabled = true;
        ClearAllButton.Visible = false;
    }

    #endregion

    #region input

    private int GetNumber(string name = "число")
    {
        string result = Interaction.InputBox($"Введите {name}:", "Ввод числа");
        int number;
        while (!int.TryParse(result, out number))
        {
            MessageBox.Show("Текст не соответствует формату числа. Повторите ввод.","Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            result = Interaction.InputBox($"Введите {name}:", "Ввод числа");
        }
        return number;
    }

    private int[] GetArray()
    {
        ArrayEnterForm arrayEnter = new();
        arrayEnter.ShowDialog();
        return arrayEnter.Array;
    }

    #endregion

    #region nodes metods

    private void AddAsFirstTo1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.InsertBeforeFirst(GetNumber());
    private void AddAsFirstTo2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.InsertBeforeFirst(GetNumber());
    private void AddAsFirstTo3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.InsertBeforeFirst(GetNumber());

    private void AddAsLastTo1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.InsertAfterLast(GetNumber());
    private void AddAsLastTo2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.InsertAfterLast(GetNumber());
    private void AddAsLastTo3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.InsertAfterLast(GetNumber());

    private void AddSomewhereTo1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.InsertAt(GetNumber("èíäåêñ"), GetNumber());
    private void AddSomewhereTo2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.InsertAt(GetNumber("èíäåêñ"), GetNumber());
    private void AddSomewhereTo3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.InsertAt(GetNumber("èíäåêñ"), GetNumber());

    private void RemoveFirstIn1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.DeleteFirst();
    private void RemoveFirstIn2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.DeleteFirst();
    private void RemoveFirstIn3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.DeleteFirst();

    private void RemoveLastIn1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.DeleteLast();
    private void RemoveLastIn2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.DeleteLast();
    private void RemoveLastIn3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.DeleteLast();

    private void RemoveSomewhereIn1ToolStripMenuItem_Click(object sender, EventArgs e)
    => L1.DeleteAt(GetNumber("номер"));
    private void RemoveSomewhereIn2ToolStripMenuItem_Click(object sender, EventArgs e)
    => L2.DeleteAt(GetNumber("номер"));
    private void RemoveSomewhereIn3ToolStripMenuItem_Click(object sender, EventArgs e)
    => L3.DeleteAt(GetNumber("номер"));

    #endregion
}
