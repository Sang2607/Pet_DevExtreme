#pragma checksum "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99acf5f1e18114af97f0d7116a78079740097ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PetProjects_Dev_Extreme.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PetProjects_Dev_Extreme.Pages
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
#line 1 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\_ViewImports.cshtml"
using PetProjects_Dev_Extreme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
using PetProjects_Dev_Extreme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99acf5f1e18114af97f0d7116a78079740097ea8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f10f12c1e8fbf40f83dd099b4fdc0195743704", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class= \"content-block\" > Home </ h2 >\r\n\r\n");
#nullable restore
#line 6 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<Student>()
    .ElementAttr(new { @class = "dx-card wide-card" })
    .DataSource(d => d.Mvc()
    .Controller("Students")
    .LoadAction("Get")
    .InsertAction("Insert")
    .UpdateAction("Update")
    .DeleteAction("Delete")
    .Key("SchedulerID"))


    .ShowBorders(false)
    .FilterRow(f => f.Visible(true))
    .FocusedRowEnabled(true)
    .FocusedRowIndex(0)
    .ColumnAutoWidth(true)
    .ColumnHidingEnabled(true)
    .Columns(columns =>
    {
        columns.AddFor(m => m.SchedulerID);
        columns.AddFor(m => m.Name);
        columns.AddFor(m => m.DoB);
        columns.AddFor(m => m.Address);
        columns.AddFor(m => m.ClassStudent);
        columns.AddFor(m => m.Maths);
        columns.AddFor(m => m.Physical);
        columns.AddFor(m => m.Chemistry);
        columns.AddFor(m => m.Medium);

    })
    .Paging(p => p.PageSize(3))
    .Pager(p => p
        .ShowPageSizeSelector(true)
        .AllowedPageSizes(new[] { 5, 10, 20 })
        .ShowInfo(true)
    )
        .FilterRow(f => f.Visible(true))
    .HeaderFilter(f => f.Visible(true))
    .GroupPanel(p => p.Visible(true))
    .Grouping(g => g.AutoExpandAll(false))
    .RemoteOperations(true)

    .Summary(s => s
        .TotalItems(totalItems =>
        {
            totalItems.AddFor(m => m.SchedulerID).SummaryType(SummaryType.Count);
        })
        .GroupItems(groupItems =>
        {
            groupItems.Add().SummaryType(SummaryType.Count);
        })

    )
     .ColumnChooser(c => c.Enabled(false))
    .ColumnFixing(c => c.Enabled(false))

    .MasterDetail(md => md
    .Enabled(true)
    .Template(new TemplateName("DetailEmployee"))
    )
     .Editing(editing =>
    {
        editing.Mode(GridEditMode.Form);
        editing.AllowAdding(true);
        editing.AllowDeleting(true);
        editing.AllowUpdating(true);
        //editing.Mode(GridEditMode.Batch);
    })

    .Export(e => e.Enabled(true).AllowExportSelectedData(true))
    .AllowColumnReordering(true)
    .AllowColumnResizing(true)
    .Selection(s => s.Mode(SelectionMode.Multiple))
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
 using(Html.DevExtreme().NamedTemplate("DetailEmployee"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
Write(Html.DevExtreme().TabPanel()
                .Items(items =>
                {
                    items.Add()
                    .Title("Information")
                    .Template(new TemplateName("TabInfor"))
                    .Option("masterGridData", new { Id = new JS("data.SchedulerID") });


                    items.Add()
                    .Title("Node")
                    .Template(new TemplateName("TabNode"))
                    .Option("masterGridData", new JS("data"));


                })
                );

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
                 
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
 using(Html.DevExtreme().NamedTemplate("TabInfor"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<EmployeeInfor>()
                .DataSource(d => d.WebApi().Controller("SampleData").LoadAction("TaskDetails")
                .LoadParams(new
                {
                    Id = new JS("masterGridData.Id")
                }))
                .ShowBorders(true)
                .LoadPanel(l => l.Enabled(false))

                );

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
                 
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
 using(Html.DevExtreme().NamedTemplate("TabNode"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p><%= masterGridData.Address %></p>\r\n");
#nullable restore
#line 116 "C:\Users\sangt\source\repos\PetProjects_Dev_Extreme\PetProjects_Dev_Extreme\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
