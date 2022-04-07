Module [Public]
    Public Delay As Integer
    Public Notice
    Public LocalVersion
    Public Log

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
