#pragma checksum "C:\Users\chris\Desktop\BackgroundSystem\Background_ProFinder\Views\Home\AdminiAccountManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a33c59ea91bbe4e0cc725566033095d3316d44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminiAccountManagement), @"mvc.1.0.view", @"/Views/Home/AdminiAccountManagement.cshtml")]
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
#line 1 "C:\Users\chris\Desktop\BackgroundSystem\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\Desktop\BackgroundSystem\Background_ProFinder\Views\_ViewImports.cshtml"
using Background_ProFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a33c59ea91bbe4e0cc725566033095d3316d44", @"/Views/Home/AdminiAccountManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1042ab2bd1801a3916ccb856993cba548ccba7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminiAccountManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\chris\Desktop\BackgroundSystem\Background_ProFinder\Views\Home\AdminiAccountManagement.cshtml"
  
    ViewData["Title"] = "AdminiAccountManagement";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"account\">\r\n    <div>\r\n        <button class=\"addaccountbtn\" ");
            WriteLiteral(@"@click.prevent=""AddUserModal"">新增帳號</button>
    </div>

    <div class=""cart_area   active tab-pane fade show"" id=""tabs-1"" role=""tabpanel"">
        <div class=""container"">
            <div class=""cart_inner"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">選取</th>
                                <th scope=""col"">管理員帳號</th>
                                <th scope=""col"">管理員Email</th>
                                <th scope=""col"">管理員名稱</th>
                                <th scope=""col"">權限</th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr v-for=""(item,index) in userdataArray"">
                                <td>
                                    <input class=""checkbox paymentcheckbox"" type=""check");
            WriteLiteral("box\" />\r\n                                </td>\r\n                                <td>\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 1283, "\"", 1291, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <p>{{ item.account }}</p>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <p>{{ item.email }}</p>
                                    </div>
                                </td>
                                <td>
                                    <div");
            BeginWriteAttribute("class", " class=\"", 1752, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                        <span class=""count"">{{ item.name }}</span>

                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <p>{{ item.authority }}</p>
                                    </div>
                                </td>
                                <td>

                                    <a class=""mr-2 text-primary"">
                                        <i class=""fas fa-edit""></i>
                                    </a>
                                    <a class=""delete text-danger"">
                                        <i class=""far fa-trash-alt""></i>
                                    </a>

                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

 ");
            WriteLiteral(@"   <!-- Modal -->
    <div class=""modal fade"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-scrollable"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""staticBackdropLabel"">新增管理員帳號</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""confirmProduct"">
                        <div class=""row justify-content-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d449257", async() => {
                WriteLiteral(@"
                                <h5 class=""text-start text-dark pb-2 border-bottom"">
                                    管理員資訊
                                </h5>
                                <div class=""form-group text-start text-dark mb-2"">
                                    <label");
                BeginWriteAttribute("class", " class=\"", 3919, "\"", 3927, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""useraccount "">管理員帳號</label>
                                    <input type=""text"" class=""form-control"" name=""account"" id=""useraccount""
                                           placeholder=""輸入姓名""/> <span class=""text-danger""></span>
                                </div>
                                <div class=""form-group text-start text-dark mb-2"">
                                    <label");
                BeginWriteAttribute("class", " class=\"", 4337, "\"", 4345, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""useremail"">管理員Email</label>
                                    <input type=""email"" class=""form-control"" name=""email"" id=""useremail""
                                           placeholder=""請輸入Email""/> <span class=""text-danger""></span>
                                </div>

                                <div class=""form-group text-start text-dark mb-2"">
                                    <label");
                BeginWriteAttribute("class", " class=\"", 4758, "\"", 4766, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""username "">管理員名稱</label>
                                    <input type=""text"" class=""form-control"" name=""name"" id=""username""
                                           placeholder=""輸入名稱""/> <span class=""text-danger""></span>
                                </div>
                                <div class=""form-group text-start text-dark mb-2"">
                                    <label");
                BeginWriteAttribute("class", " class=\"", 5167, "\"", 5175, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                           for=\"authority\">管理員權限</label>\r\n                                    <select id=\"authority\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d4411887", async() => {
                    WriteLiteral("請選擇管理員權限");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d4412944", async() => {
                    WriteLiteral("全功能");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d4414205", async() => {
                    WriteLiteral("會員管理&訂單管理");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d4415472", async() => {
                    WriteLiteral("首頁管理&總覽");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a33c59ea91bbe4e0cc725566033095d3316d4416737", async() => {
                    WriteLiteral("管理員帳號管理");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""modal-footer d-flex"">
                    <button type=""button"" class=""w-50 btn btn-warning"" >加入</button>
                    <button type=""button"" class=""w-50 btn btn-dark"" data-dismiss=""modal"">關閉</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("TopCSS", async() => {
                WriteLiteral(@" 
<style>

    .addaccountbtn {
        width: 90px;
        height: 40px;
        border-radius: 5px;
        color: white;
        background-color:#5b7dca;
        background-repeat: no-repeat;
        font-weight: bolder;
        margin-bottom: 10px;
        margin-left: 30px;
        font-size: 15px;
        border: 0.5px solid #9e9696;
    }
</style>

");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("endJS", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@9""></script>
    <script src=""https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.js""></script>
    <script>
        let Account = new Vue({
            el: ""#account"",
            data: {
                userdataArray: [],
                modal: {},
            },
            methods: {
                GetUserData() {
                    axios.get('/api/LoginApi/GetUserAccountData')
                        .then(res => {
                            this.userdataArray = res.data.result;
                            console.log(this.userdataArray);
                            console.log('aaaaa');
                        })
                },
                AddUserModal() {
                    $('#staticBackdrop').modal('show')
                }
            },
            created() {
                this.GetUserData();
            }
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