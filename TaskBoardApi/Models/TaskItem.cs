using System.ComponentModel.DataAnnotations;

namespace TaskBoardApi.Models;
public class TaskItem {
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

}