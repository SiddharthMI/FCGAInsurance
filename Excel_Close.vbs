Set objWMIService = GetObject("winmgmts:" _
    & "{impersonationLevel=impersonate, " _
    & "(Debug)}!\\.\root\cimv2")

Set colProcessList = objWMIService.ExecQuery _
    ("Select * from Win32_Process Where Name = 'Excel.exe'")

For Each objProcess In colProcessList
    objProcess.Terminate()
Next