﻿using MiniServer.HTTP;

namespace IRunes.App.Controllers
{
    public class HomeController : BaseController
    {

        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}
