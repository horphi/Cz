using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.TableColumns;
using Volo.Abp.Authorization.Permissions;
using Blazorise;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement.Blazor.Components;
using Volo.Abp.BlazoriseUI;
using System.Threading.Tasks;
using Blazorise.DataGrid;
using Cz.Books;
using System.Linq;
using Volo.Abp.Users;

namespace Cz.Blazor.Client.Pages.Books
{



    public partial class Books
    {
        // Properties for DataGrid
        private int CurrentPage { get; set; }
        private int PageSize { get; } = 50;
        private string CurrentSorting { get; set; }
        private int TotalCount { get; set; }
        private IReadOnlyList<BookDto> BookDtoList { get; set; }
        // End of Properties for DataGrid
        private readonly IBookAppService BookAppService;

        [Inject]
        protected IPermissionChecker PermissionChecker { get; set; }


        public Books(IBookAppService bookAppService)
        {
            BookAppService = bookAppService;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetBooksAsync();

        }

        private async Task GetBooksAsync()
        {
            var result = await BookAppService.GetPagedListAsync(new GetBooksInput
            {
                MaxResultCount = PageSize,
                SkipCount = CurrentPage * PageSize,
                Sorting = CurrentSorting,
                TenantId = CurrentUser.TenantId
            });

            BookDtoList = result.Items;
            TotalCount = (int)result.TotalCount;
        }

        private async Task OnDataGridReadAsync(DataGridReadDataEventArgs<BookDto> e)
        {
            CurrentPage = e.Page - 1;
            CurrentSorting = e.Columns
               .Where(e => e.SortDirection != SortDirection.Default)
               .Select(e => e.Field + (e.SortDirection == SortDirection.Descending ? " DESC" : "")).JoinAsString(",");

            await GetBooksAsync();

        }
    }
}
