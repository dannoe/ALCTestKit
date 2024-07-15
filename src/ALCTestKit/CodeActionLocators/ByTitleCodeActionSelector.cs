﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.Dynamics.Nav.CodeAnalysis.CodeActions;

namespace ALCTestKit.CodeActionLocators;

public class ByTitleCodeActionSelector : ICodeActionSelector
{
    private readonly string _title;

    public ByTitleCodeActionSelector(string title)
    {
        _title = title;
    }


    public CodeAction Find(IReadOnlyList<CodeAction> actions)
    {
        return actions.FirstOrDefault(x => x.Title == _title);
    }

    public override string ToString()
    {
        return $"with title '{_title}'";
    }
}