using Microsoft.AspNetCore.Mvc;

[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public string Get()
    {

    }
    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {

    }
    [HttpPut]
    [Route("")]
    public string Put()
    {

    }
    [HttpPost]
    [Route("")]
    public string Post()
    {

    }
    [HttpDelete]
    [Route("")]
    public string Delete()
    {

    }

}