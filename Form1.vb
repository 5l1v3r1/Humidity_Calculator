Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dry As Integer
        Dim wet As Integer
        Dim diff As Integer
        Dim result As Integer

        Dim DataLists()() = New Integer(40)() {}
        DataLists(0) = {80, 60, 40, 21, 3, 0, 0}
        DataLists(1) = {81, 62, 43, 25, 8, 0, 0}
        DataLists(2) = {82, 64, 46, 29, 12, 0, 0}
        DataLists(3) = {82, 65, 49, 32, 16, 1, 0}
        DataLists(4) = {83, 67, 51, 35, 20, 5, 0}
        DataLists(5) = {84, 68, 53, 38, 24, 9, 0}
        DataLists(6) = {85, 70, 55, 41, 27, 13, 0}
        DataLists(7) = {85, 71, 57, 43, 30, 17, 4}
        DataLists(8) = {86, 72, 59, 46, 33, 20, 8}
        DataLists(9) = {86, 73, 60, 48, 36, 24, 12}
        DataLists(10) = {87, 74, 62, 50, 38, 27, 16}
        DataLists(11) = {87, 75, 63, 52, 40, 29, 19}
        DataLists(12) = {88, 76, 65, 53, 43, 32, 23}
        DataLists(13) = {88, 77, 65, 55, 45, 34, 25}
        DataLists(14) = {89, 78, 67, 57, 46, 37, 27}
        DataLists(15) = {89, 78, 68, 58, 48, 39, 30}
        DataLists(16) = {89, 79, 69, 59, 50, 41, 32}
        DataLists(17) = {90, 80, 70, 61, 51, 43, 34}
        DataLists(18) = {90, 80, 71, 62, 53, 44, 36}
        DataLists(19) = {90, 81, 72, 63, 54, 46, 38}
        DataLists(20) = {91, 81, 73, 64, 56, 48, 40}
        DataLists(21) = {91, 82, 73, 65, 57, 49, 42}
        DataLists(22) = {91, 82, 74, 66, 58, 50, 43}
        DataLists(23) = {91, 83, 75, 67, 59, 52, 44}
        DataLists(24) = {91, 83, 75, 68, 60, 53, 46}
        DataLists(25) = {92, 84, 76, 68, 61, 54, 47}
        DataLists(26) = {92, 84, 76, 69, 62, 55, 49}
        DataLists(27) = {92, 84, 77, 70, 63, 56, 50}
        DataLists(28) = {92, 85, 77, 70, 64, 57, 51}
        DataLists(29) = {92, 85, 78, 71, 64, 58, 52}
        DataLists(30) = {92, 85, 78, 72, 65, 59, 53}
        DataLists(31) = {93, 86, 79, 72, 66, 60, 54}
        DataLists(32) = {93, 86, 79, 73, 66, 61, 55}
        DataLists(33) = {93, 86, 80, 73, 67, 61, 56}
        DataLists(34) = {93, 86, 80, 74, 68, 62, 56}
        DataLists(35) = {93, 87, 80, 74, 68, 63, 57}
        DataLists(36) = {93, 87, 81, 75, 69, 63, 58}
        DataLists(37) = {93, 87, 81, 75, 69, 64, 59}
        DataLists(38) = {94, 87, 81, 75, 70, 64, 59}
        DataLists(39) = {94, 87, 82, 76, 70, 65, 60}
        DataLists(40) = {94, 88, 82, 76, 71, 66, 61}


        dry = TextBox1.Text
        wet = TextBox2.Text
        diff = dry - wet

        If diff < 7 Then
            Label5.Text = diff
            TextBox3.Text = DataLists(dry)(diff - 1)
        Else
            MessageBox.Show("ค่าผลต่างมากกกว่า 7 : ไม่พบข้อมูล", "Error")
        End If

       

















    End Sub
End Class
