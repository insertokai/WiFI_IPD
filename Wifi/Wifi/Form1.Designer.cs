namespace Wifi
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
            this.components = new System.ComponentModel.Container();
            this.listViewWifi = new System.Windows.Forms.ListView();
            this.clm1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewWifi
            // 
            this.listViewWifi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm1,
            this.clm2,
            this.clm3,
            this.clm4});
            this.listViewWifi.Location = new System.Drawing.Point(12, 12);
            this.listViewWifi.Name = "listViewWifi";
            this.listViewWifi.Size = new System.Drawing.Size(342, 237);
            this.listViewWifi.TabIndex = 0;
            this.listViewWifi.UseCompatibleStateImageBehavior = false;
            this.listViewWifi.View = System.Windows.Forms.View.Details;
            this.listViewWifi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewWifi_MouseClick);
            // 
            // clm1
            // 
            this.clm1.Text = "Name";
            this.clm1.Width = 96;
            // 
            // clm2
            // 
            this.clm2.Text = "MAC";
            this.clm2.Width = 68;
            // 
            // clm3
            // 
            this.clm3.Text = "Strength";
            this.clm3.Width = 75;
            // 
            // clm4
            // 
            this.clm4.Text = "Auth type";
            this.clm4.Width = 97;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(360, 12);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(128, 20);
            this.Password.TabIndex = 1;
            this.Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_MouseClick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(360, 38);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(128, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(360, 78);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(35, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.listViewWifi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewWifi;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ColumnHeader clm1;
        private System.Windows.Forms.ColumnHeader clm2;
        private System.Windows.Forms.ColumnHeader clm3;
        private System.Windows.Forms.ColumnHeader clm4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Status;
    }
}

