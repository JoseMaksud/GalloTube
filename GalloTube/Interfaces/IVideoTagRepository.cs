using GalloTube.Models;

namespace GalloTube.Interfaces;

public interface IVideoTagRepository
{
    void Create(int VideoId, int TagId);

    void Delete(int VideoId, int TagId);

    void Delete(int VideoId);

    List<VideoTag> ReadVideoTag();

    List<Video> ReadVideosByTag(int TagId);

    List<Tag> ReadTagsByVideo(int VideoId);
}
