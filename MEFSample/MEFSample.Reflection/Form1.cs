using System;
using System.Reflection;
using System.Windows.Forms;

namespace MEFSample.Reflection
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var assemblyFileName = textBox1.Text;
      var formClassFullName = textBox2.Text;

      var asm = Assembly.LoadFrom(System.IO.Path.Combine(@".\plugins\", assemblyFileName));
      var formType = asm.GetType(formClassFullName);
      using(var form = Activator.CreateInstance(formType) as Form)
      {
        form.ShowDialog();
      }
    }
  }
}
