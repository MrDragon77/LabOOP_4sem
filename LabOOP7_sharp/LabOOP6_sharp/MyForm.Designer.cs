using System.Drawing;
using System.Numerics;

namespace LabOOP7_sharp
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
            this.toGroupButton = new System.Windows.Forms.Button();
            this.toUngroupButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintBox.Location = new System.Drawing.Point(282, 57);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(692, 501);
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
            this.checkBox_CrossSelecting.Size = new System.Drawing.Size(343, 24);
            this.checkBox_CrossSelecting.TabIndex = 2;
            this.checkBox_CrossSelecting.Text = "Множественное выделение на пересечении";
            this.checkBox_CrossSelecting.UseVisualStyleBackColor = true;
            this.checkBox_CrossSelecting.CheckedChanged += new System.EventHandler(this.checkBox_CrossSelecting_CheckedChanged);
            this.checkBox_CrossSelecting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.checkBox_CrossSelecting.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.Red;
            this.colorDialog.ShowHelp = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(15, 144);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(261, 29);
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
            this.panel1.Size = new System.Drawing.Size(264, 81);
            this.panel1.TabIndex = 4;
            // 
            // figureRadioButton_triangle
            // 
            this.figureRadioButton_triangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.figureRadioButton_triangle.Location = new System.Drawing.Point(165, 23);
            this.figureRadioButton_triangle.Name = "figureRadioButton_triangle";
            this.figureRadioButton_triangle.Size = new System.Drawing.Size(96, 50);
            this.figureRadioButton_triangle.TabIndex = 7;
            this.figureRadioButton_triangle.Text = "Треугольник";
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
            this.figureRadioButton_circle.Enabled = false;
            this.figureRadioButton_circle.Location = new System.Drawing.Point(3, 23);
            this.figureRadioButton_circle.Name = "figureRadioButton_circle";
            this.figureRadioButton_circle.Size = new System.Drawing.Size(75, 50);
            this.figureRadioButton_circle.TabIndex = 5;
            this.figureRadioButton_circle.Text = "Круг";
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
            this.figureRadioButton_square.Text = "Квадрат";
            this.figureRadioButton_square.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.figureRadioButton_square.UseVisualStyleBackColor = true;
            this.figureRadioButton_square.CheckedChanged += new System.EventHandler(this.figureRadioButton_square_CheckedChanged);
            this.figureRadioButton_square.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.figureRadioButton_square.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // toGroupButton
            // 
            this.toGroupButton.Location = new System.Drawing.Point(12, 191);
            this.toGroupButton.Name = "toGroupButton";
            this.toGroupButton.Size = new System.Drawing.Size(124, 57);
            this.toGroupButton.TabIndex = 5;
            this.toGroupButton.Text = "Сгруппировать";
            this.toGroupButton.UseVisualStyleBackColor = true;
            this.toGroupButton.Click += new System.EventHandler(this.toGroupButton_Click);
            this.toGroupButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.toGroupButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // toUngroupButton
            // 
            this.toUngroupButton.Location = new System.Drawing.Point(133, 191);
            this.toUngroupButton.Name = "toUngroupButton";
            this.toUngroupButton.Size = new System.Drawing.Size(143, 57);
            this.toUngroupButton.TabIndex = 6;
            this.toUngroupButton.Text = "Разгруппировать";
            this.toUngroupButton.UseVisualStyleBackColor = true;
            this.toUngroupButton.Click += new System.EventHandler(this.toUngroupButton_Click);
            this.toUngroupButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.toUngroupButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 267);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 52);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.saveButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(133, 267);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 52);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyDown);
            this.loadButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyForm_KeyUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 570);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.toUngroupButton);
            this.Controls.Add(this.toGroupButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.checkBox_CrossSelecting);
            this.Controls.Add(this.paintBox);
            this.Name = "MyForm";
            this.Text = "LabOOP7";
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
        private Button colorButton;
        private Panel panel1;
        private RadioButton figureRadioButton_circle;
        private RadioButton figureRadioButton_square;
        private RadioButton figureRadioButton_triangle;
        private Label figureLabel;
        private Button toGroupButton;
        private Button toUngroupButton;
        private Button saveButton;
        private Button loadButton;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        public ColorDialog colorDialog;
    }
}