using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFullStack.Models;

[ComplexType]
public class Address
{
    public required string Street1 { get; set; }
    public string street2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
}
