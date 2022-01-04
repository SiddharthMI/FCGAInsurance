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

namespace Sid_FCGAProject.WC_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AgentIncludeOwner recording.
    /// </summary>
    [TestModule("50ef6b9d-87f5-4c77-8726-602fbd5e899a", ModuleType.Recording, 1)]
    public partial class AgentIncludeOwner : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentIncludeOwner instance = new AgentIncludeOwner();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentIncludeOwner()
        {
            DescofOp = "OK";
            TxtFTEmp = "10";
            TxtPTEmp = "08";
            TxtGrossPayroll = "100000";
            AOFTEmpNo = "1";
            AOPTEmp = "1";
            AOGrossAmt = "45670";
            StatusReason = "Agent Include Owner and ClassPayroll";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentIncludeOwner Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescofOp;

        /// <summary>
        /// Gets or sets the value of variable DescofOp.
        /// </summary>
        [TestVariable("43d17d87-734b-4f63-969e-6cac83a603ea")]
        public string DescofOp
        {
            get { return _DescofOp; }
            set { _DescofOp = value; }
        }

        string _TxtFTEmp;

        /// <summary>
        /// Gets or sets the value of variable TxtFTEmp.
        /// </summary>
        [TestVariable("e6161733-6a45-4b1f-ba51-256a515b6296")]
        public string TxtFTEmp
        {
            get { return _TxtFTEmp; }
            set { _TxtFTEmp = value; }
        }

        string _TxtPTEmp;

        /// <summary>
        /// Gets or sets the value of variable TxtPTEmp.
        /// </summary>
        [TestVariable("01afc840-9494-4c43-921e-877def9edc51")]
        public string TxtPTEmp
        {
            get { return _TxtPTEmp; }
            set { _TxtPTEmp = value; }
        }

        string _TxtGrossPayroll;

        /// <summary>
        /// Gets or sets the value of variable TxtGrossPayroll.
        /// </summary>
        [TestVariable("3d2e7dee-758a-4068-8178-4e0320624070")]
        public string TxtGrossPayroll
        {
            get { return _TxtGrossPayroll; }
            set { _TxtGrossPayroll = value; }
        }

        string _AOFTEmpNo;

        /// <summary>
        /// Gets or sets the value of variable AOFTEmpNo.
        /// </summary>
        [TestVariable("6f907198-dd22-4fe8-be8d-bf8fa3a43aed")]
        public string AOFTEmpNo
        {
            get { return _AOFTEmpNo; }
            set { _AOFTEmpNo = value; }
        }

        string _AOPTEmp;

        /// <summary>
        /// Gets or sets the value of variable AOPTEmp.
        /// </summary>
        [TestVariable("8f1330b4-04d4-4bc3-a36d-6b5d6aaf233a")]
        public string AOPTEmp
        {
            get { return _AOPTEmp; }
            set { _AOPTEmp = value; }
        }

        string _AOGrossAmt;

        /// <summary>
        /// Gets or sets the value of variable AOGrossAmt.
        /// </summary>
        [TestVariable("72120d2f-2804-434c-820f-619ddbc8ae5a")]
        public string AOGrossAmt
        {
            get { return _AOGrossAmt; }
            set { _AOGrossAmt = value; }
        }

        string _StatusReason;

        /// <summary>
        /// Gets or sets the value of variable StatusReason.
        /// </summary>
        [TestVariable("bbdaa27a-2fb1-4da7-9d6b-a51d549b533b")]
        public string StatusReason
        {
            get { return _StatusReason; }
            set { _StatusReason = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabletxtRadioInclude' at Center.", repo.ApplicationUnderTest.LabletxtRadioIncludeInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LabletxtRadioInclude.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtDescriptionOfOprations' at Center.", repo.ApplicationUnderTest.TxtDescriptionOfOprationsInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtDescriptionOfOprations.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescofOp' with focus on 'ApplicationUnderTest.TxtDescriptionOfOprations'.", repo.ApplicationUnderTest.TxtDescriptionOfOprationsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtDescriptionOfOprations.EnsureVisible();
            Keyboard.Press(DescofOp);
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod1(repo.ApplicationUnderTest.TxtFTEmployee1Info, repo.ApplicationUnderTest.TxtPTEmployee1Info, repo.ApplicationUnderTest.TxtGrossannualPayroll1Info, repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Click_TableInfo, repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFTEmployee2Info, repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtPTEmployee2Info, repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtGrossannualPayroll2Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAOCode1' at Center.", repo.ApplicationUnderTest.TxtAOCode1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtAOCode1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.IncludeOwnerClassCodeClick' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.IncludeOwnerClassCodeClickInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.IncludeOwnerClassCodeClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$AOFTEmpNo' on item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOFTEmp1.Element.SetAttributeValue("Value", AOFTEmpNo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$AOPTEmp' on item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtAOPTEmp1.Element.SetAttributeValue("Value", AOPTEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAOGross1' at Center.", repo.ApplicationUnderTest.TxtAOGross1Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.TxtAOGross1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$AOGrossAmt' on item 'ApplicationUnderTest.TxtAOGross1'.", repo.ApplicationUnderTest.TxtAOGross1Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.TxtAOGross1.Element.SetAttributeValue("Value", AOGrossAmt);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Click_Table' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Click_TableInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Click_Table.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
