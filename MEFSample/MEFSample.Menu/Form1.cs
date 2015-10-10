using MEFSample.Composition;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Windows.Forms;

namespace MEFSample.Menu
{
  public partial class Form1 : Form
  {

    [ImportMany]
    private IEnumerable<Lazy<IFormFactory, IFormFactoryMetadata>> factories { get; set; }

    public Form1()
    {
      InitializeComponent();

      var catalog = new DirectoryCatalog(@".\plugins");
      var container = new CompositionContainer(catalog);
      container.ComposeParts(this);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var programName = textBox1.Text;

      var factory = factories.FirstOrDefault(f => f.Metadata.ProgramName == programName);
      if (factory != null)
      {
        using (var form = factory.Value.Create())
        {
          form.ShowDialog();
        }
      }
      else
      {
        MessageBox.Show("該当する機能がありません。");
      }
    }
  }
}
