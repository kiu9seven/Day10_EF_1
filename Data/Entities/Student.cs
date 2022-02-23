using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace  Day10.Data.Entities;

[Table("Student")]

public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required, MaxLength(50)]
    public string? FisrtName {get;set;}

    [Required, MaxLength(50)]
    public string? LastName {get;set;}

    [MaxLength(20)]
    public string? City {get;set;}

    [NotMapped]
    public string? State {get;set;}

    // public virtual Group Group {get;set;} 

}