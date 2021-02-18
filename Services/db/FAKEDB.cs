using System.Collections.Generic;
using burgerApi.Models;

namespace burgerApi.db
{

  public static class FAKEDB
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>();
  }
}