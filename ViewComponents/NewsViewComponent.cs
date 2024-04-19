using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.ViewComponents;

public class NewsViewComponent(NewsService newsService) : ViewComponents
{
    private List<NewsModel> _newsList;

    private async Task GetAllNews()
    {
        _newsList = await newsService.GetAllByDate(DateTime.UtcNow.AddDays(-7));
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        await GetAllNews();
        return View(_newsList);
    }
}