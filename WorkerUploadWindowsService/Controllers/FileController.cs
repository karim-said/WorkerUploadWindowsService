using Microsoft.AspNetCore.Mvc;
using WorkerUploadWindowsService.Contracts.Models;
using WorkerUploadWindowsService.Services;

namespace WorkerUploadWindowsService.Controllers;

[Route("api/file")]
public class FileController : Controller
{
    private readonly ILogger<FileController> _logger;
    private readonly IFileService _fileService;

    public FileController(ILogger<FileController> logger, IFileService fileService)
    {
        _logger = logger;
        _fileService = fileService;
    }

    [HttpGet]
    public IActionResult Get()
    { 
        return Ok("Was connected to the service successfully");
    }

    [HttpPost]
    public IActionResult UploadFile([FromBody] FileDto request)
    {
        var file = _fileService.UpdloadFile(request);
        return Ok();
    }
     
}