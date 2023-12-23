using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Layer1_Draftflex.Data;

public class License
{
    [Key]
    public int Id { get; set; }
    
    public string Version { get; set; }
    
    public string Permissions { get; set;  }
}

