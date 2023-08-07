namespace MultifunctionCalculatorwhitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double s1, s2;
        string isaret;

        private void Rakamlar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text != "0")
            {


                textBox1.Text += btn.Text;

            }
            else
            {
                textBox1.Clear();
                textBox1.Text += btn.Text;

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",")) return;
            textBox1.Text += ",";
        }

        private void İslemler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                if (s1 != 0)
                {
                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    textBox1.Text = (s1 + sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "-")
            {
                if (s1 != 0)
                {
                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    textBox1.Text = (s1 - sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "/")
            {
                if (s1 != 0)
                {
                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    if (sayi == 0) label1.Text = "Hata"; else textBox1.Text = (s1 / sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "*")
            {
                if (s1 != 0)
                {
                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    textBox1.Text = (s1 * sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "%")
            {
                if (s1 != 0)
                {
                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    if (sayi == 0) label1.Text = "Hata"; else textBox1.Text = (s1 % sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "n!")
            {
                double sayi;
                double fakt = 1;
                double.TryParse(textBox1.Text, out sayi);
                try
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        fakt = fakt * i;
                    }
                    if (fakt.ToString() == "Infinity")
                    {
                        label1.Text = "Hata"; textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = fakt.ToString();
                        label1.Text = sayi + "!";
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                    textBox1.Text = "0";
                }
            }
            else if (btn.Text == "√")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Sqrt(s1).ToString();
                label1.Text = "√" + s1;
            }
            else if (btn.Text == "³√")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Pow(s1, (double)1 / 3).ToString();//Math.Pow(s1, 0.333333333333333).ToString();//0.333333333333333 sayısı 1/3 ün sonucudur...
                label1.Text = "³√" + s1;
            }
            else if (btn.Text == "PI")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.PI.ToString();
                label1.Text = "PI";
            }
            else if (btn.Text == "Sin")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Sin(Math.PI * s1 / 180).ToString();
                label1.Text = "Sin " + s1;
            }
            else if (btn.Text == "Cos")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Cos(Math.PI * s1 / 180).ToString();
                label1.Text = "Cos " + s1;
            }
            else if (btn.Text == "Tan")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Tan(Math.PI * s1 / 180).ToString();
                label1.Text = "Tan " + s1;
            }
            else if (btn.Text == "x²")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = (s1 * s1).ToString();
                label1.Text = s1 + "²";
            }
            else if (btn.Text == "x³")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = (s1 * s1 * s1).ToString();
                label1.Text = s1 + "³";
            }
            else if (btn.Text == "Üs")
            {
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + "^";
                textBox1.Text = "0";
            }
            else if (btn.Text == "ln")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Log(s1).ToString();
                label1.Text = "ln " + s1;
            }
            else if (btn.Text == "Log10")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Log10(s1).ToString();
                label1.Text = "Log10 " + s1;
            }
            else if (btn.Text == "Log(sy,tbn)")
            {
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = "Log(" + s1 + ",taban)";
                textBox1.Text = "0";
            }
            else if (btn.Text == "1/x")
            {
                double.TryParse(textBox1.Text, out s1);
                label1.Text = "1/" + s1;
                if (s1 != 0) textBox1.Text = (1 / s1).ToString(); else label1.Text = "Hata";
            }
            else if (btn.Text == "e")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.E.ToString();
            }
            else if (btn.Text == "C")
            {
                s1 = 0;
                s2 = 0;
                isaret = "";
                textBox1.Text = "0";
                label1.Text = "";
            }
            else if (btn.Text == "<-")
            {
                try
                {
                    if (textBox1.Text.Length != 0)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        if (textBox1.Text.Length == 0)
                        {
                            textBox1.Text = "0";
                        }
                    }
                }
                catch
                { }
            }
            if (btn.Text == "=")
            {
                label1.Text = "";
                double.TryParse(textBox1.Text, out s2);
                if (isaret == "+") textBox1.Text = (s1 + s2).ToString();
                if (isaret == "-") textBox1.Text = (s1 - s2).ToString();
                if (isaret == "*") textBox1.Text = (s1 * s2).ToString();
                if (isaret == "/") if (s2 == 0) label1.Text = "Hata"; else textBox1.Text = (s1 / s2).ToString();
                if (isaret == "%") if (s2 == 0) label1.Text = "Hata"; else textBox1.Text = (s1 % s2).ToString();
                if (isaret == "Üs") textBox1.Text = Math.Pow(s1, s2).ToString();
                if (isaret == "Log(sy,tbn)") textBox1.Text = Math.Log(s1, s2).ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Melek Sungur Tarafından C# eğitimleri kapsamında hazırlanmıştır.", "Bilgi", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}