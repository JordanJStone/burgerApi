using System;
using System.ComponentModel.DataAnnotations;

namespace burgerApi.Models
{
  public class Burger
  {
    public string Name { get; set; }
    [Range(1, 15)]
    public int Patties { get; set; }
    public bool Cheese { get; set; }

    public string Toppings { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();
  }

}