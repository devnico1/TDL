namespace ToDoList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LTotalTasks = new System.Windows.Forms.Label();
            this.LTasks = new System.Windows.Forms.Label();
            this.CLB = new System.Windows.Forms.CheckedListBox();
            this.BCreate = new System.Windows.Forms.Button();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.BDelete = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.LTotalTasks);
            this.groupBox1.Controls.Add(this.LTasks);
            this.groupBox1.Controls.Add(this.CLB);
            this.groupBox1.Controls.Add(this.BCreate);
            this.groupBox1.Controls.Add(this.TBTitle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TO DO LIST";
            // 
            // LTotalTasks
            // 
            this.LTotalTasks.AutoSize = true;
            this.LTotalTasks.Location = new System.Drawing.Point(459, 169);
            this.LTotalTasks.Name = "LTotalTasks";
            this.LTotalTasks.Size = new System.Drawing.Size(0, 16);
            this.LTotalTasks.TabIndex = 4;
            // 
            // LTasks
            // 
            this.LTasks.AutoSize = true;
            this.LTasks.Location = new System.Drawing.Point(459, 132);
            this.LTasks.Name = "LTasks";
            this.LTasks.Size = new System.Drawing.Size(50, 16);
            this.LTasks.TabIndex = 3;
            this.LTasks.Text = "Tasks";
            // 
            // CLB
            // 
            this.CLB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB.FormattingEnabled = true;
            this.CLB.Location = new System.Drawing.Point(6, 80);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(421, 255);
            this.CLB.TabIndex = 2;
            // 
            // BCreate
            // 
            this.BCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCreate.Location = new System.Drawing.Point(433, 37);
            this.BCreate.Name = "BCreate";
            this.BCreate.Size = new System.Drawing.Size(102, 23);
            this.BCreate.TabIndex = 1;
            this.BCreate.Text = "Create";
            this.BCreate.UseVisualStyleBackColor = true;
            this.BCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // TBTitle
            // 
            this.TBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitle.Location = new System.Drawing.Point(6, 37);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(421, 22);
            this.TBTitle.TabIndex = 0;
            this.TBTitle.Enter += new System.EventHandler(this.TBTitle_Enter);
            this.TBTitle.Leave += new System.EventHandler(this.TBTitle_Leave);
            // 
            // BDelete
            // 
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDelete.Location = new System.Drawing.Point(315, 385);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(140, 31);
            this.BDelete.TabIndex = 1;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BSave
            // 
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.Location = new System.Drawing.Point(132, 385);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(140, 31);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TDL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BCreate;
        private System.Windows.Forms.TextBox TBTitle;
        private System.Windows.Forms.CheckedListBox CLB;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label LTotalTasks;
        private System.Windows.Forms.Label LTasks;
    }
}

