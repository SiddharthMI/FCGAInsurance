﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sid_FCGAProject.User_Collection
{
    public partial class Latest_Excel_Write
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        public void TestExcelWrite (string TCID, string Product, string TestScenario, string ClassCode, string ClassDescription, string ClassGroup, string InsuredName, 
               string ReferralReason, string InsuredAddress, string PrdPremium, string CarrierName, string MIPolicyNo, string XSPolicyNo, string StatusReason, string StartTime, string EndTime)
        {
        	Microsoft.Office.Interop.Excel.Application excelFile = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWB= excelFile.Workbooks.Open(@"C:\Users\SMishra\Documents\Automation\Frankcrum-Project-master_V5.0\Frankcrum-Project-master\Automation Report.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet excelWS=(Microsoft.Office.Interop.Excel.Worksheet) excelWB.Worksheets.get_Item("Report");
            Microsoft.Office.Interop.Excel.Range xlRange = excelWS.UsedRange;
            
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            
            Report.Log(ReportLevel.Info,"Row Count is :"+rowCount);
            Report.Log(ReportLevel.Info,"Collumn Count is :"+colCount);
            rowCount = rowCount+1;
            
            for(int i=1; i<=colCount; i++)
            {
             if(i== 1){
              string Res = Product.Substring(0, 1);
              excelWS.Cells[rowCount,i] = Res+"-"+TCID;
            	}
              if(i== 2){
              excelWS.Cells[rowCount,i] = Product;
            	}
              if(i== 3){
              excelWS.Cells[rowCount,i] = TestScenario;
            	}
              if(i== 4){
              excelWS.Cells[rowCount,i] = ClassCode;
            	}
              if(i== 5){
              excelWS.Cells[rowCount,i] = ClassDescription;
            	}
              if(i== 6){
              excelWS.Cells[rowCount,i] = ClassGroup;
            	}
              if(i== 7){
              excelWS.Cells[rowCount,i] = InsuredName;
            	}
              if(i== 8){
              excelWS.Cells[rowCount,i] = ReferralReason;
            	}
              if(i== 9){
              excelWS.Cells[rowCount,i] = InsuredAddress;
            	}
              if(i== 10){
              excelWS.Cells[rowCount,i] = PrdPremium;
            	}
              if(i== 11){
              excelWS.Cells[rowCount,i] = CarrierName;
            	}
            	if(i== 12){
              excelWS.Cells[rowCount,i] = MIPolicyNo;
            	}
              if(i== 13){
              excelWS.Cells[rowCount,i] = XSPolicyNo;
            	}
              if(i== 14){
            	if(MIPolicyNo == ""){
            	   excelWS.Cells[rowCount,i] ="Fail";
            		} else {
            		excelWS.Cells[rowCount,i] ="Pass";	
            		}
            	}
              if(i== 15){
            	if(MIPolicyNo == ""){
            	 excelWS.Cells[rowCount,i] ="Error in "+ StatusReason+". Need Further Investigation";	
            	  }
            	}
              if(i== 16){
              excelWS.Cells[rowCount,i] = StartTime;
            	}
              if(i== 17){
              excelWS.Cells[rowCount,i] = EndTime;
            	}
            }
            
            excelWB.Save();
            excelWB.Close();
            excelFile.Quit();
            
        }
    }
}
