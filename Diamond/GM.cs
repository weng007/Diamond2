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
        static UserBiz bizUser;
        static SellerBiz bizSeller;
        static BuyBookDiamondCerBiz bizBuyBookDiamondCer;
        static BuyBookDiamondBiz bizBuyBookDiamond;
        static BuyBookGemstoneBiz bizBuyBookGemstone;
        static BuyBookGemstoneCerBiz bizBuyBookGemstoneCer;
        static BuyBookGoldBiz bizBuyBookGold;
        static BuyBookJewelryBiz bizBuyBookJewelry;
        static BuyBookETCBiz bizBuyBookETC;
        static DiamondCerBiz bizDiamondCer;
        static DiamondDetailBiz bizDiamondDetail;
        static GemstoneCerBiz bizGemstoneCer;
        static GemstoneDetailBiz bizGemstoneDetail;
        static CustomerBiz bizCustomer;
        static SellBiz bizSell;
        static CatalogBiz bizCatalog;
        static BBJewelryGemstoneDetailBiz bizBBJewelryGemstoneDetail;
        static BBJewelryDiamondDetailBiz bizBBJewelryDiamondDetail;
        static BBJewelryDiamondCerDetailBiz bizBBJewelryDiamondCerDetail;
        static BBJewelryGemstoneCerDetailBiz bizBBJewelryGemstoneCerDetail;
        static InventoryBiz bizInventory;
        static InvDiamondDetailBiz bizInvDiamondDetail;
        static BuyBookSettingBiz bizBuyBookSetting;
        static BuyBookSettingDetailBiz bizBuyBookSettingDetail;
        static InvDiamondCerDetailBiz bizInvDiamondCerDetai;
        static InvGemstoneCerDetailBiz bizInvGemstoneCerDetai;
        static InvGemstoneDetailBiz bizInvGemstoneDetai;

        public static MasterTableDetailBiz GetMasterTableDetailBiz()
        {
            if (bizMasterTableDetail == null) { return new MasterTableDetailBiz(); }
            else { return bizMasterTableDetail; }
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

        public static BuyBookGoldBiz GetBuyBookGoldBiz()
        {
            if (bizBuyBookGold == null) { return new BuyBookGoldBiz(); }
            else { return bizBuyBookGold; }
        }

        public static BuyBookSettingDetailBiz GetBuyBookSettingDetailBiz()
        {
            if (bizBuyBookSettingDetail == null) { return new BuyBookSettingDetailBiz(); }
            else { return bizBuyBookSettingDetail; }
        }

        public static DiamondCerBiz GetDiamondBiz()
        {
            if (bizDiamondCer == null) { return new DiamondCerBiz(); }
            else { return bizDiamondCer; }
        }

        public static DiamondDetailBiz GetDiamondDetailBiz()
        {
            if (bizDiamondDetail == null) { return new DiamondDetailBiz(); }
            else { return bizDiamondDetail; }
        }

        public static GemstoneCerBiz GetGemstoneCerBiz()
        {
            if (bizGemstoneCer == null) { return new GemstoneCerBiz(); }
            else { return bizGemstoneCer; }
        }
       
        public static GemstoneDetailBiz GetGemstoneDetailBiz()
        {
            if (bizGemstoneDetail == null) { return new GemstoneDetailBiz(); }
            else { return bizGemstoneDetail; }
        }

        public static CustomerBiz GetCustomerBiz()
        {
            if (bizCustomer == null) { return new CustomerBiz(); }
            else { return bizCustomer; }
      
        }

        public static SellBiz SellBiz()
        {
            if (bizSell == null) { return new SellBiz(); }
            else { return bizSell; }
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
        public static BBJewelryGemstoneCerDetailBiz BBJewelryGemstoneCerDetailBiz()
        {
            if (bizBBJewelryGemstoneCerDetail == null)
            { return new BBJewelryGemstoneCerDetailBiz(); }
            else { return bizBBJewelryGemstoneCerDetail; }
        }
        public static BBJewelryDiamondCerDetailBiz BBJewelryDiamondCerDetailBiz()
        {
            if (bizBBJewelryDiamondCerDetail == null)
            { return new BBJewelryDiamondCerDetailBiz(); }
            else { return bizBBJewelryDiamondCerDetail; }
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
        public static InvDiamondCerDetailBiz InvDiamondCerDetailBiz()
        {
            if (bizInvDiamondCerDetai == null)
            { return new InvDiamondCerDetailBiz(); }
            else { return bizInvDiamondCerDetai; }
        }
        public static InvGemstoneCerDetailBiz InvGemstoneCerDetailBiz()
        {
            if (bizInvGemstoneCerDetai == null)
            { return new InvGemstoneCerDetailBiz(); }
            else { return bizInvGemstoneCerDetai; }
        }
        public static InvGemstoneDetailBiz InvGemstoneDetailBiz()
        {
            if (bizInvGemstoneDetai == null)
            { return new InvGemstoneDetailBiz(); }
            else { return bizInvGemstoneDetai; }
        }

        private static BBDiamondStockBiz bbDiamondStockBiz;
        public static BBDiamondStockBiz GetBBDiamondStockBiz()
        {
            if (bbDiamondStockBiz == null)
            { return new BBDiamondStockBiz(); }
            else { return bbDiamondStockBiz; }
        }

        private static BBGemstoneStockBiz bbGemstoneStockBiz;
        public static BBGemstoneStockBiz GetBBGemstoneStockBiz()
        {
            if (bbGemstoneStockBiz == null)
            { return new BBGemstoneStockBiz(); }
            else { return bbGemstoneStockBiz; }
        }
    }
}
