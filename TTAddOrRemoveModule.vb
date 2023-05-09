Module TTAddOrRemoveModule

    Public Sub remove(lb As ListBox, lbRemoved As ListBox)
        If lb.SelectedIndex <> -1 Then

            'to collect removed items
            Dim removedItem = lb.SelectedItem
            If Not lbRemoved.Items.Contains(removedItem) Then
                lbRemoved.Items.Add(removedItem)
                lb.Items.RemoveAt(lb.SelectedIndex)
            End If

        End If

    End Sub



End Module
