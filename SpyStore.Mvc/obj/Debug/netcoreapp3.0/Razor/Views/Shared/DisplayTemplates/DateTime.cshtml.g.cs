#pragma checksum "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43363dae34681cbcc05eb8c67ff9fbded062a23e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_DateTime), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using SpyStore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using SpyStore.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using SpyStore.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using SpyStore.Mvc.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43363dae34681cbcc05eb8c67ff9fbded062a23e", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12073c195711606e34ca52e68f517077775224c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_DateTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Unknown\r\n");
#nullable restore
#line 5 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
}
else
{
    if (ViewData.ModelMetadata.IsNullableValueType)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 10 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(Model.Value.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 14 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(((DateTime)Model).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Worksapce\Dot.netCoreSample\Building Web Applications with .NET Core 2.1 and JavaScript\Unisi-Workshop\SpyStore.Mvc\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
