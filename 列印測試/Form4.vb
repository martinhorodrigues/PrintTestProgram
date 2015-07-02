Public Class Form4

    Dim doc As String = "郭sir，目前先整理三個報表功能出來。" & _
                        "裡面有包含平台以後的規劃架構以及新增功能，可以再和你說明簡報內容 "

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '給定要列印的文件格式
        Me.PrintDialog1.Document = Me.PrintDocument1

        ''按下確定後開始列印
        'If Me.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        PrintDocument1.Print()
        'End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '設定文字格式
        Dim myFont As New Font("新明細體", 10, FontStyle.Regular)

        '確保文字不會被腰斬，我們預計最後一行不印文字，所以減去myFont.GetHeight(e.Graphics)
        Dim strSize As New Size(e.MarginBounds.Width, e.MarginBounds.Height - myFont.GetHeight(e.Graphics))

        '確保文字(英文單字)不會被分成兩行
        Dim strFormat As New StringFormat
        strFormat.Trimming = StringTrimming.Word

        '取得文字行數
        Dim lines As Integer '= e.MarginBounds.Height / myFont.GetHeight(e.Graphics)
        '取得文字字數
        Dim count As Integer ' = e.MarginBounds.Width / myFont.Size * lines
        ''計算doc(要列印的文字)在myFont以及strSize的規定下，一頁最多可以放多少文字
        e.Graphics.MeasureString(doc, myFont, strSize, strFormat, count, lines)

        'e.Graphics.DrawString(列印文字字數, 字型 , 字型色彩,  可列印範圍, 文字屬性)
        e.Graphics.DrawString(doc.Substring(0, count), myFont, Brushes.Black, e.MarginBounds, strFormat)

        '檢查有幾頁要印
        If count < doc.Length Then
            'e.HasMorePages是否還有要再列印的文字
            e.HasMorePages = True
            '去除掉已經列印過的文字
            doc = doc.Substring(count, doc.Length - count)
        Else
            e.HasMorePages = False
        End If
    End Sub
End Class