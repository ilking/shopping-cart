using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
  public class Cart
  {
    private Queue<CartItem> _items;
    
    public Cart()
    {
      _items = new Queue<CartItem>();
    }
    
    public void AddItem(CartItem item)
    {
      _items.Enqueue(item);
    }
    
    public double TotalPrice()
    {
      List<Product> processedItems = new List<Product>();
      
      while (_items.Count != 0)
      {
        CartItem item = _items.Dequeue();
        
        if (!item.IsCoupon())
        {
          processedItems.Add((Product)item);
        }
        else
        {
          var type = ((Coupon)item).Type();
          switch(type)
          {
            case(CouponType.CouponAll):
              foreach(Product i in processedItems)
              {
                i.ApplyCoupon((Coupon)item);
              }
              
              foreach(CartItem i in _items)
              {
                if(!i.IsCoupon())
                {
                  ((Product)i).ApplyCoupon((Coupon)item);
                }
              }
              break;
              
            case(CouponType.CouponNext):
              foreach (CartItem i in _items)
              {
                if(!i.IsCoupon())
                {
                  ((Product)i).ApplyCoupon((Coupon)item);
                  break;
                }
              }
              break;
              
            case(CouponType.CouponNextType):
              foreach(CartItem i in _items)
              {
                if(!i.IsCoupon() && ((Product)i).ApplyCoupon((Coupon)item))
                {
                  break;
                }
              }
              break;
          }
        }
      }
      
      double totalPrice = processedItems.Sum(x => x.Price);
      
      foreach(Product p in processedItems)
      {
        Console.WriteLine(p.Price);
      }
      return Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero);
    }
  }
}