namespace Guestbook_Web_Service_Tester
{
    partial class MainForm
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
            this.signGuestbookButton = new System.Windows.Forms.Button();
            this.guestbookDataGridView = new System.Windows.Forms.DataGridView();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.userMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewGuestbookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestbookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // signGuestbookButton
            // 
            this.signGuestbookButton.Location = new System.Drawing.Point(33, 263);
            this.signGuestbookButton.Name = "signGuestbookButton";
            this.signGuestbookButton.Size = new System.Drawing.Size(163, 45);
            this.signGuestbookButton.TabIndex = 0;
            this.signGuestbookButton.Text = "Sign GuestBook";
            this.signGuestbookButton.UseVisualStyleBackColor = true;
            this.signGuestbookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // guestbookDataGridView
            // 
            this.guestbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestbookDataGridView.Location = new System.Drawing.Point(220, 12);
            this.guestbookDataGridView.Name = "guestbookDataGridView";
            this.guestbookDataGridView.Size = new System.Drawing.Size(240, 236);
            this.guestbookDataGridView.TabIndex = 1;
            // 
            // userNametextBox
            // 
            this.userNametextBox.Location = new System.Drawing.Point(33, 46);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(163, 20);
            this.userNametextBox.TabIndex = 2;
            // 
            // userMessageTextBox
            // 
            this.userMessageTextBox.Location = new System.Drawing.Point(33, 120);
            this.userMessageTextBox.Multiline = true;
            this.userMessageTextBox.Name = "userMessageTextBox";
            this.userMessageTextBox.Size = new System.Drawing.Size(163, 128);
            this.userMessageTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(68, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // ViewGuestbookButton
            // 
            this.ViewGuestbookButton.Location = new System.Drawing.Point(220, 263);
            this.ViewGuestbookButton.Name = "ViewGuestbookButton";
            this.ViewGuestbookButton.Size = new System.Drawing.Size(240, 45);
            this.ViewGuestbookButton.TabIndex = 6;
            this.ViewGuestbookButton.Text = "View Messages";
            this.ViewGuestbookButton.UseVisualStyleBackColor = true;
            this.ViewGuestbookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 347);
            this.Controls.Add(this.ViewGuestbookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userMessageTextBox);
            this.Controls.Add(this.userNametextBox);
            this.Controls.Add(this.guestbookDataGridView);
            this.Controls.Add(this.signGuestbookButton);
            this.Name = "MainForm";
            this.Text = "Guestbook Web Service Tester";
            ((System.ComponentModel.ISupportInitialize)(this.guestbookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signGuestbookButton;
        private System.Windows.Forms.DataGridView guestbookDataGridView;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.TextBox userMessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewGuestbookButton;
    }
}

