#pragma checksum "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26439be0e8b0bdca93bfafa8c11513d062ae914c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_QuanLy_pSize), @"mvc.1.0.view", @"/Areas/Merchant/Views/QuanLy/pSize.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Merchant/Views/QuanLy/pSize.cshtml", typeof(AspNetCore.Areas_Merchant_Views_QuanLy_pSize))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26439be0e8b0bdca93bfafa8c11513d062ae914c", @"/Areas/Merchant/Views/QuanLy/pSize.cshtml")]
    public class Areas_Merchant_Views_QuanLy_pSize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.SizeSanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 224, true);
            WriteLiteral("\r\n\r\n<table table table-striped table-bordered table-hover>\r\n    <thead>\r\n        <tr>\r\n            <th>Tên sản phẩm</th>\r\n            <th>Size</th>\r\n            <th>Số lượng</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 14 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(322, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(353, 35, false);
#line 17 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml"
           Write(item.IdSanPhamNavigation.TenSanPham);

#line default
#line hidden
            EndContext();
            BeginContext(388, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(412, 9, false);
#line 18 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml"
           Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(421, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(445, 12, false);
#line 19 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml"
           Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(457, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSize.cshtml"
        }

#line default
#line hidden
            BeginContext(490, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.SizeSanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
