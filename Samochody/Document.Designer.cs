namespace Samochody
{
    partial class Document
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.numerPojazdu = new System.Windows.Forms.ColumnHeader();
            this.markaPojazdu = new System.Windows.Forms.ColumnHeader();
            this.maksymalnaPredkosc = new System.Windows.Forms.ColumnHeader();
            this.dataProdukcji = new System.Windows.Forms.ColumnHeader();
            this.rodzajPojazdu = new System.Windows.Forms.ColumnHeader();
            this.dodajNowyPojazdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EdytujItoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dodajNowyPojazdToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujIstniejacyPojazdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńIstniejacyPojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNowyPojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujIstniejacyPojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńIstniejącyPojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numerPojazdu,
            this.markaPojazdu,
            this.maksymalnaPredkosc,
            this.dataProdukcji,
            this.rodzajPojazdu});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 234);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // numerPojazdu
            // 
            this.numerPojazdu.Text = "Numer pojazdu";
            this.numerPojazdu.Width = 87;
            // 
            // markaPojazdu
            // 
            this.markaPojazdu.Text = "Marka pojazdu";
            this.markaPojazdu.Width = 82;
            // 
            // maksymalnaPredkosc
            // 
            this.maksymalnaPredkosc.Text = "Maksymalna prędkość";
            this.maksymalnaPredkosc.Width = 120;
            // 
            // dataProdukcji
            // 
            this.dataProdukcji.Text = "Data produkcji";
            this.dataProdukcji.Width = 87;
            // 
            // rodzajPojazdu
            // 
            this.rodzajPojazdu.Text = "Rodzaj pojazdu";
            this.rodzajPojazdu.Width = 92;
            // 
            // dodajNowyPojazdToolStripMenuItem1
            // 
            this.dodajNowyPojazdToolStripMenuItem1.Name = "dodajNowyPojazdToolStripMenuItem1";
            this.dodajNowyPojazdToolStripMenuItem1.Size = new System.Drawing.Size(120, 20);
            this.dodajNowyPojazdToolStripMenuItem1.Text = "Dodaj nowy pojazd";
            // 
            // EdytujItoolStripMenuItem1
            // 
            this.EdytujItoolStripMenuItem1.Name = "EdytujItoolStripMenuItem1";
            this.EdytujItoolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.EdytujItoolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(511, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrowanie pojazdów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybierz sposób wyświetlania pojazdów";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wyświetlanie wszystkich pojazdów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Wyświetlanie pojazdów o maksymalnej prędkości nie mniejszej niż 100 km/h";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Wyświetlanie pojazdów o maksymalnej prędkości mniejszej niż 100 km/h";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dodajNowyPojazdToolStripMenuItem2
            // 
            this.dodajNowyPojazdToolStripMenuItem2.Name = "dodajNowyPojazdToolStripMenuItem2";
            this.dodajNowyPojazdToolStripMenuItem2.Size = new System.Drawing.Size(120, 20);
            this.dodajNowyPojazdToolStripMenuItem2.Text = "Dodaj nowy pojazd";
            this.dodajNowyPojazdToolStripMenuItem2.Click += new System.EventHandler(this.CarAddClicked);
            // 
            // edytujIstniejacyPojazdToolStripMenuItem1
            // 
            this.edytujIstniejacyPojazdToolStripMenuItem1.Name = "edytujIstniejacyPojazdToolStripMenuItem1";
            this.edytujIstniejacyPojazdToolStripMenuItem1.Size = new System.Drawing.Size(142, 20);
            this.edytujIstniejacyPojazdToolStripMenuItem1.Text = "Edytuj istniejący pojazd";
            this.edytujIstniejacyPojazdToolStripMenuItem1.Click += new System.EventHandler(this.CarEditClicked);
            // 
            // usuńIstniejacyPojazdToolStripMenuItem
            // 
            this.usuńIstniejacyPojazdToolStripMenuItem.Name = "usuńIstniejacyPojazdToolStripMenuItem";
            this.usuńIstniejacyPojazdToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.usuńIstniejacyPojazdToolStripMenuItem.Text = "Usuń istniejący pojazd";
            this.usuńIstniejacyPojazdToolStripMenuItem.Click += new System.EventHandler(this.CarRemoveClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyPojazdToolStripMenuItem2,
            this.edytujIstniejacyPojazdToolStripMenuItem1,
            this.usuńIstniejacyPojazdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // dodajNowyPojazdToolStripMenuItem
            // 
            this.dodajNowyPojazdToolStripMenuItem.Name = "dodajNowyPojazdToolStripMenuItem";
            this.dodajNowyPojazdToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dodajNowyPojazdToolStripMenuItem.Text = "Dodaj nowy pojazd";
            this.dodajNowyPojazdToolStripMenuItem.Click += new System.EventHandler(this.CarAddClicked);
            // 
            // edytujIstniejacyPojazdToolStripMenuItem
            // 
            this.edytujIstniejacyPojazdToolStripMenuItem.Name = "edytujIstniejacyPojazdToolStripMenuItem";
            this.edytujIstniejacyPojazdToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.edytujIstniejacyPojazdToolStripMenuItem.Text = "Edytuj istniejący pojazd";
            this.edytujIstniejacyPojazdToolStripMenuItem.Click += new System.EventHandler(this.CarEditClicked);
            // 
            // usuńIstniejącyPojazdToolStripMenuItem
            // 
            this.usuńIstniejącyPojazdToolStripMenuItem.Name = "usuńIstniejącyPojazdToolStripMenuItem";
            this.usuńIstniejącyPojazdToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.usuńIstniejącyPojazdToolStripMenuItem.Text = "Usuń istniejący pojazd";
            this.usuńIstniejącyPojazdToolStripMenuItem.Click += new System.EventHandler(this.CarRemoveClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyPojazdToolStripMenuItem,
            this.edytujIstniejacyPojazdToolStripMenuItem,
            this.usuńIstniejącyPojazdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(472, 233);
            this.treeView1.TabIndex = 3;
            this.treeView1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(217, 17);
            this.toolStripStatusLabel1.Text = "liczba elementów w aktywnym widoku: ";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Document";
            this.Text = "Document";
            this.Deactivate += new System.EventHandler(this.Document_Deactivate);
            this.Activated += new System.EventHandler(this.Document_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Document_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader numerPojazdu;
        private System.Windows.Forms.ColumnHeader markaPojazdu;
        private System.Windows.Forms.ColumnHeader maksymalnaPredkosc;
        private System.Windows.Forms.ColumnHeader dataProdukcji;
        private System.Windows.Forms.ColumnHeader rodzajPojazdu;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyPojazdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EdytujItoolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyPojazdToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem edytujIstniejacyPojazdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńIstniejacyPojazdToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyPojazdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujIstniejacyPojazdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńIstniejącyPojazdToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

