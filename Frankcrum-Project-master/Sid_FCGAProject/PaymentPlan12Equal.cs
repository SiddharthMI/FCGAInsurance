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
    ///The PaymentPlan12Equal recording.
    /// </summary>
    [TestModule("92252010-b355-4fa1-a535-66c2f9fedd34", ModuleType.Recording, 1)]
    public partial class PaymentPlan12Equal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static PaymentPlan12Equal instance = new PaymentPlan12Equal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PaymentPlan12Equal()
        {
            Status_Reason = "12 Equal";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PaymentPlan12Equal Instance
        {
            get { return instance; }
        }

#region Variables

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("922cf846-0765-4a99-b7b0-ebde17cb3e57")]
        public string Status_Reason
        {
            get { return _Status_Reason; }
            set { _Status_Reason = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TblPaymentInfo.Payment_Info_12Equal' at Center.", repo.ApplicationUnderTest.TblPaymentInfo.Payment_Info_12EqualInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TblPaymentInfo.Payment_Info_12Equal.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
