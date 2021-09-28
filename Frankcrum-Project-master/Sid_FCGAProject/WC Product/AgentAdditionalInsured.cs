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
    ///The AgentAdditionalInsured recording.
    /// </summary>
    [TestModule("4f09f196-f6e5-4591-9f4b-d15f7d3ee8d2", ModuleType.Recording, 1)]
    public partial class AgentAdditionalInsured : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentAdditionalInsured instance = new AgentAdditionalInsured();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentAdditionalInsured()
        {
            AdditionalInsuredName = "Raj";
            AddInsFEINNo = "4545454545";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentAdditionalInsured Instance
        {
            get { return instance; }
        }

#region Variables

        string _AdditionalInsuredName;

        /// <summary>
        /// Gets or sets the value of variable AdditionalInsuredName.
        /// </summary>
        [TestVariable("eb79ec22-bc9b-4c0e-bb2f-753eaaa77237")]
        public string AdditionalInsuredName
        {
            get { return _AdditionalInsuredName; }
            set { _AdditionalInsuredName = value; }
        }

        string _AddInsFEINNo;

        /// <summary>
        /// Gets or sets the value of variable AddInsFEINNo.
        /// </summary>
        [TestVariable("bd42ec95-7e78-4a0a-805c-b360e3035472")]
        public string AddInsFEINNo
        {
            get { return _AddInsFEINNo; }
            set { _AddInsFEINNo = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAddinsuredName1' at Center.", repo.ApplicationUnderTest.TxtAddinsuredName1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtAddinsuredName1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AdditionalInsuredName' with focus on 'ApplicationUnderTest.TxtAddinsuredName1'.", repo.ApplicationUnderTest.TxtAddinsuredName1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtAddinsuredName1.PressKeys(AdditionalInsuredName);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AddInsFEINNo' with focus on 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.TxtFEINNo1.EnsureVisible();
            Keyboard.Press(AddInsFEINNo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
