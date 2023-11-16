namespace MorseCodeTranslator
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbBtnRefresh = new System.Windows.Forms.PictureBox();
            this.pbBtnDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridView1.Location = new System.Drawing.Point(17, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(729, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label4.Location = new System.Drawing.Point(297, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbClear
            // 
            this.pbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClear.Image = global::MorseCodeTranslator.Properties.Resources.Group_8;
            this.pbClear.Location = new System.Drawing.Point(512, 467);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(111, 56);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClear.TabIndex = 14;
            this.pbClear.TabStop = false;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // pbBtnRefresh
            // 
            this.pbBtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnRefresh.Image = global::MorseCodeTranslator.Properties.Resources.Group_10;
            this.pbBtnRefresh.Location = new System.Drawing.Point(88, 467);
            this.pbBtnRefresh.Name = "pbBtnRefresh";
            this.pbBtnRefresh.Size = new System.Drawing.Size(130, 56);
            this.pbBtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBtnRefresh.TabIndex = 13;
            this.pbBtnRefresh.TabStop = false;
            this.pbBtnRefresh.Click += new System.EventHandler(this.pbBtnRefresh_Click);
            // 
            // pbBtnDelete
            // 
            this.pbBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnDelete.Image = global::MorseCodeTranslator.Properties.Resources.Group_9;
            this.pbBtnDelete.Location = new System.Drawing.Point(305, 467);
            this.pbBtnDelete.Name = "pbBtnDelete";
            this.pbBtnDelete.Size = new System.Drawing.Size(120, 56);
            this.pbBtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBtnDelete.TabIndex = 12;
            this.pbBtnDelete.TabStop = false;
            this.pbBtnDelete.Click += new System.EventHandler(this.pbBtnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MorseCodeTranslator.Properties.Resources.cross_1;
            this.pictureBox2.Location = new System.Drawing.Point(645, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(758, 598);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.pbBtnRefresh);
            this.Controls.Add(this.pbBtnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistory";
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmHistory_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHistory_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbBtnDelete;
        private System.Windows.Forms.PictureBox pbBtnRefresh;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}