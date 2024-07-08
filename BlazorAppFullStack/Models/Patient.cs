using System.ComponentModel.DataAnnotations;

namespace BlazorAppFullStack.Models;

public class Patient
{
    public Patient()
    {
        Name = new();
        Address = new();
    }

    public int Id { get; set; }
    [Required]
    public Name Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Address Address { get; set; }
}
