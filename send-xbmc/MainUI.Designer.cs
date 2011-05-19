namespace SendXBMC
{
    partial class frmSendXBMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendXBMC));
            this.btnContextAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContextRem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAksDeets = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContextAdd
            // 
            this.btnContextAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContextAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContextAdd.Location = new System.Drawing.Point(9, 26);
            this.btnContextAdd.Name = "btnContextAdd";
            this.btnContextAdd.Size = new System.Drawing.Size(166, 23);
            this.btnContextAdd.TabIndex = 1;
            this.btnContextAdd.Text = "ADD";
            this.btnContextAdd.UseVisualStyleBackColor = true;
            this.btnContextAdd.Click += new System.EventHandler(this.btnContextAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add / Remove [ \"Send To XBMC\" ] option to context menu\'s :";
            // 
            // btnContextRem
            // 
            this.btnContextRem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContextRem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContextRem.Location = new System.Drawing.Point(179, 26);
            this.btnContextRem.Name = "btnContextRem";
            this.btnContextRem.Size = new System.Drawing.Size(166, 23);
            this.btnContextRem.TabIndex = 2;
            this.btnContextRem.Text = "REMOVE";
            this.btnContextRem.UseVisualStyleBackColor = true;
            this.btnContextRem.Click += new System.EventHandler(this.btnContextRem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address (or Hostname) of XBOX:";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(12, 76);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(164, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "0.0.0.0";
            // 
            // btnSetIP
            // 
            this.btnSetIP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetIP.Location = new System.Drawing.Point(182, 75);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(93, 21);
            this.btnSetIP.TabIndex = 5;
            this.btnSetIP.Text = "SET";
            this.btnSetIP.UseVisualStyleBackColor = true;
            this.btnSetIP.Click += new System.EventHandler(this.btnSetIP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 71);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "3) Right click any video file, and click \"Send to XBMC\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "2) Put in your xbox\'s IP Address, and click \"SET\" (then close app)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "1) Click \"ADD\" button to set context menu\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Install Notes:";
            // 
            // chkAksDeets
            // 
            this.chkAksDeets.AutoSize = true;
            this.chkAksDeets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkAksDeets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAksDeets.Location = new System.Drawing.Point(12, 106);
            this.chkAksDeets.Name = "chkAksDeets";
            this.chkAksDeets.Size = new System.Drawing.Size(303, 17);
            this.chkAksDeets.TabIndex = 7;
            this.chkAksDeets.Text = "Show a User/Pass Prompt (For XBOX to use over network)";
            this.chkAksDeets.UseVisualStyleBackColor = true;
            this.chkAksDeets.CheckedChanged += new System.EventHandler(this.chkAksDeets_CheckedChanged);
            // 
            // frmSendXBMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 204);
            this.Controls.Add(this.chkAksDeets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSetIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContextRem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContextAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendXBMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendXBMC v1.1  - by EToS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContextAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContextRem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAksDeets;
    }
}

