//Jeremy Lapham
//10-27-22
//Reverse It - Endpoint
//This program will take whatever the user has in the url and reverse it 
//Peer Review: Christopher Prado 27OCT22 : I could not break the code and it worked properly. I even entered 3 letters and it reversed the letters. The code is also very refined. 
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
