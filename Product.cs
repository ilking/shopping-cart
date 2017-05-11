using System;

namespace ShoppingCart
{
  public class Product : CartItem
  {
    private double _price;
    private ProductType _type;
    
    public double Price
    {
      get
      {
        return _price;
      }
    }
    
    public ProductType Type() { 
      return _type;
    }
    
    public Product(double price, ProductType type)
    {
      _price = price;
      _type = type;
    }
    
    private void _deductPrice(int percent)
    {
      double res = _price - (_price * (percent/100.00));
      
      _price = Math.Round(res, 2, MidpointRounding.AwayFromZero);
    }
    
    public bool ApplyCoupon(Coupon coupon) {
      Console.Write("Current Price is ${0}. Reducing price by {1}%...", _price, coupon.PercentOff);
      
      if (coupon.Type() == CouponType.CouponNextType)
      {
        var coup = (CouponNextType) coupon;
        if (coup.ProdType() != _type)
        {
          Console.WriteLine("Does Not Apply");
          return false;
        }
      }
      
      this._deductPrice(coupon.PercentOff);
      Console.WriteLine("New price is ${0}.", _price);
      return true;
    }
    
    public bool IsCoupon()
    {
      return false;
    }
  }
}