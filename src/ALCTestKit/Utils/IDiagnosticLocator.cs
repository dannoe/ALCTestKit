using Microsoft.Dynamics.Nav.CodeAnalysis;
using Microsoft.Dynamics.Nav.CodeAnalysis.Text;

namespace ALCTestKit.Utils;

public interface IDiagnosticLocator
{
    bool Match(Location location);
    TextSpan GetSpan();

    string Description();
}