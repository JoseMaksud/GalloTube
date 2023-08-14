using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }


    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "Data")]
    [Display(Name = "Data")]
    [Required(ErrorMessage = "A Data é obrigatória")]
    public DateTime UploadDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [StringLength(200)]
    [Display(Name = "Thumbnail")]
    public string Thumbnail { get; set; }

    [StringLength(200)]
    [Display(Name = "VideoFile")]
    public string VideoFile { get; set; }
    

    [NotMapped]
    [Display(Name = "Duração")]
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration) .ToString(@"%h'h 'mm'min'");
    }}

    public ICollection<VideoTag> Tags { get; set; }
}
