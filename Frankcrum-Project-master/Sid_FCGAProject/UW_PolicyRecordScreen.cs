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

namespace Sid_FCGAProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UW_PolicyRecordScreen recording.
    /// </summary>
    [TestModule("27446279-7cda-4dfc-b52b-ff1441c2c540", ModuleType.Recording, 1)]
    public partial class UW_PolicyRecordScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_PolicyRecordScreen instance = new UW_PolicyRecordScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_PolicyRecordScreen()
        {
            UW_PolicyNumber = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_PolicyRecordScreen Instance
        {
            get { return instance; }
        }

#region Variables

        string _UW_PolicyNumber;

        /// <summary>
        /// Gets or sets the value of variable UW_PolicyNumber.
        /// </summary>
        [TestVariable("e50a30d2-a2ad-47d4-9fb3-2bcd381b6613")]
        public string UW_PolicyNumber
        {
            get { return _UW_PolicyNumber; }
            set { _UW_PolicyNumber = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UW_SelectTypes' at Center.", repo.ApplicationUnderTest.UW_SelectTypesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.UW_SelectTypes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UW_SelectPolicy' at Center.", repo.ApplicationUnderTest.UW_SelectPolicyInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.UW_SelectPolicy.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(2));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Txtsearch' at 14;21.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Txtsearch.Click("14;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UW_PolicyNumber' with focus on 'ApplicationUnderTest.Txtsearch'.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Txtsearch.PressKeys(UW_PolicyNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Txtsearch'.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Txtsearch.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(6));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AutmSelect_1' at Center.", repo.ApplicationUnderTest.AutmSelect_1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AutmSelect_1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(8));
            Delay.Duration(15000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
