#pragma checksum "C:\Users\Mehar Shahbaz\Desktop\New folder\eSoftLogix\Task_111\Views\Home\ChartAccountsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace22e546b4c1b7883bd92edc8ee86e074be2cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChartAccountsList), @"mvc.1.0.view", @"/Views/Home/ChartAccountsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChartAccountsList.cshtml", typeof(AspNetCore.Views_Home_ChartAccountsList))]
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
#line 1 "C:\Users\Mehar Shahbaz\Desktop\New folder\eSoftLogix\Task_111\Views\_ViewImports.cshtml"
using Task_111;

#line default
#line hidden
#line 2 "C:\Users\Mehar Shahbaz\Desktop\New folder\eSoftLogix\Task_111\Views\_ViewImports.cshtml"
using Task_111.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace22e546b4c1b7883bd92edc8ee86e074be2cd0", @"/Views/Home/ChartAccountsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f73c5b23d3569e1497dc477e6f9114c7ee21c20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChartAccountsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Tree/themes/default/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Tree/jstree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Mehar Shahbaz\Desktop\New folder\eSoftLogix\Task_111\Views\Home\ChartAccountsList.cshtml"
  
    ViewData["Title"] = "ChartAccountsList";

#line default
#line hidden
            DefineSection("css", async() => {
                BeginContext(66, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(72, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ace22e546b4c1b7883bd92edc8ee86e074be2cd05354", async() => {
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
                BeginContext(130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(136, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ace22e546b4c1b7883bd92edc8ee86e074be2cd06686", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(200, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(205, 257, true);
            WriteLiteral(@"
<h4><span style=""font-size:20px;color:cornflowerblue""><strong style=""font-size:28px;"">M</strong>aintain</span><small> >> </small> General Ladger <small>>></small>  Chart of Account</h4>
<br />
<hr />

<!-- Tree show here-->
<div id=""tree-contaner"">
");
            EndContext();
            BeginContext(499, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(573, 1076, true);
            WriteLiteral(@"
<!-- Modal Start here ... -->
<div class=""modal inmodal"" id=""myModal4"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content animated fadeIn"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span><span class=""sr-only"">Close</span></button>
            </div>
            <div class=""modal-body"" id=""Model-Body"">

            </div>

        </div>
    </div>
</div>
<!-- add chaild model here -->
<div class=""modal inmodal"" id=""chaildmodel"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content animated fadeIn"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span><span class=""sr-only"">Close</span></button>
            </div>
            <div class=""modal-body"" id=""chidbody"">
      ");
            WriteLiteral("      </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1666, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1672, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ace22e546b4c1b7883bd92edc8ee86e074be2cd09976", async() => {
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
                BeginContext(1719, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1725, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ace22e546b4c1b7883bd92edc8ee86e074be2cd011231", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1765, 7290, true);
                WriteLiteral(@">
    <script type=""text/javascript"">
        $(document).ready(function () {

            Showtree();
            
            

          //  Showtree();
           

        })
        // for Creating childe     
       

        var childSubling = function (id) {
            $.ajax({
                method: ""GET"",
                url: ""/ChartOfAccount/AddChartAccount/"" + id
            }).done(function (result) {
                $(""#chidbody"").html(result)
                $(""#chaildmodel"").modal();
            });
        }
        var Chartofchild = function (id) {
            $.ajax({
                method: ""GET"",
                url: ""/ChartOfAccount/AddControlAccount/"" + id

            }).done(function (result) {
                $(""#chidbody"").html(result)
                $(""#chaildmodel"").modal();
            });
        }

        var UpdateAccount = function (id) {

            $.ajax({
                method: ""GET"",
                url: ""/ChartOfAccount/Upd");
                WriteLiteral(@"ateControlAccount/"" + id

            }).done(function (result) {
                $(""#chidbody"").html(result)
                $(""#chaildmodel"").modal();
            });
        }

        var EditChartAccount = function (id) {

            $.ajax({
                method: ""GET"",
                url: ""/ChartOfAccount/UpdateChartAccount/"" + id

            }).done(function (result) {
                $(""#chidbody"").html(result)
                $(""#chaildmodel"").modal();
            });
        }

        var ControlSubling = function (id) {

            $.ajax({
                method: ""GET"",
                url: ""/ChartOfAccount/AddControl/"" + id

            }).done(function (result) {
                $(""#chidbody"").html(result)
                $(""#chaildmodel"").modal();
            });
        }
        var DeleteControlAccount = function (id) {
            $.ajax({

                method: ""Delete"",
                url: ""/ChartOfAccount/DeleteParentNode/"" + id,
           ");
                WriteLiteral(@"     success: function (res) {
                    
                    swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Deleted Successfully',
                        showConfirmButton: false,
                        timer: 1500                      
                    });
                   // $('#tree').jstree(true).redraw(true);
                    $('#tree').jstree(true).refresh();
                  

                },
                error: function (err) {
                    alert(err);
                }
            })
        }  

      
        var Showtree = function ()
        {
            $.ajax({
                
                url: ""/ChartOfAccount/Showtree"",
                type:""Get"",
                success: function (res)
                {
                    $(""#tree-contaner"").html(res)
                   tree()
                   // $('#tree').jstree(""destroy"").empty();

 ");
                WriteLiteral(@"                   $('#tree').on(""changed.jstree"", function (e, data, ) {
                        var id = data.node.id;
                        var c_Id;
                        //Remove the ParentId.
                        if (data.node.id.indexOf('-') != -1) {
                            var c = data.node.id.match(/-/g).length
                            c_Id = data.node.id.split(""-"")[c];
                            id = data.node.id.split(""-"")[c - 1];
                            $(""#myModal4"").modal();
                            $(""#Model-Body"").html(
                                `<div class=""row"">
                                                    <div ></div>
                                                    <button class=""col-lg-4 btn btn-success"" type=""button"" onclick=""childSubling(${id})"" >Add</button>
                                                    <button class=""col-lg-4 btn btn-primary"" data-dismiss=""modal""type=""button"" disabled>Add Child</button>
                        ");
                WriteLiteral(@"                            <button class=""col-lg-4 btn btn-info"" type=""button"" data-dismiss=""modal"" onclick=""EditChartAccount(${c_Id})"">Edit</button>
                                                </div>
                                                   <br/>
                                                 <div class=""row"">
                                                    <div ></div>
                                                    <a class="" col-lg-4 btn btn-danger"" href=""/ChartOfAccount/DeleteNode/${c_Id}"" role=""button"">Delete</a>
                                                   <!-- <button class=""col-lg-4 btn btn-danger"" type=""button""> <a href=""/ChartOfAccount/DeleteNode/${c_Id}"">Delete</a></button>-->
                                                    <button class=""col-lg-4 btn btn-warning"" type=""button"" data-dismiss=""modal"">Cancle</button>
                                                </div>`
                            );
                        }
                        els");
                WriteLiteral(@"e {

                            $(""#myModal4"").modal();
                            $(""#Model-Body"").html(
                                `<div class=""row"">
                                                    <div ></div>
                                                    <button class=""col-lg-4 btn btn-success"" type=""button"" data-dismiss=""modal"" onclick=""ControlSubling(${id})"">Add</button>
                                                    <button class=""col-lg-4 btn btn-primary"" data-dismiss=""modal""type=""button"" onclick=""Chartofchild(${id})"">Add Child</button>
                                                    <button class=""col-lg-4 btn btn-info"" type=""button"" data-dismiss=""modal"" onclick=""UpdateAccount(${id})"" >Edit</button>
                                                </div>
                                                   <br/>
                                                 <div class=""row"">
                                                    <div ></div>
                       ");
                WriteLiteral(@"                             <a class="" col-lg-4 btn btn-danger"" href=""return:false"" data-dismiss=""modal"" onclick=""DeleteControlAccount(${id})"" role=""button"">Delete</a>
                                                    <button class=""col-lg-4 btn btn-warning"" type=""button"" data-dismiss=""modal"">Cancle</button>
                                                </div>`
                            );
                        }
                    });   
                   // var aa = $('#tree').jstree(true).refresh_node(""id"")
                  //  alert(aa)
                    
                }

            })
        }
        var tree = function () {
            $(""#tree"").jstree({
                'core': {
                    ""themes"": {
                        ""variant"": ""large""
                    },
                    'data': {
                        'url': '/ChartOfAccount/tree/',
                        'data': function (node) {
                            return { 'id': node.id };");
                WriteLiteral("\r\n                        }\r\n                    }\r\n                },\r\n            }); \r\n\r\n        }\r\n    </script>\r\n\r\n\r\n");
                EndContext();
            }
            );
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
