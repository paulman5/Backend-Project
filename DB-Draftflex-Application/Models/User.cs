namespace DB_Layer1_Draftflex.Data



{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : ITenantEntity 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Sub { get; set; }
        public string Email { get; set; }
        
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        
        public string TenantId { get; set; }
    
    }
}