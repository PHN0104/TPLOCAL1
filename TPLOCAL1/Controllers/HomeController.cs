using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//L'énoncé du tp et le logo hn sont livrés dans le répertoire /ressources de la solution
//--------------------------------------------------------------------------------------
//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //reste à faire : coder la lecture du fichier xml fourni
                        return View(id);
                    case "Formulaire":
                        //reste à faire : appeler la vue Formulaire avec le modèle de données vide
                        return View(id);
                    case "Validation":
                        return View(id);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }


        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        public ActionResult ValidationFormulaire(FormulaireModel FormulaireModel)
        {
            string Nom = FormulaireModel.Nom;
            string Prenom = FormulaireModel.Prenom;
            string Sexe = FormulaireModel.Sexe;
            string Adresse = FormulaireModel.Adresse;
            int Code_postal = FormulaireModel.Code_postal;
            string Ville = FormulaireModel.Ville;
            string Adresse_mail = FormulaireModel.Adresse_mail;
            DateTime Date = FormulaireModel.Date;
            string Formation = FormulaireModel.Formation;
            string Avis1 = FormulaireModel.Avis1;
            string Avis2 = FormulaireModel.Avis2;

            return View();

        }
    }
}
