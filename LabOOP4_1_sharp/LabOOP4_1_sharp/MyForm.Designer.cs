using System.Drawing;
using System.Numerics;

namespace LabOOP4_1_sharp
{
    partial class MyForm
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
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.checkBox_Control = new System.Windows.Forms.CheckBox();
            this.checkBox_CrossSelecting = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintBox.Location = new System.Drawing.Point(134, 49);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(713, 501);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseClick);
            // 
            // checkBox_Control
            // 
            this.checkBox_Control.AutoSize = true;
            this.checkBox_Control.Checked = true;
            this.checkBox_Control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Control.Location = new System.Drawing.Point(23, 19);
            this.checkBox_Control.Name = "checkBox_Control";
            this.checkBox_Control.Size = new System.Drawing.Size(125, 24);
            this.checkBox_Control.TabIndex = 1;
            this.checkBox_Control.Text = "Control Active";
            this.checkBox_Control.UseVisualStyleBackColor = true;
            this.checkBox_Control.CheckedChanged += new System.EventHandler(this.checkBox_Control_CheckedChanged);
            this.checkBox_Control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.checkBox_Control.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // checkBox_CrossSelecting
            // 
            this.checkBox_CrossSelecting.AutoSize = true;
            this.checkBox_CrossSelecting.Checked = true;
            this.checkBox_CrossSelecting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CrossSelecting.Location = new System.Drawing.Point(168, 19);
            this.checkBox_CrossSelecting.Name = "checkBox_CrossSelecting";
            this.checkBox_CrossSelecting.Size = new System.Drawing.Size(131, 24);
            this.checkBox_CrossSelecting.TabIndex = 2;
            this.checkBox_CrossSelecting.Text = "Cross Selecting";
            this.checkBox_CrossSelecting.UseVisualStyleBackColor = true;
            this.checkBox_CrossSelecting.CheckedChanged += new System.EventHandler(this.checkBox_CrossSelecting_CheckedChanged);
            this.checkBox_CrossSelecting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.checkBox_CrossSelecting.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 570);
            this.Controls.Add(this.checkBox_CrossSelecting);
            this.Controls.Add(this.checkBox_Control);
            this.Controls.Add(this.paintBox);
            this.Name = "MyForm";
            this.Text = "LabOOP4_1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox paintBox;
        private CheckBox checkBox_Control;
        private CheckBox checkBox_CrossSelecting;
    }
}