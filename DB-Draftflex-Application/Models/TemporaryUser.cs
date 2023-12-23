using System.ComponentModel.DataAnnotations;

namespace DB_Layer1_Draftflex.Data;

public class TemporaryUser
{
    [Key]
    public string sub { get; set; }
    
    public string Email { get; set; }
}