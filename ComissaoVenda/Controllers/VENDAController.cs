using ComissaoVenda.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ComissaoVenda.Controllers
{
    public class VENDAController : Controller
    {
        private ComissaoVendaContext db = new ComissaoVendaContext();

        // GET: VENDA
        public ActionResult Index()
        {
            var vND002_VENDA = db.VND002_VENDA.Include(v => v.VEI004_MODELO_VERSAO).Include(v => v.VND001_VENDEDOR);
            return View(vND002_VENDA.ToList());           
        }

        // GET: Venda/RelatorioComissao
        public ActionResult RelatorioComissao()
        {
            var result = db
               .Database
               .SqlQuery<RELATORIO>("dbo.ListarComissoesVendedores")
               .ToList();
                        
            return View(result);
        }

        // GET: VENDA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VND002_VENDA vND002_VENDA = db.VND002_VENDA.Find(id);
            if (vND002_VENDA == null)
            {
                return HttpNotFound();
            }
            return View(vND002_VENDA);
        }

        // GET: VENDA/Create
        public ActionResult Create()
        {
            ViewBag.IdeModeloVersao = new SelectList(db.VEI004_MODELO_VERSAO, "IdeModeloVersao", "IdeModeloVersao");
            ViewBag.IdeVendedor = new SelectList(db.VND001_VENDEDOR, "IdeVendedor", "NmeVendedor");
            return View();
        }

        // POST: VENDA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdeVenda,IdeVendedor,IdeModeloVersao,VlrPrecoVenda,StaValeCombustivel")] VND002_VENDA vND002_VENDA)
        {
            if (ModelState.IsValid)
            {
                db.VND002_VENDA.Add(vND002_VENDA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdeModeloVersao = new SelectList(db.VEI004_MODELO_VERSAO, "IdeModeloVersao", "IdeModeloVersao", vND002_VENDA.IdeModeloVersao);
            ViewBag.IdeVendedor = new SelectList(db.VND001_VENDEDOR, "IdeVendedor", "NmeVendedor", vND002_VENDA.IdeVendedor);
            return View(vND002_VENDA);
        }

        // GET: VENDA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VND002_VENDA vND002_VENDA = db.VND002_VENDA.Find(id);
            if (vND002_VENDA == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdeModeloVersao = new SelectList(db.VEI004_MODELO_VERSAO, "IdeModeloVersao", "IdeModeloVersao", vND002_VENDA.IdeModeloVersao);
            ViewBag.IdeVendedor = new SelectList(db.VND001_VENDEDOR, "IdeVendedor", "NmeVendedor", vND002_VENDA.IdeVendedor);
            return View(vND002_VENDA);
        }

        // POST: VENDA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdeVenda,IdeVendedor,IdeModeloVersao,VlrPrecoVenda,StaValeCombustivel")] VND002_VENDA vND002_VENDA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vND002_VENDA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdeModeloVersao = new SelectList(db.VEI004_MODELO_VERSAO, "IdeModeloVersao", "IdeModeloVersao", vND002_VENDA.IdeModeloVersao);
            ViewBag.IdeVendedor = new SelectList(db.VND001_VENDEDOR, "IdeVendedor", "NmeVendedor", vND002_VENDA.IdeVendedor);
            return View(vND002_VENDA);
        }

        // GET: VENDA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VND002_VENDA vND002_VENDA = db.VND002_VENDA.Find(id);
            if (vND002_VENDA == null)
            {
                return HttpNotFound();
            }
            return View(vND002_VENDA);
        }

        // POST: VENDA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VND002_VENDA vND002_VENDA = db.VND002_VENDA.Find(id);
            db.VND002_VENDA.Remove(vND002_VENDA);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
