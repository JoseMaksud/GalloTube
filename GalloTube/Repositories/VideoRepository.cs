using System.Data;
using GalloTube.Interfaces;
using GalloTube.Models;
using MySql.Data.MySqlClient;

namespace GalloTube.Repositories;

public class VideoRepository : IVideoRepository
{
    readonly string connectionString = "server=localhost;port=3306;database=GalloTubedb;uid=root;pwd=''";

    public void Create(Video model)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "insert into Movie(Name, Description, UploadDate, Duration, Thumbnail, VideoFile) "
              + "values (@Name, @Description, @UploadDate, @Duration, @Thumbnail, @VideoFile)";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Name", model.Name);
        command.Parameters.AddWithValue("@Description", model.Description);
        command.Parameters.AddWithValue("@UploadDate", model.UploadDate);
        command.Parameters.AddWithValue("@Duration", model.Duration);
        command.Parameters.AddWithValue("@Thumbnail", model.Thumbnail);
        command.Parameters.AddWithValue("@VideoFile", model.VideoFile);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void Delete(int? id)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "delete from Video where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<Video> ReadAll()
    {
        MySqlConnection connection = new(connectionString);
        string sql = "select * from Video";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        
        List<Video> videos = new();
        connection.Open();
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Video video = new()
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name"),
                Description = reader.GetString("description"),
                UploadDate = reader.GetDateTime("uploadDate"),
                Duration = reader.GetInt16("duration"),
                Thumbnail = reader.GetString("thumbnail"),
                VideoFile = reader.GetString("videoFile")
            };
            videos.Add(video);
        }
        connection.Close();
        return videos;
    }

    public Video ReadById(int? id)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "select * from Video where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Id", id);
        
        connection.Open();
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            Video video = new()
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name"),
                Description = reader.GetString("description"),
                UploadDate = reader.GetDateTime("uploadDate"),
                Duration = reader.GetInt16("duration"),
                Thumbnail = reader.GetString("thumbnail"),
                VideoFile = reader.GetString("videoFile")
            };
            connection.Close();
            return video;
        }
        connection.Close();
        return null;
    }

    public void Update(Video model)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "update Video set "
                        + "Name = @Name, "
                        + "Description = @Description, "
                        + "UploadDate = @UploadDate, "
                        + "Duration = @Duration, "
                        + "Thumbnail = @Thumbnail, "
                        + "VideoFile = @VideoFile "
                    + "where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Name", model.Name);
        command.Parameters.AddWithValue("@Description", model.Description);
        command.Parameters.AddWithValue("@UploadDate", model.UploadDate);
        command.Parameters.AddWithValue("@Duration", model.Duration);
        command.Parameters.AddWithValue("@Thumbnail", model.Thumbnail);
        command.Parameters.AddWithValue("@VideoFile", model.VideoFile);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
