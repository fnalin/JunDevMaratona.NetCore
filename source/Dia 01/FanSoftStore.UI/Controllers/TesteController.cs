using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSoftStore.UI.Controllers
{
    public class TesteController:Controller
    {

        public string Server()
        {
            return $"Bateu no TesteController - {DateTime.Now}";
        }

    }
}
