using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class Blog2Controller : Controller
    {
        // GET: Blog2Controller
        public ActionResult Index()
        {
            List<Blog> blog = [
                new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
                 new Blog { Baslik =" Galatasaray" ,Ozet =" GS", GorselUrl="https://r.resimlink.com/M37Sh8.png?v=3593c4691a2ccfff41bb5d6a4e3e79fd"},
             ];

            return View(blog);
        }

    }
}
