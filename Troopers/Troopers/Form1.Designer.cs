namespace Troopers
{
    partial class Form1
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
            this.listBoxTroopers = new System.Windows.Forms.ListBox();
            this.textBoxTrooperSearch = new System.Windows.Forms.TextBox();
            this.textBoxSquadName = new System.Windows.Forms.TextBox();
            this.buttonAddTrooperForSquad = new System.Windows.Forms.Button();
            this.listBoxSquadTeam = new System.Windows.Forms.ListBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBoxTroopers
            // 
            this.listBoxTroopers.FormattingEnabled = true;
            this.listBoxTroopers.ItemHeight = 16;
            this.listBoxTroopers.Location = new System.Drawing.Point(32, 90);
            this.listBoxTroopers.Name = "listBoxTroopers";
            this.listBoxTroopers.Size = new System.Drawing.Size(204, 292);
            this.listBoxTroopers.TabIndex = 0;
            // 
            // textBoxTrooperSearch
            // 
            this.textBoxTrooperSearch.Location = new System.Drawing.Point(32, 62);
            this.textBoxTrooperSearch.Name = "textBoxTrooperSearch";
            this.textBoxTrooperSearch.Size = new System.Drawing.Size(204, 22);
            this.textBoxTrooperSearch.TabIndex = 1;
            this.textBoxTrooperSearch.TextChanged += new System.EventHandler(this.textBoxTrooperSearch_TextChanged);
            // 
            // textBoxSquadName
            // 
            this.textBoxSquadName.Location = new System.Drawing.Point(270, 62);
            this.textBoxSquadName.Name = "textBoxSquadName";
            this.textBoxSquadName.Size = new System.Drawing.Size(204, 22);
            this.textBoxSquadName.TabIndex = 2;
            this.textBoxSquadName.TextChanged += new System.EventHandler(this.textBoxSquadName_TextChanged);
            // 
            // buttonAddTrooperForSquad
            // 
            this.buttonAddTrooperForSquad.Location = new System.Drawing.Point(270, 90);
            this.buttonAddTrooperForSquad.Name = "buttonAddTrooperForSquad";
            this.buttonAddTrooperForSquad.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTrooperForSquad.TabIndex = 3;
            this.buttonAddTrooperForSquad.Text = "Add";
            this.buttonAddTrooperForSquad.UseVisualStyleBackColor = true;
            this.buttonAddTrooperForSquad.Click += new System.EventHandler(this.buttonAddTrooperForSquad_Click);
            // 
            // listBoxSquadTeam
            // 
            this.listBoxSquadTeam.FormattingEnabled = true;
            this.listBoxSquadTeam.ItemHeight = 16;
            this.listBoxSquadTeam.Location = new System.Drawing.Point(488, 90);
            this.listBoxSquadTeam.Name = "listBoxSquadTeam";
            this.listBoxSquadTeam.Size = new System.Drawing.Size(204, 292);
            this.listBoxSquadTeam.TabIndex = 4;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(698, 359);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busqueda trooper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.listBoxSquadTeam);
            this.Controls.Add(this.buttonAddTrooperForSquad);
            this.Controls.Add(this.textBoxSquadName);
            this.Controls.Add(this.textBoxTrooperSearch);
            this.Controls.Add(this.listBoxTroopers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTroopers;
        private System.Windows.Forms.TextBox textBoxTrooperSearch;
        private System.Windows.Forms.TextBox textBoxSquadName;
        private System.Windows.Forms.Button buttonAddTrooperForSquad;
        private System.Windows.Forms.ListBox listBoxSquadTeam;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

