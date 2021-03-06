﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("COM4")>  _
        Public Property IncomingCOMPort() As String
            Get
                Return CType(Me("IncomingCOMPort"),String)
            End Get
            Set
                Me("IncomingCOMPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10.0.0.255")>  _
        Public Property UDP1() As String
            Get
                Return CType(Me("UDP1"),String)
            End Get
            Set
                Me("UDP1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.0.255")>  _
        Public Property UDP2() As String
            Get
                Return CType(Me("UDP2"),String)
            End Get
            Set
                Me("UDP2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10.10.10.255")>  _
        Public Property UDP3() As String
            Get
                Return CType(Me("UDP3"),String)
            End Get
            Set
                Me("UDP3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.255.255")>  _
        Public Property UDP4() As String
            Get
                Return CType(Me("UDP4"),String)
            End Get
            Set
                Me("UDP4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("99")>  _
        Public Property LocationCode() As String
            Get
                Return CType(Me("LocationCode"),String)
            End Get
            Set
                Me("LocationCode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP1Enabled() As Boolean
            Get
                Return CType(Me("UDP1Enabled"),Boolean)
            End Get
            Set
                Me("UDP1Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP2Enabled() As Boolean
            Get
                Return CType(Me("UDP2Enabled"),Boolean)
            End Get
            Set
                Me("UDP2Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP3Enabled() As Boolean
            Get
                Return CType(Me("UDP3Enabled"),Boolean)
            End Get
            Set
                Me("UDP3Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP4Enabled() As Boolean
            Get
                Return CType(Me("UDP4Enabled"),Boolean)
            End Get
            Set
                Me("UDP4Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("m:ss.ff")>  _
        Public Property TestTimerFormat() As String
            Get
                Return CType(Me("TestTimerFormat"),String)
            End Get
            Set
                Me("TestTimerFormat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("hh:mm:ss")>  _
        Public Property TestClockFormat() As String
            Get
                Return CType(Me("TestClockFormat"),String)
            End Get
            Set
                Me("TestClockFormat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10542")>  _
        Public Property UDP1Port() As String
            Get
                Return CType(Me("UDP1Port"),String)
            End Get
            Set
                Me("UDP1Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10542")>  _
        Public Property UDP2Port() As String
            Get
                Return CType(Me("UDP2Port"),String)
            End Get
            Set
                Me("UDP2Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10542")>  _
        Public Property UDP3Port() As String
            Get
                Return CType(Me("UDP3Port"),String)
            End Get
            Set
                Me("UDP3Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10542")>  _
        Public Property UDP4Port() As String
            Get
                Return CType(Me("UDP4Port"),String)
            End Get
            Set
                Me("UDP4Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7124")>  _
        Public Property UDPListenPort() As String
            Get
                Return CType(Me("UDPListenPort"),String)
            End Get
            Set
                Me("UDPListenPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDPListenEnabled() As Boolean
            Get
                Return CType(Me("UDPListenEnabled"),Boolean)
            End Get
            Set
                Me("UDPListenEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property COMPortEnabled() As Boolean
            Get
                Return CType(Me("COMPortEnabled"),Boolean)
            End Get
            Set
                Me("COMPortEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SourceCOM() As Boolean
            Get
                Return CType(Me("SourceCOM"),Boolean)
            End Get
            Set
                Me("SourceCOM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SourceUDP() As Boolean
            Get
                Return CType(Me("SourceUDP"),Boolean)
            End Get
            Set
                Me("SourceUDP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SourceTestClock() As Boolean
            Get
                Return CType(Me("SourceTestClock"),Boolean)
            End Get
            Set
                Me("SourceTestClock") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SourceTestTimer() As Boolean
            Get
                Return CType(Me("SourceTestTimer"),Boolean)
            End Get
            Set
                Me("SourceTestTimer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("55")>  _
        Public Property UDP5() As String
            Get
                Return CType(Me("UDP5"),String)
            End Get
            Set
                Me("UDP5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("66")>  _
        Public Property UDP6() As String
            Get
                Return CType(Me("UDP6"),String)
            End Get
            Set
                Me("UDP6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("77")>  _
        Public Property UDP7() As String
            Get
                Return CType(Me("UDP7"),String)
            End Get
            Set
                Me("UDP7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("88")>  _
        Public Property UDP8() As String
            Get
                Return CType(Me("UDP8"),String)
            End Get
            Set
                Me("UDP8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("555")>  _
        Public Property UDP5Port() As String
            Get
                Return CType(Me("UDP5Port"),String)
            End Get
            Set
                Me("UDP5Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("666")>  _
        Public Property UDP6Port() As String
            Get
                Return CType(Me("UDP6Port"),String)
            End Get
            Set
                Me("UDP6Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("777")>  _
        Public Property UDP7Port() As String
            Get
                Return CType(Me("UDP7Port"),String)
            End Get
            Set
                Me("UDP7Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("888")>  _
        Public Property UDP8Port() As String
            Get
                Return CType(Me("UDP8Port"),String)
            End Get
            Set
                Me("UDP8Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP5Enabled() As Boolean
            Get
                Return CType(Me("UDP5Enabled"),Boolean)
            End Get
            Set
                Me("UDP5Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP6Enabled() As Boolean
            Get
                Return CType(Me("UDP6Enabled"),Boolean)
            End Get
            Set
                Me("UDP6Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP7Enabled() As Boolean
            Get
                Return CType(Me("UDP7Enabled"),Boolean)
            End Get
            Set
                Me("UDP7Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UDP8Enabled() As Boolean
            Get
                Return CType(Me("UDP8Enabled"),Boolean)
            End Get
            Set
                Me("UDP8Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("RUK:")>  _
        Public Property Destination1() As String
            Get
                Return CType(Me("Destination1"),String)
            End Get
            Set
                Me("Destination1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination2() As String
            Get
                Return CType(Me("Destination2"),String)
            End Get
            Set
                Me("Destination2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination3() As String
            Get
                Return CType(Me("Destination3"),String)
            End Get
            Set
                Me("Destination3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination4() As String
            Get
                Return CType(Me("Destination4"),String)
            End Get
            Set
                Me("Destination4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination5() As String
            Get
                Return CType(Me("Destination5"),String)
            End Get
            Set
                Me("Destination5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination6() As String
            Get
                Return CType(Me("Destination6"),String)
            End Get
            Set
                Me("Destination6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination7() As String
            Get
                Return CType(Me("Destination7"),String)
            End Get
            Set
                Me("Destination7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Destination8() As String
            Get
                Return CType(Me("Destination8"),String)
            End Get
            Set
                Me("Destination8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property RepeatCount() As String
            Get
                Return CType(Me("RepeatCount"),String)
            End Get
            Set
                Me("RepeatCount") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property RepeatInterval() As String
            Get
                Return CType(Me("RepeatInterval"),String)
            End Get
            Set
                Me("RepeatInterval") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TimingServer.My.MySettings
            Get
                Return Global.TimingServer.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
