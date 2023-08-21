using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }


    [Required]
    [StringLength(8000)]
    public string Description { get; set; }

    [Required]
    public Int16 Duration { get; set; }

    [Required]
    public DateTime UploadDate { get; set; }

    [StringLength(200)]
    public string Thumbnail { get; set; }

    [StringLength(200)]
    public string VideoFile { get; set; }

    [NotMapped]
    public List<Tag> Tags { get; set; }
}
