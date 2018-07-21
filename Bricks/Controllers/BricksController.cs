using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationInsights;
using System.Web.Mvc;
using Bricks.Core;

namespace Bricks.Controllers
{
    [System.Web.Mvc.OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    //[Authorize]
    public class BricksController : Controller
    {
        private TelemetryClient telemetry;
        public BricksController()
        {
            telemetry = new TelemetryClient();
        }
    
        // GET: Bricks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBoard()
        {
            return new JsonResult()
            {

                Data = GameManager.Instance.CurrentBoard,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public ActionResult Tick()
        {
            GameManager.Instance.Presenter.Tick();
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult MoveLeft()
        {
            GameManager.Instance.Presenter.MoveLeft();
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult MoveUp()
        {
            GameManager.Instance.Presenter.Rotate90();
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult MoveRight()
        {
            GameManager.Instance.Presenter.MoveRight();
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult MoveDown()
        {
            GameManager.Instance.Presenter.MoveDown();
            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult InitializeBoard(string shape, string gender)
        {
            GameManager.Instance.InitializeBoard(shape);

            var properties = new Dictionary<string, string>
            {
                {"Shape", shape},{"Gender",gender}
            };

            telemetry.TrackEvent("GameStarted", properties, null);

            return new JsonResult() { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}