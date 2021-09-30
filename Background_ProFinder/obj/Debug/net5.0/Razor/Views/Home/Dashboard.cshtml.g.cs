#pragma checksum "C:\Users\wan\Desktop\BuildSchool專題\back\Background_ProFinder\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced44c5959b36f71b1585cdb83ff74fd3c37b204"
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
#line 1 "C:\Users\wan\Desktop\BuildSchool專題\back\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wan\Desktop\BuildSchool專題\back\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced44c5959b36f71b1585cdb83ff74fd3c37b204", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1042ab2bd1801a3916ccb856993cba548ccba7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"" id=""app"">
    <loading-screen v-if=""isLoading""></loading-screen>
    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
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
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">{{MemberCount}}人</div>
                        </div>
                        <div class=""col-auto"">
                 ");
            WriteLiteral(@"           <i class=""fas fa-person-booth fa-2x text-gray-300""></i>
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
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">{{QuotationCount}}項</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
 ");
            WriteLiteral(@"               </div>
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
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">{{OrderCount}}件</div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-check-double fa-2x t");
            WriteLiteral(@"ext-gray-300""></i>
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
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">NT${{OrderRevenue}}</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </");
            WriteLiteral("div>\r\n    </div>\r\n\r\n\r\n    <!-- Content Row -->\r\n\r\n    <div class=\"row\">\r\n\r\n");
            WriteLiteral(@"        <!-- Area Chart -->
        <div class=""col-xl-8 col-lg-7"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">近五日上架服務件數折線圖</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
");
            WriteLiteral("                    <div class=\"barchart pt-6 pb-8\">\r\n");
            WriteLiteral("                        <bar-chart :height=\"200\" :tick=\"{min: 0, max: 10}\"></bar-chart>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Pie Chart -->\r\n        <div class=\"col-xl-4 col-lg-5\">\r\n");
            WriteLiteral(@"            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">前三大項服務種類比例圓餅圖</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">

                    <div class=""app pt-4 pb-2"" id=""piechar"">
                        <pie-chart></pie-chart>
                    </div>

");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("topCSS", async() => {
                WriteLiteral(" \r\n<style>\r\n    #loading {\r\n        color: gray; \r\n        font-size: 32px;\r\n        padding-top: 10vh;\r\n        height :100vh;\r\n        text-align :center;\r\n    }\r\n</style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("endJS", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js""></script>
    <script src=""https://unpkg.com/vue-chartjs/dist/vue-chartjs.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/apexcharts""></script>
    <script src=""https://cdn.jsdelivr.net/npm/vue-apexcharts""></script>
    <script src=""https://unpkg.com/vue/dist/vue.min.js""></script>
    <script src=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue.min.js""></script>
    <script src=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue-icons.min.js""></script>
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>






    <script>
        Vue.component('loading-screen', {
            template: '<div id=""loading"">Loading...</div>'
        })

        var app = new Vue({
            el: ""#app"",
            data() {
                return {
                 
      ");
                WriteLiteral(@"              MemberCount: 0,
                    OrderCount: 0,
                    QuotationCount: 0,
                    OrderRevenue: 0,
                    isLoading: true
                    //Piechartname: [],
                    //Piechartcnt: []
                }
            },
            mounted() {
                setTimeout(() => {
                    this.isLoading = false
                }, 6000)
            },
            created: function () {

                axios({ method: ""Get"", url: ""/api/Dashboard""}).then(res => {
                    this.MemberCount = JSON.parse(res.data.result).MemberCount;
                    this.QuotationCount = JSON.parse(res.data.result).QuotationCount;
                    this.OrderCount = JSON.parse(res.data.result).OrderCount;
                    this.OrderRevenue = JSON.parse(res.data.result).OrderRevenue;
                    //this.Piechartname.push(...JSON.parse(res.data.result).PieChartName);
                    //this.Piechartcnt.pus");
                WriteLiteral("h(...JSON.parse(res.data.result).PieChartCnt);\r\n                    console.log(JSON.parse(res.data.result));\r\n                });\r\n            }\r\n        \r\n        })\r\n\r\n    </script>\r\n\r\n");
                WriteLiteral(@"<script>
    Vue.component('bar-chart', {
        extends: VueChartJs.Bar,
        //props:  [""parentmsg""],
        data()//: function ()
        {
            return {
                datacollection: {
                
                    labels:[],
                    datasets: [
                        {
                            label: '上架件數',
                            backgroundColor: '#f87979',
                            data: []
                        }
                    ],
                },
                options: {
                    responsive: true,
                    legend: {
                        display: true,
                        position: 'top',
                    },

                    scales: {
                        //xAxes: [{
                        //    gridLines: {
                        //        display: true
                        //    }
                        //}],
                        yAxes: [{
                           ");
                WriteLiteral(@" gridLines: {
                                display: true
                            },
                            ticks: {
                                min: 0,
                                max: 10,
                                stepSize: 2,
                                //min: this.tick.min,
                                //max: this.tick.max,
                            }
                        }]
                    }
                },
            }
        },
     
        mounted() {
            // this.chartData is created in the mixin
            this.renderChart(this.datacollection, this.options)
            axios({ method: ""Get"", url: ""/api/Dashboard"" }).then(res => {
                this.datacollection.labels = JSON.parse(res.data.result).LaunchDay;
                this.datacollection.datasets[0].data = JSON.parse(res.data.result).LaunchCnt;
            });
        },
       
    })

    var vm = new Vue({
        el: '.barchart',
    })
</script>

");
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        Vue.component('pie-chart', {
            extends: VueChartJs.Pie,
            //props:  [""parentmsg""],
            data()//: function ()
            {
                return {
                 
                    datacollection: {
                        //labels: this.parentmsg,
                        labels: ['Pie 1', 'Pie 2', 'Pie 3'],
                        datasets: [
                            {
                                backgroundColor: ['#4e73df', '#1cc88a', '#36b9cc'],
                                data: [1, 2, 3]
                            },
                        ],
                    },
                    options: {
                        responsive: true,
                        legend: {
                            display: true,
                            position: 'right',
                        },
                    },
                }
            },
           
            mounted() {
                // this.chartData is");
                WriteLiteral(@" created in the mixin
                this.renderChart(this.datacollection, this.options)
                axios({ method: ""Get"", url: ""/api/Dashboard"" }).then(res => {
                    this.datacollection.labels = JSON.parse(res.data.result).PieChartName;
                    this.datacollection.datasets[0].data = JSON.parse(res.data.result).PieChartCnt;
                    //for (let i = 0; i < response.data.length; i++) {
                    //    this.datacollection.labels.push(response.data[i].value);
                    //    this.datacollection.datasets.data.push(response.data[i].key);
                    //}
                    //this.items.push(...JSON.parse(res.data.result));
                    //this.allitems = this.items;
                    //console.log(this.items);
                    //this.datacollection.labels = ['Pie 4', 'Pie 6', 'Pie 7'];
                    //this.data.datacollection.datasets[0].data = JSON.parse(res.data.result).PieChartCnt;
                });

       ");
                WriteLiteral("     }\r\n        })\r\n\r\n        var vm = new Vue({\r\n            el: \'.app\',\r\n        })\r\n    </script>\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n\r\n\r\n");
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
