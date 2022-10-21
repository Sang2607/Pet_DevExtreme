//@page
//@using PetProjects_Dev_Extreme.Models

//<h2 class= "content-block" > Home </ h2 >

//@(Html.DevExtreme().DataGrid<Student>()
//    .ElementAttr(new { @class = "dx-card wide-card" })
//    .DataSource(d => d.Mvc().Controller("SampleData").LoadAction("Get").Key("SchedulerID"))
//    .ShowBorders(false)
//    .FilterRow(f => f.Visible(true))
//    .FocusedRowEnabled(true)
//    .FocusedRowIndex(0)
//    .ColumnAutoWidth(true)
//    .ColumnHidingEnabled(true)
//    .Columns(columns =>
//    {
//        columns.AddFor(m => m.SchedulerID);
//        columns.AddFor(m => m.Name);
//        columns.AddFor(m => m.DoB);
//        columns.AddFor(m => m.Address);
//        columns.AddFor(m => m.ClassStudent);
//        columns.AddFor(m => m.Maths);
//        columns.AddFor(m => m.Physical);
//        columns.AddFor(m => m.Chemistry);
//        columns.AddFor(m => m.Medium);

//    })
//    .Paging(p => p.PageSize(3))
//    .Pager(p => p
//        .ShowPageSizeSelector(true)
//        .AllowedPageSizes(new[] { 5, 10, 20 })
//        .ShowInfo(true)
//    )
//        .FilterRow(f => f.Visible(true))
//    .HeaderFilter(f => f.Visible(true))
//    .GroupPanel(p => p.Visible(true))
//    .Grouping(g => g.AutoExpandAll(false))
//    .RemoteOperations(true)

//    .Summary(s => s
//        .TotalItems(totalItems =>
//        {
//            totalItems.AddFor(m => m.SchedulerID).SummaryType(SummaryType.Count);
//        })
//        .GroupItems(groupItems =>
//        {
//            groupItems.Add().SummaryType(SummaryType.Count);
//        })

//    )
//     .ColumnChooser(c => c.Enabled(false))
//    .ColumnFixing(c => c.Enabled(false))

//    .MasterDetail(md => md
//    .Enabled(true)
//    .Template(new TemplateName("DetailEmployee"))
//    )
//     .Editing(editing =>
//    {
//        editing.Mode(GridEditMode.Form);
//        editing.AllowAdding(true);
//        editing.AllowDeleting(true);
//        editing.AllowUpdating(true);
//        //editing.Mode(GridEditMode.Batch);
//    })

//    .Export(e => e.Enabled(true).AllowExportSelectedData(true))
//    .AllowColumnReordering(true)
//    .AllowColumnResizing(true)
//    .Selection(s => s.Mode(SelectionMode.Multiple))
//)
//@using(Html.DevExtreme().NamedTemplate("DetailEmployee"))
//{
//    @(Html.DevExtreme().TabPanel()
//                .Items(items =>
//                {
//                    items.Add()
//                    .Title("Information")
//                    .Template(new TemplateName("TabInfor"))
//                    .Option("masterGridData", new { Id = new JS("data.SchedulerID") });


//                    items.Add()
//                    .Title("Node")
//                    .Template(new TemplateName("TabNode"))
//                    .Option("masterGridData", new JS("data"));


//                })
//                )
//}
//@using(Html.DevExtreme().NamedTemplate("TabInfor"))
//{
//    @(Html.DevExtreme().DataGrid<EmployeeInfor>()
//                .DataSource(d => d.WebApi().Controller("SampleData").LoadAction("TaskDetails")
//                .LoadParams(new
//                {
//                    Id = new JS("masterGridData.Id")
//                }))
//                .ShowBorders(true)
//                .LoadPanel(l => l.Enabled(false))

//                )
//}
//@using(Html.DevExtreme().NamedTemplate("TabNode"))
//{
//< div style = "white-space: pre-wrap;" ><%= masterGridData.Address %></ div >
//}