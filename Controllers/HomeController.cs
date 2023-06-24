using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTesting.Models;

namespace MVCTesting.Controllers;

public class HomeController : Controller
{
    public int add(int a, int b){
        return a + b;
    }
}
