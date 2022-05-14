using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public IActionResult Soma(double valor1, double valor2)
    {
        try
        {
            var calc = new Calculadora();
            var total = calc.Somar(valor1, valor2);
            return Ok(total);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
     
    }

    [HttpGet("Subtrair")]
    public IActionResult Subtracao(double valor1, double valor2)
    {
        try
        {
            var calc = new Calculadora();
            var total = calc.Subtrair(valor1, valor2);
            return Ok(total);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("Dividir")]
    public IActionResult Divisao(double valor1, double valor2)
    {
        try
        {
            var calc = new Calculadora();
            var total = calc.Dividir(valor1, valor2);
            return Ok(total);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet("Multiplicar")]
    public IActionResult Multiplicacao(double valor1, double valor2)
    {
        try
        {
            var calc = new Calculadora();
            var total = calc.Multiplicar(valor1, valor2);
            return Ok(total);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
