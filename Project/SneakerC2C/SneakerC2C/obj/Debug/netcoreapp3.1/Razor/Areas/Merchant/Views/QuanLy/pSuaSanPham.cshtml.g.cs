#pragma checksum "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6f2c0ff0a510721471075c60245dcbee25d019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Merchant_Views_QuanLy_pSuaSanPham), @"mvc.1.0.view", @"/Areas/Merchant/Views/QuanLy/pSuaSanPham.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6f2c0ff0a510721471075c60245dcbee25d019", @"/Areas/Merchant/Views/QuanLy/pSuaSanPham.cshtml")]
    public class Areas_Merchant_Views_QuanLy_pSuaSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Database.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px; height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Mã sản phẩm</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-ma\" name=\"item_sua_ma\"");
            BeginWriteAttribute("value", " value=\"", 169, "\"", 193, 1);
#line 4 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 177, Model.MaSanPham, 177, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Tên sản phẩm</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-tensp\" name=\"item_sua_tensp\"");
            BeginWriteAttribute("value", " value=\"", 358, "\"", 383, 1);
#line 8 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 366, Model.TenSanPham, 366, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Màu</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"item-sua-mau\" name=\"item_sua_mau\"");
            BeginWriteAttribute("value", " value=\"", 535, "\"", 553, 1);
#line 12 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 543, Model.Mau, 543, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Hãng sản phẩm</label>\r\n    <select class=\"form-control\" id=\"item-sua-hang\" name=\"item_sua_hang\">\r\n");
#line 17 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
         foreach (var item in ViewBag.HangSanPham)
        {

#line default
#line hidden
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 782, "\"", 798, 1);
#line 19 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 790, item.Id, 790, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 19 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
                                Write(item.TenHang);

#line default
#line hidden
            WriteLiteral("</option>\r\n");
#line 20 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
        }

#line default
#line hidden
            WriteLiteral(@"    </select>
</div>
<div class=""form-group"">
    <label>Phân loại</label>
    <select class=""form-control"" id=""item-sua-phanloai"" name=""item_sua_phanloai"">
        <option value=""Nam"">Nam</option>
        <option value=""Nữ"">Nữ</option>
    </select>
</div>
<div class=""form-group"">
    <label>Giá</label>
    <input type=""text"" class=""form-control"" id=""item-sua-gia"" name=""item_sua_gia""");
            BeginWriteAttribute("value", " value=\"", 1233, "\"", 1251, 1);
#line 32 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1241, Model.Gia, 1241, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Hinh</label>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb6f2c0ff0a510721471075c60245dcbee25d0197091", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1349, "~/Hinh/SanPham/", 1349, 15, true);
#line 36 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
AddHtmlAttributeValue("", 1364, Model.Hinh, 1364, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <input type=""file"" class=""form-control"" id=""item-sua-hinh"" name=""item_sua_hinh"" accept=""image/x-png,image/gif,image/jpeg"" multiple />
</div>
<div class=""form-group"">
    <label>Chi tiết</label>
    <input type=""text"" class=""form-control"" id=""item-sua-chitiet"" name=""item_sua_chitiet""");
            BeginWriteAttribute("value", " value=\"", 1707, "\"", 1729, 1);
#line 41 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1715, Model.ChiTiet, 1715, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Giảm giá</label>\r\n    <input type=\"number\" class=\"form-control\" id=\"item-sua-giamgia\" name=\"item_sua_giamgia\"");
            BeginWriteAttribute("value", " value=\"", 1887, "\"", 1909, 1);
#line 45 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 1895, Model.GiamGia, 1895, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Size</label>\r\n    <select class=\"form-control\" id=\"item-sua-size\" name=\"item_sua_size\">\r\n        <option value=\"không\" selected>Không</option>\r\n");
#line 51 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
         foreach(var item in ViewBag.ListSizeSanPham)
        {

#line default
#line hidden
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 2187, "\"", 2203, 1);
#line 53 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
WriteAttributeValue("", 2195, item.Id, 2195, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 53 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
                                Write(item.Size);

#line default
#line hidden
            WriteLiteral("</option>\r\n");
#line 54 "C:\Users\kysui\OneDrive\Desktop\TMDT\Project\SneakerC2C\SneakerC2C\Areas\Merchant\Views\QuanLy\pSuaSanPham.cshtml"
        }

#line default
#line hidden
            WriteLiteral(@"    </select>
</div>
<div class=""form-group"">
    <label>Số lượng</label>
    <input type=""number"" class=""form-control"" id=""item-sua-soluong"" name=""item_sua_soluong"" value=""0"" readonly>
</div>
<script>
    function validateNumber(e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
            // Allow: Ctrl/cmd+A
            (e.keyCode == 65 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: Ctrl/cmd+C
            (e.keyCode == 67 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: Ctrl/cmd+X
            (e.keyCode == 88 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: home, end, left, right
            (e.keyCode >= 35 && e.keyCode <= 39)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)");
            WriteLiteral(@") && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    };
</script>
<script>
     $(""#item-sua-gia"").keydown(validateNumber);
    $(""#item-sua-giamgia"").change(function(){
     if($(this).val() < 0)
          $(this).val(0);
     if($(this).val() > 100)
          $(this).val(100);
});
    $(""#item-sua-size"").change(function(){
        let id = $(this).val();
        if (id == ""không"")
        {
            $(""#item-sua-soluong"").attr('readonly', true);
        }
        else
        {
            $(""#item-sua-soluong"").attr('readonly', false);

            $.ajax({
            url: ""/Merchant/QuanLy/GetQuantity"",
            type: ""post"",
            data: { ""id"": id },
            success: function (data) {
                $(""#item-sua-soluong"").val(data);
            },
            error: function (data) {
                alert(""Error: "" + data);
            }
        });
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Database.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
