using System;

namespace ShoppingCart
{
  public abstract class Coupon : CartItem
  {
    public int PercentOff { get; private set; }
    
    public Coupon(int percent)
    {
      PercentOff = percent;
    }
    
    public bool IsCoupon()
    {
      return true;
    }
    
    public abstract CouponType Type();
    
  }
}