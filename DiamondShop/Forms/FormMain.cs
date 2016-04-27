using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using uApplication.Base;
using uApplication;
using Telerik.WinControls;
using uApplication.App;
using WCS.Forms;
using WCS.Forms.Analysis;
using WCS.Forms.Target;

namespace uApplication
{
    public partial class FormMain : FormMaster
    {
        FormTestList frmTest = new FormTestList();
        FormWarningtList frmWarning = new FormWarningtList();//แจ้งเตือน
        FormBankList frmBankList = new FormBankList();
        FormLifeInsureMasterList frmLifeInsure = new FormLifeInsureMasterList();//ประกันภัย
        FormLifeInsuranceCondList frmInsureCond = new FormLifeInsuranceCondList();
        FormAssetList frmAssetList = new FormAssetList();//สินทรัพย์ หนี้สิน
        FormInsureList frmInsureList = new FormInsureList();
        FormOtherExpense frmIncomeList = new FormOtherExpense();//รายจ่าย
        FormRevenueGroupList frmRevenue = new FormRevenueGroupList();//เกษียณอายุ
        FormFamilyList frmFamily = new FormFamilyList();//ครอบครัว
        FormCustomerList frmCustomer = new FormCustomerList();
        //FormSearchCustomerList frmSearchCustomer = new FormSearchCustomerList();  ใช้หน้าข้อมูลส่วนตัว (ทั่วไป) ค้นหาแทน
        FormFinanceList frmFinance = new FormFinanceList();
        FormProfitList frmProfit = new FormProfitList();
        FormSummaryList frmSummary = new FormSummaryList(); 
        FormFamilyList frmGeneralFam = new FormFamilyList();
        FormBalanceSheet frmBalanceSheet = new FormBalanceSheet();
        FormOtherExpense frmOtherExpense = new FormOtherExpense();
        FormRatio frmRatio = new FormRatio();
        FormRevenue frmRevenue1 = new FormRevenue();
        FormTaxRevenue frmTaxRevenue = new FormTaxRevenue();
        FormEducationGradeList frmGrade = new FormEducationGradeList();
        FormSpecialEducationInfo frmSpecialEducation = new FormSpecialEducationInfo();
        FormInsure frmInsure = new FormInsure();
        FormHeritage frmHeritage = new FormHeritage();
        FormTargetOther frmTargetOther= new FormTargetOther();
        FormTargetRetrie frmTargetRetrie = new FormTargetRetrie();
        FormEducationList frmEdcuation = new FormEducationList();
        FormExpenseAnalyze frmExpenseAnalyze = new FormExpenseAnalyze();
        FormInvestmentMasterInfo frmInvestmentMaster = new FormInvestmentMasterInfo();
        FormFormulaList frmFormulaDetail = new FormFormulaList();
        
        public FormMain()
        {
            InitializeComponent();
        }

        public void OpenForm(Form frm)
        {
            if (frm.IsDisposed)
            {
                frm = (Form)Activator.CreateInstance(frm.GetType());
            }
            if (frm is FormList && ((FormList)frm).MdiParentForm == null)
            {
                frm.MdiParent = this;
                if (frm is FormList)
                {
                    ((FormList)frm).MdiParentForm = this;
                }
                frm.Show();
                frm.Activate();
            }
            else if (frm is FormInfo && ((FormInfo)frm).MdiParentForm == null)
            {
                frm.MdiParent = this;
                frm.Show();
                frm.Activate();
            }
            documentContainer1.DockManager.ActivateMdiChild(frm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            new FormSetting().SetTheme();
            itemPerson.Click += new EventHandler(itemPerson_Click);
            itemFamily.Click += new EventHandler(itemFamily_Click);
            itemInsurance.Click+=new EventHandler(itemInsurance_Click);
            itemWork.Click+=new EventHandler(itemWork_Click);
            itemAsset.Click+=new EventHandler(itemAsset_Click);
            itemIncome.Click += new EventHandler(itemIncome_Click);
            /*Setup*/
            itemLifeInsurance.Click += new EventHandler(itemLifeInsurance_Click);
            itemTemplatLifeInsurance.Click += new EventHandler(itemTemplatLifeInsurance_Click);
            itemBank.Click += new EventHandler(itemBank_Click);
            itemSpecialEducation.Click += new EventHandler(itemSpecialEducation_Click);
            itemEducationGrade.Click += new EventHandler(itemEducationGrade_Click);
            ItemInvestmentMaster.Click += new EventHandler(ItemInvestmentMaster_Click);
            ItemFormulaDetail.Click += new EventHandler(ItemFormulaDetail_Click);
            itemNewUser.Click += new EventHandler(itemNewUser_Click);

            itemTargetConclusion.Click += new EventHandler(itemTargetConclusion_Click);
            itemTargetConclusion3.Click += new EventHandler(itemTargetConclusion3_Click);
            itemConclusion.Click += new EventHandler(itemConclusion_Click); //สรุปเป้าหมาย (Report)
            itemConclusionReport.Click += new EventHandler(itemConclusionReport_Click); //สรุปเป้าหมาย (Report)
            itemConclusionAttach.Click += new EventHandler(itemConclusionAttach_Click); //เอกสารแนบท้าย (Report)

            itemBalance.Click += new EventHandler(itemBalance_Click);
            radMenuItem5.Click += new EventHandler(radMenuItem5_Click);
            radMenuItem6.Click += new EventHandler(radMenuItem6_Click);
            ApplicationInfo.PropertyChanged += new EventHandler(ApplicationInfo_PropertyChanged);
            radMenuItem3.Click += new EventHandler(radMenuItem3_Click);
            radMenuItem4.Click += new EventHandler(radMenuItem4_Click);
            radMenuItem7.Click += new EventHandler(radMenuItem7_Click);
            radMenuItem8.Click += new EventHandler(radMenuItem8_Click);
            radMenuItem9.Click += new EventHandler(radMenuItem9_Click);
            radMenuItem10.Click += new EventHandler(radMenuItem10_Click);
            itemBenefitReturn.Click +=new EventHandler(itemBenefitReturn_Click);
            ApplicationInfo_PropertyChanged(null, EventArgs.Empty);
            /*แสดงหน้าแจ้งเตือน*/
            OpenForm(frmWarning);
        }

        void itemBenefitReturn_Click(object sender, EventArgs e)
        {
            FormFundTypeMaster frmFundTypeMaster = new FormFundTypeMaster();
            frmFundTypeMaster.ShowDialog();
        }

        void itemNewUser_Click(object sender, EventArgs e)
        {
            FormNewUserList frmNewUser = new FormNewUserList();
            frmNewUser.ShowDialog();
        }

        void itemConclusion_Click(object sender, EventArgs e)
        {
            FormReport frmReport = new FormReport();
            frmReport.ShowDialog();
        }

        void itemConclusionReport_Click(object sender, EventArgs e)
        {
            FormReportInfo frmReportinfo = new FormReportInfo();
            frmReportinfo.ShowDialog();
        }

        void itemConclusionAttach_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FormDocument frmDocAttach = new FormDocument();
            frmDocAttach.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        void itemTargetConclusion_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FormTargetConclusion frmFormTagetConclusion = new FormTargetConclusion();
            frmFormTagetConclusion.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        void itemTargetConclusion3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FormTargetConclusion2 frmFormTagetConclusion3 = new FormTargetConclusion2();
            frmFormTagetConclusion3.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        void ItemFormulaDetail_Click(object sender, EventArgs e)
        {
            OpenForm(frmFormulaDetail);
        }

        void ItemInvestmentMaster_Click(object sender, EventArgs e)
        {
            OpenForm(frmInvestmentMaster);
        }

        void itemEducationGrade_Click(object sender, EventArgs e)
        {
            OpenForm(frmGrade);
        }

        void itemSpecialEducation_Click(object sender, EventArgs e)
        {
            OpenForm(frmSpecialEducation);
        }

        void radMenuItem3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmTaxRevenue);
            this.Cursor = Cursors.Default;
        }

        void radMenuItem5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmRatio);
            this.Cursor = Cursors.Default;
        }
        void radMenuItem6_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmRevenue1);
            this.Cursor = Cursors.Default;
        }

        void itemBalance_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmBalanceSheet);
            this.Cursor = Cursors.Default;
        }        
        #region Link Event
        void itemSearchPerson_Click(object sender, EventArgs e)
        {
            //OpenForm(frmSearchCustomer);
        }

        void itemBank_Click(object sender, EventArgs e)
        {
            OpenForm(frmBankList);
        }

        void itemTemplatLifeInsurance_Click(object sender, EventArgs e)
        {
            OpenForm(frmLifeInsure);
        }

        void itemLifeInsurance_Click(object sender, EventArgs e)
        {
            OpenForm(frmInsureCond);
        }

        void itemAsset_Click(object sender, EventArgs e)
        {
            OpenForm(frmAssetList);
        }

        void itemInsurance_Click(object sender, EventArgs e)
        {
            OpenForm(frmInsureList);
        }

        void itemIncome_Click(object sender, EventArgs e)
        {
            OpenForm(frmIncomeList);
        }

        void itemWork_Click(object sender, EventArgs e)
        {
            OpenForm(frmRevenue);
        }

        void ApplicationInfo_PropertyChanged(object sender, EventArgs e)
        {
            lblPerson.Text = ApplicationInfo.CustomerFullName;
            lblDisplayName.Text = ApplicationInfo.DisplayName;
            lblPlanCode.Text = ApplicationInfo.PlanID;
            lblUserName.Text = ApplicationInfo.UserName;
            ////bool enabled = ApplicationInfo.CustomerID != "";
            bool enabled = ApplicationInfo.PlanID != "";
            btnFinance.Enabled = enabled;
            btnProfit.Enabled = enabled;
            btnSummary.Enabled = enabled;
            itemFamily.Enabled = enabled;
            itemInsurance.Enabled = enabled;
            itemWork.Enabled = enabled;
            itemAsset.Enabled = enabled;
            itemIncome.Enabled = enabled;
        }

        void itemPerson_Click(object sender, EventArgs e)
        {
            OpenForm(frmCustomer);
        }

        void itemFamily_Click(object sender, EventArgs e)
        {
            OpenForm(frmFamily);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            //OpenForm(frmCustomer);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            //OpenForm(frmFinance);
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            OpenForm(frmSummary);
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {            
            OpenForm(frmTest);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting frm = new FormSetting();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
        #endregion

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmInsure);
            this.Cursor = Cursors.Default;
        }

        private void radBtnWarning_Click(object sender, EventArgs e)
        {
            OpenForm(frmWarning);
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmHeritage);
            this.Cursor = Cursors.Default;
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmTargetOther);
            this.Cursor = Cursors.Default;
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmTargetRetrie);
            this.Cursor = Cursors.Default;
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmEdcuation);
            this.Cursor = Cursors.Default;
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenForm(frmExpenseAnalyze);
            this.Cursor = Cursors.Default;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelp frmHelp = new FormHelp();
            frmHelp.ShowDialog();
        }

        private void radDock1_Click(object sender, EventArgs e)
        {

        }
    }
}
