namespace WindowsFormsApplication7
{
    partial class SerialCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialCom));
            this.response_box = new System.Windows.Forms.RichTextBox();
            this.input_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Port_Name = new System.Windows.Forms.ComboBox();
            this.Baud_Rate = new System.Windows.Forms.ComboBox();
            this.Parity_Input = new System.Windows.Forms.ComboBox();
            this.DataBits_Input = new System.Windows.Forms.ComboBox();
            this.StopBits_Inputs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DAtabits = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // response_box
            // 
            this.response_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.response_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.response_box.Location = new System.Drawing.Point(14, 20);
            this.response_box.Name = "response_box";
            this.response_box.ReadOnly = true;
            this.response_box.Size = new System.Drawing.Size(428, 254);
            this.response_box.TabIndex = 3;
            this.response_box.Text = "";
            this.response_box.TextChanged += new System.EventHandler(this.response_TextChanged);
            // 
            // input_box
            // 
            this.input_box.BackColor = System.Drawing.Color.Black;
            this.input_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.input_box.Location = new System.Drawing.Point(14, 280);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(428, 41);
            this.input_box.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.response_box);
            this.groupBox1.Controls.Add(this.input_box);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 332);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Port_Name
            // 
            this.Port_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Port_Name.FormattingEnabled = true;
            this.Port_Name.Location = new System.Drawing.Point(549, 25);
            this.Port_Name.Name = "Port_Name";
            this.Port_Name.Size = new System.Drawing.Size(100, 21);
            this.Port_Name.TabIndex = 19;
            // 
            // Baud_Rate
            // 
            this.Baud_Rate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Baud_Rate.FormattingEnabled = true;
            this.Baud_Rate.Location = new System.Drawing.Point(549, 69);
            this.Baud_Rate.Name = "Baud_Rate";
            this.Baud_Rate.Size = new System.Drawing.Size(100, 21);
            this.Baud_Rate.TabIndex = 20;
            this.Baud_Rate.SelectedIndexChanged += new System.EventHandler(this.baudrate_SelectedIndexChanged);
            // 
            // Parity_Input
            // 
            this.Parity_Input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Parity_Input.FormattingEnabled = true;
            this.Parity_Input.Location = new System.Drawing.Point(549, 122);
            this.Parity_Input.Name = "Parity_Input";
            this.Parity_Input.Size = new System.Drawing.Size(100, 21);
            this.Parity_Input.TabIndex = 21;
            // 
            // DataBits_Input
            // 
            this.DataBits_Input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataBits_Input.FormattingEnabled = true;
            this.DataBits_Input.Location = new System.Drawing.Point(549, 171);
            this.DataBits_Input.Name = "DataBits_Input";
            this.DataBits_Input.Size = new System.Drawing.Size(100, 21);
            this.DataBits_Input.TabIndex = 22;
            // 
            // StopBits_Inputs
            // 
            this.StopBits_Inputs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StopBits_Inputs.FormattingEnabled = true;
            this.StopBits_Inputs.Location = new System.Drawing.Point(549, 222);
            this.StopBits_Inputs.Name = "StopBits_Inputs";
            this.StopBits_Inputs.Size = new System.Drawing.Size(100, 21);
            this.StopBits_Inputs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Parity";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stop bit";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Buad rate";
            // 
            // DAtabits
            // 
            this.DAtabits.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DAtabits.AutoSize = true;
            this.DAtabits.Location = new System.Drawing.Point(481, 171);
            this.DAtabits.Name = "DAtabits";
            this.DAtabits.Size = new System.Drawing.Size(49, 13);
            this.DAtabits.TabIndex = 30;
            this.DAtabits.Text = "Data bits";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_send.Location = new System.Drawing.Point(470, 279);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 32;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // btn_cls
            // 
            this.btn_cls.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cls.Location = new System.Drawing.Point(471, 308);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_cls.TabIndex = 33;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_connect.Location = new System.Drawing.Point(574, 279);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 34;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(574, 309);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 35;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // SerialCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.DAtabits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopBits_Inputs);
            this.Controls.Add(this.DataBits_Input);
            this.Controls.Add(this.Parity_Input);
            this.Controls.Add(this.Baud_Rate);
            this.Controls.Add(this.Port_Name);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialCom";
            this.Text = "SerialCom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox response_box;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Port_Name;
        private System.Windows.Forms.ComboBox Baud_Rate;
        private System.Windows.Forms.ComboBox Parity_Input;
        private System.Windows.Forms.ComboBox DataBits_Input;
        private System.Windows.Forms.ComboBox StopBits_Inputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DAtabits;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_refresh;
    }
}

