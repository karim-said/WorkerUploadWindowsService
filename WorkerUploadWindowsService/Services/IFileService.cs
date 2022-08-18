using WorkerUploadWindowsService.Contracts.Models;

namespace WorkerUploadWindowsService.Services
{ 
    public interface IFileService
    {
        FileResponseDto UpdloadFile(FileDto input);
         
    }
}
