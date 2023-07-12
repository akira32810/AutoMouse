
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace QuickAutoMouseMove
{
    public partial class AutoMoveMouse : Form
    {

        private Timer EnableAutoMouseTimer;

        private Timer EnableKeybardPressTimer;

        private InputSimulator simkey = new InputSimulator();

     


        public AutoMoveMouse()
        {
            InitializeComponent();

            //   MessageBox.Show("Hello");

            // Note: for the application hook, use the Hook.AppEvents() instead

        }


        private void chkActivateMouseMove_Click(object sender, EventArgs e)
        {

            if (chkActivateMouseMove.Checked)
            {
                //  MessageBox.Show("checked");

                if (!string.IsNullOrEmpty(txtXCoord.Text) && !string.IsNullOrEmpty(txtYCoord.Text) && !string.IsNullOrEmpty(txtTimerInterval.Text))
                {

                    EnableAutoMouseTimer = new Timer();
                    EnableAutoMouseTimer.Interval = Convert.ToInt32(txtTimerInterval.Text);
                    EnableAutoMouseTimer.Enabled = true;
                    EnableAutoMouseTimer.Tick += EnableAutoMouseTimer_Tick;
                    EnableAutoMouseTimer.Start();
                }

                else
                {
                    MessageBox.Show("Make coordinates and timer is fill out");
                    chkActivateMouseMove.Checked = false;
                }

            }

            else
            {
                // MessageBox.Show("not checked");

                

                if (EnableAutoMouseTimer.Enabled)
                {
                    EnableAutoMouseTimer.Enabled = false;
                    EnableAutoMouseTimer.Stop();
                    EnableAutoMouseTimer.Dispose();
                }
            }
        }

        private void EnableAutoMouseTimer_Tick(object sender, EventArgs e)
        {
            Random x = new Random();
            Random y = new Random();

            var xcoord = x.Next(Convert.ToInt32(txtXCoord.Text));
            var ycoord = y.Next(Convert.ToInt32(txtYCoord.Text));

            simkey.Mouse.MoveMouseTo(xcoord, ycoord);
         //   MessageBox.Show(xcoord.ToString());
            
         //   MouseMovement.LeftClick(Convert.ToInt32(txtXCoord.Text), Convert.ToInt32(txtYCoord.Text), true, 100, 200, false);
            //  MessageBox.Show("ok now");
        }

        private void chkeyPress_Click(object sender, EventArgs e)
        {

            if (chkeyPress.Checked)
            {
                if (!string.IsNullOrEmpty(txtkeypress.Text) && !string.IsNullOrEmpty(txtTimerInterval.Text))
                {
                    EnableKeybardPressTimer = new Timer();
                    EnableKeybardPressTimer.Interval = Convert.ToInt32(txtTimerInterval.Text);
                    EnableKeybardPressTimer.Enabled = true;
                    EnableKeybardPressTimer.Tick += EnableKeybardPressTimer_Tick;
                    EnableKeybardPressTimer.Start();

                }
                else
                {
                    MessageBox.Show("Make sure keypress field and timer is fill out");
                    chkeyPress.Checked = false;
                }
            }

            else
            {
                // MessageBox.Show("not checked");



                if (EnableKeybardPressTimer.Enabled)
                {
                    EnableKeybardPressTimer.Enabled = false;
                    EnableKeybardPressTimer.Stop();
                    EnableKeybardPressTimer.Dispose();
                }
            }

        }

        private void EnableKeybardPressTimer_Tick(object sender, EventArgs e)
        {
            
            simkey.Keyboard.TextEntry(txtkeypress.Text.Trim());
        }
    }
}
