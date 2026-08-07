using Microsoft.AspNetCore.Mvc;
using TaskFlow.API.Models;

namespace TaskFlow.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private static readonly List<TaskItem> Tasks =
    [
        new TaskItem { Id = 1, Title = "Learn C#", IsComplete = true },
        new TaskItem { Id = 2, Title = "Build a TaskFlow API", IsComplete = false },
        new TaskItem { Id = 3, Title = "Start at New Job", DueDate = new DateTime(2026, 9, 7)}

    ];

    [HttpGet]
    public ActionResult<IEnumerable<TaskItem>> GetAll()
    {
        return Ok(Tasks);
    }

}

