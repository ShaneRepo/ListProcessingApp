namespace ListProcessingProgram
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxAdd = new System.Windows.Forms.TextBox();
            this.lblAddToList = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lstboxList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(434, 562);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(550, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxAdd
            // 
            this.txtboxAdd.Location = new System.Drawing.Point(95, 41);
            this.txtboxAdd.Name = "txtboxAdd";
            this.txtboxAdd.Size = new System.Drawing.Size(100, 20);
            this.txtboxAdd.TabIndex = 0;
            this.txtboxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAdd_KeyPress);
            // 
            // lblAddToList
            // 
            this.lblAddToList.AutoSize = true;
            this.lblAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToList.Location = new System.Drawing.Point(13, 44);
            this.lblAddToList.Name = "lblAddToList";
            this.lblAddToList.Size = new System.Drawing.Size(76, 13);
            this.lblAddToList.TabIndex = 4;
            this.lblAddToList.Text = "Add To List:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(326, 47);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(57, 13);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "The List:";
            // 
            // lstboxList
            // 
            this.lstboxList.FormattingEnabled = true;
            this.lstboxList.Location = new System.Drawing.Point(398, 44);
            this.lstboxList.Name = "lstboxList";
            this.lstboxList.Size = new System.Drawing.Size(120, 95);
            this.lstboxList.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 630);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstboxList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblAddToList);
            this.Controls.Add(this.txtboxAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Name = "Form1";
            this.Text = "List Processing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxAdd;
        private System.Windows.Forms.Label lblAddToList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstboxList;
        private System.Windows.Forms.Button btnAdd;
    }
}

