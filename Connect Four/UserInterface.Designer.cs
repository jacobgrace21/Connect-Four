
namespace Connect_Four
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uxNewGame = new System.Windows.Forms.ToolStripButton();
            this.uxUndo = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uxColumnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNewGame,
            this.uxUndo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxNewGame
            // 
            this.uxNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxNewGame.Image = ((System.Drawing.Image)(resources.GetObject("uxNewGame.Image")));
            this.uxNewGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxNewGame.Name = "uxNewGame";
            this.uxNewGame.Size = new System.Drawing.Size(86, 24);
            this.uxNewGame.Text = "New Game";
            // 
            // uxUndo
            // 
            this.uxUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxUndo.Image = ((System.Drawing.Image)(resources.GetObject("uxUndo.Image")));
            this.uxUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxUndo.Name = "uxUndo";
            this.uxUndo.Size = new System.Drawing.Size(49, 24);
            this.uxUndo.Text = "Undo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.uxButtonPanel);
            this.flowLayoutPanel1.Controls.Add(this.uxColumnPanel);
            this.flowLayoutPanel1.Controls.Add(this.uxTextBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(90, 104);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 112);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // uxButtonPanel
            // 
            this.uxButtonPanel.AutoSize = true;
            this.uxButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.uxButtonPanel.MinimumSize = new System.Drawing.Size(81, 26);
            this.uxButtonPanel.Name = "uxButtonPanel";
            this.uxButtonPanel.Size = new System.Drawing.Size(81, 26);
            this.uxButtonPanel.TabIndex = 0;
            // 
            // uxColumnPanel
            // 
            this.uxColumnPanel.AutoSize = true;
            this.uxColumnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxColumnPanel.Location = new System.Drawing.Point(3, 35);
            this.uxColumnPanel.MinimumSize = new System.Drawing.Size(81, 29);
            this.uxColumnPanel.Name = "uxColumnPanel";
            this.uxColumnPanel.Size = new System.Drawing.Size(81, 29);
            this.uxColumnPanel.TabIndex = 1;
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(3, 70);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ReadOnly = true;
            this.uxTextBox.Size = new System.Drawing.Size(81, 22);
            this.uxTextBox.TabIndex = 0;
            this.uxTextBox.TextChanged += new System.EventHandler(this.uxTextBox_TextChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton uxNewGame;
        private System.Windows.Forms.ToolStripButton uxUndo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel uxButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel uxColumnPanel;
        private System.Windows.Forms.TextBox uxTextBox;
    }
}

