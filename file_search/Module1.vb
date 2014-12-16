Module Module1

    Sub Main(args As String())
        If args.Length = 0 Then
            Dim frm As New Form1
            Application.Run(frm)
        Else
            Dim arg As String
            For Each arg In args
                Console.WriteLine(arg)
            Next
            If args.Length = 1 Then

            End If
        End If

    End Sub

End Module
