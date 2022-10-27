//Jeremy Lapham
//10-27-22
//Reverse It - Endpoint
//This program will take whatever the user has in the url and reverse it 
//Peer Review: 
using Microsoft.AspNetCore.Mvc;

namespace LaphamJReverseIt_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("ReverseIt/{numOrString}")]

    public string ReverseIt(string numOrString)
    {
        string text = "";
        for (int i = numOrString.Length - 1; i >= 0; i--)
        {
            text = text + numOrString[i];
        }
        return $"Your Word/Number: {numOrString} \n The Reverse: {text}";
    }

}
