Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Security.Policy
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Newtonsoft.Json.Linq
Namespace Geral
    Public Class Utilitario
        Public SistemaImplementado As String = "SCAE"
        Public Shared Function Converter_TimeSpan_Date_Time(TimeSpan As String) As String
            Dim mdtIniUnixDate As DateTime = New DateTime(1970, 1, 1, 0, 0, 0)
            Dim Data As DateTime = mdtIniUnixDate.AddSeconds(TimeSpan)
            Return Format(Data, "dd/MM/yyyy")
        End Function
        Public Shared Function Gerar_Time_Span_Data(Data As Date) As Long

            Dim dateTime1 As DateTime = New DateTime(1970, 1, 1, 0, 0, 0)
            Dim timeSpan As TimeSpan = Data - dateTime1
            Dim Str_Span As Long = timeSpan.TotalSeconds
            'Dim Resposta As Long = CLng(Str_Span)
            Return CLng(Str_Span)
        End Function
    End Class

End Namespace
Namespace Shopee
    Public Class Utilitário
        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Shared Function Gera_Time_Spam() As Integer
            Return DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        End Function
        Public Overloads Shared Function Gerar_Signature(partner_id As String, partnerKey As String, Caminho_APP As String) As String
            Dim _TimeSpan As Integer = Shopee.Utilitário.Gera_Time_Spam()
            Dim baseString As String = String.Format("{0}{1}{2}", partner_id, Caminho_APP, _TimeSpan)
            Using hmacsha256 As New System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(partnerKey))
                Dim hashBytes As Byte() = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(baseString))
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
            End Using

        End Function
        Public Overloads Shared Function Gerar_Signature(partner_id As String, partnerKey As String, Caminho_APP As String, AcessToken As String, Shopee_ID As String) As String
            Dim _TimeSpan As Integer = Shopee.Utilitário.Gera_Time_Spam()
            Dim baseString As String = String.Format("{0}{1}{2}{3}{4}", partner_id, Caminho_APP, _TimeSpan, AcessToken, Shopee_ID)
            Using hmacsha256 As New System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(partnerKey))
                Dim hashBytes As Byte() = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(baseString))
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
            End Using

        End Function
        Public Shared Function Comunicação_POST(Url As String, Body As Dictionary(Of String, Object)) As Stream

            Dim request As WebRequest = WebRequest.Create(Url)
            request.Method = "POST"
            request.ContentType = "application/json"
            Dim bodyJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(Body)
            Dim bodyBytes As Byte() = Encoding.UTF8.GetBytes(bodyJson)
            request.ContentLength = bodyBytes.Length
            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(bodyBytes, 0, bodyBytes.Length)
            End Using

            Dim response As WebResponse = request.GetResponse()
            Dim responseStream As Stream = response.GetResponseStream()
            Return responseStream

        End Function
        Public Shared Function Trata_Resposta_POST(response As Stream) As Token
            Dim _Token As New Token
            Try
                Dim reader As New StreamReader(response)
                Dim jsonResponse As String = reader.ReadToEnd()
                Console.WriteLine("Raw result: " & jsonResponse)
                Dim ret As JObject = JObject.Parse(jsonResponse)
            Catch ex As Exception

            End Try

            Return _Token
        End Function
        Public Shared Function Lista_Status_Pedido() As ArrayList
            Dim Resposta As New ArrayList

            Resposta.Add("Não pago")
            Resposta.Add("Pronto para envio")
            Resposta.Add("Processado")
            Resposta.Add("Concluído")
            Resposta.Add("Cancelado")
            Resposta.Add("Em cancelamento")
            Resposta.Add("Cancelado")
            Resposta.Add("Pagamento pendente da faturamento")
            Return Resposta
        End Function
        Public Shared Function Get_Status_Pedido(Status As String) As String
            Dim Resposta As String = ""
            Select Case Status
                Case = "Não pago"
                    Return "UNPAID"
                Case = "Pronto para envio"
                    Return "READY_TO_SHIP"
                Case = "Processado"
                    Return "PROCESSED"
                Case = "Enviado"
                    Return "SHIPPED"
                Case = "Concluído"
                    Return "COMPLETED"
                Case = "Em cancelamento"
                    Return "IN_CANCEL"
                Case = "Cancelado"
                    Return "CANCELLED"
                Case = "Pagamento pendente da faturamento"
                    Return "INVOICE_PENDING"
                Case Else
                    Return "READY_TO_SHIP"
            End Select

            Return Resposta
        End Function

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class

End Namespace

