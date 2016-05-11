using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DiamondDS.DS;
using DiamondBiz.Biz;

namespace Diamond
{
    public static class GM
    {
        //Biz
        static MasterTableDetailBiz bizMasterTableDetail;
        static PriceCodeBiz bizPriceCode;
        static UserBiz bizUser;
        static SellerBiz bizSeller;
        static BuyBookDiamondCerBiz bizBuyBookDiamondCer;
        static BuyBookDiamondBiz bizBuyBookDiamond;
        static BuyBookGemstoneBiz bizBuyBookGemstone;
        static BuyBookGemstoneCerBiz bizBuyBookGemstoneCer;
        static BuyBookGoldBiz bizBuyBookGold;
        static BuyBookSpecialBiz bizBuyBookSpecial;
        static BuyBookJewelryBiz bizBuyBookJewelry;
        static BuyBookETCBiz bizBuyBookETC;
        static BuyBookSettingDetailBiz bizBuyBookSettingDetail;
        static ProductBiz bizProduct;
        static DiamondCerBiz bizDiamondCer;
        static DiamondDetailBiz bizDiamondDetail;
        static GemstoneCerBiz bizGemstoneCer;
        static GemstoneDetailBiz bizGemstoneDetail;
        static CustomerBiz bizCustomer;
        static SellBiz bizSell;
        static CatalogBiz bizCatalog;
        static BBJewelryGemstoneDetailBiz bizBBJewelryGemstoneDetail;
        static BBJewelryDiamondDetailBiz bizBBJewelryDiamondDetail;
        static InventoryBiz bizInventory;
        static InvDiamondDetailBiz bizInvDiamondDetail;
        static BuyBookSettingBiz bizBuyBookSetting;

        //DS
        static dsPriceCode priceCodeDS;
        //static dsUser userDS;
        //static dsSeller sellerDS;
        //static dsBuyBookDiamondCer BuyBookDiamondCerDS;
        //static dsBuyBookJewelry BuyBookJewelryDS;
        //static dsBuyBookETC BuyBookETCDS;
        //static dsBuyBookDiamond BuyBookDiamondDS;
        static dsBuyBookGemstone BuyBookGemstoneDS;
        static dsBuyBookGold BuyBookGoldDS;
        static dsBuyBookSpecial BuyBookSpecialDS;
        static dsProduct ProductDS;
        static dsDiamondCer DiamondCerDS;
        static dsDiamondDetail DiamondDetailDS;
        static dsGemstoneCer GemstoneCerDS;
        static dsGemstoneDetail GemstoneDetailDS;
        static dsCustomer CustomerDS;
        static dsSell SellDS;

        public static MasterTableDetailBiz GetMasterTableDetailBiz()
        {
            if (bizMasterTableDetail == null) { return new MasterTableDetailBiz(); }
            else { return bizMasterTableDetail; }
        }
        public static PriceCodeBiz GetPriceCodeBiz()
        {
            if (bizPriceCode == null) { return new PriceCodeBiz(); }
            else { return bizPriceCode; }
        }
        public static dsPriceCode GetDSPriceCode()
        {
            if (priceCodeDS == null) { return new dsPriceCode(); }
            else { return priceCodeDS; }
        }

        public static UserBiz GetUserBiz()
        {
            if (bizUser == null) { return new UserBiz(); }
            else { return bizUser; }
        }
        public static SellerBiz GetSellerBiz()
        {
            if (bizSeller == null) { return new SellerBiz(); }
            else { return bizSeller; }
        }
        public static BuyBookDiamondCerBiz GetBuyBookDiamondCerBiz()
        {
            if (bizBuyBookDiamondCer == null) { return new BuyBookDiamondCerBiz(); }
            else { return bizBuyBookDiamondCer; }
        }
        public static BuyBookJewelryBiz GetBuyBookJewelryBiz()
        {
            if (bizBuyBookJewelry == null) { return new BuyBookJewelryBiz(); }
            else { return bizBuyBookJewelry; }
        }
        public static BuyBookETCBiz GetBuyBookETCBiz()
        {
            if (bizBuyBookETC == null) { return new BuyBookETCBiz(); }
            else { return bizBuyBookETC; }
        }
        public static BuyBookDiamondBiz GetBuyBookDiamondBiz()
        {
            if (bizBuyBookDiamond == null) { return new BuyBookDiamondBiz(); }
            else { return bizBuyBookDiamond; }
        }
        public static BuyBookGemstoneBiz GetBuyBookGemstoneBiz()
        {
            if (bizBuyBookGemstone == null) { return new BuyBookGemstoneBiz(); }
            else { return bizBuyBookGemstone; }
        }
        public static BuyBookGemstoneCerBiz GetBuyBookGemstoneCerBiz()
        {
            if (bizBuyBookGemstoneCer == null) { return new BuyBookGemstoneCerBiz(); }
            else { return bizBuyBookGemstoneCer; }
        }
        public static dsBuyBookGemstone GetDSBuyBookGemstone()
        {
            if (BuyBookGemstoneDS == null) { return new dsBuyBookGemstone(); }
            else { return BuyBookGemstoneDS; }
        }
        public static BuyBookGoldBiz GetBuyBookGoldBiz()
        {
            if (bizBuyBookGold == null) { return new BuyBookGoldBiz(); }
            else { return bizBuyBookGold; }
        }
        public static dsBuyBookGold GetDSBuyBookGold()
        {
            if (BuyBookGoldDS == null) { return new dsBuyBookGold(); }
            else { return BuyBookGoldDS; }
        }
        public static BuyBookSettingDetailBiz GetBuyBookSettingDetailBiz()
        {
            if (bizBuyBookSettingDetail == null) { return new BuyBookSettingDetailBiz(); }
            else { return bizBuyBookSettingDetail; }
        }
        public static BuyBookSpecialBiz GetBuyBookSpecialBiz()
        {
            if (bizBuyBookSpecial == null) { return new BuyBookSpecialBiz(); }
            else { return bizBuyBookSpecial; }
        }
        public static dsBuyBookSpecial GetDSBuyBookSpecial()
        {
            if (BuyBookSpecialDS == null) { return new dsBuyBookSpecial(); }
            else { return BuyBookSpecialDS; }
        }

        public static ProductBiz GetProductBiz()
        {
            if (bizProduct == null) { return new ProductBiz(); }
            else { return bizProduct; }
        }
        public static dsProduct GetDSProduct()
        {
            if (ProductDS == null) { return new dsProduct(); }
            else { return ProductDS; }
        }
        public static DiamondCerBiz GetDiamondBiz()
        {
            if (bizDiamondCer == null) { return new DiamondCerBiz(); }
            else { return bizDiamondCer; }
        }
        public static dsDiamondCer GetDSDiamondCer()
        {
            if (DiamondCerDS == null) { return new dsDiamondCer(); }
            else { return DiamondCerDS; }
        }

        public static DiamondDetailBiz GetDiamondDetailBiz()
        {
            if (bizDiamondDetail == null) { return new DiamondDetailBiz(); }
            else { return bizDiamondDetail; }
        }
        public static dsDiamondDetail GetDSDiamondDetail()
        {
            if (DiamondDetailDS == null) { return new dsDiamondDetail(); }
            else { return DiamondDetailDS; }
        }

        public static GemstoneCerBiz GetGemstoneCerBiz()
        {
            if (bizGemstoneCer == null) { return new GemstoneCerBiz(); }
            else { return bizGemstoneCer; }
        }
       
        public static dsGemstoneCer GetDSGemstoneCer()
        {
            if (GemstoneCerDS == null) { return new dsGemstoneCer(); }
            else { return GemstoneCerDS; }
        }
        public static GemstoneDetailBiz GetGemstoneDetailBiz()
        {
            if (bizGemstoneDetail == null) { return new GemstoneDetailBiz(); }
            else { return bizGemstoneDetail; }
        }
        public static dsGemstoneDetail GetDSGemstoneDetail()
        {
            if (GemstoneDetailDS == null) { return new dsGemstoneDetail(); }
            else { return GemstoneDetailDS; }
        }

        public static CustomerBiz GetCustomerBiz()
        {
            if (bizCustomer == null) { return new CustomerBiz(); }
            else { return bizCustomer; }
        }
        public static dsCustomer GetDSCustomer()
        {
            if (CustomerDS == null) { return new dsCustomer(); }
            else { return CustomerDS; }
        }

        public static SellBiz SellBiz()
        {
            if (bizSell == null) { return new SellBiz(); }
            else { return bizSell; }
        }
        public static dsSell GetDSSell()
        {
            if (SellDS == null) { return new dsSell(); }
            else { return SellDS; }
        }
        public static CatalogBiz CatalogBiz()
        {
            if (bizCatalog == null) { return new CatalogBiz(); }
            else { return bizCatalog; }
        }
        public static BBJewelryGemstoneDetailBiz BBJewelryGemstoneDetailBiz()
        {
            if (bizBBJewelryGemstoneDetail == null)
            { return new BBJewelryGemstoneDetailBiz(); }
            else { return bizBBJewelryGemstoneDetail; }
        }
        public static BBJewelryDiamondDetailBiz BBJewelryDiamondDetailBiz()
        {
            if (bizBBJewelryDiamondDetail == null)
            { return new BBJewelryDiamondDetailBiz(); }
            else { return bizBBJewelryDiamondDetail; }
        }
        public static InventoryBiz InventoryBiz()
        {
            if (bizInventory == null)
            { return new InventoryBiz(); }
            else { return bizInventory; }
        }
        public static InvDiamondDetailBiz InvDiamondDetailBiz()
        {
            if (bizInvDiamondDetail == null)
            { return new InvDiamondDetailBiz(); }
            else { return bizInvDiamondDetail; }
        }
        public static BuyBookSettingBiz BuyBookSettingBiz()
        {
            if (bizBuyBookSetting == null)
            { return new BuyBookSettingBiz(); }
            else { return bizBuyBookSetting; }
        }
    }
}
