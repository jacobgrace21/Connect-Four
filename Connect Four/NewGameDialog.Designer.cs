
namespace Connect_Four
{
    partial class NewGameDialog
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
            this.uxLevel = new System.Windows.Forms.Label();
            this.uxUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxHumanFirst = new System.Windows.Forms.RadioButton();
            this.uxComputerFirst = new System.Windows.Forms.RadioButton();
            this.uxNoComputer = new System.Windows.Forms.RadioButton();
            this.uxOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLevel
            // 
            this.uxLevel.AutoSize = true;
            this.uxLevel.Location = new System.Drawing.Point(22, 26);
            this.uxLevel.Name = "uxLevel";
            this.uxLevel.Size = new System.Drawing.Size(46, 17);
            this.uxLevel.TabIndex = 0;
            this.uxLevel.Text = "Level:";
            // 
            // uxUpDown
            // 
            this.uxUpDown.Location = new System.Drawing.Point(74, 24);
            this.uxUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxUpDown.Name = "uxUpDown";
            this.uxUpDown.Size = new System.Drawing.Size(120, 22);
            this.uxUpDown.TabIndex = 1;
            this.uxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxHumanFirst
            // 
            this.uxHumanFirst.AutoSize = true;
            this.uxHumanFirst.Checked = true;
            this.uxHumanFirst.Location = new System.Drawing.Point(25, 52);
            this.uxHumanFirst.Name = "uxHumanFirst";
            this.uxHumanFirst.Size = new System.Drawing.Size(143, 21);
            this.uxHumanFirst.TabIndex = 2;
            this.uxHumanFirst.TabStop = true;
            this.uxHumanFirst.Text = "Human Plays First";
            this.uxHumanFirst.UseVisualStyleBackColor = true;
            // 
            // uxComputerFirst
            // 
            this.uxComputerFirst.AutoSize = true;
            this.uxComputerFirst.Location = new System.Drawing.Point(25, 79);
            this.uxComputerFirst.Name = "uxComputerFirst";
            this.uxComputerFirst.Size = new System.Drawing.Size(159, 21);
            this.uxComputerFirst.TabIndex = 3;
            this.uxComputerFirst.Text = "Computer Plays First";
            this.uxComputerFirst.UseVisualStyleBackColor = true;
            // 
            // uxNoComputer
            // 
            this.uxNoComputer.AutoSize = true;
            this.uxNoComputer.Location = new System.Drawing.Point(25, 106);
            this.uxNoComputer.Name = "uxNoComputer";
            this.uxNoComputer.Size = new System.Drawing.Size(156, 21);
            this.uxNoComputer.TabIndex = 4;
            this.uxNoComputer.Text = "No Computer Player";
            this.uxNoComputer.UseVisualStyleBackColor = true;
            // 
            // uxOk
            // 
            this.uxOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOk.Location = new System.Drawing.Point(25, 133);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(156, 23);
            this.uxOk.TabIndex = 5;
            this.uxOk.Text = "Ok";
            this.uxOk.UseVisualStyleBackColor = true;
            // 
            // NewGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(213, 180);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxNoComputer);
            this.Controls.Add(this.uxComputerFirst);
            this.Controls.Add(this.uxHumanFirst);
            this.Controls.Add(this.uxUpDown);
            this.Controls.Add(this.uxLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewGameDialog";
            ((System.ComponentModel.ISupportInitialize)(this.uxUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLevel;
        private System.Windows.Forms.NumericUpDown uxUpDown;
        private System.Windows.Forms.RadioButton uxHumanFirst;
        private System.Windows.Forms.RadioButton uxComputerFirst;
        private System.Windows.Forms.RadioButton uxNoComputer;
        private System.Windows.Forms.Button uxOk;
    }
}