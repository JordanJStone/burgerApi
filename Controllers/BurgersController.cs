using System;
using System.Collections.Generic;
using burgerApi.Models;
using burgerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgerApi
{
  [ApiController]
  [Route("api/[controller]")]

  public class BurgersController : ControllerBase
  {

    private readonly BurgersService _ds;

    public BurgersController(BurgersService ds)
    {
      _ds = ds;
    }

    [HttpGet]
    public ActionResult<IEnumerable<BurgersController>> GetAction()
    {
      try
      {
        return Ok(_ds.Get());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Burger> Get(string id)
    {
      try
      {
        Burger burger = _ds.Get(id);
        return Ok(burger);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        Burger burger = _ds.Create(newBurger);
        return Ok(burger);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Burger> Edit([FromBody] Burger updated, string id)
    {
      try
      {
        updated.Id = id;
        Burger burger = _ds.Edit(updated);
        return Ok(burger);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _ds.Delete(id);
        return Ok("Deleted");
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }



  }
}