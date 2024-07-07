using System.ComponentModel.DataAnnotations;

namespace BlazorAppFullStack.Models;

public class Patient
{
    public int Id { get; set; }
    [Required]
    public Name Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Street1 { get; set; }
    public string Street2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}
