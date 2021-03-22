using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPractic2
{
  public partial class Form1 : Form
  {
    public Form1()
    {

      InitializeComponent();
    }
    public new void PerformAutoScale()
    {

    }
    private void button1_Click(object sender, EventArgs e)
    {
      PerformAutoScale();
      double x = double.Parse(textBox1.Text);
      double y = (Math.Sin(3 * x) + Math.Pow(Math.Exp(x), (1 - Math.Pow(x, 2)))) / (Math.Pow(2, (x + 1)) + 1 - Math.Exp(5 * x * x - 1));
      textBox2.Text += Environment.NewLine +
"Результат y = " + y.ToString();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      PerformAutoScale();
      textBox1.Text = "2";
      textBox2.Text = "Ваш результат";
      textBox2.Text += Environment.NewLine + " ";

    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Resize(object sender, System.EventArgs e)
    {
      
    }
  }
}