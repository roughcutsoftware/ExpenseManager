#pragma checksum "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc52b2240c9e2ce990fa5a1718651a457378228e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_Index), @"mvc.1.0.view", @"/Views/Expense/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Expense/Index.cshtml", typeof(AspNetCore.Views_Expense_Index))]
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
#line 1 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\_ViewImports.cshtml"
using ExpenseManager;

#line default
#line hidden
#line 2 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\_ViewImports.cshtml"
using ExpenseManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc52b2240c9e2ce990fa5a1718651a457378228e", @"/Views/Expense/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56456e038c6badcb713349cb361de84a2cc1a3f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExpenseManager.Models.ExpenseReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
  
    ViewData["Title"] = "Personal Expense Manager";

#line default
#line hidden
            BeginContext(119, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97426d85ae2c4b569fab25489fceee71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(192, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc058834b604bff97b3739c1233d316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(249, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2079b1ff50c749eea16f6c2176c1aeb6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(309, 568, true);
            WriteLiteral(@"
<script src=""//cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/js/bootstrap-datepicker.js""></script>
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/css/bootstrap-datepicker.css"" rel=""stylesheet"">

<h2>Personal Expense Manager</h2>
<br />
<div>
    <div style=""float:left"">
        <button class=""btn btn-primary"" onclick=""AddEditExpenses(0)"">Add Expense</button>
        <button class=""btn btn-success"" onclick=""ReportExpense()"">Expense Report</button>
    </div>
    <div style=""float:right; width:40%;"">
        ");
            EndContext();
            BeginContext(877, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7319ce22ba844ca4a5cbbdbf3726f255", async() => {
                BeginContext(946, 249, true);
                WriteLiteral("\r\n            <div class=\"col-sm-6\">\r\n                <input class=\"form-control\" type=\"text\" name=\"SearchString\" placeholder=\"Search\">\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default btn-info\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1202, 104, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(1307, 42, false);
#line 33 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1373, 44, false);
#line 34 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1441, 42, false);
#line 35 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1507, 47, false);
#line 36 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1578, 44, false);
#line 37 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 83, true);
            WriteLiteral("</th>\r\n            <th>Action Item</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1754, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1793, 41, false);
#line 45 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1862, 43, false);
#line 46 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1933, 41, false);
#line 47 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2002, 46, false);
#line 48 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpenseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2076, 43, false);
#line 49 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 80, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2199, "\"", 2238, 3);
            WriteAttributeValue("", 2209, "AddEditExpenses(", 2209, 16, true);
#line 51 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
WriteAttributeValue("", 2225, item.ItemId, 2225, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2237, ")", 2237, 1, true);
            EndWriteAttribute();
            BeginContext(2239, 66, true);
            WriteLiteral(">Edit</button>\r\n                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2305, "\"", 2342, 3);
            WriteAttributeValue("", 2315, "DeleteExpense(", 2315, 14, true);
#line 52 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
WriteAttributeValue("", 2329, item.ItemId, 2329, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2341, ")", 2341, 1, true);
            EndWriteAttribute();
            BeginContext(2343, 60, true);
            WriteLiteral(">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\asharma2\source\repos\ExpenseManager\ExpenseManager\Views\Expense\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2414, 2834, true);
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""expenseFormModel"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h3 id=""title"" class=""modal-title"">Add Expense</h3>
            </div>
            <div class=""modal-body"" id=""expenseFormModelDiv"">
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""expenseReportModal"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h3 class=""modal-title"">Expense Report</h3>
            </div>
            <div class=""modal-body"" id=""expenseReportModalDiv"">
            </div>
        </div>
    </div>
</div>

<script>

    var AddEditExpenses = function (itemId) {
        var url = ""/");
            WriteLiteral(@"Expense/AddEditExpenses?itemId="" + itemId;
        if (itemId > 0)
            $('#title').html(""Edit Expense"");

        $(""#expenseFormModelDiv"").load(url, function () {
            $(""#expenseFormModel"").modal(""show"");

        });

        $('#expenseFormModel').on('shown.bs.modal', function () {

            $('#calender-container .input-group.date').datepicker({
                todayBtn: true,
                calendarWeeks: true,
                todayHighlight: true,
                autoclose: true,
                container: '#expenseFormModel modal-body'
            });

        });
    }

    var ReportExpense = function () {
        var url = ""/Expense/ExpenseSummary"";

        $(""#expenseReportModalDiv"").load(url, function () {
            $(""#expenseReportModal"").modal(""show"");
        })
    }

    var DeleteExpense = function (itemId) {

        var ans = confirm(""Do you want to delete item with Item Id: "" + itemId);

        if (ans) {
            $.ajax({
  ");
            WriteLiteral(@"              type: ""POST"",
                url: ""/Expense/Delete/"" + itemId,
                success: function () {
                    window.location.href = ""/Expense/Index"";
                }
            })
        }
    }
</script>

<script>

    $('body').on('click', ""#btnSubmit"", function () {
        var myformdata = $(""#expenseForm"").serialize();

        $.ajax({
            type: ""POST"",
            url: ""/Expense/Create"",
            data: myformdata,
            success: function () {
                $(""#myModal"").modal(""hide"");
                window.location.href = ""/Expense/Index"";
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        })
    })
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExpenseManager.Models.ExpenseReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
