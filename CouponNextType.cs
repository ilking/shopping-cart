using System;

namespace ShoppingCart
{
  public class CouponNextType : Coupon
  {
    private ProductType _prodType;
    
    public CouponNextType(int percent, ProductType prodType) : base(percent)
    {
      _prodType = prodType;
    }
    
    public override CouponType Type()
    {
      return CouponType.CouponNextType;
    }
    
    public ProductType ProdType()
    {
      return _prodType;
    }
  }
}