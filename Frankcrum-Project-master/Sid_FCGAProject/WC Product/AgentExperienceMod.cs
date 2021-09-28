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
    ///The AgentExperienceMod recording.
    /// </summary>
    [TestModule("a0afaf8c-c17c-4e18-b210-d8c773f5b302", ModuleType.Recording, 1)]
    public partial class AgentExperienceMod : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentExperienceMod instance = new AgentExperienceMod();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentExperienceMod()
        {
            ExpModID = "1.89";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentExperienceMod Instance
        {
            get { return instance; }
        }

#region Variables

        string _ExpModID;

        /// <summary>
        /// Gets or sets the value of variable ExpModID.
        /// </summary>
        [TestVariable("65582b87-e569-4d3b-aebb-a8fe06f4ebac")]
        public string ExpModID
        {
            get { return _ExpModID; }
            set { _ExpModID = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes1.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtExpMod' at Center.", repo.ApplicationUnderTest.TxtExpModInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtExpMod.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExpModID' with focus on 'ApplicationUnderTest.TxtExpMod'.", repo.ApplicationUnderTest.TxtExpModInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtExpMod.PressKeys(ExpModID);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
