namespace aplikasi_2_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtB.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int jumlah = numA + numB;
                txthasil.Text = jumlah.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukkan tidak valid", "Salah input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtB.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int hasil = numA - numB;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukkan tidak valid", "Salah input");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtB.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int hasil = numA * numB;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukkan tidak valid", "Salah input");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtB.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int hasil = numA / numB;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukkan tidak valid", "Salah input");
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txthasil.Text = "";
        }

        private void txthasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}