Imports System.IO

Module ModEverything
    Public Declare Function Everything_SetSearchA Lib "Everything64.dll" (ByVal search As String) As UInt32
    Public Declare Function Everything_SetRequestFlags Lib "Everything64.dll" (ByVal dwRequestFlags As UInt32) As UInt32
    Public Declare Function Everything_QueryA Lib "Everything64.dll" (ByVal bWait As Integer) As Integer
    Public Declare Function Everything_GetNumResults Lib "Everything64.dll" () As UInt32
    Public Declare Function Everything_GetResultFileNameA Lib "Everything64.dll" (ByVal index As UInt32) As String
    Public Declare Function Everything_GetLastError Lib "Everything64.dll" () As UInt32
    Public Declare Function Everything_GetResultFullPathNameA Lib "Everything64.dll" (ByVal index As UInt32, ByVal buf As System.Text.StringBuilder, ByVal size As UInt32) As UInt32
    Public Declare Function Everything_GetResultSize Lib "Everything64.dll" (ByVal index As UInt32, ByRef size As UInt64) As Integer
    Public Declare Function Everything_GetResultDateModified Lib "Everything64.dll" (ByVal index As UInt32, ByRef ft As UInt64) As Integer

    Public Const EVERYTHING_REQUEST_FILE_NAME = &H1
    Public Const EVERYTHING_REQUEST_PATH = &H2
    Public Const EVERYTHING_REQUEST_FULL_PATH_AND_FILE_NAME = &H4
    Public Const EVERYTHING_REQUEST_EXTENSION = &H8
    Public Const EVERYTHING_REQUEST_SIZE = &H10
    Public Const EVERYTHING_REQUEST_DATE_CREATED = &H20
    Public Const EVERYTHING_REQUEST_DATE_MODIFIED = &H40
    Public Const EVERYTHING_REQUEST_DATE_ACCESSED = &H80
    Public Const EVERYTHING_REQUEST_ATTRIBUTES = &H100
    Public Const EVERYTHING_REQUEST_FILE_LIST_FILE_NAME = &H200
    Public Const EVERYTHING_REQUEST_RUN_COUNT = &H400
    Public Const EVERYTHING_REQUEST_DATE_RUN = &H800
    Public Const EVERYTHING_REQUEST_DATE_RECENTLY_CHANGED = &H1000
    Public Const EVERYTHING_REQUEST_HIGHLIGHTED_FILE_NAME = &H2000
    Public Const EVERYTHING_REQUEST_HIGHLIGHTED_PATH = &H4000
    Public Const EVERYTHING_REQUEST_HIGHLIGHTED_FULL_PATH_AND_FILE_NAME = &H8000


    Public Function SearchGooseExePath()
        Everything_SetSearchA("GooseDesktop.exe")
        Everything_SetRequestFlags(EVERYTHING_REQUEST_FILE_NAME Or EVERYTHING_REQUEST_PATH Or EVERYTHING_REQUEST_SIZE Or EVERYTHING_REQUEST_DATE_MODIFIED)
        Everything_QueryA(1)

        Dim NumResults As UInt32
        Dim filename As New System.Text.StringBuilder(260)

        NumResults = Everything_GetNumResults()

        If NumResults > 0 Then
            Everything_GetResultFullPathNameA(0, filename, filename.Capacity)

            Dim p As String = System.IO.Path.GetDirectoryName(filename.ToString())
            If Microsoft.VisualBasic.Right(p, 1) <> "\" Then
                p += "\"
            End If

            If System.IO.File.Exists(p + "config.ini") Then
                If System.IO.File.Exists(p + "GooseModdingAPI.dll") Then
                    If System.IO.Directory.Exists(p + "Assets") Then
                        Goose.DirPath = p
                        Return True
                    End If
                End If
            End If
        End If

        Return False
    End Function
End Module
