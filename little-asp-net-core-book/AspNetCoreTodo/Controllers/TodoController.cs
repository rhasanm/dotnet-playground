using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{

    public class TodoController : Controller
    {
		private readonly ITodoItemService _todoItemService;

		public TodoController(ITodoItemService todoItemService)
		{
			_todoItemService = todoItemService;
		}

		public async Task<IActionResult> index()
		{
			var items = await _todoItemService.GetIncompleteItemsAsync();

			var model = new TodoViewModel()
			{
				Items = items
			};

			return View(model);
		}
    }
}
