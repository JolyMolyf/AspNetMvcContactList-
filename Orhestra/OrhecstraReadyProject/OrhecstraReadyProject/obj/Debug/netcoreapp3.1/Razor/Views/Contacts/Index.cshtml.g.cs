#pragma checksum "C:\Users\Joly\source\repos\OrhecstraReadyProject\OrhecstraReadyProject\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ded5a992b617df1ee60c337802de12210f94ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
#line 1 "C:\Users\Joly\source\repos\OrhecstraReadyProject\OrhecstraReadyProject\Views\_ViewImports.cshtml"
using OrhecstraReadyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joly\source\repos\OrhecstraReadyProject\OrhecstraReadyProject\Views\_ViewImports.cshtml"
using OrhecstraReadyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ded5a992b617df1ee60c337802de12210f94ea", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb9d73d4184c683447fb4ac2c5894cfa3f7ca9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrhecstraReadyProject.Data.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contacts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/contactJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Contacts</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Joly\source\repos\OrhecstraReadyProject\OrhecstraReadyProject\Views\Contacts\Index.cshtml"
  
    string[] Headers = new string[] {
        "ID",
        "Name",
        "Date of Birth",
        "Married",
        "Phone",
        "salary"

    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>File upload</h4>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ded5a992b617df1ee60c337802de12210f94ea6039", async() => {
                WriteLiteral("\r\n        <input type=\"file\" name=\"contactFile\" />\r\n        <button type=\"submit\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"order-table-wrapper\">\r\n        <input id=\"IndexColSort\" placeholder=\"Write index of col to sort by\" />\r\n        <input id =\"sortBtn\" type=\"button\"  value=\"Sort\"/>\r\n\r\n        <p id=\"showData\"></p>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ded5a992b617df1ee60c337802de12210f94ea8329", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ded5a992b617df1ee60c337802de12210f94ea9368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\r\n\r\n\r\n    var column; \r\n\r\n\r\n\r\n\r\n\r\n var json = ");
#nullable restore
#line 61 "C:\Users\Joly\source\repos\OrhecstraReadyProject\OrhecstraReadyProject\Views\Contacts\Index.cshtml"
       Write(ViewBag.arr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    console.log(json);
    var rows = [];
    function fillTable(json) {
        sorted = [];
        var col = [];
        for (var i = 0; i < json.length; i++) {
            for (var key in json[i]) {
                if (col.indexOf(key) === -1) {
                    col.push(key);
                }
            }
        }

        var table = document.createElement(""table"");

        var tr = table.insertRow(-1);

        for (var i = 0; i < col.length; i++) {
            var th = document.createElement(""th"");      // TABLE HEADER.
            th.innerHTML = col[i];
            tr.appendChild(th);
        }

       

        for (var i = 0; i < json.length; i++) {

            tr = table.insertRow(-1);
            var arr = [];
            for (var j = 0; j < col.length; j++) {

                var tabCell = tr.insertCell(-1);
                tabCell.innerHTML = json[i][col[j]];
                rows.push(json[i][col[j]]);

            }


        }

        // F");
            WriteLiteral(@"INALLY ADD THE NEWLY CREATED TABLE WITH JSON DATA TO A CONTAINER.
        var divContainer = document.getElementById(""showData"");
        divContainer.innerHTML = """";
        divContainer.appendChild(table);
    
    }

    fillTable(json);


    var sorted = []
    function sortData(column) {
   
       



       
        console.log(rows + "" initial sorted"");
        for (var i = 0; i < rows.length; i += 6) {


          

            console.log(rows[i + 1]);
            var con =  {
              
                     id: rows[i],
                     firstName: rows[i + 1],
                     dataofbirth: rows[i + 2],
                     married: rows[i + 3],
                     phone: rows[i + 4], 
                     salary: rows[i + 5], 
                
            };
 


            console.log(con)
            sorted.push(con); 

        }
        

        console.log(sorted);
        console.log(sorted[0].firstName + "" user name"");
        conso");
            WriteLiteral(@"le.log(sorted[0].salary + "" user name"");



     

        if (column == 0) {

            sorted.sort(compareById)

        }
        if (column == 1) {

            sorted.sort(compareByName);

        }
        if (column == 2) {
            sorted.sort(compareByDataofBirth);
        }
        if (column == 3) {
            sorted.sort(compareByMarried);
           
        }
        if (column == 4) {
            sorted.sort(compareByPhone);
       
        }
        if (column == 5) {
            sorted.sort(compareBySalary);
        }




        console.log(""--------"");
        console.log(sorted[0].firstName + "" user name"");
        console.log(sorted[0].salary + "" user name"");

    
        rows = [];
    }


    function  compareByName(a, b) {

        if (a.firstName > b.firstName) {
            console.log(a + "" from compare"");
            return 1;
        } else if (a.firstName == b.firstName) {
           
            console.log(""the are equal""");
            WriteLiteral(@");
            return 0;
        } else {

         
            console.log(b + "" from compare"");
            return -1;
        }

    }

    function compareById(a, b) {

        if (a.id > b.id) {
            console.log(a + "" from compare"");
            return 1;
        } else if (a.id == b.id) {

            console.log(""the are equal"");
            return 0;
        } else {


            console.log(b + "" from compare"");
            return -1;
        }

    }
    function compareByDataofBirth(a, b) {

        if (a.dataofbirth > b.dataofbirth) {
            console.log(a + "" from compare"");
            return 1;
        } else if (a.dataofbirth == b.dataofbirth) {

            console.log(""the are equal"");
            return 0;
        } else {


            console.log(b + "" from compare"");
            return -1;
        }

    }
    function compareBySalary(a, b) {

        if (a.salary > b.salary) {
            console.log(a + "" from compare"");
   ");
            WriteLiteral(@"         return 1;
        } else if (a.salary == b.salary) {

            console.log(""the are equal"");
            return 0;
        } else {


            console.log(b + "" from compare"");
            return -1;
        }

    }
    function compareByPhone(a, b) {

        if (a.phone > b.phone) {
            console.log(a + "" from compare"");
            return 1;
        } else if (a.phone == b.phone) {

            console.log(""the are equal"");
            return 0;
        } else {


            console.log(b + "" from compare"");
            return -1;
        }

    }

    $('#sortBtn').click(function () {
       
        $('#IndexColSort').val(function (index, value) {
         
            sortData(value);
            fillTable(sorted);
     
           
     
           
        });

    })


 
   

  
  

</script>









");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrhecstraReadyProject.Data.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591