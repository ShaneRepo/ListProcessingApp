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
            this.button1 = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.txtboxRemove = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblSearchList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblListFun = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
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
            this.btnAdd.Location = new System.Drawing.Point(16, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear Listbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(13, 125);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(112, 13);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "Remove From List:";
            // 
            // txtboxRemove
            // 
            this.txtboxRemove.Location = new System.Drawing.Point(131, 122);
            this.txtboxRemove.Name = "txtboxRemove";
            this.txtboxRemove.Size = new System.Drawing.Size(100, 20);
            this.txtboxRemove.TabIndex = 9;
            this.txtboxRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRemove_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove From List";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(16, 220);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(76, 13);
            this.lblDisplay.TabIndex = 11;
            this.lblDisplay.Text = "Display List:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(95, 215);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 23);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Display The List";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblSearchList
            // 
            this.lblSearchList.AutoSize = true;
            this.lblSearchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchList.Location = new System.Drawing.Point(16, 267);
            this.lblSearchList.Name = "lblSearchList";
            this.lblSearchList.Size = new System.Drawing.Size(101, 13);
            this.lblSearchList.TabIndex = 13;
            this.lblSearchList.Text = "Search The List:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 293);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search For Number";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 267);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblListFun
            // 
            this.lblListFun.AutoSize = true;
            this.lblListFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListFun.Location = new System.Drawing.Point(13, 343);
            this.lblListFun.Name = "lblListFun";
            this.lblListFun.Size = new System.Drawing.Size(192, 13);
            this.lblListFun.TabIndex = 16;
            this.lblListFun.Text = "Controls To Manipulate The List:";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(8, 380);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(95, 23);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Sum The List";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(109, 380);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(95, 23);
            this.btnMean.TabIndex = 18;
            this.btnMean.Text = "Display Mean";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(8, 420);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(95, 23);
            this.btnMedium.TabIndex = 19;
            this.btnMedium.Text = "Display Median";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(109, 420);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(97, 23);
            this.btnMode.TabIndex = 20;
            this.btnMode.Text = "Display Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save List";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(433, 529);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load List";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnHigh
            // 
            this.btnHigh.Location = new System.Drawing.Point(8, 466);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(95, 23);
            this.btnHigh.TabIndex = 23;
            this.btnHigh.Text = "Highest Value";
            this.btnHigh.UseVisualStyleBackColor = true;
            // 
            // btnLow
            // 
            this.btnLow.Location = new System.Drawing.Point(109, 466);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(95, 23);
            this.btnLow.TabIndex = 24;
            this.btnLow.Text = "Lowest Value";
            this.btnLow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 630);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblListFun);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchList);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtboxRemove);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.TextBox txtboxRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblSearchList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblListFun;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Button btnLow;
    }
}

