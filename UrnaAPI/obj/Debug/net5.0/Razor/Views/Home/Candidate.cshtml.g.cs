#pragma checksum "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1548dec139848bd13cb44f721c36caf913d74b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Candidate), @"mvc.1.0.view", @"/Views/Home/Candidate.cshtml")]
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
#line 1 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\_ViewImports.cshtml"
using UrnaAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\_ViewImports.cshtml"
using UrnaAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1548dec139848bd13cb44f721c36caf913d74b3f", @"/Views/Home/Candidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4ef810e8faad348f546a88299cda27e3fc37d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Candidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UrnaAPI.Models.Candidate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/modal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ticketSpan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
  
    ViewData["Title"] = "Cadastro e Listagem de Candidatos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1548dec139848bd13cb44f721c36caf913d74b3f5546", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<h4>\r\n    Cadastrar candidato\r\n</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f6786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 16 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f8437", async() => {
                WriteLiteral("Nome do Candidato");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 18 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().CandidateName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <input id=\"candidateName\" oninput=\"checkEmptiness(this.id)\" class=\"form-control\" />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f10140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 20 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().CandidateName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f11813", async() => {
                WriteLiteral("Nome do Vice");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 23 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().ViceName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <input id=\"viceName\" oninput=\"checkEmptiness(this.id)\" class=\"form-control\" />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f13502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 25 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().ViceName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f15170", async() => {
                WriteLiteral("Legenda");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 28 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Ticket);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <input id=\"ticket\" max=\"99\" min=\"1\" oninput=\"checkTicketLength()\" onkeydown=\"checkEmptiness(this.id)\" type=\"number\" class=\"form-control\" />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1548dec139848bd13cb44f721c36caf913d74b3f16921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 30 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Ticket);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Cadastrar Candidato"" onclick=""CreateCandidate()"" class=""btn btn-primary"" />
        </div>
    </div>
</div>
<hr />
<h4>
    Candidatos
</h4>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nome do Candidato
            </th>
            <th>
                Legenda
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 54 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
               Write(Html.DisplayFor(modelItem => item.CandidateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ticket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"submit\" value=\"Deletar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2311, "\"", 2355, 3);
            WriteAttributeValue("", 2321, "DeleteCandidate(", 2321, 16, true);
#nullable restore
#line 64 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
WriteAttributeValue("", 2337, item.CandidateId, 2337, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2354, ")", 2354, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Pichau\source\repos\TUrnaAPI\UrnaAPI\Views\Home\Candidate.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""myModal"" class=""modal"">

    <div class=""modal-content"">
        <span class=""close"">⟳</span>
        <p id=""modalMessage"">Sucesso.</p>
    </div>

</div>

<script>
    const urlCandidate = 'https://localhost:44362/api/Candidates';


    function checkTicketLength() {
        var length = document.getElementById(""ticket"").value.length
        if (length > 2) {
            var resultValue = document.getElementById(""ticket"").value.slice(0, 2);
            document.getElementById(""ticket"").value = resultValue;
        }
    }

    function checkEmptiness(id) {
        var length = document.getElementById(id).value.length
        console.log(length)
        if (length < 1) {
            document.getElementById(id).style.borderColor = 'red'
        }
        else {
            document.getElementById(id).style.borderColor = ''
        }
    }

    function CreateCandidate() {

        const item = {
            candidateName: document.getElement");
            WriteLiteral(@"ById(""candidateName"").value,
            viceName: document.getElementById(""viceName"").value,
            registryDate: GetTodayDate(),
            ticket: document.getElementById(""ticket"").value
        };

        fetch(urlCandidate, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(item)
        }).then(function (response) {
            console.log(response.status);
            if (!response.ok) {
                modal.style.display = ""block""
                modalMessage.innerText = ""Inválido, Verifique os campos.""
                throw new Error(""HTTP status "" + response.status);
            }
            modalMessage.innerText = ""Sucesso.""
            modal.style.display = ""block""
        })
            .catch (error => console.error('Não foi possível cadastrar o candidato.', error));
    }

    function DeleteCandidate(id) {

    ");
            WriteLiteral(@"    fetch(`${urlCandidate}/${id}`, {
            method: 'DELETE'
        })
            .catch(error => console.error('Unable to delete item.', error));
    }

    function GetTodayDate() {
        var today = new Date();
        var dd = String(today.getDate()).padStart(2, '0');
        var mm = String(today.getMonth() + 1).padStart(2, '0');
        var yyyy = today.getFullYear();

        return today = yyyy + '-' + mm + '-' + dd;
    }

    var modal = document.getElementById(""myModal"");

    var modalMessage = document.getElementById(""modalMessage"");

    var span = document.getElementsByClassName(""close"")[0];

    span.onclick = function () {
        modal.style.display = ""none"";
        window.location.reload(true)
    }

    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = ""none"";
            window.location.reload(true)
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UrnaAPI.Models.Candidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
