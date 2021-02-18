using System;
using System.Collections.Generic;
using burgerApi.db;
using burgerApi.Models;

namespace burgerApi.Services
{

  public class BurgersService
  {
    // GetAll
    public IEnumerable<Burger> Get()
    {
      return FAKEDB.Burgers;
    }

    // GetById
    public Burger Get(string id)
    {
      Burger burger = FAKEDB.Burgers.Find(b => b.Id == id);
      if (burger == null)
      {
        throw new Exception("invalid Id");
      }
      return burger;
    }

    // Create
    public Burger Create(Burger newBurger)
    {
      FAKEDB.Burgers.Add(newBurger);
      return newBurger;
    }

    // Edit
    public Burger Edit(Burger updated)
    {
      Burger burger = FAKEDB.Burgers.Find(b => b.Id == updated.Id);
      if (burger == null)
      {
        throw new Exception("invalid Id");
      }
      FAKEDB.Burgers.Remove(burger);
      FAKEDB.Burgers.Add(updated);
      return updated;
    }

    // Delete
    public string Delete(string id)
    {
      Burger burger = FAKEDB.Burgers.Find(b => b.Id == id);
      if (burger == null)
      {
        throw new Exception("invalid Id");
      }
      FAKEDB.Burgers.Remove(burger);
      return "Deleted";
    }



  }
}