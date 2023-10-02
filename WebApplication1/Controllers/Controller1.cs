using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers;

public class Controller1 : Controller
{
    public IActionResult Register(string username)
    {
        var rmodel = new RegisterModel()
        {
            Username = username
        };

        var user = JsonConvert.SerializeObject(rmodel);
        return Content(user);
    }
    
    public IActionResult Notify(int bankCode, int bankTransactionNumber, int bankBranchCode, int prn)
    {
        var nmodel = new NotifyModel()
        {
            BankCode = bankCode,
            BankTransactionNumber = bankTransactionNumber,
            BankBranchCode = bankBranchCode,
            Prn = prn
        };

        var input = JsonConvert.SerializeObject(nmodel);
        return Content(input);
    }
}