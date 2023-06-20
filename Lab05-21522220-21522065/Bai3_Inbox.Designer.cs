namespace Lab05_21522220_21522065
{
    partial class Bai3_Inbox
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(17, 157);
            /*listView1.Name = "listView1";
            listView1.Size = new Size(770, 280);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;*/
            
            this.listView1.HideSelection = false;
            
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 431);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // button1
            // 
            button1.Location = new Point(41, 43);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 1;
            button1.Text = "New Email";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 43);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 1;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai3_Inbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Bai3_Inbox";
            Text = "form5";
            FormClosed += Bai3_Inbox_FormClosed;
            Load += Bai3_Inbox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
    }
}