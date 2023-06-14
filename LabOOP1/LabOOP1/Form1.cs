using System.Diagnostics;
using System.DirectoryServices;

namespace LabOOP1
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void btn_IncProgBar_Click(object sender, EventArgs e)
        {
            if(progBar_IncDecByBtns.Value + 10 <= 100)
            {
                progBar_IncDecByBtns.Value += 10;
            }
        }

        private void btn_DecProgBar_Click(object sender, EventArgs e)
        {
            if (progBar_IncDecByBtns.Value - 10 >= 0)
            {
                progBar_IncDecByBtns.Value -= 10;
            }
        }

        private void chkBox_blockTxtBox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBox_blockTxtBox.Checked)
            {
                txtBox.ReadOnly = true;
            }
            else
            {
                txtBox.ReadOnly = false;
            }
            
        }

        private void comboBox_FavDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_FavDates.SelectedIndex == 0)
            {
                maskedTxtBox_Date.Text = dateTimePicker_DateChooser.MinDate.ToString();
                dateTimePicker_DateChooser.Value = dateTimePicker_DateChooser.MinDate;
            }
            if(comboBox_FavDates.SelectedIndex == 1)
            {
                maskedTxtBox_Date.Text = dateTimePicker_DateChooser.MaxDate.ToString();
                dateTimePicker_DateChooser.Value = dateTimePicker_DateChooser.MaxDate;
            }
        }

        private void chkBox_ShowDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBox_ShowDate.Checked)
            {
                comboBox_FavDates.Visible = true;
                maskedTxtBox_Date.Visible = true;
                dateTimePicker_DateChooser.Visible = true;
            }
            else
            {
                comboBox_FavDates.Visible = false;
                maskedTxtBox_Date.Visible = false;
                dateTimePicker_DateChooser.Visible = false;
            }
        }

        private void radioBtn_setUpPic_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Date.BackgroundImage = global::LabOOP1.Properties.Resources.cat; ;
        }

        private void radioBtn_setDownPic_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Date.BackgroundImage = null;
        }

        private void label_ChngColors_MouseEnter(object sender, EventArgs e)
        {
            bool isMouse;

            if (Object.ReferenceEquals(sender.GetType(), typeof(System.Windows.Forms.Label)))
            {
                isMouse = true;
            }
            else
            {
                isMouse = false;
            }

            System.Windows.Forms.Label label;
            int label_ColorQueue;
            if(isMouse)
            {
                label = (System.Windows.Forms.Label)sender;
                label_ColorQueue = label_ColorQueueMouse;
            }
            else
            {
                label = label_ChngColors_Timer;
                label_ColorQueue = label_ColorQueueTimer;
            }


            if (label.BackColor.R >= 250)
            {
                label_ColorQueue = 1;
            }
            else if(label.BackColor.G >= 250)
            {
                label_ColorQueue = 2;
            }
            else if(label.BackColor.B >= 250)
            {
                label_ColorQueue = 0;
            }


            if (label_ColorQueue == 0)
            {
                label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(label.BackColor.R + 6)))), ((int)(((byte)(label.BackColor.G - 3)))), ((int)(((byte)(label.BackColor.B - 3)))));
            }
            if (label_ColorQueue == 1)
            {
                label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(label.BackColor.R - 3)))), ((int)(((byte)(label.BackColor.G + 6)))), ((int)(((byte)(label.BackColor.B - 3)))));
            }
            if (label_ColorQueue == 2)
            {
                label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(label.BackColor.R - 3)))), ((int)(((byte)(label.BackColor.G - 3)))), ((int)(((byte)(label.BackColor.B + 6)))));
            }

            if(isMouse)
            {
                sender = label;
                label_ColorQueueMouse = label_ColorQueue;
            }
            else
            {
                label_ChngColors_Timer = label;
                label_ColorQueueTimer = label_ColorQueue;
            }
        }

        private void pic_RunningCat_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveByKey(((System.Windows.Forms.PictureBox)sender).Name);
        }

        private void form_Main_MouseDown(object sender, MouseEventArgs e)
        {

            System.Windows.Forms.PictureBox pic_NewCat = new System.Windows.Forms.PictureBox();
            pic_NewCat.Image = global::LabOOP1.Properties.Resources.running_cat;
            pic_NewCat.Location = new System.Drawing.Point(e.X - pic_NewCat.Size.Width / 2, e.Y - pic_NewCat.Size.Height / 2);
            pic_NewCat.Name = "pic_NewCat" + pic_CatQueue++;
            pic_NewCat.Size = new System.Drawing.Size(72, 72);
            pic_NewCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_NewCat.TabIndex = 18;
            pic_NewCat.TabStop = false;
            pic_NewCat.Click += new System.EventHandler(pic_RunningCat_Click);
            this.Controls.Add(pic_NewCat);

        }

        private void form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseLastX != 801 && mouseLastY != 601)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name.StartsWith("pic_NewCat"))
                    {
                        if ((ctrl.Location.X + mouseLastX - e.X <= 800 - ctrl.Size.Width) &&
                            (ctrl.Location.X + mouseLastX - e.X >= 0) &&
                            (ctrl.Location.Y + mouseLastY - e.Y <= 600 - ctrl.Size.Height) &&
                            (ctrl.Location.Y + mouseLastY - e.Y >= 0))
                        {
                            ctrl.Location = new System.Drawing.Point(ctrl.Location.X + mouseLastX - e.X, ctrl.Location.Y + mouseLastY - e.Y);
                        }
                    }
                }
            }
            mouseLastX = e.X;
            mouseLastY = e.Y;
        }

        private void linkLabel_BigCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_BigCat.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"C:\cat.jpg", UseShellExecute = true });
        }

        private void numericUpDown_X_ValueChanged(object sender, EventArgs e)
        {
            pic_Meow.Size = new System.Drawing.Size((int)numericUpDown_X.Value, pic_Meow.Size.Height); 
        }

        private void numericUpDown_Y_ValueChanged(object sender, EventArgs e)
        {
            pic_Meow.Size = new System.Drawing.Size(pic_Meow.Size.Width, (int)numericUpDown_Y.Value);
        }

        private void pic_Meow_Click(object sender, EventArgs e)
        {
            notyficon_Meow.ShowBalloonTip(1000);
        }

        private void notyficon_Meow_Click(object sender, EventArgs e)
        {
            if(pic_Meow.Size.Width != 150 && pic_Meow.Size.Height != 150)
            {
                pic_Meow.Size = new System.Drawing.Size(150, 150);
            }
            else
            {
                pic_Meow.Size = new System.Drawing.Size(50, 50);
            }
            

        }

        private void pic_Meow_Resize(object sender, EventArgs e)
        {
            numericUpDown_X.Value = pic_Meow.Size.Width;
            numericUpDown_Y.Value = pic_Meow.Size.Height;
        }

        private void label_ChngColors_Timer_Paint(object sender, PaintEventArgs e)
        {
            listBox_ChngColorsTimer.Items.Clear();
            listBox_ChngColorsTimer.Items.AddRange(new object[] {
                label_ChngColors_Timer.BackColor.R,
                label_ChngColors_Timer.BackColor.G,
                label_ChngColors_Timer.BackColor.B});
        }

        private void label_ChngColors_Mouse_Paint(object sender, PaintEventArgs e)
        {
            listBox_ChngColorsMouse.Items.Clear();
            listBox_ChngColorsMouse.Items.AddRange(new object[] {
                label_ChngColors_Mouse.BackColor.R,
                label_ChngColors_Mouse.BackColor.G,
                label_ChngColors_Mouse.BackColor.B});
        }

        private void firstToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(firstToolStripMenuItem.Checked)
            {
                checkedListBox_Menu.SetItemChecked(0, true);
            }
            else
            {
                checkedListBox_Menu.SetItemChecked(0, false);
            }
        }

        private void secondToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (secondToolStripMenuItem.Checked)
            {
                checkedListBox_Menu.SetItemChecked(1, true);
            }
            else
            {
                checkedListBox_Menu.SetItemChecked(1, false);
            }
        }

        private void thirdToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (thirdToolStripMenuItem.Checked)
            {
                checkedListBox_Menu.SetItemChecked(2, true);
            }
            else
            {
                checkedListBox_Menu.SetItemChecked(2, false);
            }
        }

        private void checkedListBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstToolStripMenuItem.Checked = checkedListBox_Menu.GetItemChecked(0);
            secondToolStripMenuItem.Checked = checkedListBox_Menu.GetItemChecked(1);
            thirdToolStripMenuItem.Checked = checkedListBox_Menu.GetItemChecked(2);
        }

        private void MenuCat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MenuCat1_ToolStripMenuItem.Enabled)
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\flaffy_cat.jpg", UseShellExecute = true });
                MenuCat1_ToolStripMenuItem.Enabled = false;
            }
        }

        private void MenuCat2_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuCat2_ToolStripMenuItem.Enabled)
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\scary_cat.jpg", UseShellExecute = true });
                MenuCat2_ToolStripMenuItem.Enabled = false;
            }
        }

        private void btn_AutoWrite_Ya_Click(object sender, EventArgs e)
        {
            richTextBox_AutoWrite.Text += "Я ";
        }

        private void btn_AutoWrite_Idu_Click(object sender, EventArgs e)
        {
            richTextBox_AutoWrite.Text += "Иду ";
        }

        private void btn_AutoWrite_Domoj_Click(object sender, EventArgs e)
        {
            richTextBox_AutoWrite.Text += "Домой ";
        }

        private void richTextBox_AutoWrite_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox_AutoWrite.BackColor != Color.White)
            {
                richTextBox_AutoWrite.BackColor = Color.White;
            } 
            else
            {
                richTextBox_AutoWrite.BackColor = Color.Cyan;
            }
        }

        private void richTextBox_AutoWrite_Click(object sender, EventArgs e)
        {
            richTextBox_AutoWrite.Text = "";
        }

        private void contextMenuItem_redBackGround_Click(object sender, EventArgs e)
        {
            richTextBox_AutoWrite.BackColor = Color.IndianRed;
        }

        private void contextMenuItem_CatBackGroundFar_Click(object sender, EventArgs e)
        {
            radioBtn_setUpPic.Checked = true;
        }

        private void form_Main_SizeChanged(object sender, EventArgs e)
        {
            label_FormWidth.Text = this.Size.Width.ToString();
        }
    }
}