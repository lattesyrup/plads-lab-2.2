namespace lists_p2.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ms = new MenuStrip();
        TaskToolStripMenuItem = new ToolStripMenuItem();
        CreateToolStripMenuItem = new ToolStripMenuItem();
        Create1ToolStripMenuItem = new ToolStripMenuItem();
        Create2ToolStripMenuItem = new ToolStripMenuItem();
        Create3ToolStripMenuItem = new ToolStripMenuItem();
        EditToolStripMenuItem = new ToolStripMenuItem();
        AddToolStripMenuItem = new ToolStripMenuItem();
        AddAsFirstToolStripMenuItem = new ToolStripMenuItem();
        AddAsFirstTo1ToolStripMenuItem = new ToolStripMenuItem();
        AddAsFirstTo2ToolStripMenuItem = new ToolStripMenuItem();
        AddAsFirstTo3ToolStripMenuItem = new ToolStripMenuItem();
        AddAsLastToolStripMenuItem = new ToolStripMenuItem();
        AddAsLastTo1ToolStripMenuItem = new ToolStripMenuItem();
        AddAsLastTo2ToolStripMenuItem = new ToolStripMenuItem();
        AddAsLastTo3ToolStripMenuItem = new ToolStripMenuItem();
        AddSomewhereToolStripMenuItem = new ToolStripMenuItem();
        AddSomewhereTo1ToolStripMenuItem = new ToolStripMenuItem();
        AddSomewhereTo2ToolStripMenuItem = new ToolStripMenuItem();
        AddSomewhereTo3ToolStripMenuItem = new ToolStripMenuItem();
        RemoveToolStripMenuItem = new ToolStripMenuItem();
        RemoveFirstToolStripMenuItem = new ToolStripMenuItem();
        RemoveFirstIn1ToolStripMenuItem = new ToolStripMenuItem();
        RemoveFirstIn2ToolStripMenuItem = new ToolStripMenuItem();
        RemoveFirstIn3ToolStripMenuItem = new ToolStripMenuItem();
        RemoveLastToolStripMenuItem = new ToolStripMenuItem();
        RemoveLastIn1ToolStripMenuItem = new ToolStripMenuItem();
        RemoveLastIn2ToolStripMenuItem = new ToolStripMenuItem();
        RemoveLastIn3ToolStripMenuItem = new ToolStripMenuItem();
        RemoveSomewhereToolStripMenuItem = new ToolStripMenuItem();
        RemoveSomewhereIn1ToolStripMenuItem = new ToolStripMenuItem();
        RemoveSomewhereIn2ToolStripMenuItem = new ToolStripMenuItem();
        RemoveSomewhereIn3ToolStripMenuItem = new ToolStripMenuItem();
        TaskReplaceToolStripMenuItem = new ToolStripMenuItem();
        DestroyToolStripMenuItem = new ToolStripMenuItem();
        DestroyFirstToolStripMenuItem = new ToolStripMenuItem();
        DestroySecondToolStripMenuItem = new ToolStripMenuItem();
        DestroyThirdToolStripMenuItem = new ToolStripMenuItem();
        AboutToolStripMenuItem = new ToolStripMenuItem();
        ExitToolStripMenuItem = new ToolStripMenuItem();
        ListBox1 = new ListBox();
        ListBox2 = new ListBox();
        ListBox3 = new ListBox();
        ListBox1Changed = new ListBox();
        Label1 = new Label();
        Label2 = new Label();
        Label3 = new Label();
        Label1Changed = new Label();
        ClearAllButton = new Button();
        ms.SuspendLayout();
        SuspendLayout();
        // 
        // ms
        // 
        ms.ImageScalingSize = new Size(20, 20);
        ms.Items.AddRange(new ToolStripItem[] { TaskToolStripMenuItem, AboutToolStripMenuItem, ExitToolStripMenuItem });
        ms.Location = new Point(0, 0);
        ms.Name = "ms";
        ms.Size = new Size(647, 28);
        ms.TabIndex = 0;
        ms.Text = "menuStrip1";
        // 
        // TaskToolStripMenuItem
        // 
        TaskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, EditToolStripMenuItem, TaskReplaceToolStripMenuItem, DestroyToolStripMenuItem });
        TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
        TaskToolStripMenuItem.Size = new Size(81, 24);
        TaskToolStripMenuItem.Text = "Задание";
        // 
        // CreateToolStripMenuItem
        // 
        CreateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Create1ToolStripMenuItem, Create2ToolStripMenuItem, Create3ToolStripMenuItem });
        CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
        CreateToolStripMenuItem.Size = new Size(257, 26);
        CreateToolStripMenuItem.Text = "Создание списка";
        // 
        // Create1ToolStripMenuItem
        // 
        Create1ToolStripMenuItem.Name = "Create1ToolStripMenuItem";
        Create1ToolStripMenuItem.Size = new Size(205, 26);
        Create1ToolStripMenuItem.Text = "Первого списка";
        Create1ToolStripMenuItem.Click += Create1ToolStripMenuItem_Click;
        // 
        // Create2ToolStripMenuItem
        // 
        Create2ToolStripMenuItem.Name = "Create2ToolStripMenuItem";
        Create2ToolStripMenuItem.Size = new Size(205, 26);
        Create2ToolStripMenuItem.Text = "Второго списка";
        Create2ToolStripMenuItem.Click += Create2ToolStripMenuItem_Click;
        // 
        // Create3ToolStripMenuItem
        // 
        Create3ToolStripMenuItem.Name = "Create3ToolStripMenuItem";
        Create3ToolStripMenuItem.Size = new Size(205, 26);
        Create3ToolStripMenuItem.Text = "Третьего списка";
        Create3ToolStripMenuItem.Click += Create3ToolStripMenuItem_Click;
        // 
        // EditToolStripMenuItem
        // 
        EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddToolStripMenuItem, RemoveToolStripMenuItem });
        EditToolStripMenuItem.Name = "EditToolStripMenuItem";
        EditToolStripMenuItem.Size = new Size(257, 26);
        EditToolStripMenuItem.Text = "Редактирование списка";
        // 
        // AddToolStripMenuItem
        // 
        AddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAsFirstToolStripMenuItem, AddAsLastToolStripMenuItem, AddSomewhereToolStripMenuItem });
        AddToolStripMenuItem.Name = "AddToolStripMenuItem";
        AddToolStripMenuItem.Size = new Size(247, 26);
        AddToolStripMenuItem.Text = "Добавление элемента";
        // 
        // AddAsFirstToolStripMenuItem
        // 
        AddAsFirstToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAsFirstTo1ToolStripMenuItem, AddAsFirstTo2ToolStripMenuItem, AddAsFirstTo3ToolStripMenuItem });
        AddAsFirstToolStripMenuItem.Name = "AddAsFirstToolStripMenuItem";
        AddAsFirstToolStripMenuItem.Size = new Size(209, 26);
        AddAsFirstToolStripMenuItem.Text = "В начало";
        // 
        // AddAsFirstTo1ToolStripMenuItem
        // 
        AddAsFirstTo1ToolStripMenuItem.Name = "AddAsFirstTo1ToolStripMenuItem";
        AddAsFirstTo1ToolStripMenuItem.Size = new Size(205, 26);
        AddAsFirstTo1ToolStripMenuItem.Text = "Первого списка";
        AddAsFirstTo1ToolStripMenuItem.Click += AddAsFirstTo1ToolStripMenuItem_Click;
        // 
        // AddAsFirstTo2ToolStripMenuItem
        // 
        AddAsFirstTo2ToolStripMenuItem.Name = "AddAsFirstTo2ToolStripMenuItem";
        AddAsFirstTo2ToolStripMenuItem.Size = new Size(205, 26);
        AddAsFirstTo2ToolStripMenuItem.Text = "Второго списка";
        AddAsFirstTo2ToolStripMenuItem.Click += AddAsFirstTo2ToolStripMenuItem_Click;
        // 
        // AddAsFirstTo3ToolStripMenuItem
        // 
        AddAsFirstTo3ToolStripMenuItem.Name = "AddAsFirstTo3ToolStripMenuItem";
        AddAsFirstTo3ToolStripMenuItem.Size = new Size(205, 26);
        AddAsFirstTo3ToolStripMenuItem.Text = "Третьего списка";
        AddAsFirstTo3ToolStripMenuItem.Click += AddAsFirstTo3ToolStripMenuItem_Click;
        // 
        // AddAsLastToolStripMenuItem
        // 
        AddAsLastToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAsLastTo1ToolStripMenuItem, AddAsLastTo2ToolStripMenuItem, AddAsLastTo3ToolStripMenuItem });
        AddAsLastToolStripMenuItem.Name = "AddAsLastToolStripMenuItem";
        AddAsLastToolStripMenuItem.Size = new Size(209, 26);
        AddAsLastToolStripMenuItem.Text = "В конец";
        // 
        // AddAsLastTo1ToolStripMenuItem
        // 
        AddAsLastTo1ToolStripMenuItem.Name = "AddAsLastTo1ToolStripMenuItem";
        AddAsLastTo1ToolStripMenuItem.Size = new Size(205, 26);
        AddAsLastTo1ToolStripMenuItem.Text = "Первого списка";
        AddAsLastTo1ToolStripMenuItem.Click += AddAsLastTo1ToolStripMenuItem_Click;
        // 
        // AddAsLastTo2ToolStripMenuItem
        // 
        AddAsLastTo2ToolStripMenuItem.Name = "AddAsLastTo2ToolStripMenuItem";
        AddAsLastTo2ToolStripMenuItem.Size = new Size(205, 26);
        AddAsLastTo2ToolStripMenuItem.Text = "Второго списка";
        AddAsLastTo2ToolStripMenuItem.Click += AddAsLastTo2ToolStripMenuItem_Click;
        // 
        // AddAsLastTo3ToolStripMenuItem
        // 
        AddAsLastTo3ToolStripMenuItem.Name = "AddAsLastTo3ToolStripMenuItem";
        AddAsLastTo3ToolStripMenuItem.Size = new Size(205, 26);
        AddAsLastTo3ToolStripMenuItem.Text = "Третьего списка";
        AddAsLastTo3ToolStripMenuItem.Click += AddAsLastTo3ToolStripMenuItem_Click;
        // 
        // AddSomewhereToolStripMenuItem
        // 
        AddSomewhereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddSomewhereTo1ToolStripMenuItem, AddSomewhereTo2ToolStripMenuItem, AddSomewhereTo3ToolStripMenuItem });
        AddSomewhereToolStripMenuItem.Name = "AddSomewhereToolStripMenuItem";
        AddSomewhereToolStripMenuItem.Size = new Size(209, 26);
        AddSomewhereToolStripMenuItem.Text = "В произвольную";
        // 
        // AddSomewhereTo1ToolStripMenuItem
        // 
        AddSomewhereTo1ToolStripMenuItem.Name = "AddSomewhereTo1ToolStripMenuItem";
        AddSomewhereTo1ToolStripMenuItem.Size = new Size(205, 26);
        AddSomewhereTo1ToolStripMenuItem.Text = "Первого списка";
        AddSomewhereTo1ToolStripMenuItem.Click += AddSomewhereTo1ToolStripMenuItem_Click;
        // 
        // AddSomewhereTo2ToolStripMenuItem
        // 
        AddSomewhereTo2ToolStripMenuItem.Name = "AddSomewhereTo2ToolStripMenuItem";
        AddSomewhereTo2ToolStripMenuItem.Size = new Size(205, 26);
        AddSomewhereTo2ToolStripMenuItem.Text = "Второго списка";
        AddSomewhereTo2ToolStripMenuItem.Click += AddSomewhereTo2ToolStripMenuItem_Click;
        // 
        // AddSomewhereTo3ToolStripMenuItem
        // 
        AddSomewhereTo3ToolStripMenuItem.Name = "AddSomewhereTo3ToolStripMenuItem";
        AddSomewhereTo3ToolStripMenuItem.Size = new Size(205, 26);
        AddSomewhereTo3ToolStripMenuItem.Text = "Третьего списка";
        AddSomewhereTo3ToolStripMenuItem.Click += AddSomewhereTo3ToolStripMenuItem_Click;
        // 
        // RemoveToolStripMenuItem
        // 
        RemoveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RemoveFirstToolStripMenuItem, RemoveLastToolStripMenuItem, RemoveSomewhereToolStripMenuItem });
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
        RemoveToolStripMenuItem.Size = new Size(247, 26);
        RemoveToolStripMenuItem.Text = "Удаление элемента";
        // 
        // RemoveFirstToolStripMenuItem
        // 
        RemoveFirstToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RemoveFirstIn1ToolStripMenuItem, RemoveFirstIn2ToolStripMenuItem, RemoveFirstIn3ToolStripMenuItem });
        RemoveFirstToolStripMenuItem.Name = "RemoveFirstToolStripMenuItem";
        RemoveFirstToolStripMenuItem.Size = new Size(208, 26);
        RemoveFirstToolStripMenuItem.Text = "В начале";
        // 
        // RemoveFirstIn1ToolStripMenuItem
        // 
        RemoveFirstIn1ToolStripMenuItem.Name = "RemoveFirstIn1ToolStripMenuItem";
        RemoveFirstIn1ToolStripMenuItem.Size = new Size(205, 26);
        RemoveFirstIn1ToolStripMenuItem.Text = "Первого списка";
        RemoveFirstIn1ToolStripMenuItem.Click += RemoveFirstIn1ToolStripMenuItem_Click;
        // 
        // RemoveFirstIn2ToolStripMenuItem
        // 
        RemoveFirstIn2ToolStripMenuItem.Name = "RemoveFirstIn2ToolStripMenuItem";
        RemoveFirstIn2ToolStripMenuItem.Size = new Size(205, 26);
        RemoveFirstIn2ToolStripMenuItem.Text = "Второго списка";
        RemoveFirstIn2ToolStripMenuItem.Click += RemoveFirstIn2ToolStripMenuItem_Click;
        // 
        // RemoveFirstIn3ToolStripMenuItem
        // 
        RemoveFirstIn3ToolStripMenuItem.Name = "RemoveFirstIn3ToolStripMenuItem";
        RemoveFirstIn3ToolStripMenuItem.Size = new Size(205, 26);
        RemoveFirstIn3ToolStripMenuItem.Text = "Третьего списка";
        RemoveFirstIn3ToolStripMenuItem.Click += RemoveFirstIn3ToolStripMenuItem_Click;
        // 
        // RemoveLastToolStripMenuItem
        // 
        RemoveLastToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RemoveLastIn1ToolStripMenuItem, RemoveLastIn2ToolStripMenuItem, RemoveLastIn3ToolStripMenuItem });
        RemoveLastToolStripMenuItem.Name = "RemoveLastToolStripMenuItem";
        RemoveLastToolStripMenuItem.Size = new Size(208, 26);
        RemoveLastToolStripMenuItem.Text = "В конце";
        // 
        // RemoveLastIn1ToolStripMenuItem
        // 
        RemoveLastIn1ToolStripMenuItem.Name = "RemoveLastIn1ToolStripMenuItem";
        RemoveLastIn1ToolStripMenuItem.Size = new Size(205, 26);
        RemoveLastIn1ToolStripMenuItem.Text = "Первого списка";
        RemoveLastIn1ToolStripMenuItem.Click += RemoveLastIn1ToolStripMenuItem_Click;
        // 
        // RemoveLastIn2ToolStripMenuItem
        // 
        RemoveLastIn2ToolStripMenuItem.Name = "RemoveLastIn2ToolStripMenuItem";
        RemoveLastIn2ToolStripMenuItem.Size = new Size(205, 26);
        RemoveLastIn2ToolStripMenuItem.Text = "Второго списка";
        RemoveLastIn2ToolStripMenuItem.Click += RemoveLastIn2ToolStripMenuItem_Click;
        // 
        // RemoveLastIn3ToolStripMenuItem
        // 
        RemoveLastIn3ToolStripMenuItem.Name = "RemoveLastIn3ToolStripMenuItem";
        RemoveLastIn3ToolStripMenuItem.Size = new Size(205, 26);
        RemoveLastIn3ToolStripMenuItem.Text = "Третьего списка";
        RemoveLastIn3ToolStripMenuItem.Click += RemoveLastIn3ToolStripMenuItem_Click;
        // 
        // RemoveSomewhereToolStripMenuItem
        // 
        RemoveSomewhereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RemoveSomewhereIn1ToolStripMenuItem, RemoveSomewhereIn2ToolStripMenuItem, RemoveSomewhereIn3ToolStripMenuItem });
        RemoveSomewhereToolStripMenuItem.Name = "RemoveSomewhereToolStripMenuItem";
        RemoveSomewhereToolStripMenuItem.Size = new Size(208, 26);
        RemoveSomewhereToolStripMenuItem.Text = "В произвольной";
        // 
        // RemoveSomewhereIn1ToolStripMenuItem
        // 
        RemoveSomewhereIn1ToolStripMenuItem.Name = "RemoveSomewhereIn1ToolStripMenuItem";
        RemoveSomewhereIn1ToolStripMenuItem.Size = new Size(205, 26);
        RemoveSomewhereIn1ToolStripMenuItem.Text = "Первого списка";
        RemoveSomewhereIn1ToolStripMenuItem.Click += RemoveSomewhereIn1ToolStripMenuItem_Click;
        // 
        // RemoveSomewhereIn2ToolStripMenuItem
        // 
        RemoveSomewhereIn2ToolStripMenuItem.Name = "RemoveSomewhereIn2ToolStripMenuItem";
        RemoveSomewhereIn2ToolStripMenuItem.Size = new Size(205, 26);
        RemoveSomewhereIn2ToolStripMenuItem.Text = "Второго списка";
        RemoveSomewhereIn2ToolStripMenuItem.Click += RemoveSomewhereIn2ToolStripMenuItem_Click;
        // 
        // RemoveSomewhereIn3ToolStripMenuItem
        // 
        RemoveSomewhereIn3ToolStripMenuItem.Name = "RemoveSomewhereIn3ToolStripMenuItem";
        RemoveSomewhereIn3ToolStripMenuItem.Size = new Size(205, 26);
        RemoveSomewhereIn3ToolStripMenuItem.Text = "Третьего списка";
        RemoveSomewhereIn3ToolStripMenuItem.Click += RemoveSomewhereIn3ToolStripMenuItem_Click;
        // 
        // TaskReplaceToolStripMenuItem
        // 
        TaskReplaceToolStripMenuItem.Name = "TaskReplaceToolStripMenuItem";
        TaskReplaceToolStripMenuItem.Size = new Size(257, 26);
        TaskReplaceToolStripMenuItem.Text = "Обработка списка";
        TaskReplaceToolStripMenuItem.Click += TaskReplaceToolStripMenuItem_Click;
        // 
        // DestroyToolStripMenuItem
        // 
        DestroyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DestroyFirstToolStripMenuItem, DestroySecondToolStripMenuItem, DestroyThirdToolStripMenuItem });
        DestroyToolStripMenuItem.Name = "DestroyToolStripMenuItem";
        DestroyToolStripMenuItem.Size = new Size(257, 26);
        DestroyToolStripMenuItem.Text = "Разрушение списка";
        // 
        // DestroyFirstToolStripMenuItem
        // 
        DestroyFirstToolStripMenuItem.Name = "DestroyFirstToolStripMenuItem";
        DestroyFirstToolStripMenuItem.Size = new Size(205, 26);
        DestroyFirstToolStripMenuItem.Text = "Первого списка";
        DestroyFirstToolStripMenuItem.Click += DestroyFirstToolStripMenuItem_Click;
        // 
        // DestroySecondToolStripMenuItem
        // 
        DestroySecondToolStripMenuItem.Name = "DestroySecondToolStripMenuItem";
        DestroySecondToolStripMenuItem.Size = new Size(205, 26);
        DestroySecondToolStripMenuItem.Text = "Второго списка";
        DestroySecondToolStripMenuItem.Click += DestroySecondToolStripMenuItem_Click;
        // 
        // DestroyThirdToolStripMenuItem
        // 
        DestroyThirdToolStripMenuItem.Name = "DestroyThirdToolStripMenuItem";
        DestroyThirdToolStripMenuItem.Size = new Size(205, 26);
        DestroyThirdToolStripMenuItem.Text = "Третьего списка";
        DestroyThirdToolStripMenuItem.Click += DestroyThirdToolStripMenuItem_Click;
        // 
        // AboutToolStripMenuItem
        // 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
        AboutToolStripMenuItem.Size = new Size(118, 24);
        AboutToolStripMenuItem.Text = "О программе";
        AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
        // 
        // ExitToolStripMenuItem
        // 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
        ExitToolStripMenuItem.Size = new Size(67, 24);
        ExitToolStripMenuItem.Text = "Выход";
        ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        // 
        // ListBox1
        // 
        ListBox1.FormattingEnabled = true;
        ListBox1.Location = new Point(12, 31);
        ListBox1.Name = "ListBox1";
        ListBox1.Size = new Size(150, 264);
        ListBox1.TabIndex = 1;
        ListBox1.Visible = false;
        // 
        // ListBox2
        // 
        ListBox2.FormattingEnabled = true;
        ListBox2.Location = new Point(168, 31);
        ListBox2.Name = "ListBox2";
        ListBox2.Size = new Size(150, 124);
        ListBox2.TabIndex = 2;
        ListBox2.Visible = false;
        // 
        // ListBox3
        // 
        ListBox3.FormattingEnabled = true;
        ListBox3.Location = new Point(324, 31);
        ListBox3.Name = "ListBox3";
        ListBox3.Size = new Size(150, 124);
        ListBox3.TabIndex = 3;
        ListBox3.Visible = false;
        // 
        // ListBox1Changed
        // 
        ListBox1Changed.FormattingEnabled = true;
        ListBox1Changed.Location = new Point(480, 31);
        ListBox1Changed.Name = "ListBox1Changed";
        ListBox1Changed.Size = new Size(150, 264);
        ListBox1Changed.TabIndex = 4;
        ListBox1Changed.Visible = false;
        // 
        // Label1
        // 
        Label1.AutoSize = true;
        Label1.Location = new Point(12, 298);
        Label1.Name = "Label1";
        Label1.Size = new Size(117, 20);
        Label1.TabIndex = 5;
        Label1.Text = "Первый список";
        Label1.Visible = false;
        // 
        // Label2
        // 
        Label2.AutoSize = true;
        Label2.Location = new Point(168, 158);
        Label2.Name = "Label2";
        Label2.Size = new Size(112, 20);
        Label2.TabIndex = 6;
        Label2.Text = "Второй список";
        Label2.Visible = false;
        // 
        // Label3
        // 
        Label3.AutoSize = true;
        Label3.Location = new Point(324, 158);
        Label3.Name = "Label3";
        Label3.Size = new Size(110, 20);
        Label3.TabIndex = 7;
        Label3.Text = "Третий список";
        Label3.Visible = false;
        // 
        // Label1Changed
        // 
        Label1Changed.AutoSize = true;
        Label1Changed.Location = new Point(480, 298);
        Label1Changed.Name = "Label1Changed";
        Label1Changed.Size = new Size(130, 20);
        Label1Changed.TabIndex = 8;
        Label1Changed.Text = "Итоговый список";
        Label1Changed.Visible = false;
        // 
        // ClearAllButton
        // 
        ClearAllButton.Location = new Point(275, 241);
        ClearAllButton.Name = "ClearAllButton";
        ClearAllButton.Size = new Size(94, 29);
        ClearAllButton.TabIndex = 9;
        ClearAllButton.Text = "Очистка";
        ClearAllButton.UseVisualStyleBackColor = true;
        ClearAllButton.Visible = false;
        ClearAllButton.Click += ClearAllButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(647, 351);
        Controls.Add(ClearAllButton);
        Controls.Add(Label1Changed);
        Controls.Add(Label3);
        Controls.Add(Label2);
        Controls.Add(Label1);
        Controls.Add(ListBox1Changed);
        Controls.Add(ListBox3);
        Controls.Add(ListBox2);
        Controls.Add(ListBox1);
        Controls.Add(ms);
        MainMenuStrip = ms;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Л/р №2: списки";
        FormClosing += MainForm_FormClosing;
        ms.ResumeLayout(false);
        ms.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip ms;
    private ToolStripMenuItem TaskToolStripMenuItem;
    private ToolStripMenuItem CreateToolStripMenuItem;
    private ToolStripMenuItem EditToolStripMenuItem;
    private ToolStripMenuItem AddToolStripMenuItem;
    private ToolStripMenuItem AddAsFirstToolStripMenuItem;
    private ToolStripMenuItem AddAsFirstTo1ToolStripMenuItem;
    private ToolStripMenuItem AddAsFirstTo2ToolStripMenuItem;
    private ToolStripMenuItem AddAsLastToolStripMenuItem;
    private ToolStripMenuItem AddAsLastTo1ToolStripMenuItem;
    private ToolStripMenuItem AddAsLastTo2ToolStripMenuItem;
    private ToolStripMenuItem AddSomewhereToolStripMenuItem;
    private ToolStripMenuItem RemoveToolStripMenuItem;
    private ToolStripMenuItem Create1ToolStripMenuItem;
    private ToolStripMenuItem Create2ToolStripMenuItem;
    private ToolStripMenuItem Create3ToolStripMenuItem;
    private ToolStripMenuItem AddAsLastTo3ToolStripMenuItem;
    private ToolStripMenuItem AddSomewhereTo1ToolStripMenuItem;
    private ToolStripMenuItem AddSomewhereTo2ToolStripMenuItem;
    private ToolStripMenuItem AddSomewhereTo3ToolStripMenuItem;
    private ToolStripMenuItem TaskReplaceToolStripMenuItem;
    private ToolStripMenuItem DestroyToolStripMenuItem;
    private ToolStripMenuItem DestroyFirstToolStripMenuItem;
    private ToolStripMenuItem DestroySecondToolStripMenuItem;
    private ToolStripMenuItem DestroyThirdToolStripMenuItem;
    private ToolStripMenuItem AboutToolStripMenuItem;
    private ToolStripMenuItem ExitToolStripMenuItem;
    private ToolStripMenuItem RemoveFirstToolStripMenuItem;
    private ToolStripMenuItem RemoveFirstIn1ToolStripMenuItem;
    private ToolStripMenuItem RemoveFirstIn2ToolStripMenuItem;
    private ToolStripMenuItem RemoveFirstIn3ToolStripMenuItem;
    private ToolStripMenuItem RemoveLastToolStripMenuItem;
    private ToolStripMenuItem RemoveLastIn1ToolStripMenuItem;
    private ToolStripMenuItem RemoveLastIn2ToolStripMenuItem;
    private ToolStripMenuItem RemoveLastIn3ToolStripMenuItem;
    private ToolStripMenuItem RemoveSomewhereToolStripMenuItem;
    private ToolStripMenuItem RemoveSomewhereIn1ToolStripMenuItem;
    private ToolStripMenuItem RemoveSomewhereIn2ToolStripMenuItem;
    private ToolStripMenuItem RemoveSomewhereIn3ToolStripMenuItem;
    private ToolStripMenuItem AddAsFirstTo3ToolStripMenuItem;
    private ListBox ListBox1;
    private ListBox ListBox2;
    private ListBox ListBox3;
    private ListBox ListBox1Changed;
    private Label Label1;
    private Label Label2;
    private Label Label3;
    private Label Label1Changed;
    private Button ClearAllButton;
}
