namespace WinFormsApp2;

partial class Form1
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
        splitContainer1 = new SplitContainer();
        listBox1 = new ListBox();
        splitContainer2 = new SplitContainer();
        groupBox1 = new GroupBox();
        textBox1 = new TextBox();
        groupBox2 = new GroupBox();
        textBox2 = new TextBox();
        文件ToolStripMenuItem = new ToolStripMenuItem();
        导出ToolStripMenuItem = new ToolStripMenuItem();
        功能ToolStripMenuItem = new ToolStripMenuItem();
        自动监听剪切板ToolStripMenuItem = new ToolStripMenuItem();
        快捷键ToolStripMenuItem = new ToolStripMenuItem();
        配置快捷键ToolStripMenuItem = new ToolStripMenuItem();
        格式化器ToolStripMenuItem = new ToolStripMenuItem();
        格式化器配置ToolStripMenuItem = new ToolStripMenuItem();
        导出格式化器ToolStripMenuItem = new ToolStripMenuItem();
        导入格式化器ToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1 = new MenuStrip();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
        splitContainer2.Panel1.SuspendLayout();
        splitContainer2.Panel2.SuspendLayout();
        splitContainer2.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0,47);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(listBox1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(splitContainer2);
        splitContainer1.Size = new Size(1833,1068);
        splitContainer1.SplitterDistance = 611;
        splitContainer1.TabIndex = 3;
        // 
        // listBox1
        // 
        listBox1.Dock = DockStyle.Fill;
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 39;
        listBox1.Location = new Point(0,0);
        listBox1.Margin = new Padding(5);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(611,1068);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // splitContainer2
        // 
        splitContainer2.Dock = DockStyle.Fill;
        splitContainer2.Location = new Point(0,0);
        splitContainer2.Name = "splitContainer2";
        splitContainer2.Orientation = Orientation.Horizontal;
        // 
        // splitContainer2.Panel1
        // 
        splitContainer2.Panel1.Controls.Add(groupBox1);
        // 
        // splitContainer2.Panel2
        // 
        splitContainer2.Panel2.Controls.Add(groupBox2);
        splitContainer2.Size = new Size(1218,1068);
        splitContainer2.SplitterDistance = 406;
        splitContainer2.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox1);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(0,0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1218,406);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "捕获的语句";
        // 
        // textBox1
        // 
        textBox1.AcceptsReturn = true;
        textBox1.AcceptsTab = true;
        textBox1.AllowDrop = true;
        textBox1.BorderStyle = BorderStyle.FixedSingle;
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(3,42);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "捕获的语句会显示在这里";
        textBox1.ScrollBars = ScrollBars.Vertical;
        textBox1.Size = new Size(1212,361);
        textBox1.TabIndex = 2;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(textBox2);
        groupBox2.Dock = DockStyle.Fill;
        groupBox2.Location = new Point(0,0);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1218,658);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "处理后的语句";
        // 
        // textBox2
        // 
        textBox2.AcceptsReturn = true;
        textBox2.AcceptsTab = true;
        textBox2.AllowDrop = true;
        textBox2.BorderStyle = BorderStyle.FixedSingle;
        textBox2.Dock = DockStyle.Fill;
        textBox2.Location = new Point(3,42);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.ScrollBars = ScrollBars.Vertical;
        textBox2.Size = new Size(1212,613);
        textBox2.TabIndex = 2;
        // 
        // 文件ToolStripMenuItem
        // 
        文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 导出ToolStripMenuItem });
        文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
        文件ToolStripMenuItem.Size = new Size(101,43);
        文件ToolStripMenuItem.Text = "文件";
        // 
        // 导出ToolStripMenuItem
        // 
        导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
        导出ToolStripMenuItem.Size = new Size(242,54);
        导出ToolStripMenuItem.Text = "导出";
        // 
        // 功能ToolStripMenuItem
        // 
        功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 自动监听剪切板ToolStripMenuItem,快捷键ToolStripMenuItem,格式化器ToolStripMenuItem });
        功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
        功能ToolStripMenuItem.Size = new Size(101,43);
        功能ToolStripMenuItem.Text = "功能";
        // 
        // 自动监听剪切板ToolStripMenuItem
        // 
        自动监听剪切板ToolStripMenuItem.Name = "自动监听剪切板ToolStripMenuItem";
        自动监听剪切板ToolStripMenuItem.Size = new Size(392,54);
        自动监听剪切板ToolStripMenuItem.Text = "自动监听剪切板";
        // 
        // 快捷键ToolStripMenuItem
        // 
        快捷键ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 配置快捷键ToolStripMenuItem });
        快捷键ToolStripMenuItem.Name = "快捷键ToolStripMenuItem";
        快捷键ToolStripMenuItem.Size = new Size(392,54);
        快捷键ToolStripMenuItem.Text = "启用快捷键";
        // 
        // 配置快捷键ToolStripMenuItem
        // 
        配置快捷键ToolStripMenuItem.Name = "配置快捷键ToolStripMenuItem";
        配置快捷键ToolStripMenuItem.Size = new Size(332,54);
        配置快捷键ToolStripMenuItem.Text = "配置快捷键";
        // 
        // 格式化器ToolStripMenuItem
        // 
        格式化器ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 格式化器配置ToolStripMenuItem,导出格式化器ToolStripMenuItem,导入格式化器ToolStripMenuItem });
        格式化器ToolStripMenuItem.Name = "格式化器ToolStripMenuItem";
        格式化器ToolStripMenuItem.Size = new Size(392,54);
        格式化器ToolStripMenuItem.Text = "启用格式化器";
        // 
        // 格式化器配置ToolStripMenuItem
        // 
        格式化器配置ToolStripMenuItem.Name = "格式化器配置ToolStripMenuItem";
        格式化器配置ToolStripMenuItem.Size = new Size(362,54);
        格式化器配置ToolStripMenuItem.Text = "格式化器配置";
        // 
        // 导出格式化器ToolStripMenuItem
        // 
        导出格式化器ToolStripMenuItem.Name = "导出格式化器ToolStripMenuItem";
        导出格式化器ToolStripMenuItem.Size = new Size(362,54);
        导出格式化器ToolStripMenuItem.Text = "导出格式化器";
        // 
        // 导入格式化器ToolStripMenuItem
        // 
        导入格式化器ToolStripMenuItem.Name = "导入格式化器ToolStripMenuItem";
        导入格式化器ToolStripMenuItem.Size = new Size(362,54);
        导入格式化器ToolStripMenuItem.Text = "导入格式化器";
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(40,40);
        menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem,功能ToolStripMenuItem });
        menuStrip1.Location = new Point(0,0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1833,47);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(18F,39F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1833,1115);
        Controls.Add(splitContainer1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(8,7,8,7);
        Name = "Form1";
        Text = "SQL 反参数化工具 230702";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        splitContainer2.Panel1.ResumeLayout(false);
        splitContainer2.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
        splitContainer2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private SplitContainer splitContainer1;
    private ListBox listBox1;
    private ToolStripMenuItem 文件ToolStripMenuItem;
    private ToolStripMenuItem 导出ToolStripMenuItem;
    private ToolStripMenuItem 功能ToolStripMenuItem;
    private ToolStripMenuItem 自动监听剪切板ToolStripMenuItem;
    private ToolStripMenuItem 快捷键ToolStripMenuItem;
    private ToolStripMenuItem 格式化器ToolStripMenuItem;
    private MenuStrip menuStrip1;
    private SplitContainer splitContainer2;
    private ToolStripMenuItem 配置快捷键ToolStripMenuItem;
    private ToolStripMenuItem 格式化器配置ToolStripMenuItem;
    private ToolStripMenuItem 导出格式化器ToolStripMenuItem;
    private ToolStripMenuItem 导入格式化器ToolStripMenuItem;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox2;
    private TextBox textBox2;
}
