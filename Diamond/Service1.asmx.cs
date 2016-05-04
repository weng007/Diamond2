using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using DiamondDS.DS;
using DiamondBiz.Biz;

namespace Diamond
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        bool flag = false;

        [WebMethod]
        public dsMasterTableDetail GetMasterTableDetail(string TypeID)
        { 
            MasterTableDetailBiz biz = new MasterTableDetailBiz();
            return biz.GetMasterTableDetail(TypeID);
        }

        #region DoSelectData
        [WebMethod]
        public DataSet DoSelectData(string TableName, int id)
        {
            
            if (TableName == "User")
            {
                UserBiz biz = GM.GetUserBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Seller")
            {
                SellerBiz biz = GM.GetSellerBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamondCer")
            {
                BuyBookDiamondCerBiz biz = GM.GetBuyBookDiamondCerBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookJewelry")
            {
                BuyBookJewelryBiz biz = GM.GetBuyBookJewelryBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookETC")
            {
                BuyBookETCBiz biz = GM.GetBuyBookETCBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamond")
            {
                BuyBookDiamondBiz biz = GM.GetBuyBookDiamondBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstone")
            {
                BuyBookGemstoneBiz biz = GM.GetBuyBookGemstoneBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstoneCer")
            {
                BuyBookGemstoneBiz biz = GM.GetBuyBookGemstoneBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGold")
            {
                BuyBookGoldBiz biz = GM.GetBuyBookGoldBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSettingDetail")
            {
                BuyBookSettingDetailBiz biz = GM.GetBuyBookSettingDetailBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSpecial")
            {
                BuyBookSpecialBiz biz = GM.GetBuyBookSpecialBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Product")
            {
                ProductBiz biz = GM.GetProductBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "DiamondCer")
            {
                DiamondCerBiz biz = GM.GetDiamondBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "DiamondDetail")
            {
                DiamondDetailBiz biz = GM.GetDiamondDetailBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneCer")
            {
                GemstoneCerBiz biz = GM.GetGemstoneCerBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneDetail")
            {
                GemstoneDetailBiz biz = GM.GetGemstoneDetailBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Customer")
            {
                CustomerBiz biz = GM.GetCustomerBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Sell")
            {
                SellBiz biz = GM.SellBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Catalog")
            {
                CatalogBiz biz = GM.CatalogBiz();
                try
                {
                    return biz.DoSelectData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneCerDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                try
                {
                    return biz.DoSelectDataCer(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                try
                {
                    return biz.DoSelectData(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondCerDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                try
                {
                    return biz.DoSelectDataCer(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                try
                {
                    return biz.DoSelectData(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Inventory")
            {
                InventoryBiz biz = GM.InventoryBiz();
                try
                {
                    return biz.DoSelectData(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondCerDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                try
                {
                    return biz.DoSelectData(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                try
                {
                    return biz.DoSelectData(id);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }
        #endregion

        #region DoInsertData
        [WebMethod]
        public bool DoInsertData(string TableName, DataSet ds)
        {
            if (TableName == "PriceCode")
            {
                PriceCodeBiz biz = GM.GetPriceCodeBiz();
                dsPriceCode ds1 = GM.GetDSPriceCode();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "User")
            {
                UserBiz biz = GM.GetUserBiz();
                dsUser ds1 = new dsUser();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Seller")
            {
                SellerBiz biz = GM.GetSellerBiz();
                dsSeller ds1 = new dsSeller();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamondCer")
            {
                BuyBookDiamondCerBiz biz = GM.GetBuyBookDiamondCerBiz();
                dsBuyBookDiamondCer ds1 = new dsBuyBookDiamondCer();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookJewelry")
            {
                BuyBookJewelryBiz biz = GM.GetBuyBookJewelryBiz();
                dsBuyBookJewelry ds1 = new dsBuyBookJewelry();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookETC")
            {
                BuyBookETCBiz biz =  GM.GetBuyBookETCBiz();
                dsBuyBookETC ds1 = new dsBuyBookETC();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamond")
            {
                BuyBookDiamondBiz biz = GM.GetBuyBookDiamondBiz();
                dsBuyBookDiamond ds1 = new dsBuyBookDiamond();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstone")
            {
                BuyBookGemstoneBiz biz = GM.GetBuyBookGemstoneBiz();
                dsBuyBookGemstone ds1 = GM.GetDSBuyBookGemstone();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstoneCer")
            {
                BuyBookGemstoneCerBiz biz = GM.GetBuyBookGemstoneCerBiz();
                dsBuyBookGemstoneCer ds1 = new dsBuyBookGemstoneCer();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGold")
            {
                BuyBookGoldBiz biz = GM.GetBuyBookGoldBiz();
                dsBuyBookGold ds1 = GM.GetDSBuyBookGold();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSettingDetail")
            {
                BuyBookSettingDetailBiz biz = GM.GetBuyBookSettingDetailBiz();
                dsBuyBookSettingDetail ds1 = new dsBuyBookSettingDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSpecial")
            {
                BuyBookSpecialBiz biz = GM.GetBuyBookSpecialBiz();
                dsBuyBookSpecial ds1 = GM.GetDSBuyBookSpecial();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Product")
            {
                ProductBiz biz = GM.GetProductBiz();
                dsProduct ds1 = GM.GetDSProduct();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            //else if (TableName == "DiamondCer")
            //{
            //    DiamondCerBiz biz = GM.GetDiamondBiz();
            //    dsDiamondCer ds1 = GM.GetDSDiamondCer();
            //    ds1.Merge(ds);

            //    try
            //    {
            //        flag = biz.DoInsertData(ds1);
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            else if (TableName == "DiamondDetail")
            {
                DiamondDetailBiz biz = GM.GetDiamondDetailBiz();
                dsDiamondDetail ds1 = GM.GetDSDiamondDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneCer")
            {
                GemstoneCerBiz biz = GM.GetGemstoneCerBiz();
                dsGemstoneCer ds1 = new dsGemstoneCer();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneDetail")
            {
                GemstoneDetailBiz biz = GM.GetGemstoneDetailBiz();
                dsGemstoneDetail ds1 = GM.GetDSGemstoneDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Customer")
            {
                CustomerBiz biz = GM.GetCustomerBiz();
                dsCustomer ds1 = GM.GetDSCustomer();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Sell")
            {
                SellBiz biz = GM.SellBiz();
                dsSell ds1 = GM.GetDSSell();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Catalog")
            {
                CatalogBiz biz = GM.CatalogBiz();
                dsCatalog ds1 = new dsCatalog();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneCerDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                dsBBJewelryGemstoneCerDetail ds1 = new dsBBJewelryGemstoneCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                dsBBJewelryGemstoneDetail ds1 = new dsBBJewelryGemstoneDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondCerDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                dsBBJewelryDiamondCerDetail ds1 = new dsBBJewelryDiamondCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                dsBBJewelryDiamondDetail ds1 = new dsBBJewelryDiamondDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Inventory")
            {
                InventoryBiz biz = GM.InventoryBiz();
                dsInventory ds1 = new dsInventory();

                ds1.Merge(ds);


                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondCerDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                dsInvDiamondCerDetail ds1 = new dsInvDiamondCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                dsInvDiamondDetail ds1 = new dsInvDiamondDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoInsertData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return flag;
        }
        #endregion

        #region DoUpdateData
        [WebMethod]
        public bool DoUpdateData(string TableName, DataSet ds)
        {
            if (TableName == "PriceCode")
            {
                PriceCodeBiz biz = GM.GetPriceCodeBiz();
                dsPriceCode ds1 = GM.GetDSPriceCode();
                
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "User")
            {
                UserBiz biz = GM.GetUserBiz();
                dsUser ds1 = new dsUser();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Seller")
            {
                SellerBiz biz = GM.GetSellerBiz();
                dsSeller ds1 = new dsSeller();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamondCer")
            {
                BuyBookDiamondCerBiz biz = GM.GetBuyBookDiamondCerBiz();
                dsBuyBookDiamondCer ds1 = new dsBuyBookDiamondCer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookJewelry")
            {
                BuyBookJewelryBiz biz = GM.GetBuyBookJewelryBiz();
                dsBuyBookJewelry ds1 = new dsBuyBookJewelry();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookETC")
            {
                BuyBookETCBiz biz = GM.GetBuyBookETCBiz();
                dsBuyBookETC ds1 = new dsBuyBookETC();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamond")
            {
                BuyBookDiamondBiz biz = GM.GetBuyBookDiamondBiz();
                dsBuyBookDiamond ds1 = new dsBuyBookDiamond();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstone")
            {
                BuyBookGemstoneCerBiz biz = GM.GetBuyBookGemstoneCerBiz();
                dsBuyBookGemstoneCer ds1 = new dsBuyBookGemstoneCer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstoneCer")
            {
                BuyBookGemstoneCerBiz biz = GM.GetBuyBookGemstoneCerBiz();
                dsBuyBookGemstoneCer ds1 = new dsBuyBookGemstoneCer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGold")
            {
                BuyBookGoldBiz biz = GM.GetBuyBookGoldBiz();
                dsBuyBookGold ds1 = GM.GetDSBuyBookGold();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSettingDetail")
            {
                BuyBookSettingDetailBiz biz = GM.GetBuyBookSettingDetailBiz();
                dsBuyBookSettingDetail ds1 =  new dsBuyBookSettingDetail();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSpecial")
            {
                BuyBookSpecialBiz biz = GM.GetBuyBookSpecialBiz();
                dsBuyBookSpecial ds1 = GM.GetDSBuyBookSpecial();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Product")
            {
                ProductBiz biz = GM.GetProductBiz();
                dsProduct ds1 = GM.GetDSProduct();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "DiamondCer")
            {
                DiamondCerBiz biz = GM.GetDiamondBiz();
                dsDiamondCer ds1 = GM.GetDSDiamondCer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "DiamondDetail")
            {
                DiamondDetailBiz biz = GM.GetDiamondDetailBiz();
                dsDiamondDetail ds1 = GM.GetDSDiamondDetail();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneCer")
            {
                GemstoneCerBiz biz = GM.GetGemstoneCerBiz();
                dsGemstoneCer ds1 = new dsGemstoneCer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneDetail")
            {
                GemstoneDetailBiz biz = GM.GetGemstoneDetailBiz();
                dsGemstoneDetail ds1 = GM.GetDSGemstoneDetail();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Customer")
            {
                CustomerBiz biz = GM.GetCustomerBiz();
                dsCustomer ds1 = GM.GetDSCustomer();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Catalog")
            {
                CatalogBiz biz = GM.CatalogBiz();
                dsCatalog ds1 = new dsCatalog();

                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneCerDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                dsBBJewelryGemstoneCerDetail ds1 = new dsBBJewelryGemstoneCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneCerDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();

                dsBBJewelryGemstoneDetail ds1 = new dsBBJewelryGemstoneDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondCerDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                dsBBJewelryDiamondCerDetail ds1 = new dsBBJewelryDiamondCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                dsBBJewelryDiamondDetail ds1 = new dsBBJewelryDiamondDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Inventory")
            {
                InventoryBiz biz = GM.InventoryBiz();
                dsInventory ds1 = new dsInventory();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondCerDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                dsInvDiamondCerDetail ds1 = new dsInvDiamondCerDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateDataCer(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                dsInvDiamondDetail ds1 = new dsInvDiamondDetail();
                ds1.Merge(ds);

                try
                {
                    flag = biz.DoUpdateData(ds1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return flag;
        }
        #endregion

        #region DoDeleteData
        [WebMethod]
        public bool DoDeleteData(string TableName, int id)
        {
            if (TableName == "PriceCode")
            {
                PriceCodeBiz biz = GM.GetPriceCodeBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "User")
            {
                UserBiz biz = GM.GetUserBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Seller")
            {
                SellerBiz biz = GM.GetSellerBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamondCer")
            {
                BuyBookDiamondCerBiz biz = GM.GetBuyBookDiamondCerBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookJewelry")
            {
                BuyBookJewelryBiz biz = GM.GetBuyBookJewelryBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookETC")
            {
                BuyBookETCBiz biz = GM.GetBuyBookETCBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookDiamond")
            {
                BuyBookDiamondBiz biz = GM.GetBuyBookDiamondBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstone")
            {
                BuyBookGemstoneBiz biz = GM.GetBuyBookGemstoneBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGemstoneCer")
            {
                BuyBookGemstoneCerBiz biz = GM.GetBuyBookGemstoneCerBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookGold")
            {
                BuyBookGoldBiz biz = GM.GetBuyBookGoldBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSettingDetail")
            {
                BuyBookSettingDetailBiz biz = GM.GetBuyBookSettingDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BuyBookSpecial")
            {
                BuyBookSpecialBiz biz = GM.GetBuyBookSpecialBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Product")
            {
                ProductBiz biz = GM.GetProductBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            //else if (TableName == "DiamondCer")
            //{
            //    DiamondCerBiz biz = GM.GetDiamondBiz();
            //    try
            //    {
            //        flag = biz.DoDeleteData(id);
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            else if (TableName == "DiamondDetail")
            {
                DiamondDetailBiz biz = GM.GetDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneCer")
            {
                GemstoneCerBiz biz = GM.GetGemstoneCerBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "GemstoneDetail")
            {
                GemstoneDetailBiz biz = GM.GetGemstoneDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Customer")
            {
                CustomerBiz biz = GM.GetCustomerBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Sell")
            {
                SellBiz biz = GM.SellBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Catalog")
            {
                CatalogBiz biz = GM.CatalogBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneCerDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                try
                {
                    flag = biz.DoDeleteDataCer(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryGemstoneDetail")
            {
                BBJewelryGemstoneDetailBiz biz = GM.BBJewelryGemstoneDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondCerDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "BBJewelryDiamondDetail")
            {
                BBJewelryDiamondDetailBiz biz = GM.BBJewelryDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "Inventory")
            {
                InventoryBiz biz = GM.InventoryBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondCerDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (TableName == "InvDiamondDetail")
            {
                InvDiamondDetailBiz biz = GM.InvDiamondDetailBiz();
                try
                {
                    flag = biz.DoDeleteData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return flag;
        }
        #endregion
    }
}
