using GalloTube.Models;
namespace GalloTube.Interfaces;

public interface IVideoRepository : IRepository<Video>
{
    List<Video> ReadAllDetailed();

    Video ReadByIdDetailed(int id);
}