namespace LitehackRecode
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.kill = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exec = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-15, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 41);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Orange;
            this.min.FlatAppearance.BorderSize = 0;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.min.Location = new System.Drawing.Point(874, 9);
            this.min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(27, 27);
            this.min.TabIndex = 1;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(909, 9);
            this.close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 27);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(909, 424);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // kill
            // 
            this.kill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kill.FlatAppearance.BorderSize = 0;
            this.kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kill.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kill.ForeColor = System.Drawing.Color.White;
            this.kill.Image = global::LitehackRecode.Properties.Resources.human_skull;
            this.kill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kill.Location = new System.Drawing.Point(12, 475);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(102, 32);
            this.kill.TabIndex = 5;
            this.kill.Text = "Kill Roblox";
            this.kill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kill.UseVisualStyleBackColor = false;
            this.kill.Click += new System.EventHandler(this.kill_Click);
            this.kill.MouseHover += new System.EventHandler(this.kill_MouseHover);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Image = global::LitehackRecode.Properties.Resources._9025522_eraser_icon;
            this.clear.Location = new System.Drawing.Point(807, 475);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(34, 32);
            this.clear.TabIndex = 5;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseHover += new System.EventHandler(this.clear_MouseHover);
            // 
            // exec
            // 
            this.exec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exec.FlatAppearance.BorderSize = 0;
            this.exec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exec.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exec.ForeColor = System.Drawing.Color.White;
            this.exec.Image = global::LitehackRecode.Properties.Resources._2849794_plane_paper_airplane_send_airplane_multimedia_icon_2_;
            this.exec.Location = new System.Drawing.Point(847, 475);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(34, 32);
            this.exec.TabIndex = 5;
            this.exec.UseVisualStyleBackColor = false;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            this.exec.MouseHover += new System.EventHandler(this.exec_MouseHover);
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.inject.FlatAppearance.BorderSize = 0;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inject.ForeColor = System.Drawing.Color.White;
            this.inject.Image = global::LitehackRecode.Properties.Resources._81385182;
            this.inject.Location = new System.Drawing.Point(887, 475);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(34, 32);
            this.inject.TabIndex = 5;
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            this.inject.MouseHover += new System.EventHandler(this.inject_MouseHover);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Image = global::LitehackRecode.Properties.Resources.diskette;
            this.save.Location = new System.Drawing.Point(60, 9);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(27, 27);
            this.save.TabIndex = 5;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseHover += new System.EventHandler(this.save_MouseHover);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.ForeColor = System.Drawing.Color.White;
            this.open.Image = global::LitehackRecode.Properties.Resources.open_folder;
            this.open.Location = new System.Drawing.Point(27, 9);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(27, 27);
            this.open.TabIndex = 5;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            this.open.MouseHover += new System.EventHandler(this.open_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(417, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Litehack v1.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Litehack";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button kill;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ToolTip btnsToolTip;
    }
}

