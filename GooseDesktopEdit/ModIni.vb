'读取ini文件
Imports System.IO

Module ModIni
    ''' <summary>
    ''' 从
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetValueFromIniByKey(ByVal key As String)
        Dim LenKey As Integer = Len(key)
        Dim SR As New StreamReader(Goose.ConfigIniPath)
        While (SR.Peek >= 0)
            Dim L As String = SR.ReadLine
            If Microsoft.VisualBasic.Left(L, LenKey) = key Then
                Dim value As String = L.Split("=")(1)
                SR.Close()
                Return value
            End If
        End While
    End Function

    Public Function WriteStruToIni()
        Dim WStr As String = "Version_DoNotEdit=1" & vbCrLf &
            "EnableMods=" + GooseConfig.EnableMods & vbCrLf &
            "SilenceSounds=" + GooseConfig.SilenceSounds & vbCrLf &
            "Task_CanAttackMouse=" + GooseConfig.Task_CanAttackMouse & vbCrLf &
            "AttackRandomly=" + GooseConfig.AttackRandomly & vbCrLf &
            "UseCustomColors=" + GooseConfig.UseCustomColors & vbCrLf &
            "GooseDefaultWhite=" + GooseConfig.GooseDefaultWhite & vbCrLf &
            "GooseDefaultOrange=" + GooseConfig.GooseDefaultOrange & vbCrLf &
            "GooseDefaultOutline=" + GooseConfig.GooseDefaultOutline & vbCrLf &
            "MinWanderingTimeSeconds=" + GooseConfig.MinWanderingTimeSeconds & vbCrLf &
            "MaxWanderingTimeSeconds=" + GooseConfig.MaxWanderingTimeSeconds & vbCrLf &
            "FirstWanderTimeSeconds=" + GooseConfig.FirstWanderTimeSeconds
        Dim SW As New StreamWriter(Goose.ConfigIniPath)
        SW.Write(WStr)
        SW.Close()
    End Function
End Module