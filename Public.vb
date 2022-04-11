Module [Public]
    Public Delay As Integer
    Public Notice
    Public LocalVersion
    Public Log As String
    Public ReturnValue As Integer
    Function CheckApplicationIsRun(ByVal szExeFileName As String) As Boolean
        On Error GoTo Err
        Dim WMI
        Dim Obj
        Dim Objs
        CheckApplicationIsRun = False
        WMI = GetObject("WinMgmts:")
        Objs = WMI.InstancesOf("Win32_Process")
        For Each Obj In Objs
            If InStr(UCase(szExeFileName), UCase(Obj.Description)) <> 0 Then
                CheckApplicationIsRun = True
                If Objs IsNot Nothing Then Objs = Nothing
                If WMI IsNot Nothing Then WMI = Nothing
                Exit Function
            End If
        Next
        If Objs IsNot Nothing Then Objs = Nothing
        If WMI IsNot Nothing Then WMI = Nothing
        Exit Function
Err:
        If Objs IsNot Nothing Then Objs = Nothing
        If WMI IsNot Nothing Then WMI = Nothing
    End Function

    Public Function RunCmd(ByVal strCMD As String) As String
        Dim p As New Process
        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + strCMD
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()
        Dim result As String = p.StandardOutput.ReadToEnd()
        p.Close()
        Return result
    End Function
End Module
