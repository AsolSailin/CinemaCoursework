using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace CinemaCoursework.Services;

public class FileSystemService
{
    public async Task UploadImageToDbAsync(Stream stream, string fileName)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("CinemaCourseworkDatabase");
        var gridFS = new GridFSBucket(database);

        await gridFS.UploadFromStreamAsync(fileName, stream);
    }

    public void DownloadToLocal(string fileName)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("CinemaCourseworkDatabase");
        var gridFS = new GridFSBucket(database);

        using (FileStream fs =
               new($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/images/")}{fileName}",
                   FileMode.OpenOrCreate))
        {
            gridFS.DownloadToStreamByName(fileName, fs);
        }
    }
}