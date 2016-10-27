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
        //static SellerBiz bizSeller;
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
        static ExchangeRateBiz bizExchangeRate;
        static BuyBookPaymentBiz bizBuyBookPayment;
        static WarningBiz bizWarning;
        static TransferBiz bizTransfer;
        static TransferDetailBiz bizTransferDetail;
        static TransferBuyBookBiz bizTransferBuyBook;
        static TransferInventoryBiz bizTransferInventory;
        static OrderBiz bizOrder;
        static OrderDetailBiz bizOrderDetail;
        static WarningTransferBiz bizWarningTransfer;
        static ProductionLineBiz bizProductionLine;
        static SellBookBiz bizSellBook;
        static SellBookDetailBiz bizSellBookDetail;
        static ExpenseGroupBiz bizExpenseGroup;
        static ExpenseBiz bizExpense;
        static ReceiveDocumentBiz bizReceiveDocument;

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
        //public static SellerBiz GetSellerBiz()
        //{
        //    if (bizSeller == null) { return new SellerBiz(); }
        //    else { return bizSeller; }
        //}
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

        public static DiamondCerBiz GetDiamondCerBiz()
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
        public static ExchangeRateBiz GetExchangeRateBiz()
        {
            if (bizExchangeRate == null)
            { return new ExchangeRateBiz(); }
            else { return bizExchangeRate; }
        }
        public static BuyBookPaymentBiz GetBuyBookPaymentBiz()
        {
            if (bizBuyBookPayment == null)
            { return new BuyBookPaymentBiz(); }
            else { return bizBuyBookPayment; }
        }
        public static WarningBiz GetWarningBiz()
        {
            if (bizWarning == null)
            { return new WarningBiz(); }
            else { return bizWarning; }
        }
        public static TransferBiz GetTransferBiz()
        {
            if (bizTransfer == null)
            { return new TransferBiz(); }
            else { return bizTransfer; }
        }
        public static TransferDetailBiz GetTransferDetailBiz()
        {
            if (bizTransferDetail == null)
            { return new TransferDetailBiz(); }
            else { return bizTransferDetail; }
        }
        public static TransferBuyBookBiz GetTransferBuyBookBiz()
        {
            if (bizTransferBuyBook == null)
            { return new TransferBuyBookBiz(); }
            else { return bizTransferBuyBook; }
        }
        public static TransferInventoryBiz GetTransferInventoryBiz()
        {
            if (bizTransferInventory == null)
            { return new TransferInventoryBiz(); }
            else { return bizTransferInventory; }
        }
        public static OrderBiz GetOrderBiz()
        {
            if (bizOrder == null)
            { return new OrderBiz(); }
            else { return bizOrder; }
        }
        public static OrderDetailBiz GetOrderDetailBiz()
        {
            if (bizOrderDetail == null)
            { return new OrderDetailBiz(); }
            else { return bizOrderDetail; }
        }
        public static WarningTransferBiz GetWarningTransferBiz()
        {
            if (bizWarningTransfer == null)
            { return new WarningTransferBiz(); }
            else { return bizWarningTransfer; }
        }
        public static ProductionLineBiz GetProductionLineBiz()
        {
            if (bizProductionLine == null)
            { return new ProductionLineBiz(); }
            else { return bizProductionLine; }
        }
        public static SellBookBiz GetSellBookBiz()
        {
            if (bizSellBook == null)
            { return new SellBookBiz(); }
            else { return bizSellBook; }
        }
        public static SellBookDetailBiz GetSellBookDetailBiz()
        {
            if (bizSellBookDetail == null)
            { return new SellBookDetailBiz(); }
            else { return bizSellBookDetail; }
        }

        public static ExpenseGroupBiz GetExpenseGroupBiz()
        {
            if (bizExpenseGroup == null)
            { return new ExpenseGroupBiz(); }
            else { return bizExpenseGroup; }
        }
        public static ExpenseBiz GetExpenseBiz()
        {
            if (bizExpense == null)
            { return new ExpenseBiz(); }
            else { return bizExpense; }
        }
        public static ReceiveDocumentBiz GetReceiveDocumentBiz()
        {
            if (bizReceiveDocument == null)
            { return new ReceiveDocumentBiz(); }
            else { return bizReceiveDocument; }
        }
    }
}
