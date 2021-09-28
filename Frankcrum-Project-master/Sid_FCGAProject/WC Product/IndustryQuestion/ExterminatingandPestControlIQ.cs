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

namespace Sid_FCGAProject.WC_Product.IndustryQuestion
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ExterminatingandPestControlIQ recording.
    /// </summary>
    [TestModule("ad78a157-d2c5-4a94-a962-5843836c2e05", ModuleType.Recording, 1)]
    public partial class ExterminatingandPestControlIQ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static ExterminatingandPestControlIQ instance = new ExterminatingandPestControlIQ();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExterminatingandPestControlIQ()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ExterminatingandPestControlIQ Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1YesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1NoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q1No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2YesInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2NoInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q2No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3YesInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3NoInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q3No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4YesInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4NoInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q4No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5YesInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5NoInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q5No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6YesInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6NoInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q6No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7YesInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7NoInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q7No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8Yes' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8YesInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8Yes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8No' at Center.", repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8NoInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.IndustryQuestionTable.ExterminatingandPestControl.IQ_ExterminatingandPestControl_Q8No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnNext' at Center.", repo.ApplicationUnderTest.BtnNextInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.BtnNext.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
