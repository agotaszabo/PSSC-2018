namespace home_library.forms
{
    partial class ViewAllForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title_addForm = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 330);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Title_addForm
            // 
            this.Title_addForm.AutoSize = true;
            this.Title_addForm.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_addForm.ForeColor = System.Drawing.Color.Maroon;
            this.Title_addForm.Location = new System.Drawing.Point(175, 9);
            this.Title_addForm.Name = "Title_addForm";
            this.Title_addForm.Size = new System.Drawing.Size(240, 28);
            this.Title_addForm.TabIndex = 32;
            this.Title_addForm.Text = "List all of your books";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Tan;
            this.CancelBtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Maroon;
            this.CancelBtn.Location = new System.Drawing.Point(167, 389);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(269, 38);
            this.CancelBtn.TabIndex = 34;
            this.CancelBtn.Text = "Close";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(583, 437);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Title_addForm);
            this.Name = "ViewAllForm";
            this.Text = "ViewAllForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Title_addForm;
        private System.Windows.Forms.Button CancelBtn;
    }
}