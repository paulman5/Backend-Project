using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_Layer1_Draftflex.Data;

public class Unique_Document
{
    [Key]
    public int DocumentId { get; set; }
    
    public int TemplateId { get; set; }
    
    public string Author { get; set; }
    
    public DateTime Renewal_Date_Reminder { get; set; }
    
    public DateTime Payment_Date_Reminder { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
    public DateTime SignatureDate { get; set; }
}








