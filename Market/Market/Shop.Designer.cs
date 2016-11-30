namespace Market
{
    partial class Shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridDiscsMy = new System.Windows.Forms.DataGridView();
            this.gridDiscsTake = new System.Windows.Forms.DataGridView();
            this.disc_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscsMy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscsTake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "maxcriser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range of discs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(15, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Your discs:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gridDiscsMy
            // 
            this.gridDiscsMy.AllowUserToAddRows = false;
            this.gridDiscsMy.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridDiscsMy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiscsMy.ColumnHeadersVisible = false;
            this.gridDiscsMy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.whome,
            this.date,
            this.return_disc});
            this.gridDiscsMy.Location = new System.Drawing.Point(18, 345);
            this.gridDiscsMy.Name = "gridDiscsMy";
            this.gridDiscsMy.ReadOnly = true;
            this.gridDiscsMy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDiscsMy.RowHeadersVisible = false;
            this.gridDiscsMy.RowTemplate.ReadOnly = true;
            this.gridDiscsMy.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiscsMy.ShowCellErrors = false;
            this.gridDiscsMy.ShowCellToolTips = false;
            this.gridDiscsMy.ShowEditingIcon = false;
            this.gridDiscsMy.ShowRowErrors = false;
            this.gridDiscsMy.Size = new System.Drawing.Size(464, 116);
            this.gridDiscsMy.TabIndex = 5;
            // 
            // gridDiscsTake
            // 
            this.gridDiscsTake.AllowUserToAddRows = false;
            this.gridDiscsTake.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridDiscsTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiscsTake.ColumnHeadersVisible = false;
            this.gridDiscsTake.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disc_title,
            this.state,
            this.who,
            this.remove});
            this.gridDiscsTake.Location = new System.Drawing.Point(18, 57);
            this.gridDiscsTake.Name = "gridDiscsTake";
            this.gridDiscsTake.ReadOnly = true;
            this.gridDiscsTake.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDiscsTake.RowHeadersVisible = false;
            this.gridDiscsTake.RowTemplate.ReadOnly = true;
            this.gridDiscsTake.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiscsTake.ShowCellErrors = false;
            this.gridDiscsTake.ShowCellToolTips = false;
            this.gridDiscsTake.ShowEditingIcon = false;
            this.gridDiscsTake.ShowRowErrors = false;
            this.gridDiscsTake.Size = new System.Drawing.Size(464, 264);
            this.gridDiscsTake.TabIndex = 6;
            this.gridDiscsTake.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDiscsTake_CellContentClick);
            // 
            // disc_title
            // 
            this.disc_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.disc_title.HeaderText = "Disc title";
            this.disc_title.Name = "disc_title";
            this.disc_title.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 80;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 80;
            // 
            // who
            // 
            this.who.HeaderText = "Who";
            this.who.MinimumWidth = 150;
            this.who.Name = "who";
            this.who.ReadOnly = true;
            this.who.Width = 150;
            // 
            // remove
            // 
            this.remove.HeaderText = "REMOVE";
            this.remove.MinimumWidth = 100;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Disc title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // whome
            // 
            this.whome.HeaderText = "Who me";
            this.whome.Name = "whome";
            this.whome.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 150;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // return_disc
            // 
            this.return_disc.HeaderText = "Return";
            this.return_disc.MinimumWidth = 150;
            this.return_disc.Name = "return_disc";
            this.return_disc.ReadOnly = true;
            this.return_disc.Width = 150;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 473);
            this.Controls.Add(this.gridDiscsTake);
            this.Controls.Add(this.gridDiscsMy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscsMy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscsTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridDiscsMy;
        private System.Windows.Forms.DataGridView gridDiscsTake;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn who;
        private System.Windows.Forms.DataGridViewTextBoxColumn remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn whome;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_disc;
    }
}