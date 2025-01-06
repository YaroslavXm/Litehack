using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace LitehackRecode
{
    public partial class Form1 : Form
    {

        public Point mouseLocation;



        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Litehack v1.1 | " + "Forlorn API - " + ForlornApi.Forlorn.ForlornVersion + " | created by XmTeam", "Litehack");
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X - 0, mouseLocation.Y + 0);
                Location = mousePose;
            }
        }

        private void inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void exec_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
            if (ForlornApi.Api.IsInjected())
                MessageBox.Show("Already injected!");
            if (ForlornApi.Api.IsRobloxOpen())
            { }
            else
            {
                MessageBox.Show("Open Roblox and Attach");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog for text files
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save Text File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save the RichTextBox content to the selected file
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, richTextBox1.Text);

                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog for text files
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Lua Scripts (*.lua)|*.lua|All Files (*.*)|*.*",
                Title = "Open Text File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the text file content into the RichTextBox
                    string filePath = openFileDialog.FileName;
                    richTextBox1.Text = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kill_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void scr_Click(object sender, EventArgs e)
        {
            string url = "https://rbxscript.com/";

            try
            {
                // Open the URL in the default browser
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Handle any errors that occur when trying to open the URL
                MessageBox.Show($"Error opening URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void inject_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Attach", inject);
        }

        private void exec_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Execute", exec);
        }

        private void clear_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Clear", clear);
        }

        private void kill_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Kill Roblox Proccess", kill);
        }

        private void open_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Open File", open);
        }

        private void save_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("Save File", save);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            btnsToolTip.Show("hmmmm , click him", label1);
        }
    }
    
}
