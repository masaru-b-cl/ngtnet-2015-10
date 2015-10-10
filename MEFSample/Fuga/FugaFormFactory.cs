using MEFSample.Composition;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace Fuga
{
  [Export(typeof(IFormFactory))]
  [ExportMetadata("ProgramName", "Fuga")]
  public class FugaFormFactory : IFormFactory
  {
    public Form Create()
    {
      return new FugaForm();
    }
  }
}
