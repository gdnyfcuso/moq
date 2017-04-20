﻿using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Moq.Proxy.Scaffold
{
    [ExportLanguageService(typeof(IDocumentVisitor), LanguageNames.CSharp, GeneratorLayer.Scaffold)]
    [Shared]
    class CSharpImplementInterfaceScaffold : ImplementInterfaceScaffold
    {
        public CSharpImplementInterfaceScaffold()
            : base(LanguageNames.CSharp)
        {
        }
    }
}