namespace Market
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adtxtbox = new System.Windows.Forms.Label();
            this.adtextbox = new System.Windows.Forms.TextBox();
            this.sifretxtbox = new System.Windows.Forms.Label();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.erzaqnovucombo = new System.Windows.Forms.ComboBox();
            this.erzaqsayinumeric = new System.Windows.Forms.NumericUpDown();
            this.erzaqaditxt = new System.Windows.Forms.TextBox();
            this.erzaqnovulbl = new System.Windows.Forms.Label();
            this.erzaqsayilbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.erzaqadilbl = new System.Windows.Forms.Label();
            this.barcodelbl = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.sekilileolanbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.erzaqsayinumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // adtxtbox
            // 
            this.adtxtbox.AutoSize = true;
            this.adtxtbox.Location = new System.Drawing.Point(12, 27);
            this.adtxtbox.Name = "adtxtbox";
            this.adtxtbox.Size = new System.Drawing.Size(28, 20);
            this.adtxtbox.TabIndex = 0;
            this.adtxtbox.Text = "Ad";
            // 
            // adtextbox
            // 
            this.adtextbox.Location = new System.Drawing.Point(85, 29);
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(125, 27);
            this.adtextbox.TabIndex = 1;
            this.adtextbox.TextChanged += new System.EventHandler(this.adtextbox_TextChanged);
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.AutoSize = true;
            this.sifretxtbox.Location = new System.Drawing.Point(12, 79);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.Size = new System.Drawing.Size(39, 20);
            this.sifretxtbox.TabIndex = 2;
            this.sifretxtbox.Text = "Sifre";
            // 
            // sifretextbox
            // 
            this.sifretextbox.Location = new System.Drawing.Point(85, 72);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.Size = new System.Drawing.Size(125, 27);
            this.sifretextbox.TabIndex = 3;
            this.sifretextbox.TextChanged += new System.EventHandler(this.sifretextbox_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(12, 127);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(198, 86);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Giriş";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // erzaqnovucombo
            // 
            this.erzaqnovucombo.DisplayMember = "sa ";
            this.erzaqnovucombo.FormattingEnabled = true;
            this.erzaqnovucombo.Items.AddRange(new object[] {
            "Un Memulatlari",
            "Sirniyyatlar",
            "Caylar",
            "Edavalar",
            "Yag Ve Et Mehsullari"});
            this.erzaqnovucombo.Location = new System.Drawing.Point(284, 227);
            this.erzaqnovucombo.Name = "erzaqnovucombo";
            this.erzaqnovucombo.Size = new System.Drawing.Size(151, 28);
            this.erzaqnovucombo.TabIndex = 5;
            this.erzaqnovucombo.ValueMember = "sa ";
            this.erzaqnovucombo.Visible = false;
            this.erzaqnovucombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // erzaqsayinumeric
            // 
            this.erzaqsayinumeric.Location = new System.Drawing.Point(285, 291);
            this.erzaqsayinumeric.Name = "erzaqsayinumeric";
            this.erzaqsayinumeric.Size = new System.Drawing.Size(150, 27);
            this.erzaqsayinumeric.TabIndex = 6;
            this.erzaqsayinumeric.Visible = false;
            // 
            // erzaqaditxt
            // 
            this.erzaqaditxt.Location = new System.Drawing.Point(285, 358);
            this.erzaqaditxt.Multiline = true;
            this.erzaqaditxt.Name = "erzaqaditxt";
            this.erzaqaditxt.Size = new System.Drawing.Size(150, 37);
            this.erzaqaditxt.TabIndex = 7;
            this.erzaqaditxt.Visible = false;
            this.erzaqaditxt.TextChanged += new System.EventHandler(this.erzaqaditxt_TextChanged);
            // 
            // erzaqnovulbl
            // 
            this.erzaqnovulbl.Location = new System.Drawing.Point(284, 196);
            this.erzaqnovulbl.Name = "erzaqnovulbl";
            this.erzaqnovulbl.Size = new System.Drawing.Size(105, 28);
            this.erzaqnovulbl.TabIndex = 8;
            this.erzaqnovulbl.Text = "Erzaq Novu";
            this.erzaqnovulbl.Visible = false;
            // 
            // erzaqsayilbl
            // 
            this.erzaqsayilbl.Location = new System.Drawing.Point(284, 258);
            this.erzaqsayilbl.Name = "erzaqsayilbl";
            this.erzaqsayilbl.Size = new System.Drawing.Size(105, 33);
            this.erzaqsayilbl.TabIndex = 9;
            this.erzaqsayilbl.Text = "Erzaq Sayi";
            this.erzaqsayilbl.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Salam";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(509, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 104);
            this.listBox1.TabIndex = 10;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 284);
            this.button1.TabIndex = 11;
            this.button1.Text = "Goster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erzaqadilbl
            // 
            this.erzaqadilbl.Location = new System.Drawing.Point(284, 321);
            this.erzaqadilbl.Name = "erzaqadilbl";
            this.erzaqadilbl.Size = new System.Drawing.Size(88, 34);
            this.erzaqadilbl.TabIndex = 12;
            this.erzaqadilbl.Text = "Erzaq Adi";
            this.erzaqadilbl.Visible = false;
            // 
            // barcodelbl
            // 
            this.barcodelbl.AutoSize = true;
            this.barcodelbl.Location = new System.Drawing.Point(284, 402);
            this.barcodelbl.Name = "barcodelbl";
            this.barcodelbl.Size = new System.Drawing.Size(64, 20);
            this.barcodelbl.TabIndex = 13;
            this.barcodelbl.Text = "Barcode";
            this.barcodelbl.Visible = false;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(285, 425);
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Size = new System.Drawing.Size(150, 27);
            this.barcode.TabIndex = 14;
            this.barcode.Text = "3112658965";
            this.barcode.Visible = false;
            // 
            // sekilileolanbutton
            // 
            this.sekilileolanbutton.Image = ((System.Drawing.Image)(resources.GetObject("sekilileolanbutton.Image")));
            this.sekilileolanbutton.Location = new System.Drawing.Point(-5, 19);
            this.sekilileolanbutton.Name = "sekilileolanbutton";
            this.sekilileolanbutton.Size = new System.Drawing.Size(1222, 140);
            this.sekilileolanbutton.TabIndex = 16;
            this.sekilileolanbutton.UseVisualStyleBackColor = true;
            this.sekilileolanbutton.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-209, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1682, 129);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Əlavə";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 27);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(12, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(604, 317);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(914, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 299);
            this.button4.TabIndex = 24;
            this.button4.Text = "Endirimlerden Yararlan";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(354, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(440, 366);
            this.button7.TabIndex = 26;
            this.button7.Text = " ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(2, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(370, 407);
            this.button8.TabIndex = 27;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(803, -4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(433, 421);
            this.button5.TabIndex = 25;
            this.button5.Text = "Eh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(1156, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 29;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(1224, 419);
            this.button9.TabIndex = 30;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mavi";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1156, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 50);
            this.button10.TabIndex = 32;
            this.button10.Text = " ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(-5, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(277, 167);
            this.button11.TabIndex = 33;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Qirmizi";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sari";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(12, 560);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1205, 196);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Kategoriya";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Adi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Sayi";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Barcode";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Əlave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 749);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sekilileolanbutton);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.barcodelbl);
            this.Controls.Add(this.erzaqadilbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.erzaqsayilbl);
            this.Controls.Add(this.erzaqnovulbl);
            this.Controls.Add(this.erzaqaditxt);
            this.Controls.Add(this.erzaqsayinumeric);
            this.Controls.Add(this.erzaqnovucombo);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.adtextbox);
            this.Controls.Add(this.adtxtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BRAVO&ADACADEMY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erzaqsayinumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label adtxtbox;
        private TextBox adtextbox;
        private Label sifretxtbox;
        private TextBox sifretextbox;
        private Button loginbtn;
        private ComboBox erzaqnovucombo;
        private NumericUpDown erzaqsayinumeric;
        private TextBox erzaqaditxt;
        private Label erzaqnovulbl;
        private Label erzaqsayilbl;
        private ListBox listBox1;
        private Button button1;
        private Label erzaqadilbl;
        private Label barcodelbl;
        private TextBox barcode;
        private Button sekilileolanbutton;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button5;
        private Label label2;
        private ColorDialog colorDialog1;
        private Button button9;
        private Label label3;
        private Button button10;
        private Button button11;
        private Label label4;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}