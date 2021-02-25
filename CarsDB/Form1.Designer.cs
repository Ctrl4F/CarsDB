namespace CarsDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listCars = new System.Windows.Forms.ListBox();
            this.listCarNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cars";
            // 
            // listCars
            // 
            this.listCars.FormattingEnabled = true;
            this.listCars.Location = new System.Drawing.Point(89, 145);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(120, 95);
            this.listCars.TabIndex = 1;
            this.listCars.SelectedIndexChanged += new System.EventHandler(this.listCars_SelectedIndexChanged);
            // 
            // listCarNames
            // 
            this.listCarNames.FormattingEnabled = true;
            this.listCarNames.Location = new System.Drawing.Point(341, 145);
            this.listCarNames.Name = "listCarNames";
            this.listCarNames.Size = new System.Drawing.Size(120, 95);
            this.listCarNames.TabIndex = 2;
            this.listCarNames.SelectedIndexChanged += new System.EventHandler(this.listCars_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Names";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCarNames);
            this.Controls.Add(this.listCars);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCars;
        private System.Windows.Forms.ListBox listCarNames;
        private System.Windows.Forms.Label label2;
    }
}

