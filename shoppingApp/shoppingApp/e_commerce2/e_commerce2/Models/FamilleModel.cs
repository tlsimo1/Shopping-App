using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce2.Models
{
    public class FamilleModel
    {
        public string InsertArticle(FAMILLE famille)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                db.FAMILLE.Add(famille);
                db.SaveChanges();
                return famille.FA_CodeFamille + "SuccesFully inserted";
            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }
        public string UpdateArticle(string FA_CodeFamille, FAMILLE famille)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                FAMILLE F = db.FAMILLE.Find(FA_CodeFamille);
                F.FA_Type = famille.FA_Type;
                F.FA_Intitule = famille.FA_Intitule;
                F.FA_UniteVen = famille.FA_UniteVen;
                F.FA_Coef = famille.FA_Coef;
                F.FA_SuiviStock = famille.FA_SuiviStock;
                F.FA_Garantie = famille.FA_Garantie;
                F.FA_CodeFiscal = famille.FA_CodeFiscal;
                F.FA_UnitePoids = famille.FA_UnitePoids;
                F.FA_Publie = famille.FA_Publie;
               
                db.SaveChanges();
                return famille.FA_CodeFamille + "SuccesFully Updating";

            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }
        public string DeleteArticle(string FA_CodeFamille)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                FAMILLE famille = db.FAMILLE.Find(FA_CodeFamille);
                db.FAMILLE.Attach(famille);
                db.FAMILLE.Remove(famille);
                db.SaveChanges();
                return famille.FA_CodeFamille + "SuccesFully Deleting";
            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }
    }
}