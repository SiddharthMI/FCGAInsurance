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
    ///The GL_PayGoPlan recording.
    /// </summary>
    [TestModule("5c6642d1-4dd3-4f1b-9c76-91ec7e3fcad2", ModuleType.Recording, 1)]
    public partial class GL_PayGoPlan : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static GL_PayGoPlan instance = new GL_PayGoPlan();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL_PayGoPlan()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GL_PayGoPlan Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TblPaymentInfo.LabletxtRadio12Equal' at Center.", repo.ApplicationUnderTest.TblPaymentInfo.LabletxtRadio12EqualInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TblPaymentInfo.LabletxtRadio12Equal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadDisc' at Center.", repo.ApplicationUnderTest.BtnDownloadDiscInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.BtnDownloadDisc.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PayGoDisclaimerPdfGoogleChrome.PayGoDisclaimerPdfGoogleChrome' at Center.", repo.PayGoDisclaimerPdfGoogleChrome.PayGoDisclaimerPdfGoogleChromeInfo, new RecordItemIndex(2));
            repo.PayGoDisclaimerPdfGoogleChrome.PayGoDisclaimerPdfGoogleChrome.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Accept' at Center.", repo.AcceptInfo, new RecordItemIndex(3));
            repo.Accept.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MainContentHolder.Email' at Center.", repo.ApplicationUnderTest.MainContentHolder.EmailInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MainContentHolder.Email.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MainContentHolder.CellPhone' at Center.", repo.ApplicationUnderTest.MainContentHolder.CellPhoneInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MainContentHolder.CellPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDisclaimerClose1' at 4;15.", repo.ApplicationUnderTest.BtnDisclaimerClose1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BtnDisclaimerClose1.Click("4;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
