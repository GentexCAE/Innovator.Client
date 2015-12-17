﻿namespace InnovatorAdmin
{
  partial class EditorWindow
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.splitMain = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.treeItems = new InnovatorAdmin.TreeListView();
      this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
      this.colDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
      this.btnPanelToggle = new InnovatorAdmin.Controls.FlatButton();
      this.splitEditors = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.inputEditor = new InnovatorAdmin.Editor.EditorControl();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tbcOutputView = new System.Windows.Forms.TabControl();
      this.pgTextOutput = new System.Windows.Forms.TabPage();
      this.outputEditor = new InnovatorAdmin.Editor.EditorControl();
      this.pgTableOutput = new System.Windows.Forms.TabPage();
      this.dgvItems = new System.Windows.Forms.DataGridView();
      this.conTable = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.scriptEditsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTableEditsToClipboard = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTableEditsToFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTableEditsToQueryEditor = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.mniAcceptChanges = new System.Windows.Forms.ToolStripMenuItem();
      this.mniResetChanges = new System.Windows.Forms.ToolStripMenuItem();
      this.btnOk = new InnovatorAdmin.Controls.FlatButton();
      this.btnCancel = new InnovatorAdmin.Controls.FlatButton();
      this.lblItems = new System.Windows.Forms.Label();
      this.lblConnColor = new System.Windows.Forms.Label();
      this.menuStrip = new System.Windows.Forms.ToolStrip();
      this.lblConnection = new System.Windows.Forms.ToolStripLabel();
      this.btnEditConnections = new System.Windows.Forms.ToolStripButton();
      this.lblSoapAction = new System.Windows.Forms.ToolStripLabel();
      this.btnSoapAction = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.mniNewWindow = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.mniClose = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.mniUndo = new System.Windows.Forms.ToolStripMenuItem();
      this.mniRedo = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.mniCut = new System.Windows.Forms.ToolStripMenuItem();
      this.mniCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.mniPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mniInsertNewGuid = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.mniUppercase = new System.Windows.Forms.ToolStripMenuItem();
      this.mniLowercase = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.mniDoubleToSingleQuotes = new System.Windows.Forms.ToolStripMenuItem();
      this.mniSingleToDoubleQuotes = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.mniMd5Encode = new System.Windows.Forms.ToolStripMenuItem();
      this.lineOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mniMoveUpCurrentLine = new System.Windows.Forms.ToolStripMenuItem();
      this.mniMoveDownCurrentLine = new System.Windows.Forms.ToolStripMenuItem();
      this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTidyXml = new System.Windows.Forms.ToolStripMenuItem();
      this.mniXmlToEntity = new System.Windows.Forms.ToolStripMenuItem();
      this.mniEntityToXml = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
      this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mniLocale = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTimeZone = new System.Windows.Forms.ToolStripMenuItem();
      this.mniTimeout = new System.Windows.Forms.ToolStripMenuItem();
      this.exploreButton = new System.Windows.Forms.ToolStripButton();
      this.btnSubmit = new System.Windows.Forms.ToolStripSplitButton();
      this.mniRunAll = new System.Windows.Forms.ToolStripMenuItem();
      this.mniRunCurrent = new System.Windows.Forms.ToolStripMenuItem();
      this.mniRunCurrentNewWindow = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
      this.splitMain.Panel1.SuspendLayout();
      this.splitMain.Panel2.SuspendLayout();
      this.splitMain.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitEditors)).BeginInit();
      this.splitEditors.Panel1.SuspendLayout();
      this.splitEditors.Panel2.SuspendLayout();
      this.splitEditors.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tbcOutputView.SuspendLayout();
      this.pgTextOutput.SuspendLayout();
      this.pgTableOutput.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
      this.conTable.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      //
      // tableLayoutPanel1
      //
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.splitMain, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblItems, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblConnColor, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 490);
      this.tableLayoutPanel1.TabIndex = 0;
      //
      // splitMain
      //
      this.tableLayoutPanel1.SetColumnSpan(this.splitMain, 3);
      this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitMain.Location = new System.Drawing.Point(3, 8);
      this.splitMain.Name = "splitMain";
      //
      // splitMain.Panel1
      //
      this.splitMain.Panel1.Controls.Add(this.tableLayoutPanel4);
      //
      // splitMain.Panel2
      //
      this.splitMain.Panel2.Controls.Add(this.splitEditors);
      this.splitMain.Size = new System.Drawing.Size(695, 444);
      this.splitMain.SplitterDistance = 220;
      this.splitMain.TabIndex = 0;
      //
      // tableLayoutPanel4
      //
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.treeItems, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.btnPanelToggle, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(220, 444);
      this.tableLayoutPanel4.TabIndex = 1;
      //
      // treeItems
      //
      this.treeItems.AllColumns.Add(this.colName);
      this.treeItems.AllColumns.Add(this.colDescription);
      this.treeItems.CellEditUseWholeCell = false;
      this.treeItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription});
      this.treeItems.Cursor = System.Windows.Forms.Cursors.Default;
      this.treeItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeItems.HighlightBackgroundColor = System.Drawing.Color.Empty;
      this.treeItems.HighlightForegroundColor = System.Drawing.Color.Empty;
      this.treeItems.Location = new System.Drawing.Point(0, 25);
      this.treeItems.Margin = new System.Windows.Forms.Padding(0);
      this.treeItems.Name = "treeItems";
      this.treeItems.ShowGroups = false;
      this.treeItems.Size = new System.Drawing.Size(220, 419);
      this.treeItems.TabIndex = 0;
      this.treeItems.UseCompatibleStateImageBehavior = false;
      this.treeItems.View = System.Windows.Forms.View.Details;
      this.treeItems.VirtualMode = true;
      this.treeItems.ModelDoubleClick += new System.EventHandler<InnovatorAdmin.ModelDoubleClickEventArgs>(this.treeItems_ModelDoubleClick);
      this.treeItems.Expanding += new System.EventHandler<BrightIdeasSoftware.TreeBranchExpandingEventArgs>(this.treeItems_Expanding);
      this.treeItems.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.treeItems_CellToolTipShowing);
      //
      // colName
      //
      this.colName.AspectName = "Name";
      this.colName.ImageAspectName = "";
      this.colName.Text = "Name";
      this.colName.Width = 150;
      //
      // colDescription
      //
      this.colDescription.AspectName = "Description";
      this.colDescription.FillsFreeSpace = true;
      this.colDescription.Text = "Description";
      this.colDescription.Width = 200;
      //
      // btnPanelToggle
      //
      this.btnPanelToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPanelToggle.AutoSize = true;
      this.btnPanelToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnPanelToggle.FlatAppearance.BorderSize = 0;
      this.btnPanelToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnPanelToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnPanelToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPanelToggle.ForeColor = System.Drawing.Color.Black;
      this.btnPanelToggle.Location = new System.Drawing.Point(0, 0);
      this.btnPanelToggle.Margin = new System.Windows.Forms.Padding(0);
      this.btnPanelToggle.Name = "btnPanelToggle";
      this.btnPanelToggle.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnPanelToggle.Padding = new System.Windows.Forms.Padding(2);
      this.btnPanelToggle.Size = new System.Drawing.Size(220, 25);
      this.btnPanelToggle.TabIndex = 1;
      this.btnPanelToggle.Text = "Table of Contents";
      this.btnPanelToggle.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnPanelToggle.UseVisualStyleBackColor = false;
      this.btnPanelToggle.Click += new System.EventHandler(this.btnPanelToggle_Click);
      //
      // splitEditors
      //
      this.splitEditors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitEditors.Location = new System.Drawing.Point(0, 0);
      this.splitEditors.Name = "splitEditors";
      this.splitEditors.Orientation = System.Windows.Forms.Orientation.Horizontal;
      //
      // splitEditors.Panel1
      //
      this.splitEditors.Panel1.Controls.Add(this.tableLayoutPanel3);
      //
      // splitEditors.Panel2
      //
      this.splitEditors.Panel2.Controls.Add(this.tableLayoutPanel2);
      this.splitEditors.Size = new System.Drawing.Size(471, 444);
      this.splitEditors.SplitterDistance = 137;
      this.splitEditors.TabIndex = 0;
      //
      // tableLayoutPanel3
      //
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Controls.Add(this.inputEditor, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(471, 137);
      this.tableLayoutPanel3.TabIndex = 1;
      //
      // inputEditor
      //
      this.tableLayoutPanel3.SetColumnSpan(this.inputEditor, 2);
      this.inputEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.inputEditor.Helper = null;
      this.inputEditor.Location = new System.Drawing.Point(3, 3);
      this.inputEditor.Name = "inputEditor";
      this.inputEditor.ReadOnly = false;
      this.inputEditor.Size = new System.Drawing.Size(465, 131);
      this.inputEditor.TabIndex = 0;
      this.inputEditor.RunRequested += new System.EventHandler<InnovatorAdmin.Editor.RunRequestedEventArgs>(this.inputEditor_RunRequested);
      //
      // tableLayoutPanel2
      //
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.tbcOutputView, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 303);
      this.tableLayoutPanel2.TabIndex = 0;
      //
      // tbcOutputView
      //
      this.tbcOutputView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.SetColumnSpan(this.tbcOutputView, 3);
      this.tbcOutputView.Controls.Add(this.pgTextOutput);
      this.tbcOutputView.Controls.Add(this.pgTableOutput);
      this.tbcOutputView.Location = new System.Drawing.Point(0, 0);
      this.tbcOutputView.Margin = new System.Windows.Forms.Padding(0);
      this.tbcOutputView.Name = "tbcOutputView";
      this.tbcOutputView.Padding = new System.Drawing.Point(0, 0);
      this.tbcOutputView.SelectedIndex = 0;
      this.tbcOutputView.Size = new System.Drawing.Size(471, 303);
      this.tbcOutputView.TabIndex = 5;
      this.tbcOutputView.SelectedIndexChanged += new System.EventHandler(this.tbcOutputView_SelectedIndexChanged);
      //
      // pgTextOutput
      //
      this.pgTextOutput.Controls.Add(this.outputEditor);
      this.pgTextOutput.Location = new System.Drawing.Point(4, 22);
      this.pgTextOutput.Name = "pgTextOutput";
      this.pgTextOutput.Size = new System.Drawing.Size(463, 277);
      this.pgTextOutput.TabIndex = 0;
      this.pgTextOutput.Text = "Text";
      this.pgTextOutput.UseVisualStyleBackColor = true;
      //
      // outputEditor
      //
      this.outputEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.outputEditor.Helper = null;
      this.outputEditor.Location = new System.Drawing.Point(0, 0);
      this.outputEditor.Name = "outputEditor";
      this.outputEditor.ReadOnly = false;
      this.outputEditor.Size = new System.Drawing.Size(463, 277);
      this.outputEditor.TabIndex = 0;
      //
      // pgTableOutput
      //
      this.pgTableOutput.Controls.Add(this.dgvItems);
      this.pgTableOutput.Location = new System.Drawing.Point(4, 22);
      this.pgTableOutput.Margin = new System.Windows.Forms.Padding(0);
      this.pgTableOutput.Name = "pgTableOutput";
      this.pgTableOutput.Size = new System.Drawing.Size(463, 277);
      this.pgTableOutput.TabIndex = 1;
      this.pgTableOutput.Text = "Table";
      this.pgTableOutput.UseVisualStyleBackColor = true;
      //
      // dgvItems
      //
      this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvItems.ContextMenuStrip = this.conTable;
      this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvItems.Location = new System.Drawing.Point(0, 0);
      this.dgvItems.Margin = new System.Windows.Forms.Padding(0);
      this.dgvItems.Name = "dgvItems";
      this.dgvItems.Size = new System.Drawing.Size(463, 277);
      this.dgvItems.TabIndex = 0;
      this.dgvItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItems_CellFormatting);
      //
      // conTable
      //
      this.conTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptEditsToToolStripMenuItem,
            this.toolStripSeparator1,
            this.mniAcceptChanges,
            this.mniResetChanges});
      this.conTable.Name = "conTable";
      this.conTable.Size = new System.Drawing.Size(161, 76);
      //
      // scriptEditsToToolStripMenuItem
      //
      this.scriptEditsToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTableEditsToClipboard,
            this.mniTableEditsToFile,
            this.mniTableEditsToQueryEditor});
      this.scriptEditsToToolStripMenuItem.Name = "scriptEditsToToolStripMenuItem";
      this.scriptEditsToToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.scriptEditsToToolStripMenuItem.Text = "Script Edits To";
      //
      // mniTableEditsToClipboard
      //
      this.mniTableEditsToClipboard.Name = "mniTableEditsToClipboard";
      this.mniTableEditsToClipboard.Size = new System.Drawing.Size(140, 22);
      this.mniTableEditsToClipboard.Text = "Clipboard";
      this.mniTableEditsToClipboard.Click += new System.EventHandler(this.mniTableEditsToClipboard_Click);
      //
      // mniTableEditsToFile
      //
      this.mniTableEditsToFile.Name = "mniTableEditsToFile";
      this.mniTableEditsToFile.Size = new System.Drawing.Size(140, 22);
      this.mniTableEditsToFile.Text = "File...";
      this.mniTableEditsToFile.Click += new System.EventHandler(this.mniTableEditsToFile_Click);
      //
      // mniTableEditsToQueryEditor
      //
      this.mniTableEditsToQueryEditor.Name = "mniTableEditsToQueryEditor";
      this.mniTableEditsToQueryEditor.Size = new System.Drawing.Size(140, 22);
      this.mniTableEditsToQueryEditor.Text = "Query Editor";
      this.mniTableEditsToQueryEditor.Click += new System.EventHandler(this.mniTableEditsToQueryEditor_Click);
      //
      // toolStripSeparator1
      //
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
      //
      // mniAcceptChanges
      //
      this.mniAcceptChanges.Name = "mniAcceptChanges";
      this.mniAcceptChanges.Size = new System.Drawing.Size(160, 22);
      this.mniAcceptChanges.Text = "Accept Changes";
      this.mniAcceptChanges.Click += new System.EventHandler(this.mniAcceptChanges_Click);
      //
      // mniResetChanges
      //
      this.mniResetChanges.Name = "mniResetChanges";
      this.mniResetChanges.Size = new System.Drawing.Size(160, 22);
      this.mniResetChanges.Text = "Reset Changes";
      this.mniResetChanges.Click += new System.EventHandler(this.mniResetChanges_Click);
      //
      // btnOk
      //
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.AutoSize = true;
      this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOk.ForeColor = System.Drawing.Color.Black;
      this.btnOk.Location = new System.Drawing.Point(542, 458);
      this.btnOk.Name = "btnOk";
      this.btnOk.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnOk.Padding = new System.Windows.Forms.Padding(2);
      this.btnOk.Size = new System.Drawing.Size(75, 29);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "&OK";
      this.btnOk.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Visible = false;
      //
      // btnCancel
      //
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.AutoSize = true;
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.ForeColor = System.Drawing.Color.Black;
      this.btnCancel.Location = new System.Drawing.Point(623, 458);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnCancel.Padding = new System.Windows.Forms.Padding(2);
      this.btnCancel.Size = new System.Drawing.Size(75, 29);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Visible = false;
      //
      // lblItems
      //
      this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblItems.AutoEllipsis = true;
      this.lblItems.AutoSize = true;
      this.lblItems.Location = new System.Drawing.Point(3, 463);
      this.lblItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
      this.lblItems.Name = "lblItems";
      this.lblItems.Size = new System.Drawing.Size(0, 13);
      this.lblItems.TabIndex = 3;
      //
      // lblConnColor
      //
      this.lblConnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.lblConnColor, 3);
      this.lblConnColor.Location = new System.Drawing.Point(0, 0);
      this.lblConnColor.Margin = new System.Windows.Forms.Padding(0);
      this.lblConnColor.Name = "lblConnColor";
      this.lblConnColor.Size = new System.Drawing.Size(701, 5);
      this.lblConnColor.TabIndex = 4;
      //
      // menuStrip
      //
      this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnection,
            this.btnEditConnections,
            this.lblSoapAction,
            this.btnSoapAction,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.exploreButton,
            this.btnSubmit});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(701, 25);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "toolStrip1";
      //
      // lblConnection
      //
      this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblConnection.ForeColor = System.Drawing.Color.DimGray;
      this.lblConnection.Name = "lblConnection";
      this.lblConnection.Size = new System.Drawing.Size(69, 22);
      this.lblConnection.Text = "Connection:";
      //
      // btnEditConnections
      //
      this.btnEditConnections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btnEditConnections.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnEditConnections.Name = "btnEditConnections";
      this.btnEditConnections.Size = new System.Drawing.Size(52, 22);
      this.btnEditConnections.Text = "Change";
      this.btnEditConnections.Click += new System.EventHandler(this.btnEditConnections_Click);
      //
      // lblSoapAction
      //
      this.lblSoapAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSoapAction.ForeColor = System.Drawing.Color.DimGray;
      this.lblSoapAction.Name = "lblSoapAction";
      this.lblSoapAction.Size = new System.Drawing.Size(43, 22);
      this.lblSoapAction.Text = "Action:";
      //
      // btnSoapAction
      //
      this.btnSoapAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btnSoapAction.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSoapAction.Name = "btnSoapAction";
      this.btnSoapAction.Size = new System.Drawing.Size(46, 22);
      this.btnSoapAction.Text = "Action";
      this.btnSoapAction.Click += new System.EventHandler(this.btnSoapAction_Click);
      //
      // toolStripSeparator2
      //
      this.toolStripSeparator2.AutoSize = false;
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(25, 25);
      //
      // toolStripDropDownButton2
      //
      this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewWindow,
            this.toolStripSeparator3,
            this.mniClose});
      this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
      this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(38, 22);
      this.toolStripDropDownButton2.Text = "File";
      //
      // mniNewWindow
      //
      this.mniNewWindow.Name = "mniNewWindow";
      this.mniNewWindow.Size = new System.Drawing.Size(145, 22);
      this.mniNewWindow.Text = "New Window";
      this.mniNewWindow.Click += new System.EventHandler(this.mniNewWindow_Click);
      //
      // toolStripSeparator3
      //
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
      //
      // mniClose
      //
      this.mniClose.Name = "mniClose";
      this.mniClose.Size = new System.Drawing.Size(145, 22);
      this.mniClose.Text = "Close";
      this.mniClose.Click += new System.EventHandler(this.mniClose_Click);
      //
      // toolStripDropDownButton1
      //
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUndo,
            this.mniRedo,
            this.toolStripSeparator4,
            this.mniCut,
            this.mniCopy,
            this.mniPaste,
            this.toolStripSeparator6,
            this.insertToolStripMenuItem,
            this.toolStripSeparator5,
            this.toolStripMenuItem1,
            this.lineOperationsToolStripMenuItem,
            this.xMLToolStripMenuItem});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
      this.toolStripDropDownButton1.Text = "Edit";
      //
      // mniUndo
      //
      this.mniUndo.Name = "mniUndo";
      this.mniUndo.ShortcutKeyDisplayString = "Ctrl+Z";
      this.mniUndo.Size = new System.Drawing.Size(175, 22);
      this.mniUndo.Text = "Undo";
      //
      // mniRedo
      //
      this.mniRedo.Name = "mniRedo";
      this.mniRedo.ShortcutKeyDisplayString = "Ctrl+Y";
      this.mniRedo.Size = new System.Drawing.Size(175, 22);
      this.mniRedo.Text = "Redo";
      //
      // toolStripSeparator4
      //
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
      //
      // mniCut
      //
      this.mniCut.Name = "mniCut";
      this.mniCut.ShortcutKeyDisplayString = "Ctrl+X";
      this.mniCut.Size = new System.Drawing.Size(175, 22);
      this.mniCut.Text = "Cut";
      //
      // mniCopy
      //
      this.mniCopy.Name = "mniCopy";
      this.mniCopy.ShortcutKeyDisplayString = "Ctrl+C";
      this.mniCopy.Size = new System.Drawing.Size(175, 22);
      this.mniCopy.Text = "Copy";
      //
      // mniPaste
      //
      this.mniPaste.Name = "mniPaste";
      this.mniPaste.ShortcutKeyDisplayString = "Ctrl+V";
      this.mniPaste.Size = new System.Drawing.Size(175, 22);
      this.mniPaste.Text = "Paste";
      //
      // toolStripSeparator6
      //
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
      //
      // insertToolStripMenuItem
      //
      this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniInsertNewGuid});
      this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
      this.insertToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.insertToolStripMenuItem.Text = "Insert";
      //
      // mniInsertNewGuid
      //
      this.mniInsertNewGuid.Name = "mniInsertNewGuid";
      this.mniInsertNewGuid.Size = new System.Drawing.Size(128, 22);
      this.mniInsertNewGuid.Text = "New GUID";
      this.mniInsertNewGuid.Click += new System.EventHandler(this.mniInsertNewGuid_Click);
      //
      // toolStripSeparator5
      //
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
      //
      // toolStripMenuItem1
      //
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUppercase,
            this.mniLowercase,
            this.toolStripSeparator7,
            this.mniDoubleToSingleQuotes,
            this.mniSingleToDoubleQuotes,
            this.toolStripSeparator8,
            this.mniMd5Encode});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
      this.toolStripMenuItem1.Text = "Convert Characters";
      //
      // mniUppercase
      //
      this.mniUppercase.Name = "mniUppercase";
      this.mniUppercase.ShortcutKeyDisplayString = "Ctrl+Shift+U";
      this.mniUppercase.Size = new System.Drawing.Size(211, 22);
      this.mniUppercase.Text = "UPPERCASE";
      this.mniUppercase.Click += new System.EventHandler(this.mniUppercase_Click);
      //
      // mniLowercase
      //
      this.mniLowercase.Name = "mniLowercase";
      this.mniLowercase.ShortcutKeyDisplayString = "Ctrl+U";
      this.mniLowercase.Size = new System.Drawing.Size(211, 22);
      this.mniLowercase.Text = "lowercase";
      this.mniLowercase.Click += new System.EventHandler(this.mniLowercase_Click);
      //
      // toolStripSeparator7
      //
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(208, 6);
      //
      // mniDoubleToSingleQuotes
      //
      this.mniDoubleToSingleQuotes.Name = "mniDoubleToSingleQuotes";
      this.mniDoubleToSingleQuotes.Size = new System.Drawing.Size(211, 22);
      this.mniDoubleToSingleQuotes.Text = "Convert \" -> \'";
      this.mniDoubleToSingleQuotes.Click += new System.EventHandler(this.mniDoubleToSingleQuotes_Click);
      //
      // mniSingleToDoubleQuotes
      //
      this.mniSingleToDoubleQuotes.Name = "mniSingleToDoubleQuotes";
      this.mniSingleToDoubleQuotes.Size = new System.Drawing.Size(211, 22);
      this.mniSingleToDoubleQuotes.Text = "Convert \' -> \"";
      this.mniSingleToDoubleQuotes.Click += new System.EventHandler(this.mniSingleToDoubleQuotes_Click);
      //
      // toolStripSeparator8
      //
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(208, 6);
      //
      // mniMd5Encode
      //
      this.mniMd5Encode.Name = "mniMd5Encode";
      this.mniMd5Encode.Size = new System.Drawing.Size(211, 22);
      this.mniMd5Encode.Text = "MD5 Encode";
      this.mniMd5Encode.Click += new System.EventHandler(this.mniMd5Encode_Click);
      //
      // lineOperationsToolStripMenuItem
      //
      this.lineOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMoveUpCurrentLine,
            this.mniMoveDownCurrentLine});
      this.lineOperationsToolStripMenuItem.Name = "lineOperationsToolStripMenuItem";
      this.lineOperationsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.lineOperationsToolStripMenuItem.Text = "Line Operations";
      //
      // mniMoveUpCurrentLine
      //
      this.mniMoveUpCurrentLine.Name = "mniMoveUpCurrentLine";
      this.mniMoveUpCurrentLine.ShortcutKeyDisplayString = "Ctrl+Shift+Up";
      this.mniMoveUpCurrentLine.Size = new System.Drawing.Size(303, 22);
      this.mniMoveUpCurrentLine.Text = "Move Up Current Line";
      this.mniMoveUpCurrentLine.Click += new System.EventHandler(this.mniMoveUpCurrentLine_Click);
      //
      // mniMoveDownCurrentLine
      //
      this.mniMoveDownCurrentLine.Name = "mniMoveDownCurrentLine";
      this.mniMoveDownCurrentLine.ShortcutKeyDisplayString = "Ctrl+Shift+Down";
      this.mniMoveDownCurrentLine.Size = new System.Drawing.Size(303, 22);
      this.mniMoveDownCurrentLine.Text = "Move Down Current Line";
      this.mniMoveDownCurrentLine.Click += new System.EventHandler(this.mniMoveDownCurrentLine_Click);
      //
      // xMLToolStripMenuItem
      //
      this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTidyXml,
            this.mniXmlToEntity,
            this.mniEntityToXml});
      this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
      this.xMLToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.xMLToolStripMenuItem.Text = "XML";
      //
      // mniTidyXml
      //
      this.mniTidyXml.Name = "mniTidyXml";
      this.mniTidyXml.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.mniTidyXml.Size = new System.Drawing.Size(326, 22);
      this.mniTidyXml.Text = "Tidy Xml";
      this.mniTidyXml.Click += new System.EventHandler(this.mniTidyXml_Click);
      //
      // mniXmlToEntity
      //
      this.mniXmlToEntity.Name = "mniXmlToEntity";
      this.mniXmlToEntity.Size = new System.Drawing.Size(326, 22);
      this.mniXmlToEntity.Text = "Convert Selection XML to Text (<> => &&lt;&&gt;)";
      this.mniXmlToEntity.Click += new System.EventHandler(this.mniXmlToEntity_Click);
      //
      // mniEntityToXml
      //
      this.mniEntityToXml.Name = "mniEntityToXml";
      this.mniEntityToXml.Size = new System.Drawing.Size(326, 22);
      this.mniEntityToXml.Text = "Convert Selection Text to XML (&&lt;&&gt; => <>)";
      this.mniEntityToXml.Click += new System.EventHandler(this.mniEntityToXml_Click);
      //
      // toolStripDropDownButton3
      //
      this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
      this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
      this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
      this.toolStripDropDownButton3.Size = new System.Drawing.Size(49, 22);
      this.toolStripDropDownButton3.Text = "Tools";
      //
      // preferencesToolStripMenuItem
      //
      this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLocale,
            this.mniTimeZone,
            this.mniTimeout});
      this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
      this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
      this.preferencesToolStripMenuItem.Text = "Preferences";
      //
      // mniLocale
      //
      this.mniLocale.Name = "mniLocale";
      this.mniLocale.ShortcutKeyDisplayString = "";
      this.mniLocale.Size = new System.Drawing.Size(140, 22);
      this.mniLocale.Text = "Locale...";
      this.mniLocale.Click += new System.EventHandler(this.mniLocale_Click);
      //
      // mniTimeZone
      //
      this.mniTimeZone.Name = "mniTimeZone";
      this.mniTimeZone.ShortcutKeyDisplayString = "";
      this.mniTimeZone.Size = new System.Drawing.Size(140, 22);
      this.mniTimeZone.Text = "Time Zone...";
      this.mniTimeZone.Click += new System.EventHandler(this.mniTimeZone_Click);
      //
      // mniTimeout
      //
      this.mniTimeout.Name = "mniTimeout";
      this.mniTimeout.Size = new System.Drawing.Size(140, 22);
      this.mniTimeout.Text = "Timeout...";
      this.mniTimeout.Click += new System.EventHandler(this.mniTimeout_Click);
      //
      // exploreButton
      //
      this.exploreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.exploreButton.Image = ((System.Drawing.Image)(resources.GetObject("exploreButton.Image")));
      this.exploreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.exploreButton.Name = "exploreButton";
      this.exploreButton.Size = new System.Drawing.Size(49, 22);
      this.exploreButton.Text = "Explore";
      this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
      //
      // btnSubmit
      //
      this.btnSubmit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.btnSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btnSubmit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRunAll,
            this.mniRunCurrent,
            this.mniRunCurrentNewWindow});
      this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
      this.btnSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(57, 22);
      this.btnSubmit.Text = "► Run";
      this.btnSubmit.ToolTipText = "Run";
      this.btnSubmit.ButtonClick += new System.EventHandler(this.btnSubmit_Click);
      //
      // mniRunAll
      //
      this.mniRunAll.Name = "mniRunAll";
      this.mniRunAll.ShortcutKeyDisplayString = "F5";
      this.mniRunAll.Size = new System.Drawing.Size(225, 22);
      this.mniRunAll.Text = "Run All";
      this.mniRunAll.Click += new System.EventHandler(this.mniRunAll_Click);
      //
      // mniRunCurrent
      //
      this.mniRunCurrent.Name = "mniRunCurrent";
      this.mniRunCurrent.ShortcutKeyDisplayString = "Ctrl+Enter";
      this.mniRunCurrent.Size = new System.Drawing.Size(225, 22);
      this.mniRunCurrent.Text = "Run Current";
      this.mniRunCurrent.Click += new System.EventHandler(this.mniRunCurrent_Click);
      //
      // mniRunCurrentNewWindow
      //
      this.mniRunCurrentNewWindow.Name = "mniRunCurrentNewWindow";
      this.mniRunCurrentNewWindow.Size = new System.Drawing.Size(225, 22);
      this.mniRunCurrentNewWindow.Text = "Run Current in New Window";
      this.mniRunCurrentNewWindow.Click += new System.EventHandler(this.mniRunCurrentNewWindow_Click);
      //
      // EditorWindow
      //
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(701, 515);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "EditorWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "AmlStudio";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.splitMain.Panel1.ResumeLayout(false);
      this.splitMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
      this.splitMain.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.treeItems)).EndInit();
      this.splitEditors.Panel1.ResumeLayout(false);
      this.splitEditors.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitEditors)).EndInit();
      this.splitEditors.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tbcOutputView.ResumeLayout(false);
      this.pgTextOutput.ResumeLayout(false);
      this.pgTableOutput.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
      this.conTable.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.SplitContainer splitMain;
    private Controls.FlatButton btnOk;
    private Controls.FlatButton btnCancel;
    private System.Windows.Forms.Label lblItems;
    private System.Windows.Forms.ContextMenuStrip conTable;
    private System.Windows.Forms.ToolStripMenuItem scriptEditsToToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mniTableEditsToQueryEditor;
    private System.Windows.Forms.ToolStripMenuItem mniTableEditsToClipboard;
    private System.Windows.Forms.ToolStripMenuItem mniTableEditsToFile;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem mniAcceptChanges;
    private System.Windows.Forms.ToolStripMenuItem mniResetChanges;
    private System.Windows.Forms.ToolStrip menuStrip;
    private System.Windows.Forms.ToolStripLabel lblConnection;
    private System.Windows.Forms.ToolStripButton btnEditConnections;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem mniTidyXml;
    private System.Windows.Forms.ToolStripLabel lblSoapAction;
    private System.Windows.Forms.ToolStripButton btnSoapAction;
    private System.Windows.Forms.ToolStripSplitButton btnSubmit;
    private System.Windows.Forms.ToolStripMenuItem mniRunAll;
    private System.Windows.Forms.ToolStripMenuItem mniRunCurrent;
    private System.Windows.Forms.ToolStripMenuItem mniRunCurrentNewWindow;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    private System.Windows.Forms.ToolStripMenuItem mniNewWindow;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem mniClose;
    private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mniLocale;
    private System.Windows.Forms.ToolStripMenuItem mniTimeZone;
    private System.Windows.Forms.ToolStripMenuItem mniTimeout;
    private System.Windows.Forms.Label lblConnColor;
    private System.Windows.Forms.ToolStripButton exploreButton;
    private System.Windows.Forms.SplitContainer splitEditors;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private Editor.EditorControl inputEditor;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TabControl tbcOutputView;
    private System.Windows.Forms.TabPage pgTextOutput;
    private Editor.EditorControl outputEditor;
    private System.Windows.Forms.TabPage pgTableOutput;
    private System.Windows.Forms.DataGridView dgvItems;
    private TreeListView treeItems;
    private BrightIdeasSoftware.OLVColumn colName;
    private BrightIdeasSoftware.OLVColumn colDescription;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mniUppercase;
    private System.Windows.Forms.ToolStripMenuItem mniLowercase;
    private System.Windows.Forms.ToolStripMenuItem lineOperationsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mniMoveUpCurrentLine;
    private System.Windows.Forms.ToolStripMenuItem mniMoveDownCurrentLine;
    private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mniXmlToEntity;
    private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mniInsertNewGuid;
    private System.Windows.Forms.ToolStripMenuItem mniEntityToXml;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private Controls.FlatButton btnPanelToggle;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
    private System.Windows.Forms.ToolStripMenuItem mniUndo;
    private System.Windows.Forms.ToolStripMenuItem mniRedo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem mniCut;
    private System.Windows.Forms.ToolStripMenuItem mniCopy;
    private System.Windows.Forms.ToolStripMenuItem mniPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem mniDoubleToSingleQuotes;
    private System.Windows.Forms.ToolStripMenuItem mniSingleToDoubleQuotes;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem mniMd5Encode;
  }
}