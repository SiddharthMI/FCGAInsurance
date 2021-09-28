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
    ///The UW_backdatedEffectivedate recording.
    /// </summary>
    [TestModule("6a2e70e2-fef5-4eff-b783-a70285c6723c", ModuleType.Recording, 1)]
    public partial class UW_backdatedEffectivedate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_backdatedEffectivedate instance = new UW_backdatedEffectivedate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_backdatedEffectivedate()
        {
            EffectiveDate = "07/29/2021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_backdatedEffectivedate Instance
        {
            get { return instance; }
        }

#region Variables

        string _EffectiveDate;

        /// <summary>
        /// Gets or sets the value of variable EffectiveDate.
        /// </summary>
        [TestVariable("0fbbec37-3f57-41d2-bcf9-d1fb208641c5")]
        public string EffectiveDate
        {
            get { return _EffectiveDate; }
            set { _EffectiveDate = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Labelcheckbox4' at Center.", repo.ApplicationUnderTest.Labelcheckbox4Info, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.Labelcheckbox4.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.Labelcheckbox4'.", repo.ApplicationUnderTest.Labelcheckbox4Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Labelcheckbox4.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtEffectiveDate' at Center.", repo.ApplicationUnderTest.TxtEffectiveDateInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtEffectiveDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtEffectiveDate'.", repo.ApplicationUnderTest.TxtEffectiveDateInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TxtEffectiveDate.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EffectiveDate' with focus on 'ApplicationUnderTest.TxtEffectiveDate'.", repo.ApplicationUnderTest.TxtEffectiveDateInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtEffectiveDate.PressKeys(EffectiveDate);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.TxtDescriptionOfOprations' at Center.", repo.ApplicationUnderTest.TxtDescriptionOfOprationsInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtDescriptionOfOprations.DoubleClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
