using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get(){
        return new string[]{"value1","value2"};
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id){
        return "value";
    }

    [HttpPost]
    public void Post([FromBody] string value){

    }

    [HttpPut("{id}")]
    public void Put(int id,[FromBody] string value){
        
    }



}
