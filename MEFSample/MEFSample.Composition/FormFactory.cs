using System.Windows.Forms;

namespace MEFSample.Composition
{

  public interface IFormFactory
  {
    Form Create();
  }

  public interface IFormFactoryMetadata
  {
    string ProgramName { get; }
  }

}
