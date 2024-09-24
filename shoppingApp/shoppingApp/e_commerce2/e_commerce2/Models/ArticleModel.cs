using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce2.Models
{
    public class ArticleModel
    {

        public string InsertArticle( ARTICLEE article)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                db.ARTICLEE.Add(article);
                db.SaveChanges();
                return article.AR_Ref + "SuccesFully inserted";
            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }
        public string UpdateArticle(string AR_Ref,ARTICLEE article)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                ARTICLEE A = db.ARTICLEE.Find(AR_Ref);
                A.AR_Design = article.AR_Design;
                A.FA_CodeFamille = article.FA_CodeFamille;
                A.AR_UniteVen = article.AR_UniteVen;
                A.AR_PrixAch = article.AR_PrixAch;
                A.AR_PrixVen = article.AR_PrixVen;
                A.AR_PrixTTC = article.AR_PrixTTC;
                A.AR_Publie = article.AR_Publie;
                A.AR_SuiviStock = article.AR_SuiviStock;
                A.AR_Publie = article.AR_Publie;
                A.AR_Photo = article.AR_Photo;
                db.SaveChanges();
                return article.AR_Ref + "SuccesFully Updating";

            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }
        public string DeleteArticle(string AR_Ref)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                ARTICLEE article = db.ARTICLEE.Find(AR_Ref);
                db.ARTICLEE.Attach(article);
                db.ARTICLEE.Remove(article);
                db.SaveChanges();
                return article.AR_Ref + "SuccesFully Deleting";
            }
            catch (Exception e)
            {

                return "Error" + e;
            }
        }

        public ARTICLEE getArticle(string AR_Ref)
        {
            try
            {
                using( E_Commerce2Entities4 db = new E_Commerce2Entities4())
                {
                    ARTICLEE article = db.ARTICLEE.Find(AR_Ref);
                    return article;
                }
            }
            catch (Exception )
            {
                throw;
                 
            }
        }
        public List<ARTICLEE> GetAllArticle()
        {
            try
            {
                using (E_Commerce2Entities4 db = new E_Commerce2Entities4())
                {
                    List<ARTICLEE> articles = (from x in db.ARTICLEE
                                               select x).ToList();
                    return articles;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public List<ARTICLEE> GetArticleByType(string AR_Ref )
        {
            try
            {
                using (E_Commerce2Entities4 db = new E_Commerce2Entities4())
                {
                    List<ARTICLEE> articles = (from x in db.ARTICLEE
                                               where x.AR_Ref == AR_Ref
                                               select x).ToList();
                    return articles;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}