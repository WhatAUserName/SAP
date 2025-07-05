Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class Exporter

    Public Shared Sub ExportToExcel()
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()

            Dim query As String = "SELECT p.code AS code, p.name AS name, p.quantity AS quantity, p.price AS price FROM [dbo].[products] AS p JOIN [dbo].[category] AS c ON p.categoryId = c.id"
            Dim cmd As New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            da.Fill(dataTable)

            ' Start Excel
            Dim xlApp As New Excel.Application
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add()
            Dim workSheet As Excel.Worksheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

            ' Write column headers or fields
            For col As Integer = 0 To dataTable.Columns.Count - 1
                workSheet.Cells(1, col + 1) = dataTable.Columns(col).ColumnName
            Next

            Dim sum As Integer = 0
            ' Write data / value in each cell
            For row As Integer = 0 To dataTable.Rows.Count - 1
                For col As Integer = 0 To dataTable.Columns.Count - 1
                    workSheet.Cells(row + 2, col + 1) = dataTable.Rows(row)(col).ToString()
                Next
                sum = (CType(dataTable.Rows(row)(2), Integer) * CType(dataTable.Rows(row)(dataTable.Columns.Count - 1), Integer)) + sum
                workSheet.Cells(row + 3, dataTable.Columns.Count) = sum
            Next

            ' Save file
            Dim savePath As String = "c:\users\user\downloads\Products.xlsx"
            xlWorkBook.SaveAs(savePath)
            xlWorkBook.Close()
            xlApp.Quit()

            MessageBox.Show("Data exported to Excel successfully!")

            ' Clean up for garbage collection
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(workSheet)

        Catch ex As Exception
            MsgBox("Please close any open instance excel file before exporting.")
            Return
        Finally
            conn.Close()
        End Try


    End Sub

    Private Shared Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class