namespace CarpetCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bestCalculate = new System.Windows.Forms.Button();
            this.economyCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bestCalculate
            // 
            this.bestCalculate.BackColor = System.Drawing.Color.Peru;
            this.bestCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestCalculate.Location = new System.Drawing.Point(154, 496);
            this.bestCalculate.Name = "bestCalculate";
            this.bestCalculate.Size = new System.Drawing.Size(248, 90);
            this.bestCalculate.TabIndex = 0;
            this.bestCalculate.Text = "Calculate Best Carpet";
            this.bestCalculate.UseVisualStyleBackColor = false;
            this.bestCalculate.Click += new System.EventHandler(this.bestCalculate_Click);
            // 
            // economyCalculate
            // 
            this.economyCalculate.BackColor = System.Drawing.Color.Orange;
            this.economyCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.economyCalculate.Location = new System.Drawing.Point(691, 496);
            this.economyCalculate.Name = "economyCalculate";
            this.economyCalculate.Size = new System.Drawing.Size(248, 90);
            this.economyCalculate.TabIndex = 1;
            this.economyCalculate.Text = "Calculate Economy Carpet";
            this.economyCalculate.UseVisualStyleBackColor = false;
            this.economyCalculate.Click += new System.EventHandler(this.economyCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(437, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carpet Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.economyCalculate);
            this.Controls.Add(this.bestCalculate);
            this.Name = "Form1";
            this.Text = "Carpet Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bestCalculate;
        private Button economyCalculate;
        private Label label1;
        private Label label2;
    }
}