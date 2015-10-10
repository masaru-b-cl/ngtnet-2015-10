using MEFSample.Composition;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace Hoge
{
  [Export(typeof(IFormFactory))]
  [ExportMetadata("ProgramName", "Hoge")]
  public class HogeFormFactory : IFormFactory
  {
    public Form Create()
    {
      return new HogeForm();
    }
  }
}
