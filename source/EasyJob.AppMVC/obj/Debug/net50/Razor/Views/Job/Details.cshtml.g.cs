#pragma checksum "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "357efe2565c2a5269c34a9fa4fc456a8f81cdb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Details), @"mvc.1.0.view", @"/Views/Job/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\_ViewImports.cshtml"
using EasyJob.AppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\_ViewImports.cshtml"
using EasyJob.AppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"357efe2565c2a5269c34a9fa4fc456a8f81cdb0a", @"/Views/Job/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd57a8499e7a338aba032b4edee3af1710db3f55", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJob.AppMVC.ViewModel.JobViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Job</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinSalaryPerHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinSalaryPerHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxSalaryPerHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxSalaryPerHour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HourPerWeek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.HourPerWeek));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeeklySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeeklySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BiWeeklySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.BiWeeklySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlySalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeeklySalaryPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeeklySalaryPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BiWeeklySalaryPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.BiWeeklySalaryPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NeedExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.NeedExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NeedCar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.NeedCar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NeedTools));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.NeedTools));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ride));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ride));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 132 "C:\Users\geibi\Downloads\Rocha-20211127T140805Z-001\Rocha\source\EasyJob.AppMVC\Views\Job\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "357efe2565c2a5269c34a9fa4fc456a8f81cdb0a17503", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJob.AppMVC.ViewModel.JobViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
