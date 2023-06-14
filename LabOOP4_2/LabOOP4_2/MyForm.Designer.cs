using System.Windows.Forms;

namespace LabOOP4_2
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
            this.trackBar_A = new System.Windows.Forms.TrackBar();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.trackBar_C = new System.Windows.Forms.TrackBar();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.numericUpDown_A = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_C = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_A
            // 
            this.trackBar_A.Location = new System.Drawing.Point(79, 299);
            this.trackBar_A.Maximum = 100;
            this.trackBar_A.Name = "trackBar_A";
            this.trackBar_A.Size = new System.Drawing.Size(130, 56);
            this.trackBar_A.TabIndex = 0;
            this.trackBar_A.Scroll += new System.EventHandler(this.trackBar_A_Scroll);
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(378, 299);
            this.trackBar_B.Maximum = 100;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(130, 56);
            this.trackBar_B.TabIndex = 1;
            this.trackBar_B.Scroll += new System.EventHandler(this.trackBar_B_Scroll);
            // 
            // trackBar_C
            // 
            this.trackBar_C.Location = new System.Drawing.Point(702, 299);
            this.trackBar_C.Maximum = 100;
            this.trackBar_C.Name = "trackBar_C";
            this.trackBar_C.Size = new System.Drawing.Size(130, 56);
            this.trackBar_C.TabIndex = 2;
            this.trackBar_C.Scroll += new System.EventHandler(this.trackBar_C_Scroll);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(79, 203);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(125, 27);
            this.textBox_A.TabIndex = 3;
            this.textBox_A.Text = "0";
            this.textBox_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_A_KeyDown);
            this.textBox_A.Leave += new System.EventHandler(this.textBox_A_Leave);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(383, 203);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(125, 27);
            this.textBox_B.TabIndex = 4;
            this.textBox_B.Text = "0";
            this.textBox_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_B_KeyDown);
            this.textBox_B.Leave += new System.EventHandler(this.textBox_B_Leave);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(707, 203);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(125, 27);
            this.textBox_C.TabIndex = 5;
            this.textBox_C.Text = "0";
            this.textBox_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_C_KeyDown);
            this.textBox_C.Leave += new System.EventHandler(this.textBox_C_Leave);
            // 
            // numericUpDown_A
            // 
            this.numericUpDown_A.CausesValidation = false;
            this.numericUpDown_A.Location = new System.Drawing.Point(79, 250);
            this.numericUpDown_A.Name = "numericUpDown_A";
            this.numericUpDown_A.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_A.TabIndex = 6;
            this.numericUpDown_A.ValueChanged += new System.EventHandler(this.numericUpDown_A_ValueChanged);
            this.numericUpDown_A.Leave += new System.EventHandler(this.numericUpDown_A_Leave);
            // 
            // numericUpDown_B
            // 
            this.numericUpDown_B.Location = new System.Drawing.Point(383, 250);
            this.numericUpDown_B.Name = "numericUpDown_B";
            this.numericUpDown_B.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_B.TabIndex = 7;
            this.numericUpDown_B.ValueChanged += new System.EventHandler(this.numericUpDown_B_ValueChanged);
            this.numericUpDown_B.Leave += new System.EventHandler(this.numericUpDown_B_Leave);
            // 
            // numericUpDown_C
            // 
            this.numericUpDown_C.Location = new System.Drawing.Point(707, 250);
            this.numericUpDown_C.Name = "numericUpDown_C";
            this.numericUpDown_C.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_C.TabIndex = 8;
            this.numericUpDown_C.ValueChanged += new System.EventHandler(this.numericUpDown_C_ValueChanged);
            this.numericUpDown_C.Leave += new System.EventHandler(this.numericUpDown_C_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 116);
            this.label1.TabIndex = 9;
            this.label1.Text = "A   <=   B   <=   C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_C);
            this.Controls.Add(this.numericUpDown_B);
            this.Controls.Add(this.numericUpDown_A);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.trackBar_C);
            this.Controls.Add(this.trackBar_B);
            this.Controls.Add(this.trackBar_A);
            this.Name = "MyForm";
            this.Text = "LabOOP4_2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trackBar_A;
        private TrackBar trackBar_B;
        private TrackBar trackBar_C;
        private TextBox textBox_A;
        private TextBox textBox_B;
        private TextBox textBox_C;
        private NumericUpDown numericUpDown_A;
        private NumericUpDown numericUpDown_B;
        private NumericUpDown numericUpDown_C;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}