// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mission7DeLange.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\_Imports.razor"
using Mission7DeLange.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\annad\OneDrive\Documents\GitHub\Mission7DeLange\Mission7DeLange\Pages\Admin\Details.razor"
       
    [Inject]
    public IBookRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Book b { get; set; }

    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }
    public string EditUrl => $"/admin/books/edit/{b.BookId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
