namespace aweme_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int BIC(int x, int m)
        {

            return x & ~m;
        }
        uint BIC(uint x, int m)
        {

            return (uint)(x & ~m);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            uint s = 0x20230928;


            List<byte> bytes = new List<byte>();

            bytes.AddRange(textBox2.Text.HexToByte());

            bytes.AddRange(textBox1.Text.HexToByte());

            bytes.AddRange(textBox3.Text.HexToByte());


            byte[] data = bytes.ToArray();

            for (int i = 0; i < data.Length; i++)
            {
                s = (s >> 4) ^ ((s << 6) ^ data[i]) ^ s;

                i++;

                s = ~((BIC(s << 0xc, data[i]) + data[i]) ^ (s >> 7) ^ s);

            }


            textBox4.Text = s.ToString("X") + "   ¿‡–Õ «£∫" + s % 16;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}