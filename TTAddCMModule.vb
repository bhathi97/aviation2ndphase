

Module TTAddCMModule
    Public Sub addCM(lb As List(Of String), dgv As DataGridViewComboBoxColumn)

        ' Get the item count of the ListBox
        Dim itemCount As Integer = lb.Count

        ' Get the total number of rows in the DataGridView
        Dim rowCount As Integer = dgv.DataGridView.Rows.Count

        ' Calculate the number of full ranges
        Dim rangeCount As Integer = Math.Floor(rowCount / itemCount)

        ' Calculate the remaining rows
        Dim remainingRows As Integer = rowCount Mod itemCount

        ' Loop through each full range
        For i As Integer = 0 To rangeCount - 1
            ' Get the starting index for the current range
            Dim startIndex As Integer = i * itemCount

            ' Loop through each item in the ListBox
            For j As Integer = 0 To lb.Count - 1


                'MsgBox(lb(j))

                ' Calculate the index of the current DataGridView row
                Dim rowIndex As Integer = startIndex + j

                'MsgBox(rowIndex.ToString + dgv.Index.ToString)

                ' Set the value of the cell at the specified rowIndex and columnIndex
                Dim cell As DataGridViewComboBoxCell = dgv.DataGridView.Rows(rowIndex).Cells(dgv.Index)

                If cell.Value Is Nothing Then
                    cell.Value = lb(j)
                End If
            Next
        Next

        ' Loop through the remaining rows
        If remainingRows > 0 Then
            ' Get the starting index for the remaining rows
            Dim startIndex As Integer = rangeCount * itemCount

            ' Loop through each item in the ListBox
            For j As Integer = 0 To lb.Count - 1
                ' Calculate the index of the current DataGridView row
                Dim rowIndex As Integer = startIndex + j

                ' Set the value of the cell at the specified rowIndex and columnIndex
                If rowIndex < rowCount Then
                    Dim cell As DataGridViewComboBoxCell = dgv.DataGridView.Rows(rowIndex).Cells(dgv.Index)
                    If cell.Value Is Nothing Then
                        cell.Value = lb(j)
                    End If
                End If
            Next
        End If
    End Sub









End Module
