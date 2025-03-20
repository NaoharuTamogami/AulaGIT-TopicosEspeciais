using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//endpoints - funcionalidades

//Request/Requisição - 
// -URL e MÉTODO HTTP
// -Parâmetro Opcional

// Métodos HTTP
//GET - Pegar alguma informação
//Post - Enviar alguma informação

//GET
app.MapGet("/", () => "Hello World!");

//GET /testaurl
app.MapGet("/testaURL", () => "Primeira API");

//GET: /parametro/param
app.MapGet("/parametro/{param1}",([FromRoute]string param1) => {

    string result = param1 + "" + DateTime.Now;
    return result;

});

app.Run();
