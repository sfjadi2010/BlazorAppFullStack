using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFullStack.Models;

[ComplexType]
public class Name
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
}
