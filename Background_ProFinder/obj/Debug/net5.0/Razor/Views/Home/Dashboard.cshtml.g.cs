#pragma checksum "C:\Users\yoyo4\Desktop\ProFinderBackGround\Background_ProFinder\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680f9b65f0f101558269fb82da93ee3e445b5a92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\yoyo4\Desktop\ProFinderBackGround\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yoyo4\Desktop\ProFinderBackGround\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680f9b65f0f101558269fb82da93ee3e445b5a92", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1042ab2bd1801a3916ccb856993cba548ccba7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">

 

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
        <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">
            <i class=""fas fa-download fa-sm text-white-50""></i> Generate Report
        </a>
    </div>

    <!-- Content Row -->
    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-primary shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                                使用者總數
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-8");
            WriteLiteral(@"00"">30人</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-person-booth fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                產品總數
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">150項</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipbo");
            WriteLiteral(@"ard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                                訂單總數
                            </div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">18件</div>
                                </div>
");
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-check-double fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Pending Requests Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                銷售總額
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">NT$24,900</div>
                        </div>
                        <div class=""col-auto"">
                           ");
            WriteLiteral(" <i class=\"fas fa-dollar-sign fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n    <!-- Earnings (Monthly) Card Example -->\r\n");
            WriteLiteral("\r\n\r\n\r\n    <!-- Content Row -->\r\n\r\n    <div class=\"row\">\r\n");
            WriteLiteral(@"        <!-- Area Chart -->
        <div class=""col-xl-8 col-lg-7"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">產品上架件數折線圖</h6>
                    <div class=""dropdown no-arrow"">
                        <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                             aria-labelledby=""dropdownMenuLink"">
                            <div class=""dropdown-header"">Dropdown Header:</div>
                            <a class=""dropdown-item"" href=""#"">Ac");
            WriteLiteral(@"tion</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div class=""chart-area"">
                        <canvas id=""myAreaChart""></canvas>
                    </div>
                </div>
            </div>
        </div>

        <!-- Pie Chart -->
        <div class=""col-xl-4 col-lg-5"">
");
            WriteLiteral(@"            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">前五大項商品銷售比例圓餅圖</h6>
                    <div class=""dropdown no-arrow"">
                        <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                             aria-labelledby=""dropdownMenuLink"">
                            <div class=""dropdown-header"">Dropdown Header:</div><a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
    ");
            WriteLiteral(@"                        <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div class=""chart-pie pt-4 pb-2"">
                        <canvas id=""myPieChart""></canvas>
                    </div>
                    <div class=""mt-4 text-center small"">
                        <span class=""mr-2"">
                            <i class=""fas fa-circle text-primary""></i> Direct
                        </span>
                        <span class=""mr-2"">
                            <i class=""fas fa-circle text-success""></i> Social
                        </span>
                        <span class=""mr-2"">
                            <i class=""fas fa-circle text-info""></i> Referral
                        </span>
                    </div>
                ");
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("endJS", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js""></script>
    <script>

        $(document).ready(function () {
            // Set new default font family and font color to mimic Bootstrap's default styling
            Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,""Segoe UI"",Roboto,""Helvetica Neue"",Arial,sans-serif';
            Chart.defaults.global.defaultFontColor = '#858796';

            function number_format(number, decimals, dec_point, thousands_sep) {
                // *     example: number_format(1234.56, 2, ',', ' ');
                // *     return: '1 234,56'
                number = (number + '').replace(',', '').replace(' ', '');
                var n = !isFinite(+number) ? 0 : +number,
                    prec = !isFinite(+decimals) ? 0 : Math.abs(decimals),
                    sep = (typeof thousands_sep === 'undefined') ? ',' : thousands_sep,
                    dec = (typeof dec_point ==");
                WriteLiteral(@"= 'undefined') ? '.' : dec_point,
                    s = '',
                    toFixedFix = function (n, prec) {
                        var k = Math.pow(10, prec);
                        return '' + Math.round(n * k) / k;
                    };
                // Fix for IE parseFloat(0.55).toFixed(0) = 0;
                s = (prec ? toFixedFix(n, prec) : '' + Math.round(n)).split('.');
                if (s[0].length > 3) {
                    s[0] = s[0].replace(/\B(?=(?:\d{3})+(?!\d))/g, sep);
                }
                if ((s[1] || '').length < prec) {
                    s[1] = s[1] || '';
                    s[1] += new Array(prec - s[1].length + 1).join('0');
                }
                return s.join(dec);
            }

            // Area Chart Example
            var ctx = document.getElementById(""myAreaChart"");
            var myLineChart = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: [""Jan"", ""Feb"", ""Mar""");
                WriteLiteral(@", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                    datasets: [{
                        label: ""Earnings"",
                        lineTension: 0.3,
                        backgroundColor: ""rgba(78, 115, 223, 0.05)"",
                        borderColor: ""rgba(78, 115, 223, 1)"",
                        pointRadius: 3,
                        pointBackgroundColor: ""rgba(78, 115, 223, 1)"",
                        pointBorderColor: ""rgba(78, 115, 223, 1)"",
                        pointHoverRadius: 3,
                        pointHoverBackgroundColor: ""rgba(78, 115, 223, 1)"",
                        pointHoverBorderColor: ""rgba(78, 115, 223, 1)"",
                        pointHitRadius: 10,
                        pointBorderWidth: 2,
                        data: [0, 10000, 5000, 15000, 10000, 20000, 15000, 25000, 20000, 30000, 25000, 40000],
                    }],
                },
                options: {
                    maintainAspectRatio: false,
 ");
                WriteLiteral(@"                   layout: {
                        padding: {
                            left: 10,
                            right: 25,
                            top: 25,
                            bottom: 0
                        }
                    },
                    scales: {
                        xAxes: [{
                            time: {
                                unit: 'date'
                            },
                            gridLines: {
                                display: false,
                                drawBorder: false
                            },
                            ticks: {
                                maxTicksLimit: 7
                            }
                        }],
                        yAxes: [{
                            ticks: {
                                maxTicksLimit: 5,
                                padding: 10,
                                // Include a dollar sign in the ticks
       ");
                WriteLiteral(@"                         callback: function (value, index, values) {
                                    return '$' + number_format(value);
                                }
                            },
                            gridLines: {
                                color: ""rgb(234, 236, 244)"",
                                zeroLineColor: ""rgb(234, 236, 244)"",
                                drawBorder: false,
                                borderDash: [2],
                                zeroLineBorderDash: [2]
                            }
                        }],
                    },
                    legend: {
                        display: false
                    },
                    tooltips: {
                        backgroundColor: ""rgb(255,255,255)"",
                        bodyFontColor: ""#858796"",
                        titleMarginBottom: 10,
                        titleFontColor: '#6e707e',
                        titleFontSize: 14,
             ");
                WriteLiteral(@"           borderColor: '#dddfeb',
                        borderWidth: 1,
                        xPadding: 15,
                        yPadding: 15,
                        displayColors: false,
                        intersect: false,
                        mode: 'index',
                        caretPadding: 10,
                        callbacks: {
                            label: function (tooltipItem, chart) {
                                var datasetLabel = chart.datasets[tooltipItem.datasetIndex].label || '';
                                return datasetLabel + ': $' + number_format(tooltipItem.yLabel);
                            }
                        }
                    }
                }
            });
        })

    </script>



");
            }
            );
            WriteLiteral("\r\n");
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
