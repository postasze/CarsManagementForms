using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samochody
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        private CarManager carManager;

        public MDIParent()
        {
            carManager = new CarManager(this);
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Document(this.carManager);
            childForm.MdiParent = this;
            childForm.Text = "Pojazdy " + ++childFormNumber;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void widokListyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Document)this.ActiveMdiChild).currentViewType = Document.viewType.listView;
            ((Document)this.ActiveMdiChild).button1_Click(sender, e);
            ((Document)this.ActiveMdiChild).SetListView();
        }

        private void widokDrzewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Document)this.ActiveMdiChild).currentViewType = Document.viewType.treeView;
            ((Document)this.ActiveMdiChild).button1_Click(sender, e);
            ((Document)this.ActiveMdiChild).SetTreeView();
        }

        private void brakWidokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Document)this.ActiveMdiChild).currentViewType = Document.viewType.noView;
            ((Document)this.ActiveMdiChild).SetNoView();
        }

        public StatusStrip GetStatusStrip()
        {
            return this.statusStrip;
        }

        public MenuStrip GetMenuStrip()
        {
            return this.menuStrip;
        }
    }
}
