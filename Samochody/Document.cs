using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Samochody
{
    public partial class Document : Form
    {
        private CarManager carManager = null;
        private ListView listView = new ListView();
        public enum viewType {listView, treeView, noView};
        public enum filterType {all, fasterThan100, slowerThan100};
        public viewType currentViewType;
        public filterType currentFilterType;
        public Boolean parentClosing = false;

        public Document()
        {
            InitializeComponent();
            listView.Parent = this;
            currentViewType = viewType.noView;
            currentFilterType = filterType.all;
            this.listView1.Visible = false;
            this.treeView1.Visible = false;
            listView.Show();
        }

        public Document(CarManager carManager)
        {
            this.carManager = carManager;
            InitializeComponent();
            listView.Parent = this;
            currentViewType = viewType.noView;
            currentFilterType = filterType.all;
            this.listView1.Visible = false;
            this.treeView1.Visible = false;
            listView.Show();
        }

        public CarManager GetCarManager()
        {
            return this.carManager;
        }

        public void SetListView()
        {
            this.listView1.Visible = true;
            this.treeView1.Visible = false;
            UpdateStatusStrip();
        }

        public void SetTreeView()
        {
            this.listView1.Visible = false;
            this.treeView1.Visible = true;
            UpdateStatusStrip();
        }

        public void SetNoView()
        {
            this.listView1.Visible = false;
            this.treeView1.Visible = false;
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            ToolStripManager.RevertMerge(((MDIParent)this.MdiParent).GetStatusStrip(), this.statusStrip1);
            UpdateStatusStripLabel();
            ToolStripManager.Merge(this.statusStrip1, ((MDIParent)this.MdiParent).GetStatusStrip());
        }

        private void UpdateStatusStripLabel()
        {
            switch (currentViewType)
            { 
                case viewType.listView:
                    this.statusStrip1.Items[0].Text = "liczba elementów w aktywnym widoku: " + this.listView1.Items.Count;
                    break;
                case viewType.treeView:
                    this.statusStrip1.Items[0].Text = "liczba elementów w aktywnym widoku: " + this.treeView1.Nodes.Count;
                    break;
                case viewType.noView:
                    this.statusStrip1.Items[0].Text = "liczba elementów w aktywnym widoku: 0";
                    break;
            }
        }

        public void UpdateView(String operation, Car car, int id)
        {
            if (currentViewType.Equals(viewType.treeView))
            {
                if (operation.Equals("Addition"))
                {
                    if ((Equals(currentFilterType,filterType.fasterThan100) && car.GetMaximalSpeed() < 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() >= 100))
                        ;
                    else
                    {
                        TreeNode newNode = car.CreateTreeNode();
                        treeView1.Nodes.Add(newNode); 
                    }
                }
                else if (operation.Equals("Edition"))
                {
                    int index = treeSearch(id);
                    if (index != -1)
                    {
                        if ((Equals(currentFilterType, filterType.fasterThan100) && car.GetMaximalSpeed() < 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() >= 100))
                            UpdateView("Removal", car, id);
                        else
                        {
                            treeView1.Nodes[index].Nodes[0].Text = car.GetBrand();
                            treeView1.Nodes[index].Nodes[1].Text = car.GetMaximalSpeed().ToString();
                            treeView1.Nodes[index].Nodes[2].Text = car.GetDate().ToShortDateString();
                            treeView1.Nodes[index].Nodes[3].Text = car.GetCarType();
                        }
                    }
                    else if ((Equals(currentFilterType, filterType.fasterThan100) && car.GetMaximalSpeed() >= 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() < 100))
                    {
                        UpdateView("Addition", car, id);
                    }
                }
                else if (operation.Equals("Removal"))
                {
                    int index = treeSearch(id);
                    if (index != -1)
                        treeView1.Nodes[index].Remove();
                }
            }
            if (currentViewType.Equals(viewType.listView))
            {
                if (operation.Equals("Addition"))
                {
                    if ((Equals(currentFilterType, filterType.fasterThan100) && car.GetMaximalSpeed() < 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() >= 100))
                        ;
                    else
                    {
                        ListViewItem newItem = car.CreateListViewItem();
                        listView1.Items.Add(newItem);
                    }
                }
                else if (operation.Equals("Edition"))
                {
                    int index = listSearch(id);
                    if (index != -1)
                    {
                        if ((Equals(currentFilterType, filterType.fasterThan100) && car.GetMaximalSpeed() < 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() >= 100))
                            UpdateView("Removal", car, id);
                        else
                        {
                            listView1.Items[index].SubItems[1].Text = car.GetBrand();
                            listView1.Items[index].SubItems[2].Text = car.GetMaximalSpeed().ToString();
                            listView1.Items[index].SubItems[3].Text = car.GetDate().ToShortDateString();
                            listView1.Items[index].SubItems[4].Text = car.GetCarType();
                        }
                    }
                    else if ((Equals(currentFilterType, filterType.fasterThan100) && car.GetMaximalSpeed() >= 100)
                        || (Equals(currentFilterType, filterType.slowerThan100) && car.GetMaximalSpeed() < 100))
                    {
                        UpdateView("Addition", car, id);
                    }
                }
                else if (operation.Equals("Removal"))
                {
                    int index = listSearch(id);
                    if (index != -1)
                        listView1.Items.RemoveAt(index);
                }
            }
            else if (currentViewType.Equals(viewType.noView))
            { 
            
            }
            if(Equals(this.MdiParent.ActiveMdiChild, this))
                UpdateStatusStrip();
            else
                UpdateStatusStripLabel();
        }

        void CarAddClicked(object sender, EventArgs evArgs)
        {
            CarAddWindow carAddWindow = new CarAddWindow(this.carManager);
            carAddWindow.ShowDialog();
        }

        void CarEditClicked(object sender, EventArgs evArgs)
        {
            if (this.carManager.GetCarList().Count > 0)
            {
                CarEditWindow carEditWindow = new CarEditWindow(this.carManager);
                carEditWindow.ShowDialog();
            }
        }

        void CarRemoveClicked(object sender, EventArgs evArgs)
        {
            if (this.carManager.GetCarList().Count > 0)
            {
                CarRemoveWindow carRemoveWindow = new CarRemoveWindow(this.carManager);
                carRemoveWindow.ShowDialog();
            }
        }

        public void button1_Click(object sender, EventArgs e) // wyswietlanie wszystkich pojazdow
        {
            currentFilterType = filterType.all;
            if (currentViewType.Equals(viewType.treeView))
            {
                TreeNode newNode = null;

                this.treeView1.Nodes.Clear();

                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    newNode = (this.carManager.GetCarList())[i].CreateTreeNode();
                    this.treeView1.Nodes.Add(newNode);
                }
            }
            else if (currentViewType.Equals(viewType.listView))
            {
                ListViewItem newItem = null;

                this.listView1.Items.Clear();

                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    newItem = (this.carManager.GetCarList())[i].CreateListViewItem();
                    this.listView1.Items.Add(newItem);
                }
            }
            else if (currentViewType.Equals(viewType.noView))
            { }
            UpdateStatusStrip();
        }

        private void button2_Click(object sender, EventArgs e) // wyswietlanie pojazdow o predkosci nie mniejszej niz 100 km/h
        {
            currentFilterType = filterType.fasterThan100;
            if (currentViewType.Equals(viewType.treeView))
            {
                TreeNode newNode = null;

                this.treeView1.Nodes.Clear();

                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    if ((this.carManager.GetCarList())[i].GetMaximalSpeed() >= 100)
                    {
                        newNode = (this.carManager.GetCarList())[i].CreateTreeNode();
                        this.treeView1.Nodes.Add(newNode);
                    }
                }
            }
            else if (currentViewType.Equals(viewType.listView))
            {
                ListViewItem newItem = null;

                this.listView1.Items.Clear();
                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    if ((this.carManager.GetCarList())[i].GetMaximalSpeed() >= 100)
                    {
                        newItem = (this.carManager.GetCarList())[i].CreateListViewItem();
                        this.listView1.Items.Add(newItem);
                    }
                } 
            }
            else if (currentViewType.Equals(viewType.noView))
            { }
            UpdateStatusStrip();
        }

        private void button3_Click(object sender, EventArgs e) // wyswietlanie pojazdow o predkosci mniejszej niz 100 km/h
        {
            currentFilterType = filterType.slowerThan100;
            if (currentViewType.Equals(viewType.treeView))
            {
                TreeNode newNode = null;

                this.treeView1.Nodes.Clear();

                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    if ((this.carManager.GetCarList())[i].GetMaximalSpeed() < 100)
                    {
                        newNode = (this.carManager.GetCarList())[i].CreateTreeNode();
                        this.treeView1.Nodes.Add(newNode);
                    }
                }
            }
            else if (currentViewType.Equals(viewType.listView))
            {
                ListViewItem newItem = null;

                this.listView1.Items.Clear();
                for (int i = 0; i < this.carManager.GetCarList().Count; i++)
                {
                    if ((this.carManager.GetCarList())[i].GetMaximalSpeed() < 100)
                    {
                        newItem = (this.carManager.GetCarList())[i].CreateListViewItem();
                        this.listView1.Items.Add(newItem);
                    }
                } 
            }
            else if (currentViewType.Equals(viewType.noView))
            { }
            UpdateStatusStrip();
        }

        private void Document_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.carManager.GetMDIParent().MdiChildren.Length == 1
                && !e.CloseReason.Equals(CloseReason.MdiFormClosing))
                e.Cancel = true;
        }

        private void Document_Activated(object sender, EventArgs e)
        {
            UpdateStatusStripLabel();
            ToolStripManager.Merge(this.statusStrip1, ((MDIParent)this.MdiParent).GetStatusStrip());            
        }

        private void Document_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MDIParent)this.MdiParent).GetStatusStrip(), this.statusStrip1);
        }

        private int listSearch(int id)
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (id == Int32.Parse(this.listView1.Items[i].SubItems[0].Text))
                    return i;
            }
            return -1;
        }

        private int treeSearch(int id)
        {
            for (int i = 0; i < this.treeView1.Nodes.Count; i++)
            {
                if (id == Int32.Parse(this.treeView1.Nodes[i].Text))
                    return i;
            }
            return -1;
        }

    }
}
