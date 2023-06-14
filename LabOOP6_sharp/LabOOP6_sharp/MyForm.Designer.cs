using System.Drawing;
using System.Numerics;

namespace LabOOP6_sharp
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
            this.checkBox_CrossSelecting = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.figureRadioButton_triangle = new System.Windows.Forms.RadioButton();
            this.figureLabel = new System.Windows.Forms.Label();
            this.figureRadioButton_circle = new System.Windows.Forms.RadioButton();
            this.figureRadioButton_square = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintBox.Location = new System.Drawing.Point(261, 57);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(713, 501);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseClick);
            // 
            // checkBox_CrossSelecting
            // 
            this.checkBox_CrossSelecting.AutoSize = true;
            this.checkBox_CrossSelecting.Checked = true;
            this.checkBox_CrossSelecting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CrossSelecting.Location = new System.Drawing.Point(12, 12);
            this.checkBox_CrossSelecting.Name = "checkBox_CrossSelecting";
            this.checkBox_CrossSelecting.Size = new System.Drawing.Size(131, 24);
            this.checkBox_CrossSelecting.TabIndex = 2;
            this.checkBox_CrossSelecting.Text = "Cross Selecting";
            this.checkBox_CrossSelecting.UseVisualStyleBackColor = true;
            this.checkBox_CrossSelecting.CheckedChanged += new System.EventHandler(this.checkBox_CrossSelecting_CheckedChanged);
            this.checkBox_CrossSelecting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.checkBox_CrossSelecting.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // colorDialog
            // 
            this.colorDialog.ShowHelp = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(15, 144);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(237, 29);
            this.colorButton.TabIndex = 3;
            this.colorButton.Text = "Поменять цвет фигуры ";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            this.colorButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.colorButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.figureRadioButton_triangle);
            this.panel1.Controls.Add(this.figureLabel);
            this.panel1.Controls.Add(this.figureRadioButton_circle);
            this.panel1.Controls.Add(this.figureRadioButton_square);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 81);
            this.panel1.TabIndex = 4;
            // 
            // figureRadioButton_triangle
            // 
            this.figureRadioButton_triangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.figureRadioButton_triangle.Location = new System.Drawing.Point(165, 23);
            this.figureRadioButton_triangle.Name = "figureRadioButton_triangle";
            this.figureRadioButton_triangle.Size = new System.Drawing.Size(75, 50);
            this.figureRadioButton_triangle.TabIndex = 7;
            this.figureRadioButton_triangle.TabStop = true;
            this.figureRadioButton_triangle.Text = "Triangle";
            this.figureRadioButton_triangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.figureRadioButton_triangle.UseVisualStyleBackColor = true;
            this.figureRadioButton_triangle.CheckedChanged += new System.EventHandler(this.figureRadioButton_triangle_CheckedChanged);
            this.figureRadioButton_triangle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.figureRadioButton_triangle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // figureLabel
            // 
            this.figureLabel.AutoSize = true;
            this.figureLabel.Location = new System.Drawing.Point(3, 0);
            this.figureLabel.Name = "figureLabel";
            this.figureLabel.Size = new System.Drawing.Size(121, 20);
            this.figureLabel.TabIndex = 8;
            this.figureLabel.Text = "Выбрать фигуру";
            // 
            // figureRadioButton_circle
            // 
            this.figureRadioButton_circle.Appearance = System.Windows.Forms.Appearance.Button;
            this.figureRadioButton_circle.Location = new System.Drawing.Point(3, 23);
            this.figureRadioButton_circle.Name = "figureRadioButton_circle";
            this.figureRadioButton_circle.Size = new System.Drawing.Size(75, 50);
            this.figureRadioButton_circle.TabIndex = 5;
            this.figureRadioButton_circle.TabStop = true;
            this.figureRadioButton_circle.Text = "Circle";
            this.figureRadioButton_circle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.figureRadioButton_circle.UseVisualStyleBackColor = true;
            this.figureRadioButton_circle.CheckedChanged += new System.EventHandler(this.figureRadioButton_circle_CheckedChanged);
            this.figureRadioButton_circle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.figureRadioButton_circle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // figureRadioButton_square
            // 
            this.figureRadioButton_square.Appearance = System.Windows.Forms.Appearance.Button;
            this.figureRadioButton_square.Location = new System.Drawing.Point(84, 23);
            this.figureRadioButton_square.Name = "figureRadioButton_square";
            this.figureRadioButton_square.Size = new System.Drawing.Size(75, 50);
            this.figureRadioButton_square.TabIndex = 6;
            this.figureRadioButton_square.TabStop = true;
            this.figureRadioButton_square.Text = "Square";
            this.figureRadioButton_square.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.figureRadioButton_square.UseVisualStyleBackColor = true;
            this.figureRadioButton_square.CheckedChanged += new System.EventHandler(this.figureRadioButton_square_CheckedChanged);
            this.figureRadioButton_square.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.figureRadioButton_square.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.checkBox_CrossSelecting);
            this.Controls.Add(this.paintBox);
            this.Name = "MyForm";
            this.Text = "LabOOP6";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox paintBox;
        private CheckBox checkBox_CrossSelecting;
        private ColorDialog colorDialog;
        private Button colorButton;
        private Panel panel1;
        private RadioButton figureRadioButton_circle;
        private RadioButton figureRadioButton_square;
        private RadioButton figureRadioButton_triangle;
        private Label figureLabel;
    }
}