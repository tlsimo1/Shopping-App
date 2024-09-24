using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce2.Models
{
    public class CartModel
    {
        public string InsertCart(cart Cart)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                db.cart.Add(Cart);
                db.SaveChanges();

                return "Order was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateCart(int id, cart cart)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();

                //Fetch object from db
                cart p = db.cart.Find(id);

                p.DatePurchased = cart.DatePurchased;
                p.ClientID = cart.ClientID;
                p.Amount = cart.Amount;
                p.IsInCart = cart.IsInCart;
                p.ArticleRef = cart.ArticleRef;

                db.SaveChanges();
                return cart.DatePurchased + " was succesfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteCart(int id)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                cart cart = db.cart.Find(id);

                db.cart.Attach(cart);
                db.cart.Remove(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was succesfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public List<cart> GetOrdersInCart(string userId)
        {
            E_Commerce2Entities4 db = new E_Commerce2Entities4();
            List<cart> orders = (from x in db.cart
                                 where x.ClientID == userId 
                                 //&& x.IsInCart
                                 orderby x.DatePurchased 
                                 select x).ToList();
            return orders;
        }

        public int GetAmountOfOrders(string userId)
        {
            try
            {
                E_Commerce2Entities4 db = new E_Commerce2Entities4();
                int amount = (from x in db.cart
                              where x.ClientID == userId
                             //&& x.IsInCart
                              select x.Amount).Sum();

                return amount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            E_Commerce2Entities4 db = new E_Commerce2Entities4();
           
            cart p = db.cart.Find(id);
            p.Amount = quantity;
            
            db.SaveChanges();
        }

        public void MarkOrdersAsPaid(List<cart> carts)
        {
            E_Commerce2Entities4 db = new E_Commerce2Entities4();

            if (carts != null)
            {
                foreach (cart cart in carts)
                {
                    cart oldCart = db.cart.Find(cart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;
                }
                db.SaveChanges();
            }
        }





    
    }
}