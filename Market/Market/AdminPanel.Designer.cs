namespace Market
{
    partial class AdminPanel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDiscs = new System.Windows.Forms.DataGridView();
            this.disc_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(412, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product list:";
            // 
            // gridDiscs
            // 
            this.gridDiscs.AllowUserToAddRows = false;
            this.gridDiscs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridDiscs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiscs.ColumnHeadersVisible = false;
            this.gridDiscs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disc_title,
            this.state,
            this.who,
            this.delete});
            this.gridDiscs.Location = new System.Drawing.Point(12, 64);
            this.gridDiscs.Name = "gridDiscs";
            this.gridDiscs.ReadOnly = true;
            this.gridDiscs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDiscs.RowHeadersVisible = false;
            this.gridDiscs.RowTemplate.ReadOnly = true;
            this.gridDiscs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiscs.ShowCellErrors = false;
            this.gridDiscs.ShowCellToolTips = false;
            this.gridDiscs.ShowEditingIcon = false;
            this.gridDiscs.ShowRowErrors = false;
            this.gridDiscs.Size = new System.Drawing.Size(464, 364);
            this.gridDiscs.TabIndex = 2;
            this.gridDiscs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDiscs_CellContentClick);
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
            // delete
            // 
            this.delete.HeaderText = "DELETE";
            this.delete.MinimumWidth = 60;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 60;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDiscs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridDiscs;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn who;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
    }
}