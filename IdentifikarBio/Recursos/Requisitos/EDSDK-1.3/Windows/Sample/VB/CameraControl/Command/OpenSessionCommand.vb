'/******************************************************************************
'*                                                                             *
'*   PROJECT : EOS Digital Software Development Kit EDSDK                      *
'*      NAME : OpenSessionCommand.vb                                           *
'*                                                                             *
'*   Description: This is the Sample code to show the usage of EDSDK.          *
'*                                                                             *
'*                                                                             *
'*******************************************************************************
'*                                                                             *
'*   Written and developed by Camera Design Dept.53                            *
'*   Copyright Canon Inc. 2006 All Rights Reserved                             *
'*                                                                             *
'*******************************************************************************
'*   File Update Information:                                                  *
'*     DATE      Identify    Comment                                           *
'*   -----------------------------------------------------------------------   *
'*   06-03-22    F-001        create first version.                            *
'*                                                                             *
'******************************************************************************/

Option Explicit On
Imports System.Runtime.InteropServices

Public Class OpenSessionCommand
    Inherits Command

    Public Sub New(ByVal model As CameraModel)
        MyBase.new(model)
    End Sub

    '// Execute a command.	
    Public Overrides Function execute() As Boolean

        Dim err As Integer = EDS_ERR_OK

        '// Open session with remote camera.
        err = EdsOpenSession(VBSample.m_model.getCameraObject())


        '//Notify Error
        If err <> EDS_ERR_OK Then

            VBSample.m_model.notifyObservers(errr, err)

        End If
        Return True

    End Function

End Class
