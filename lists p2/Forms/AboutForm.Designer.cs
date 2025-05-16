namespace lists_p2.Forms;

partial class AboutForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(13, 15);
        label1.Name = "label1";
        label1.Size = new Size(610, 120);
        label1.TabIndex = 0;
        label1.Text = resources.GetString("label1.Text");
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(442, 205);
        label2.Name = "label2";
        label2.Size = new Size(181, 60);
        label2.TabIndex = 1;
        label2.Text = "Выполнил Карбовничий\r\nГеннадий Вячеславович,\r\nгруппа 6102-090301D";
        // 
        // AboutForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(654, 301);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "AboutForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "О программе";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
}