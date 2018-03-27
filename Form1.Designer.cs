namespace CrudOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.idContainer = new System.Windows.Forms.ComboBox();
            this.dlt = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.crt = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.YourAge = new System.Windows.Forms.TextBox();
            this.YourSurName = new System.Windows.Forms.TextBox();
            this.YourName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Choose Id and Press Delete";
            // 
            // idContainer
            // 
            this.idContainer.FormattingEnabled = true;
            this.idContainer.Location = new System.Drawing.Point(520, 308);
            this.idContainer.Name = "idContainer";
            this.idContainer.Size = new System.Drawing.Size(123, 21);
            this.idContainer.TabIndex = 34;
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dlt.Location = new System.Drawing.Point(483, 161);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(160, 29);
            this.dlt.TabIndex = 33;
            this.dlt.Text = "Delete";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
            // 
            // ReadData
            // 
            this.ReadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReadData.Location = new System.Drawing.Point(343, 117);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(102, 29);
            this.ReadData.TabIndex = 32;
            this.ReadData.Text = "Read";
            this.ReadData.UseVisualStyleBackColor = false;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click_1);
            // 
            // crt
            // 
            this.crt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.crt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.crt.Location = new System.Drawing.Point(146, 159);
            this.crt.Name = "crt";
            this.crt.Size = new System.Drawing.Size(160, 29);
            this.crt.TabIndex = 31;
            this.crt.Text = "Create";
            this.crt.UseVisualStyleBackColor = false;
            this.crt.Click += new System.EventHandler(this.crt_Click_1);
            // 
            // Result
            // 
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(131, 249);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(347, 138);
            this.Result.TabIndex = 30;
            // 
            // YourAge
            // 
            this.YourAge.Location = new System.Drawing.Point(509, 95);
            this.YourAge.Name = "YourAge";
            this.YourAge.Size = new System.Drawing.Size(129, 20);
            this.YourAge.TabIndex = 29;
            // 
            // YourSurName
            // 
            this.YourSurName.Location = new System.Drawing.Point(329, 62);
            this.YourSurName.Name = "YourSurName";
            this.YourSurName.Size = new System.Drawing.Size(129, 20);
            this.YourSurName.TabIndex = 28;
            // 
            // YourName
            // 
            this.YourName.Location = new System.Drawing.Point(146, 93);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(129, 20);
            this.YourName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Your SurName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Your Name";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.change.Location = new System.Drawing.Point(343, 197);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(102, 29);
            this.change.TabIndex = 36;
            this.change.Text = "Update";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Choose Id and Press Update";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idContainer);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.crt);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.YourAge);
            this.Controls.Add(this.YourSurName);
            this.Controls.Add(this.YourName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idContainer;
        private System.Windows.Forms.Button dlt;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.Button crt;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox YourAge;
        private System.Windows.Forms.TextBox YourSurName;
        private System.Windows.Forms.TextBox YourName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label5;
    }
}

