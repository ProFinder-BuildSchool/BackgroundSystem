#pragma checksum "C:\Users\ac556\source\repos\BackgroundSystem\Background_ProFinder\Views\Home\OrderManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e079bf36878352d1a05b5539c8e3a232f88029f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderManagement), @"mvc.1.0.view", @"/Views/Home/OrderManagement.cshtml")]
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
#line 1 "C:\Users\ac556\source\repos\BackgroundSystem\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ac556\source\repos\BackgroundSystem\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e079bf36878352d1a05b5539c8e3a232f88029f", @"/Views/Home/OrderManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1042ab2bd1801a3916ccb856993cba548ccba7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ac556\source\repos\BackgroundSystem\Background_ProFinder\Views\Home\OrderManagement.cshtml"
  
    ViewData["Title"] = "OrderManagement";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Page Content -->
<div class=""container-fluid"" id=""app"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-4 text-gray-800 p-2"">訂單管理</h1>


    <!-- Order Table -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3 d-flex flex-row justify-content-between"">
            <b-pagination v-model=""currentPage"" :total-rows=""rows"" :per-page=""perPage"" align=""right""></b-pagination>
            <div class=""d-flex flex-row align-content-center"">
                <input type=""text"" placeholder=""搜尋關鍵字"" class=""form-control mr-2"" v-model=""keyword"" />
                <b-form-select v-model=""selected"" :options=""options""></b-form-select>
            </div>
            
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <div>
                    <b-table sort-icon-left striped hover responsive=""md"" :items=""items"" :fields=""fields"" :busy=""isBusy"" :per-page=""perPage"" :current-page=""currentPage"">
");
            WriteLiteral(@"                        <template #table-busy>
                            <div class=""text-center text-primary my-2"">
                                <b-spinner class=""align-middle""></b-spinner>
                                <strong>Loading...</strong>
                            </div>
                        </template>
                        <template #cell(ClientName)=""data"">
                            <p class=""modal-toggler"" style=""color:#8c6057;"" data-toggle=""modal"" data-target=""#client-modal"" ");
            WriteLiteral(@"@click=""findClient(data.item.OrderID)""> <i class=""fas fa-info-circle""></i>&ensp;{{data.value}}</p>
                        </template>
                        <template #cell(StudioName)=""data"">
                            <p class=""modal-toggler"" style=""color:#17a16e;"" data-toggle=""modal"" data-target=""#proposer-modal"" ");
            WriteLiteral(@"@click=""findProposer(data.item.OrderID)""> <i class=""fas fa-info-circle""></i>&ensp;{{data.value}}</p>
                        </template>
                        <template #cell(OrderStatusString)=""data"">
                            <p :class=""[data.item.OrderStatus==3?'modal-toggler text-danger':'modal-toggler text-primary']"" data-toggle=""modal"" data-target=""#order-modal"" ");
            WriteLiteral(@"@click=""findOrder(data.item.OrderID)""> <i class=""fas fa-file-signature""></i>&ensp;{{data.value}}</p>
                        </template>

                    </b-table>
                    
                </div>
            </div>
        </div>
    </div>

");
            WriteLiteral(@"    <div class=""modal fade"" id=""client-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">案主資訊</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>案主名稱：{{clientInfo.ClientName}}</p>
                    <p>案主電話：{{clientInfo.ClientTel}}</p>
                    <p>案主電郵：{{clientInfo.ClientEmail}}</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">關閉</button>
                </div>
            </d");
            WriteLiteral("iv>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""proposer-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">接案者資料</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>接案者名稱：{{proposerInfo.StudioName}}</p>
                    <p>接案者電話：{{proposerInfo.ProposerPhone}}</p>
                    <p>接案者電郵：{{proposerInfo.ProposerEmail}}</p>
                    <p>接案者平臺内餘額：NTD{{proposerInfo.BalanceString}}</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn");
            WriteLiteral(" btn-secondary\" data-dismiss=\"modal\">關閉</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""order-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">訂單資訊</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>訂單編號：{{orderInfo.OrderID}}</p>
                    <p>單價：{{orderInfo.PriceString}}</p>
                    <p>數量：{{orderInfo.Count}}</p>
                    <p>總價：{{orderInfo.TotalString}}</p>
                    <p>訂單狀態：{{orderInfo.OrderStatusString}}</p>
                    <p>成交日期：{{orderInfo.DealedDate}}</p>
                    <p>預計完成日期：{{orderInfo.Co");
            WriteLiteral(@"mpleteDate}}</p>
                    <p>案主備註：{{orderInfo.ClientMemo}}</p>
                    <p>接案者帳戶資訊：[銀行行號]{{orderInfo.BankCode}}[帳號]{{orderInfo.BankAccount}}</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" :disabled=isAbleToGiveMoney data-toggle=""modal"" data-target=""#giveMoney-modal"">進行撥款作業</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">關閉</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""giveMoney-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header bg-danger"">
                    <h5 class=""modal-title text-light"" id=""exampleModalLongTitle"">確定撥款作業</h5>
                    <button type=""button"" class=""close text-light"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>訂單編號：{{orderInfo.OrderID}}</p>
                    <p>確定撥款<span class=""text-danger"">{{orderInfo.TotalString}}元</span>至<span class=""text-primary"">{{orderInfo.StudioName}}</span>的帳戶</p>
");
            WriteLiteral("                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-danger\" ");
            WriteLiteral("@click=\"giveMoney(orderInfo.OrderID)\">確認撥款</button>\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">取消</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            DefineSection("topCSS", async() => {
                WriteLiteral(@"
    <link type=""text/css"" rel=""stylesheet"" href=""https://unpkg.com/bootstrap/dist/css/bootstrap.min.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue.min.css"" />
    <style>
        h6.table-title {
            line-height: 38px;
        }

        ul.pagination {
            margin-bottom: 0px;
        }

        td {
            padding-left: 22px !important;
        }

        p.modal-toggler {
            cursor: pointer;
        }
    </style>
");
            }
            );
            DefineSection("endJS", async() => {
                WriteLiteral(@"
    <script src=""https://unpkg.com/vue/dist/vue.min.js""></script>
    <script src=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue.min.js""></script>
    <script src=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue-icons.min.js""></script>
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@9""></script>
    <script>

        var app = new Vue({
            el: ""#app"",
            data() {
                return {
                    isBusy: true,
                    fields: [
                        { key: ""OrderID"", label: ""訂單編號"", sortable: true },
                        { key: ""Price"", label: ""單價"", sortable: true },
                        { key: ""Count"", label: ""數量"", sortable: true },
                        { key: ""Total"", label: ""總價"", sortable: true },
                        { key: ""ClientName"", label: ""客戶名稱"", sortable: true },
                        { key: ""StudioName"", label: ""接案工作室"", so");
                WriteLiteral(@"rtable: true },
                        { key: ""CompleteDate"", label: ""預計完成日"", sortable: true },
                        { key: ""DealedDate"", label: ""成交日期"", sortable: true },
                        { key: ""OrderStatusString"", label: ""訂單狀態"", sortable: true }
                    ],
                    options: [
                        { value: ""-1"", text: ""--訂單狀態--"" },
                        { value: ""0"", text: ""待付款"" },
                        { value: ""1"", text: ""製作中"" },
                        { value: ""2"", text: ""待驗收"" },
                        { value: ""3"", text: ""已提出撥款需求"" },
                        { value: ""4"", text: ""撥款完成"" },
                    ],
                    items: [],
                    allitems: [],
                    rows: 0,
                    perPage: 15,
                    currentPage: 1,
                    keyword: """",
                    clientInfo: {},
                    proposerInfo: {},
                    orderInfo: {},
                    isAbleToGive");
                WriteLiteral(@"Money: true,
                    selected:""-1""
                }
            },
            created: function () {
                $("".alert"").alert('close');
                axios({ method: ""Get"", url: ""/api/Order"" }).then(res => {
                    this.items.push(...JSON.parse(res.data.result));
                    this.allitems = this.items;
                    console.log(this.items);
                    console.log(this.allitems);
                });
            },
            watch: {
                items: function () {
                    this.rows = this.items.length
                    if (this.items != null) {
                        this.isBusy = false;
                    } else {
                        this.isBusy = true;
                    }
                },
                keyword: function () {
                    if (this.keyword == null) {
                        this.items = this.allitems;
                    } else {
                        this.items = th");
                WriteLiteral(@"is.allitems.filter(x => JSON.stringify(x).includes(this.keyword));
                    }
                },
                selected: function () {
                    let value = Number(this.selected);
                    if (value != -1) {
                        this.items = this.allitems.filter(x => x.OrderStatus == value);
                    } else {
                        this.items = this.allitems;
                    }
                }
            },
            methods: {
                findClient(arg) {
                    this.clientInfo = this.items.filter(x => x.OrderID == arg)[0];
                },
                findProposer(arg) {
                    this.proposerInfo = this.items.filter(x => x.OrderID == arg)[0];
                },
                findOrder(arg) {
                    this.orderInfo = this.items.filter(x => x.OrderID == arg)[0];
                    this.isAbleToGiveMoney = !this.orderInfo.IsClientComfirmed;
                },
                giveMo");
                WriteLiteral(@"ney(arg) {
                    axios.put(`/api/order/${arg}`).then(res => {
                        if (res.data.result) {
                            $('#giveMoney-modal').modal('hide');
                            $('#order-modal').modal('hide');
                            Swal.fire({
                                icon: 'success',
                                title: '撥款成功',
                                showConfirmButton: false,
                                timer: 1500
                            }).then(function () { window.location.reload(); });
                            
                            
                        } else {
                            $('#giveMoney-modal').modal('hide');
                            $('#order-modal').modal('hide');
                            Swal.fire({
                                icon: 'error',
                                title: '撥款失敗',
                                showConfirmButton: false,
                            ");
                WriteLiteral("    timer: 1500\r\n                            }).then(function () { window.location.reload(); });\r\n                        }\r\n                    });\r\n                }\r\n            },\r\n\r\n        })\r\n    </script>\r\n");
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
