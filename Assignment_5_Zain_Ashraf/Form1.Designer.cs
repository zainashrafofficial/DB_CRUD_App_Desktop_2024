namespace Assignment_5_Zain_Ashraf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Textbox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.MyGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.City_Textbox = new System.Windows.Forms.TextBox();
            this.Title_Textbox = new System.Windows.Forms.TextBox();
            this.Country_Textbox = new System.Windows.Forms.TextBox();
            this.Date_Time_Picker = new System.Windows.Forms.DateTimePicker();
            this.Reset_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase Operations";
            // 
            // Search_Textbox
            // 
            this.Search_Textbox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Textbox.Location = new System.Drawing.Point(84, 81);
            this.Search_Textbox.Name = "Search_Textbox";
            this.Search_Textbox.Size = new System.Drawing.Size(238, 26);
            this.Search_Textbox.TabIndex = 1;
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.Location = new System.Drawing.Point(329, 79);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(70, 30);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // MyGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyGridView.BackgroundColor = System.Drawing.Color.White;
            this.MyGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MyGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MyGridView.Location = new System.Drawing.Point(84, 120);
            this.MyGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MyGridView.Name = "MyGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MyGridView.RowHeadersWidth = 35;
            this.MyGridView.Size = new System.Drawing.Size(637, 392);
            this.MyGridView.TabIndex = 3;
            this.MyGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Cell_Focus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(739, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(739, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(739, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(739, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "DOB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(739, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Country:";
            // 
            // Insert_Button
            // 
            this.Insert_Button.BackColor = System.Drawing.Color.DarkViolet;
            this.Insert_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Button.ForeColor = System.Drawing.Color.White;
            this.Insert_Button.Location = new System.Drawing.Point(769, 402);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(100, 40);
            this.Insert_Button.TabIndex = 4;
            this.Insert_Button.Text = "Insert";
            this.Insert_Button.UseVisualStyleBackColor = false;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Update_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(916, 402);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(100, 40);
            this.Update_Button.TabIndex = 5;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Crimson;
            this.Delete_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(844, 461);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(100, 40);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete\r\n";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.AcceptsTab = true;
            this.ID_TextBox.Enabled = false;
            this.ID_TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TextBox.Location = new System.Drawing.Point(848, 136);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(186, 23);
            this.ID_TextBox.TabIndex = 7;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Textbox.Location = new System.Drawing.Point(848, 179);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(186, 23);
            this.Name_Textbox.TabIndex = 7;
            // 
            // City_Textbox
            // 
            this.City_Textbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Textbox.Location = new System.Drawing.Point(848, 221);
            this.City_Textbox.Name = "City_Textbox";
            this.City_Textbox.Size = new System.Drawing.Size(186, 23);
            this.City_Textbox.TabIndex = 7;
            // 
            // Title_Textbox
            // 
            this.Title_Textbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Textbox.Location = new System.Drawing.Point(848, 263);
            this.Title_Textbox.Name = "Title_Textbox";
            this.Title_Textbox.Size = new System.Drawing.Size(186, 23);
            this.Title_Textbox.TabIndex = 7;
            // 
            // Country_Textbox
            // 
            this.Country_Textbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_Textbox.Location = new System.Drawing.Point(848, 346);
            this.Country_Textbox.Name = "Country_Textbox";
            this.Country_Textbox.Size = new System.Drawing.Size(186, 23);
            this.Country_Textbox.TabIndex = 7;
            // 
            // Date_Time_Picker
            // 
            this.Date_Time_Picker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Time_Picker.Location = new System.Drawing.Point(848, 305);
            this.Date_Time_Picker.Name = "Date_Time_Picker";
            this.Date_Time_Picker.Size = new System.Drawing.Size(186, 23);
            this.Date_Time_Picker.TabIndex = 8;
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Reset_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.ForeColor = System.Drawing.Color.White;
            this.Reset_Button.Location = new System.Drawing.Point(405, 79);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(70, 30);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 571);
            this.Controls.Add(this.Date_Time_Picker);
            this.Controls.Add(this.Country_Textbox);
            this.Controls.Add(this.Title_Textbox);
            this.Controls.Add(this.City_Textbox);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.MyGridView);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_Textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1106, 610);
            this.MinimumSize = new System.Drawing.Size(1106, 610);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase Operations | Zain Ashraf | 2022-ag-8568";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_Textbox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridView MyGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.TextBox City_Textbox;
        private System.Windows.Forms.TextBox Title_Textbox;
        private System.Windows.Forms.TextBox Country_Textbox;
        private System.Windows.Forms.DateTimePicker Date_Time_Picker;
        private System.Windows.Forms.Button Reset_Button;
    }
}

