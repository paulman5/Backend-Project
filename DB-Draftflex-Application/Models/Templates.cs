namespace DB_Layer1_Draftflex.Data;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Templates
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TemplateId { get; set; }
    
    public string DocumentVersion { get; set; }
    
    public string DocumentName { get; set; }
    
    public string Formfields { get; set; }
    
    public string Author { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompanyId { get; set; }
}