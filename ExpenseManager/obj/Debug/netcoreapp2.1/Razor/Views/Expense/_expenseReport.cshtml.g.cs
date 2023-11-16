#pragma checksum "C:\repos\GitHub-Folks\ExpenseManager\ExpenseManager\Views\Expense\_expenseReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "069aa1aba0564a8404264600309a5fee65ebc6ea07650023be255bb67ce46a60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense__expenseReport), @"mvc.1.0.view", @"/Views/Expense/_expenseReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Expense/_expenseReport.cshtml", typeof(AspNetCore.Views_Expense__expenseReport))]
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
#line 1 "C:\repos\GitHub-Folks\ExpenseManager\ExpenseManager\Views\_ViewImports.cshtml"
using ExpenseManager;

#line default
#line hidden
#line 2 "C:\repos\GitHub-Folks\ExpenseManager\ExpenseManager\Views\_ViewImports.cshtml"
using ExpenseManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"069aa1aba0564a8404264600309a5fee65ebc6ea07650023be255bb67ce46a60", @"/Views/Expense/_expenseReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f9ccabd0ed6b64bfcd8facad017b7f58ad35b1e14b46e41b51da5415dfefa754", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense__expenseReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3349, true);
            WriteLiteral(@"<script src=""https://code.highcharts.com/highcharts.js""></script>

<button id=""btnMonthlyReport"" class=""btn btn-info"">Monthly Report</button>
<button id=""btnWeeklyReport"" class=""btn btn-warning"">Weekly Report</button>
<div id=""container"" style=""min-width: 400px; height: 400px; margin: 0 auto"">

</div>

<script>

    $(document).ready(function () {
        $(""#btnWeeklyReport"").click(function () {
            var titleMessage = ""Expenses in last four weeks is : "";

            $.ajax({
                type: ""GET"",
                url: ""/Expense/GetWeeklyExpense"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (result) {
                    var keys = Object.keys(result);
                    var weeklydata = new Array();
                    var totalspent = 0.0;
                    for (var i = 0; i < keys.length; i++) {
                        var arrL = new Array();
                        arrL.push(keys[i]);
     ");
            WriteLiteral(@"                   arrL.push(result[keys[i]]);
                        totalspent += result[keys[i]];
                        weeklydata.push(arrL);
                    }
                    createCharts(weeklydata, titleMessage, totalspent.toFixed(2));
                }
            })
        })

        $(""#btnMonthlyReport"").click(function () {
            var titleMessage = ""Expenses in last six months is : "";

            $.ajax({
                type: ""GET"",
                url: ""/Expense/GetMonthlyExpense"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (result) {
                    var keys = Object.keys(result);
                    var monthlydata = new Array();
                    var totalspent = 0.0;
                    for (var i = 0; i < keys.length; i++) {
                        var arrL = new Array();
                        arrL.push(keys[i]);
                        arrL.push(result[keys[i]]);
  ");
            WriteLiteral(@"                      totalspent += result[keys[i]];
                        monthlydata.push(arrL);
                    }
                    createCharts(monthlydata, titleMessage, totalspent.toFixed(2));
                }
            })
        })
    })

    function createCharts(sum, titleText, totalspent) {
        Highcharts.chart('container', {
            chart: {
                type: 'column'
            },
            title: {
                text: titleText + ' ' + totalspent
            },
            xAxis: {
                type: 'category',
                labels: {
                    rotation: -45,
                    style: {
                        fontSize: '13px',
                        fontFamily: 'Verdana, sans-serif'
                    }
                }
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Money spent'
                }
            },
            legend: {
                ");
            WriteLiteral(@"enabled: false
            },
            tooltip: {
                pointFormat: 'Total money spent: <b>{point.y:.2f} </b>'
            },
            series: [{
                type: 'column',
                data: sum,
            }]
        });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
