#pragma checksum "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8734d13b5ddb5f0e0300fcbe914f17e5a249e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\_ViewImports.cshtml"
using housecleaningmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\_ViewImports.cshtml"
using housecleaningmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8734d13b5ddb5f0e0300fcbe914f17e5a249e28", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b96f5d7c01727ba9c13267526d519c80eb4d439", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<housecleaningApi.Models.UserTbl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Adduser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8734d13b5ddb5f0e0300fcbe914f17e5a249e283696", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfLivingRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfKitchens));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfBedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfWorshipRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoOfStoreRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LivingRoomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KitchenSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BedroomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BathroomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorshipSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreRoomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PreferredDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 88 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(ViewData["costpersqft"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequestNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfLivingRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfKitchens));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfBedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfWorshipRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoOfStoreRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LivingRoomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KitchenSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BedroomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BathroomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorshipSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StoreRoomSqft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PreferredDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 164 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 165 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 168 "C:\Users\Merit\source\repos\housecleaning\housecleaningmvc\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<housecleaningApi.Models.UserTbl>> Html { get; private set; }
    }
}
#pragma warning restore 1591