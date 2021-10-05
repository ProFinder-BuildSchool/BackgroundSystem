#pragma checksum "C:\Users\User\Desktop\BackgroundSystem_Profinder\Background_ProFinder\Views\Home\MemManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f589f3bfe382f9d4e28f55852ec4f4f7d1fefde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MemManagement), @"mvc.1.0.view", @"/Views/Home/MemManagement.cshtml")]
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
#line 1 "C:\Users\User\Desktop\BackgroundSystem_Profinder\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BackgroundSystem_Profinder\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f589f3bfe382f9d4e28f55852ec4f4f7d1fefde", @"/Views/Home/MemManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1042ab2bd1801a3916ccb856993cba548ccba7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MemManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\BackgroundSystem_Profinder\Background_ProFinder\Views\Home\MemManagement.cshtml"
  
    ViewData["Title"] = "MemManagement";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Page Content -->
<div class=""container-fluid"" id=""app"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-4 text-gray-800 p-2"">會員管理</h1>


    <!-- MemList Table -->
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
                        <template #cell(Email)=""data"">
                            <a :href=""`mailto:${data.value}`"" style=""color:#8c6057;""  >{{data.value}}</a>
                        </template>

                        
                    </b-table>

                </div>
            </div>
        </div>
    </div>

</div>

");
            DefineSection("topCSS", async() => {
                WriteLiteral(@"
<link type=""text/css"" rel=""stylesheet"" href=""https://unpkg.com/bootstrap/dist/css/bootstrap.min.css"" />
<link type=""text/css"" rel=""stylesheet"" href=""https://unpkg.com/bootstrap-vue@latest/dist/bootstrap-vue.min.css"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css"" rel=""stylesheet"" />
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
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>
<script>

        var app = new Vue({
            el: ""#app"",
            data() {
                return {
                    isBusy: true,
                    fields: [
                        { key: ""MemberId"", label: ""編號"", sortable: true },
                        { key: ""NickName"", label: ""名稱"", sortable: true },
                        { key: ""LocationString"", label: ""地點"", sortable: true },
                        { key: ""IdentityString"", label: ""接案身分"", sortable: true },
                        { key: ""UserId"", label: """);
                WriteLiteral(@"使用者號"", sortable: true },
                        { key: ""Cellphone"", label: ""電話"", sortable: true },
                        { key: ""Email"", label: ""信箱"", sortable: true },
                        
                    ],
                    options: [
                        { value: ""-1"", text: ""--接案身分--"" },
                        { value: ""0"", text: ""NoRecord"" },
                        { value: ""1"", text: ""個人兼職"" },
                        { value: ""2"", text: ""專職SOHO"" },
                        { value: ""3"", text: ""工作室"" },
                        { value: ""4"", text: ""兼職上班族"" },
                        { value: ""5"", text: ""公司"" },
                        { value: ""6"", text: ""學生"" },

                    ],
                    items: [],
                    allitems: [],
                    rows: 0,
                    perPage: 15,
                    currentPage: 1,
                    keyword: """",
                    selected: ""-1"",
                }
            },
            created: ");
                WriteLiteral(@"function () {
                axios({ method: ""get"", url: ""/api/Member"" }).then(res => {
                    this.items.push(...JSON.parse(res.data.result));
                    this.allitems = this.items;
                    //console.log(this.items);
                    //console.log(this.allitems);
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
                        this.items = this.allitems.filter(x => JSON.stringify(x).includes(this.keyword));
                    }
                },
                selected: function");
                WriteLiteral(@" () {
                    let value = Number(this.selected);
                    if (value != -1) {
                        this.items = this.allitems.filter(x => x.Identity == value);
                    } else {
                        this.items = this.allitems;
                    }
                }
            },
            
            
           
                
            

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