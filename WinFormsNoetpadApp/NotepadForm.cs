namespace WinFormsNoetpadApp
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();


            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.CreatePrompt = true;

            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            ToolStripMenuItem serviceItem = new ToolStripMenuItem();
            serviceItem.Text = "Service";
            menuMain.Items.Add(serviceItem);

            ToolStripMenuItem colorItem = new ToolStripMenuItem("Color");
            ToolStripMenuItem fontItem = new ToolStripMenuItem("Font");
            fontItem.Click += fontToolStripMenuItem_Click!;

            serviceItem.DropDownItems.Add(colorItem);
            serviceItem.DropDownItems.Add(fontItem);

            ToolStripMenuItem colorForeItem = new ToolStripMenuItem("Fore");
            colorForeItem.Click += colorForeToolStripMenuItem_Click!;
            ToolStripMenuItem colorBackItem = new ToolStripMenuItem("Back");
            colorBackItem.Click += colorBackToolStripMenuItem_Click!;

            colorItem.DropDownItems.Add(colorForeItem);
            colorItem.DropDownItems.Add(colorBackItem);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog.FileName;
            string text = File.ReadAllText(fileName);
            textBoxEditor.Text = text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, textBoxEditor.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, textBoxEditor.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorForeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxEditor.BackColor = colorDialog.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = textBoxEditor.Font;
            fontDialog.ShowColor = true;
            fontDialog.Color = textBoxEditor.ForeColor;

            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;

            textBoxEditor.Font = fontDialog.Font;
            textBoxEditor.ForeColor = fontDialog.Color;
        }
    }
}
