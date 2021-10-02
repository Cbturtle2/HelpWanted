// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HelpWanted.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using HelpWanted.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using HelpWanted.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
using System;

#line default
#line hidden
#nullable disable
    public partial class EditProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Cebrh\Documents\Projects\HelpWanted\Components\EditProject.razor"
      
    string username;
    string projName;
    string projDesc;
    string helpNeeded;

    Guid currentProject;

    void Search()
    {
        MongoDBAccess mongoDBAccess = new MongoDBAccess(MongoDBAccess.databaseName);

        List<Project> projects = mongoDBAccess.GetItems<Project>(MongoDBAccess.databaseName);

        for(int i = 0; i < projects.Count(); i++)
        {
            if(username == projects[i].Name && projName == projects[i].ProjectName)
            {
                projDesc = projects[i].ProjectDescription;
                helpNeeded = projects[i].HelpNeeded;
                currentProject = projects[i].id;
            }
        }
    }

    void Submit()
    {        
        if(username == null || projName == null || projDesc == null || helpNeeded == null)
        {
            return;
        }

        Project editedProj = new Project(username, projName, projDesc, helpNeeded, currentProject);
        MongoDBAccess mongoDBAccess = new MongoDBAccess(MongoDBAccess.databaseName);

        mongoDBAccess.EditItem<Project>(MongoDBAccess.collectionName, currentProject, editedProj);
        
        username = null;
        projName = null;
        projDesc = null;
        helpNeeded = null;
        currentProject = Guid.Empty;
    }

    void Delete()
    {
        if(username == null || projName == null || projDesc == null || helpNeeded == null)
        {
            return;
        }

        Project editedProj = new Project(username, projName, projDesc, helpNeeded, currentProject);
        MongoDBAccess mongoDBAccess = new MongoDBAccess(MongoDBAccess.databaseName);

        mongoDBAccess.RemoveItem<Project>(MongoDBAccess.collectionName, currentProject);
        
        username = null;
        projName = null;
        projDesc = null;
        helpNeeded = null;
        currentProject = Guid.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
