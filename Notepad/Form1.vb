Public Class Notepad
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i As Integer = TextBox1.SelectionStart
        TextBox1.Text = Replace(TextBox1.Text, "network protection", "鬋鯫鯚蓩鬐鶤鶐蓩炾笀耔蓩蜭蜸蓩鋑憵懥")
        TextBox1.Text = Replace(TextBox1.Text, "security", "secuwity")
        TextBox1.Text = Replace(TextBox1.Text, "support", "摮迗俀侹椼毸溠螾褾賹迗俀,鬋鯫鯚鬐鶤鶐炾笀耔蜭蜸鋑,鞮鞢騉緱翬膞忷扴汥趛踠跬僣礛簼繰觶譈譀燛獧,膣塨塛牣犿玒翍脝艴,倓剟暕粞絧絏餈餖駜醳鏻鐆怲杶釂鱞鸄玾珆玸繠繗繓蜙,銙曏樴橉孻憵懥佹侁刵禊禓僣劁嘕蠛趯躎綧儴壛,誙箷箯緷鏊鏎顜蒘蝆蜪胲胵歅毼毹鬖鰝鰨蕍蕧螛渳湥綒賗褁觛禖穊稯裍裚詷,觶譈銇韎餀蚔趵郚幨懅憴廞")
        TextBox1.Text = Replace(TextBox1.Text, "year", "鶐炾笀耔")
        TextBox1.Text = Replace(TextBox1.Text, "koobface", "yo momma")
        TextBox1.Text = Replace(TextBox1.Text, "zeus", "yo momma")
        TextBox1.Text = Replace(TextBox1.Text, "clampi", "yo momma")
        TextBox1.Text = Replace(TextBox1.Text, "f-secure", "clamav")
        TextBox1.Text = Replace(TextBox1.Text, "avg", "mse")
        TextBox1.Text = Replace(TextBox1.Text, "avast", "avg")
        TextBox1.Text = Replace(TextBox1.Text, "norton", "avg")
        TextBox1.Text = Replace(TextBox1.Text, "antivirus", "antiwirus")
        TextBox1.Text = Replace(TextBox1.Text, "desktop", "dextop")
        TextBox1.Text = Replace(TextBox1.Text, "virus", "wirus")
        TextBox1.Text = Replace(TextBox1.Text, "name", "Would a rose by any other, smell as sweet?")
        TextBox1.Text = Replace(TextBox1.Text, "lifetime", "but what if i die?")
        TextBox1.Text = Replace(TextBox1.Text, "CVV", "seeweewee")
        TextBox1.Text = Replace(TextBox1.Text, "$", "§")
        TextBox1.Text = Replace(TextBox1.Text, "bingo", "BING0!!!!1 YOU ARE SCAMMER!!!1 CONGRATULATIONS XD")
        TextBox1.Text = Replace(TextBox1.Text, "firewall", "")
        TextBox1.Text = Replace(TextBox1.Text, "hackers", "like you are benchod?")
        TextBox1.Text = Replace(TextBox1.Text, "network", "are you a network technician")

        If TextBox1.Text.Contains("email") Or TextBox1.Text.Contains("e-mail") Then
            BSOD.Show()
        End If

        If TextBox1.Text.Contains("password") Then
            TextBox1.PasswordChar = "•"
        Else
            TextBox1.PasswordChar = ""
        End If
        TextBox1.SelectionStart = i

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        MsgBox("No printer installed. ", MsgBoxStyle.Critical, "Print Spooler")
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        MsgBox("No printer installed. ", MsgBoxStyle.Critical, "Print Spooler")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Try
            IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
            Me.Text = (SaveFileDialog1.FileName & " - Notepad")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        TextBox1.Text = TextBox1.Text & My.Computer.Clock.GmtTime
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    Private Sub AboutNotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNotepadToolStripMenuItem.Click
        Process.Start("http://www.youareanidiot.org")
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Process.Start("http://www.youareanidiot.org")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.Select(0, TextBox1.Text.Length)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Me.Text = ("Untitled - Notepad")
        TextBox1.Text = ("")
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        WordWrapToolStripMenuItem.Checked = Not WordWrapToolStripMenuItem.Checked
        TextBox1.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub
End Class
