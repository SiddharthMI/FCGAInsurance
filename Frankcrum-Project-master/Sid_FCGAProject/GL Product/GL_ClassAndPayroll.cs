﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sid_FCGAProject.GL_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GL_ClassAndPayroll recording.
    /// </summary>
    [TestModule("d6229a45-b94c-4c8c-86ce-5cd3a2574dff", ModuleType.Recording, 1)]
    public partial class GL_ClassAndPayroll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static GL_ClassAndPayroll instance = new GL_ClassAndPayroll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL_ClassAndPayroll()
        {
            GLAgContractorClassCode = "91111";
            GLAgContractorPercent = "100";
            GLAgExpectedGrossReceipt = "1345678";
            GLAgInsuredSubContratorCost = "54678";
            GLAgSubcontractorDesc = "OK";
            GLAgSubContractorClassCode = "91585";
            GLAgSubcontractorPercent = "100";
            GLAgFullAdmEmp = "6";
            GLAgPartAdmEmp = "3";
            GLAgTotAdmPayroll = "10000";
            GLAgFullScaleEmp = "4";
            GLAgPartSalesEmp = "2";
            GLAgTotSalesPayroll = "80000";
            GLAgFullPartners = "15";
            GLAgPartPartners = "8";
            GLAgFullOtherEmp = "3";
            GLAgPartOtherEmp = "1";
            GLAgTotOtherPayroll = "34256";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GL_ClassAndPayroll Instance
        {
            get { return instance; }
        }

#region Variables

        string _GLAgContractorClassCode;

        /// <summary>
        /// Gets or sets the value of variable GLAgContractorClassCode.
        /// </summary>
        [TestVariable("424aa889-66b1-4bbb-8356-52624af3059a")]
        public string GLAgContractorClassCode
        {
            get { return _GLAgContractorClassCode; }
            set { _GLAgContractorClassCode = value; }
        }

        string _GLAgContractorPercent;

        /// <summary>
        /// Gets or sets the value of variable GLAgContractorPercent.
        /// </summary>
        [TestVariable("809fee8a-dce6-467b-b2f6-b5ae8dae5e6e")]
        public string GLAgContractorPercent
        {
            get { return _GLAgContractorPercent; }
            set { _GLAgContractorPercent = value; }
        }

        string _GLAgExpectedGrossReceipt;

        /// <summary>
        /// Gets or sets the value of variable GLAgExpectedGrossReceipt.
        /// </summary>
        [TestVariable("d0adae13-76b8-4711-b789-4a2e528c6dd9")]
        public string GLAgExpectedGrossReceipt
        {
            get { return _GLAgExpectedGrossReceipt; }
            set { _GLAgExpectedGrossReceipt = value; }
        }

        string _GLAgInsuredSubContratorCost;

        /// <summary>
        /// Gets or sets the value of variable GLAgInsuredSubContratorCost.
        /// </summary>
        [TestVariable("bfccbed6-4086-449f-aa87-9ff29aaa1fb7")]
        public string GLAgInsuredSubContratorCost
        {
            get { return _GLAgInsuredSubContratorCost; }
            set { _GLAgInsuredSubContratorCost = value; }
        }

        string _GLAgSubcontractorDesc;

        /// <summary>
        /// Gets or sets the value of variable GLAgSubcontractorDesc.
        /// </summary>
        [TestVariable("37fda90b-7a36-44e5-8a0c-cd0b38424e12")]
        public string GLAgSubcontractorDesc
        {
            get { return _GLAgSubcontractorDesc; }
            set { _GLAgSubcontractorDesc = value; }
        }

        string _GLAgSubContractorClassCode;

        /// <summary>
        /// Gets or sets the value of variable GLAgSubContractorClassCode.
        /// </summary>
        [TestVariable("a25b1c47-f845-44cb-8966-3778179c9a6d")]
        public string GLAgSubContractorClassCode
        {
            get { return _GLAgSubContractorClassCode; }
            set { _GLAgSubContractorClassCode = value; }
        }

        string _GLAgSubcontractorPercent;

        /// <summary>
        /// Gets or sets the value of variable GLAgSubcontractorPercent.
        /// </summary>
        [TestVariable("ef361a23-01ea-4768-a0ed-eccb9f61315d")]
        public string GLAgSubcontractorPercent
        {
            get { return _GLAgSubcontractorPercent; }
            set { _GLAgSubcontractorPercent = value; }
        }

        string _GLAgFullAdmEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgFullAdmEmp.
        /// </summary>
        [TestVariable("9a48690d-6a07-48b2-a807-4aac6f2d5090")]
        public string GLAgFullAdmEmp
        {
            get { return _GLAgFullAdmEmp; }
            set { _GLAgFullAdmEmp = value; }
        }

        string _GLAgPartAdmEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgPartAdmEmp.
        /// </summary>
        [TestVariable("b07c9628-7eb7-4436-808e-edbd2e61bb06")]
        public string GLAgPartAdmEmp
        {
            get { return _GLAgPartAdmEmp; }
            set { _GLAgPartAdmEmp = value; }
        }

        string _GLAgTotAdmPayroll;

        /// <summary>
        /// Gets or sets the value of variable GLAgTotAdmPayroll.
        /// </summary>
        [TestVariable("496af71b-978d-4f75-823f-a0509cb7c3b7")]
        public string GLAgTotAdmPayroll
        {
            get { return _GLAgTotAdmPayroll; }
            set { _GLAgTotAdmPayroll = value; }
        }

        string _GLAgFullScaleEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgFullScaleEmp.
        /// </summary>
        [TestVariable("7114d012-2135-4776-87a9-b7277218fdf5")]
        public string GLAgFullScaleEmp
        {
            get { return _GLAgFullScaleEmp; }
            set { _GLAgFullScaleEmp = value; }
        }

        string _GLAgPartSalesEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgPartSalesEmp.
        /// </summary>
        [TestVariable("54878b57-bdd8-45af-936d-91b923b9aaaa")]
        public string GLAgPartSalesEmp
        {
            get { return _GLAgPartSalesEmp; }
            set { _GLAgPartSalesEmp = value; }
        }

        string _GLAgTotSalesPayroll;

        /// <summary>
        /// Gets or sets the value of variable GLAgTotSalesPayroll.
        /// </summary>
        [TestVariable("e3b4baff-60ea-443d-8a89-5c31d3f2abb7")]
        public string GLAgTotSalesPayroll
        {
            get { return _GLAgTotSalesPayroll; }
            set { _GLAgTotSalesPayroll = value; }
        }

        string _GLAgFullPartners;

        /// <summary>
        /// Gets or sets the value of variable GLAgFullPartners.
        /// </summary>
        [TestVariable("72326727-97c5-476c-bcbd-ebd133f5f564")]
        public string GLAgFullPartners
        {
            get { return _GLAgFullPartners; }
            set { _GLAgFullPartners = value; }
        }

        string _GLAgPartPartners;

        /// <summary>
        /// Gets or sets the value of variable GLAgPartPartners.
        /// </summary>
        [TestVariable("553c36a4-250a-4ddc-98fa-6e35ff62bc73")]
        public string GLAgPartPartners
        {
            get { return _GLAgPartPartners; }
            set { _GLAgPartPartners = value; }
        }

        string _GLAgFullOtherEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgFullOtherEmp.
        /// </summary>
        [TestVariable("a2b5332e-2442-489b-9ce3-96d81370c006")]
        public string GLAgFullOtherEmp
        {
            get { return _GLAgFullOtherEmp; }
            set { _GLAgFullOtherEmp = value; }
        }

        string _GLAgPartOtherEmp;

        /// <summary>
        /// Gets or sets the value of variable GLAgPartOtherEmp.
        /// </summary>
        [TestVariable("3e9e8003-d543-48dc-8a08-7da21efe31f8")]
        public string GLAgPartOtherEmp
        {
            get { return _GLAgPartOtherEmp; }
            set { _GLAgPartOtherEmp = value; }
        }

        string _GLAgTotOtherPayroll;

        /// <summary>
        /// Gets or sets the value of variable GLAgTotOtherPayroll.
        /// </summary>
        [TestVariable("094698a1-0c3d-4f3f-81f4-23914d685e31")]
        public string GLAgTotOtherPayroll
        {
            get { return _GLAgTotOtherPayroll; }
            set { _GLAgTotOtherPayroll = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectGLClassificationContainer' at Center.", repo.ApplicationUnderTest.SelectGLClassificationContainerInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SelectGLClassificationContainer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgContractorClassCode' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Search.PressKeys(GLAgContractorClassCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Search.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnAddClassification' at Center.", repo.ApplicationUnderTest.BtnAddClassificationInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.BtnAddClassification.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Percentage' at Center.", repo.ApplicationUnderTest.PercentageInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Percentage.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgContractorPercent' with focus on 'ApplicationUnderTest.Percentage'.", repo.ApplicationUnderTest.PercentageInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Percentage.PressKeys(GLAgContractorPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BorderTop0' at Center.", repo.ApplicationUnderTest.BorderTop0Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BorderTop0.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ExpectedGrossReceipts' at Center.", repo.ApplicationUnderTest.ExpectedGrossReceiptsInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ExpectedGrossReceipts.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgExpectedGrossReceipt' with focus on 'ApplicationUnderTest.ExpectedGrossReceipts'.", repo.ApplicationUnderTest.ExpectedGrossReceiptsInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ExpectedGrossReceipts.EnsureVisible();
            Keyboard.Press(GLAgExpectedGrossReceipt);
            Delay.Milliseconds(0);
            
            SubcontractorUserCodeMethod(repo.ApplicationUnderTest.InsuredSubcontractorsCostInfo, repo.ApplicationUnderTest.InsuredSubcontractorsOperationsInfo, repo.ApplicationUnderTest.SelectClassCodesContainerInfo, repo.ApplicationUnderTest.SearchInfo, repo.ApplicationUnderTest.BtnAddClassCodeInfo, repo.ApplicationUnderTest.Percentage1Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullAdmEmp' at Center.", repo.ApplicationUnderTest.FullAdmEmpInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.FullAdmEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.FullAdmEmp'.", repo.ApplicationUnderTest.FullAdmEmpInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.FullAdmEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgFullAdmEmp' with focus on 'ApplicationUnderTest.FullAdmEmp'.", repo.ApplicationUnderTest.FullAdmEmpInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.FullAdmEmp.PressKeys(GLAgFullAdmEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PartAdmEmp' at Center.", repo.ApplicationUnderTest.PartAdmEmpInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.PartAdmEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.PartAdmEmp'.", repo.ApplicationUnderTest.PartAdmEmpInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.PartAdmEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgPartAdmEmp' with focus on 'ApplicationUnderTest.PartAdmEmp'.", repo.ApplicationUnderTest.PartAdmEmpInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.PartAdmEmp.PressKeys(GLAgPartAdmEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TotAdmPayroll' at Center.", repo.ApplicationUnderTest.TotAdmPayrollInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.TotAdmPayroll.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TotAdmPayroll'.", repo.ApplicationUnderTest.TotAdmPayrollInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.TotAdmPayroll.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgTotAdmPayroll' with focus on 'ApplicationUnderTest.TotAdmPayroll'.", repo.ApplicationUnderTest.TotAdmPayrollInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.TotAdmPayroll.PressKeys(GLAgTotAdmPayroll);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullSalesEmp' at Center.", repo.ApplicationUnderTest.FullSalesEmpInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.FullSalesEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.FullSalesEmp'.", repo.ApplicationUnderTest.FullSalesEmpInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.FullSalesEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgFullScaleEmp' with focus on 'ApplicationUnderTest.FullSalesEmp'.", repo.ApplicationUnderTest.FullSalesEmpInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.FullSalesEmp.PressKeys(GLAgFullScaleEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PartSalesEmp' at Center.", repo.ApplicationUnderTest.PartSalesEmpInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.PartSalesEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.PartSalesEmp'.", repo.ApplicationUnderTest.PartSalesEmpInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.PartSalesEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgPartSalesEmp' with focus on 'ApplicationUnderTest.PartSalesEmp'.", repo.ApplicationUnderTest.PartSalesEmpInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.PartSalesEmp.PressKeys(GLAgPartSalesEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TotSalesPayroll' at Center.", repo.ApplicationUnderTest.TotSalesPayrollInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.TotSalesPayroll.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TotSalesPayroll'.", repo.ApplicationUnderTest.TotSalesPayrollInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.TotSalesPayroll.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgTotSalesPayroll' with focus on 'ApplicationUnderTest.TotSalesPayroll'.", repo.ApplicationUnderTest.TotSalesPayrollInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.TotSalesPayroll.PressKeys(GLAgTotSalesPayroll);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullPartners' at Center.", repo.ApplicationUnderTest.FullPartnersInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.FullPartners.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.FullPartners'.", repo.ApplicationUnderTest.FullPartnersInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.FullPartners.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgFullPartners' with focus on 'ApplicationUnderTest.FullPartners'.", repo.ApplicationUnderTest.FullPartnersInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.FullPartners.PressKeys(GLAgFullPartners);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PartPartners' at Center.", repo.ApplicationUnderTest.PartPartnersInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.PartPartners.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.PartPartners'.", repo.ApplicationUnderTest.PartPartnersInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.PartPartners.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgPartPartners' with focus on 'ApplicationUnderTest.PartPartners'.", repo.ApplicationUnderTest.PartPartnersInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.PartPartners.PressKeys(GLAgPartPartners);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FullOtherEmp' at Center.", repo.ApplicationUnderTest.FullOtherEmpInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.FullOtherEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.FullOtherEmp'.", repo.ApplicationUnderTest.FullOtherEmpInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.FullOtherEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgFullOtherEmp' with focus on 'ApplicationUnderTest.FullOtherEmp'.", repo.ApplicationUnderTest.FullOtherEmpInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.FullOtherEmp.PressKeys(GLAgFullOtherEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PartOtherEmp' at Center.", repo.ApplicationUnderTest.PartOtherEmpInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.PartOtherEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.PartOtherEmp'.", repo.ApplicationUnderTest.PartOtherEmpInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.PartOtherEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgPartOtherEmp' with focus on 'ApplicationUnderTest.PartOtherEmp'.", repo.ApplicationUnderTest.PartOtherEmpInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.PartOtherEmp.PressKeys(GLAgPartOtherEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TotOtherPayroll' at Center.", repo.ApplicationUnderTest.TotOtherPayrollInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.TotOtherPayroll.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TotOtherPayroll'.", repo.ApplicationUnderTest.TotOtherPayrollInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.TotOtherPayroll.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgTotOtherPayroll' with focus on 'ApplicationUnderTest.TotOtherPayroll'.", repo.ApplicationUnderTest.TotOtherPayrollInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.TotOtherPayroll.PressKeys(GLAgTotOtherPayroll);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnContinue1' at Center.", repo.ApplicationUnderTest.BtnContinue1Info, new RecordItemIndex(44));
            repo.ApplicationUnderTest.BtnContinue1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
