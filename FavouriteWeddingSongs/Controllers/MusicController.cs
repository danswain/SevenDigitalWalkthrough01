using System.Web.Mvc;
using SevenDigital.Api.Schema.TrackEndpoint;
using SevenDigital.Api.Wrapper;

namespace FavouriteWeddingSongs.Controllers
{
    public class MusicController : Controller
    {
        //
        // GET: /Music/

        public ActionResult Index()
        {			
            return View();
        }

		[AcceptVerbs(HttpVerbs.Get)] 
		public ActionResult SearchResults(string q)
		{
			var results = Api<TrackSearch>
				.Create
				.WithQuery(q)
				.WithParameter("imageSize", "200")
				.Please();

			return View(results);
		}

    }
}
