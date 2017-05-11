using System;

namespace ShoppingCart
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Cart cart = new Cart();
      cart.AddItem(new Product(12.99, ProductType.BusinessCard));
      cart.AddItem(new Product(12.99, ProductType.BusinessCard));
      cart.AddItem(new Product(12.99, ProductType.BusinessCard));
      cart.AddItem(new CouponAll(25));
      cart.AddItem(new Product(24.99, ProductType.TShirt));
      cart.AddItem(new CouponNext(10));
      cart.AddItem(new CouponNextType(15,ProductType.BackPack));
      cart.AddItem(new Product(24.99, ProductType.TShirt));
      cart.AddItem(new Product(34.99, ProductType.BackPack));
      
      Console.WriteLine("TotalPrice: ${0}", cart.TotalPrice());
    }
  }
}