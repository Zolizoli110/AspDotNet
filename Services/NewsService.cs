using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class NewsService(Context context) : Controller
{
    public async Task<List<NewsModel>> GetAllByDate(DateTimeOffset date)
    {
        return await context.News
            .Where(n => n.Published >= date)
            .ToListAsync();
    }

    public int Add(NewsModel news)
    {
        context.News.Add(news);
        return context.SaveChanges();
    }
}