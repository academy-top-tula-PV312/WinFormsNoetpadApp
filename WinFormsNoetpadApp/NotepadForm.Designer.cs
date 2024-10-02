namespace WinFormsNoetpadApp
{
    partial class NotepadForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            textBoxEditor = new TextBox();
            contextMenuEditor = new ContextMenuStrip(components);
            openToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolMain = new ToolStrip();
            toolMainOpenFile = new ToolStripButton();
            statusMain = new StatusStrip();
            toolStatusColumn = new ToolStripStatusLabel();
            contextMenuEditor.SuspendLayout();
            menuMain.SuspendLayout();
            toolMain.SuspendLayout();
            statusMain.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEditor
            // 
            textBoxEditor.ContextMenuStrip = contextMenuEditor;
            textBoxEditor.Dock = DockStyle.Fill;
            textBoxEditor.Location = new Point(0, 24);
            textBoxEditor.Multiline = true;
            textBoxEditor.Name = "textBoxEditor";
            textBoxEditor.Size = new Size(744, 447);
            textBoxEditor.TabIndex = 0;
            textBoxEditor.TextChanged += textBoxEditor_TextChanged;
            // 
            // contextMenuEditor
            // 
            contextMenuEditor.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem1, saveToolStripMenuItem1 });
            contextMenuEditor.Name = "contextMenuEditor";
            contextMenuEditor.Size = new Size(104, 48);
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(103, 22);
            openToolStripMenuItem1.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(103, 22);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(744, 24);
            menuMain.TabIndex = 3;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolMain
            // 
            toolMain.Items.AddRange(new ToolStripItem[] { toolMainOpenFile });
            toolMain.Location = new Point(0, 24);
            toolMain.Name = "toolMain";
            toolMain.Size = new Size(744, 25);
            toolMain.Stretch = true;
            toolMain.TabIndex = 4;
            // 
            // toolMainOpenFile
            // 
            toolMainOpenFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolMainOpenFile.Image = (Image)resources.GetObject("toolMainOpenFile.Image");
            toolMainOpenFile.ImageTransparentColor = Color.Magenta;
            toolMainOpenFile.Name = "toolMainOpenFile";
            toolMainOpenFile.Size = new Size(23, 22);
            toolMainOpenFile.Text = "toolStripButton1";
            toolMainOpenFile.Click += openToolStripMenuItem_Click;
            // 
            // statusMain
            // 
            statusMain.Items.AddRange(new ToolStripItem[] { toolStatusColumn });
            statusMain.Location = new Point(0, 449);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(744, 22);
            statusMain.TabIndex = 5;
            statusMain.Text = "statusStrip1";
            // 
            // toolStatusColumn
            // 
            toolStatusColumn.Name = "toolStatusColumn";
            toolStatusColumn.Size = new Size(0, 17);
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 471);
            Controls.Add(statusMain);
            Controls.Add(toolMain);
            Controls.Add(textBoxEditor);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "NotepadForm";
            Text = "Form1";
            contextMenuEditor.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEditor;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolMain;
        private ToolStripButton toolMainOpenFile;
        private StatusStrip statusMain;
        private ToolStripStatusLabel toolStatusColumn;
        private ContextMenuStrip contextMenuEditor;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
    }
}
