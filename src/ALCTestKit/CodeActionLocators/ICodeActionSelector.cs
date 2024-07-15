using System.Collections.Generic;
using Microsoft.Dynamics.Nav.CodeAnalysis.CodeActions;

namespace ALCTestKit.CodeActionLocators;

public interface ICodeActionSelector
{
    public CodeAction Find(IReadOnlyList<CodeAction> actions);
}