using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string ad = "Ehed123";
            string sifre = "Admin123";
            string gelenad = adtextbox.Text;
            string gelensifre=sifretextbox.Text;
            if(gelenad == ad && sifre == gelensifre)
            {
                adtxtbox.Visible = false;
                adtextbox.Visible = false;
                sifretextbox.Visible= false;
                sifretxtbox.Visible = false;
                loginbtn.Visible = false;   
                listBox1.Visible = true;
                erzaqnovulbl.Visible = true;
                erzaqadilbl.Visible = true;
                erzaqsayilbl.Visible = true;
                button1.Visible = true;
                erzaqnovucombo.Visible=true;
                erzaqsayinumeric.Visible = true;
                erzaqaditxt.Visible = true;
              
                barcodelbl.Visible=true;
                sekilileolanbutton.Visible=true;    
                barcode.Visible=true;
                button2.Visible=false;
                textBox1.Visible=true;
                button3.Visible = true;
                label1.Visible=true;
                button4.Visible=false;
                button6.Visible=false;
                button4.Visible = true;
                button10.Visible=true;
                listView1.Visible=true;
            }

         
        }

        private void adtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifretextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string erzaqnovu=erzaqnovucombo.Text;
            string erzaqsayi = erzaqsayinumeric.Text;
            string erzaqadi = erzaqaditxt.Text;
            string barcodealma = barcode.Text;
            string listboxlama = listBox1.GetItemText;
            MessageBox.Show(listboxlama);

            listView1.Visible = true;
            string kateqoriya, mehsul, sayi, barkod,listalmaq;
    

            string[] melumatlar = { erzaqnovu, erzaqadi,erzaqsayi, barcodealma,listboxlama };
            ListViewItem td = new ListViewItem(melumatlar);
            listView1.Items.Add(td);



        }

        private void erzaqaditxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
            listBox1.Items.Add(textBox1.Text); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            erzaqnovulbl.Visible = false;
            erzaqadilbl.Visible = false;
            erzaqsayilbl.Visible = false;
            button1.Visible = false;
            erzaqnovucombo.Visible = false ;
            erzaqsayinumeric.Visible = false;
            erzaqaditxt.Visible = false;
            barcodelbl.Visible = false;
            sekilileolanbutton.Visible = false;
            barcode.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            button7.Visible = true;
            button8.Visible = true;

        }

     

        private void label3_Click(object sender, EventArgs e)
        {
            var item = label3.Select;
            DialogResult result = MessageBox.Show("Arxa Fon Rengiviz Mavi Olsun?", "Sual.Exe", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dialogres = colorDialog1.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                this.BackColor = Color.Blue;
            }

            var item1 = label3.Select;
            DialogResult result1 = MessageBox.Show("Arxa Fon Rengiviz Qirmizi Olsun?", "Sual.Exe", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dialogres1 = colorDialog1.ShowDialog();
            if (dialogres1 == DialogResult.OK)
            {
                this.BackColor = Color.Red;
            }


            var item2 = label3.Select;
            DialogResult result2 = MessageBox.Show("Arxa Fon Rengiviz Sari Olsun?", "Sual.Exe", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dialogres2 = colorDialog1.ShowDialog();
            if (dialogres2 == DialogResult.OK)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            sekilileolanbutton.Visible=false;
            label1.Visible = false;
            button3.Visible=false;
            textBox1.Visible=false;
            listBox1.Visible =false;
            button1.Visible = false;
            barcode.Visible=false;
            barcodelbl.Visible=false;
            erzaqaditxt.Visible = false;
            erzaqadilbl.Visible=false;
            erzaqsayilbl.Visible=false;
            erzaqnovulbl.Visible = false;
            erzaqnovucombo.Visible = false;
            loginbtn.Visible = false;
            erzaqsayinumeric.Visible=false;
            button4.Visible=false;
            button8.Visible = false;
            button7.Visible=false;
            button5.Visible = false;
            button11.Visible=true;
            label4.Visible=true;
            label3.Visible=true;
            label5.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var item = label3.Select;
            DialogResult result = MessageBox.Show("Arxa Fon Rengiviz Qirmizi Olsun?", "Sual.Exe", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dialogres = colorDialog1.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                this.BackColor = Color.Red;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var item = label3.Select;
            DialogResult result = MessageBox.Show("Arxa Fon Rengiviz Sari Olsun?", "Sual.Exe", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dialogres = colorDialog1.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}