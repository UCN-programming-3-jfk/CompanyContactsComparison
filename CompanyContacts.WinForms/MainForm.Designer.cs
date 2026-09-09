namespace CompanyContacts.WinForms;

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
        splitContainer1 = new SplitContainer();
        lstCompanies = new ListView();
        grSortpButtons = new GroupBox();
        btnId = new Button();
        btnIsCustomer = new Button();
        btnSortByName = new Button();
        btnEmployeeCount = new Button();
        btnLastContacted = new Button();
        btnYearlyRevenue = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        grSortpButtons.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(lstCompanies);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(grSortpButtons);
        splitContainer1.Size = new Size(1154, 719);
        splitContainer1.SplitterDistance = 668;
        splitContainer1.TabIndex = 0;
        // 
        // lstCompanies
        // 
        lstCompanies.Dock = DockStyle.Fill;
        lstCompanies.Location = new Point(0, 0);
        lstCompanies.Name = "lstCompanies";
        lstCompanies.Size = new Size(668, 719);
        lstCompanies.TabIndex = 0;
        lstCompanies.UseCompatibleStateImageBehavior = false;
        lstCompanies.View = View.Details;
        // 
        // grSortpButtons
        // 
        grSortpButtons.Controls.Add(btnId);
        grSortpButtons.Controls.Add(btnIsCustomer);
        grSortpButtons.Controls.Add(btnSortByName);
        grSortpButtons.Controls.Add(btnEmployeeCount);
        grSortpButtons.Controls.Add(btnLastContacted);
        grSortpButtons.Controls.Add(btnYearlyRevenue);
        grSortpButtons.Dock = DockStyle.Top;
        grSortpButtons.Location = new Point(0, 0);
        grSortpButtons.Name = "grSortpButtons";
        grSortpButtons.Size = new Size(482, 222);
        grSortpButtons.TabIndex = 5;
        grSortpButtons.TabStop = false;
        grSortpButtons.Text = "Sort by";
        // 
        // btnId
        // 
        btnId.Location = new Point(128, 42);
        btnId.Name = "btnId";
        btnId.Size = new Size(146, 48);
        btnId.TabIndex = 5;
        btnId.Text = "&Id";
        btnId.UseVisualStyleBackColor = true;
        btnId.Click += btnId_Click;
        // 
        // btnIsCustomer
        // 
        btnIsCustomer.Location = new Point(280, 96);
        btnIsCustomer.Name = "btnIsCustomer";
        btnIsCustomer.Size = new Size(146, 48);
        btnIsCustomer.TabIndex = 4;
        btnIsCustomer.Text = "Is custo&mer";
        btnIsCustomer.UseVisualStyleBackColor = true;
        btnIsCustomer.Click += btnIsCustomer_Click;
        // 
        // btnSortByName
        // 
        btnSortByName.Location = new Point(18, 42);
        btnSortByName.Name = "btnSortByName";
        btnSortByName.Size = new Size(104, 48);
        btnSortByName.TabIndex = 0;
        btnSortByName.Text = "&Name";
        btnSortByName.UseVisualStyleBackColor = true;
        btnSortByName.Click += btnSortByName_Click;
        // 
        // btnEmployeeCount
        // 
        btnEmployeeCount.Location = new Point(280, 42);
        btnEmployeeCount.Name = "btnEmployeeCount";
        btnEmployeeCount.Size = new Size(154, 48);
        btnEmployeeCount.TabIndex = 3;
        btnEmployeeCount.Text = "&Employee count";
        btnEmployeeCount.UseVisualStyleBackColor = true;
        btnEmployeeCount.Click += btnEmployeeCount_Click;
        // 
        // btnLastContacted
        // 
        btnLastContacted.Location = new Point(128, 96);
        btnLastContacted.Name = "btnLastContacted";
        btnLastContacted.Size = new Size(146, 48);
        btnLastContacted.TabIndex = 1;
        btnLastContacted.Text = "Last &contacted";
        btnLastContacted.UseVisualStyleBackColor = true;
        btnLastContacted.Click += btnLastContacted_Click;
        // 
        // btnYearlyRevenue
        // 
        btnYearlyRevenue.Location = new Point(18, 96);
        btnYearlyRevenue.Name = "btnYearlyRevenue";
        btnYearlyRevenue.Size = new Size(104, 48);
        btnYearlyRevenue.TabIndex = 2;
        btnYearlyRevenue.Text = "&Revenue";
        btnYearlyRevenue.UseVisualStyleBackColor = true;
        btnYearlyRevenue.Click += btnYearlyRevenue_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1154, 719);
        Controls.Add(splitContainer1);
        Name = "MainForm";
        Text = "Company Contacts";
        Load += Form1_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        grSortpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private GroupBox grSortpButtons;
    private Button btnSortByName;
    private Button btnEmployeeCount;
    private Button btnYearlyRevenue;
    private Button btnLastContacted;
    private Button btnIsCustomer;
    private Button btnId;
    private ListView lstCompanies;
}
