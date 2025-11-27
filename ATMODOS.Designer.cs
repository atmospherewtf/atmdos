using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class ATMODOS
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

        private async void GetUsers()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://apollo.atmosphere.wtf/atmodos/blastem");
                    if (!response.IsSuccessStatusCode) return;

                    var num = Int32.Parse(await response.Content.ReadAsStringAsync());
                    label4.Text = "connected to apollo: " + num.ToString();
                    return;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private async void BlastEm()
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("http://apollo.atmosphere.wtf/atmodos/blastem", null);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMODOS));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("ProggyCleanTT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(48, 12);
            label1.Name = "label1";
            label1.Size = new Size(269, 39);
            label1.TabIndex = 0;
            label1.Text = "ATMODOS V1.3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 40);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(35, 35, 35);
            button1.FlatAppearance.BorderColor = Color.FromArgb(8, 8, 8);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 35);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("ProggyCleanTT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(537, 297);
            button1.Name = "button1";
            button1.Size = new Size(209, 116);
            button1.TabIndex = 2;
            button1.Text = "DDOX\r\nNOOBS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(35, 35, 35);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("ProggyCleanTT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(128, 128, 255);
            textBox1.Location = new Point(138, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 22);
            textBox1.TabIndex = 3;
            textBox1.Text = "riseclient.com";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(35, 35, 35);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("ProggyCleanTT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(128, 128, 255);
            textBox2.Location = new Point(138, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "a lot";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("ProggyCleanTT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(76, 122);
            label2.Name = "label2";
            label2.Padding = new Padding(6);
            label2.Size = new Size(66, 38);
            label2.TabIndex = 0;
            label2.Text = "IP:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("ProggyCleanTT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Padding = new Padding(6);
            label3.Size = new Size(136, 38);
            label3.TabIndex = 0;
            label3.Text = "packets:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("ProggyCleanTT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(3, 378);
            label4.Name = "label4";
            label4.Padding = new Padding(6);
            label4.Size = new Size(322, 34);
            label4.TabIndex = 0;
            label4.Text = "connected to apollo: 6171";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            label4.Click += label4_Click_1;
            // 
            // ATMODOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 17, 21);
            ClientSize = new Size(761, 421);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(777, 460);
            Name = "ATMODOS";
            Text = "ATMODOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
