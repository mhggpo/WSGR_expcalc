Class MainWindow
    Dim expfrom, expto, needexp, onceexp, onceexp1, onceexp2, times As Long
    Dim jianniangexp(111) As Long
    Dim flagship, train, mvp, shengjian, bread, laibixi, ke, baiyan, baiyane, baiyannoe, lanli, lanliu, lanlinou, xiangqu As Boolean

    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        End
    End Sub
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        MsgBox("程序开发:mhggpo 0v0" & vbCrLf & "经验表来源于舰Rwiki,感谢dalao 0v0" & vbCrLf & "计算原理来自舰少资料库,感谢dalao 0v0" & vbCrLf & "软件最新版本参见台服吧 0v0", vbInformation, "昆昆提示")
    End Sub

    Dim showtext1, showtext2, showtext3, stage As String

    Private Sub bread1_Checked(sender As Object, e As RoutedEventArgs) Handles bread1.Checked
        baiyan1.IsChecked = False
        baiyan1.IsEnabled = False
    End Sub
    Private Sub bread1_unChecked(sender As Object, e As RoutedEventArgs) Handles bread1.Unchecked
        If (xiangqu1.IsChecked = False) Then
            baiyan1.IsEnabled = True
        End If
    End Sub
    Private Sub baiyan1_Checked(sender As Object, e As RoutedEventArgs) Handles baiyan1.Checked
        radioButton5.IsEnabled = True
        radioButton6.IsEnabled = True
        xiangqu1.IsChecked = False
        xiangqu1.IsEnabled = False
        bread1.IsChecked = False
        bread1.IsEnabled = False
    End Sub
    Private Sub baiyan1_Unchecked(sender As Object, e As RoutedEventArgs) Handles baiyan1.Unchecked
        radioButton5.IsEnabled = False
        radioButton6.IsEnabled = False
        xiangqu1.IsEnabled = True
        bread1.IsEnabled = True
    End Sub
    Private Sub xiangqu1_Checked(sender As Object, e As RoutedEventArgs) Handles xiangqu1.Checked
        baiyan1.IsChecked = False
        baiyan1.IsEnabled = False
    End Sub
    Private Sub xiangqu1_unChecked(sender As Object, e As RoutedEventArgs) Handles xiangqu1.Unchecked
        If (bread1.IsChecked = False) Then
            baiyan1.IsEnabled = True
        End If
    End Sub
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        jianniangexp(0) = 0
        jianniangexp(1) = 0
        jianniangexp(2) = 100
        jianniangexp(3) = 300
        jianniangexp(4) = 600
        jianniangexp(5) = 1000
        jianniangexp(6) = 1500
        jianniangexp(7) = 2100
        jianniangexp(8) = 2800
        jianniangexp(9) = 3600
        jianniangexp(10) = 4500
        jianniangexp(11) = 5500
        jianniangexp(12) = 6600
        jianniangexp(13) = 7800
        jianniangexp(14) = 9100
        jianniangexp(15) = 10500
        jianniangexp(16) = 12000
        jianniangexp(17) = 13600
        jianniangexp(18) = 15300
        jianniangexp(19) = 17100
        jianniangexp(20) = 19000
        jianniangexp(21) = 21000
        jianniangexp(22) = 23100
        jianniangexp(23) = 25300
        jianniangexp(24) = 27600
        jianniangexp(25) = 30000
        jianniangexp(26) = 32500
        jianniangexp(27) = 35100
        jianniangexp(28) = 37800
        jianniangexp(29) = 40600
        jianniangexp(30) = 43500
        jianniangexp(31) = 46500
        jianniangexp(32) = 49600
        jianniangexp(33) = 52800
        jianniangexp(34) = 56100
        jianniangexp(35) = 59500
        jianniangexp(36) = 63000
        jianniangexp(37) = 66600
        jianniangexp(38) = 70300
        jianniangexp(39) = 74100
        jianniangexp(40) = 78000
        jianniangexp(41) = 82000
        jianniangexp(42) = 86100
        jianniangexp(43) = 90300
        jianniangexp(44) = 94600
        jianniangexp(45) = 99000
        jianniangexp(46) = 103500
        jianniangexp(47) = 108100
        jianniangexp(48) = 112800
        jianniangexp(49) = 117600
        jianniangexp(50) = 122500
        jianniangexp(51) = 127500
        jianniangexp(52) = 132700
        jianniangexp(53) = 138100
        jianniangexp(54) = 143700
        jianniangexp(55) = 149500
        jianniangexp(56) = 155500
        jianniangexp(57) = 161700
        jianniangexp(58) = 168100
        jianniangexp(59) = 174700
        jianniangexp(60) = 181500
        jianniangexp(61) = 188500
        jianniangexp(62) = 195800
        jianniangexp(63) = 203400
        jianniangexp(64) = 211300
        jianniangexp(65) = 219600
        jianniangexp(66) = 228300
        jianniangexp(67) = 237400
        jianniangexp(68) = 247000
        jianniangexp(69) = 257100
        jianniangexp(70) = 267800
        jianniangexp(71) = 279100
        jianniangexp(72) = 291100
        jianniangexp(73) = 303800
        jianniangexp(74) = 317300
        jianniangexp(75) = 331700
        jianniangexp(76) = 347000
        jianniangexp(77) = 363300
        jianniangexp(78) = 380700
        jianniangexp(79) = 399300
        jianniangexp(80) = 419100
        jianniangexp(81) = 440200
        jianniangexp(82) = 462700
        jianniangexp(83) = 486700
        jianniangexp(84) = 512300
        jianniangexp(85) = 539600
        jianniangexp(86) = 568700
        jianniangexp(87) = 599700
        jianniangexp(88) = 632700
        jianniangexp(89) = 667900
        jianniangexp(90) = 705400
        jianniangexp(91) = 745300
        jianniangexp(92) = 787700
        jianniangexp(93) = 832800
        jianniangexp(94) = 880700
        jianniangexp(95) = 931600
        jianniangexp(96) = 985600
        jianniangexp(97) = 1042800
        jianniangexp(98) = 1103400
        jianniangexp(99) = 1167600
        jianniangexp(100) = 1235500
        jianniangexp(101) = 1307300
        jianniangexp(102) = 1379100
        jianniangexp(103) = 1450900
        jianniangexp(104) = 1522700
        jianniangexp(105) = 1594500
        jianniangexp(106) = 1666300
        jianniangexp(107) = 1738100
        jianniangexp(108) = 1809900
        jianniangexp(109) = 1881700
        jianniangexp(110) = 1953500
        If Val(textBoxfrom.Text) >= 1 And Val(textBoxfrom.Text) <= Val(textBoxto.Text) Then
        Else
            MsgBox(“输入有误，请重新输入！”, vbInformation)
            Exit Sub
        End If
        If Val(textBoxto.Text) <= 110 And Val(textBoxfrom.Text) <= Val(textBoxto.Text) Then
        Else
            MsgBox(“输入有误，请重新输入！”, vbInformation)
            Exit Sub
        End If
        If Val(mvpcalc.Text) >= 0 And Val(mvpcalc.Text) <= 100 Then
        Else
            MsgBox(“输入有误，请重新输入！”, vbInformation)
            Exit Sub
        End If
        If (CInt(textBoxfrom.Text) > 110) Then
            MsgBox("FA♂Q", vbCritical)
            textBoxfrom.Text = 1
        End If
        If (CInt(textBoxto.Text) > 110) Then
            MsgBox("FA♂Q", vbCritical)
            textBoxto.Text = 110
        End If
        Dim level2 As Integer
        level2 = comboBox.SelectedIndex
        Select Case level2
            Case 0
                stage = "1-1"
                onceexp = 30
            Case 1
                stage = "1-2"
                onceexp = 50
            Case 2
                stage = "1-3"
                onceexp = 80
            Case 3
                stage = "1-4"
                onceexp = 120
            Case 4
                stage = "1-5"
                onceexp = 1
                MsgBox("兄弟你何苦为难自己呢，苦海无涯，回头是岸啊！", vbExclamation, “唉”)
                End
            Case 5
                stage = "2-1"
                onceexp = 100
            Case 6
                stage = "2-2"
                onceexp = 120
            Case 7
                stage = "2-3"
                onceexp = 150
            Case 8
                stage = "2-4"
                onceexp = 200
            Case 9
                stage = "2-5"
                onceexp = 400
            Case 10
                stage = "2-6"
                onceexp = 420
            Case 11
                stage = "3-1"
                onceexp = 150
            Case 12
                stage = "3-2"
                onceexp = 180
            Case 13
                stage = "3-3"
                onceexp = 220
            Case 14
                stage = "3-4"
                onceexp = 300
            Case 15
                stage = "4-1"
                onceexp = 250
            Case 16
                stage = "4-2"
                onceexp = 300
            Case 17
                stage = "4-3"
                onceexp = 330
            Case 18
                stage = "4-4"
                onceexp = 360
            Case 19
                stage = "5-1"
                onceexp = 350
            Case 20
                stage = "5-2"
                onceexp = 370
            Case 21
                stage = "5-3"
                onceexp = 400
            Case 22
                stage = "5-4"
                onceexp = 420
            Case 23
                stage = "5-5"
                onceexp = 450
            Case 24
                stage = "6-1"
                onceexp = 400
            Case 25
                stage = "6-2"
                onceexp = 410
            Case 26
                stage = "6-3"
                onceexp = 420
            Case 27
                stage = "6-4"
                onceexp = 500
            Case 28
                stage = "7-1"
                onceexp = 450
            Case 29
                stage = "7-2"
                onceexp = 480
            Case 30
                stage = "7-3"
                onceexp = 520
            Case 31
                stage = "7-4"
                onceexp = 560
            Case 32
                stage = "7-5"
                onceexp = 560
            Case 33
                stage = "自定义"
                Dim temp1 As String
Input1:
                temp1 = InputBox("请输入关卡基础经验(即A胜经验)", "昆昆提示")
                If temp1 = "" Then MsgBox("哼，居然想用空白的条件来忽悠昆西╭(╯^╰)╮，不可原谅！", vbInformation) : GoTo Input1
                If temp1 = "0" Then MsgBox("昆昆才不会被骗去1-5吃土呢！", vbInformation) : GoTo Input1
                onceexp = Val(temp1)
                If onceexp = 0 Then MsgBox("昆昆才不会被骗去1-5吃土呢！", vbInformation) : GoTo Input1
            Case 34
                stage = "历史战役(困难)"
                onceexp = 333
        End Select
        Dim showtext4 As String
        Dim winrate As Integer
        winrate = comboBox1.SelectedIndex
        Select Case winrate
            Case 0
                showtext4 = "SS或S"
                onceexp = onceexp * 1.2
            Case 1
                showtext4 = "A"
                onceexp = onceexp * 1
            Case 2
                showtext4 = "B"
                onceexp = onceexp * 0.8
            Case 3
                showtext4 = "C"
                onceexp = onceexp * 0.7
            Case 4
                showtext4 = "D"
                onceexp = onceexp * 0.5
        End Select
        expfrom = jianniangexp(CInt(textBoxfrom.Text))
        expto = jianniangexp(CInt(textBoxto.Text))
        needexp = expto - expfrom
        flagship = flagship1.IsChecked
        mvp = mvp1.IsChecked
        shengjian = shengjian1.IsChecked
        train = train1.IsChecked
        laibixi = laibixi1.IsChecked
        bread = bread1.IsChecked
        ke = ke1.IsChecked
        baiyan = baiyan1.IsChecked
        baiyane = radioButton5.IsChecked And radioButton5.IsEnabled
        baiyannoe = radioButton6.IsChecked And radioButton6.IsEnabled
        xiangqu = xiangqu1.IsChecked And xiangqu1.IsEnabled
        If (flagship And Not mvp) Then
            onceexp = onceexp * 1.5
        ElseIf (Not flagship And mvp) Then
            onceexp1 = onceexp * 2
            onceexp2 = ((onceexp1 * Val(mvpcalc.Text)) + (onceexp * (100 - (Val(mvpcalc.Text))))) * 0.01
            onceexp = onceexp2
        ElseIf (flagship And mvp) Then
            onceexp1 = onceexp * 2
            onceexp2 = ((onceexp1 * Val(mvpcalc.Text)) + (onceexp * (100 - (Val(mvpcalc.Text))))) * 0.01
            onceexp = onceexp2 * 1.5
        End If
        If (train) Then
            onceexp = onceexp * 1.07
        End If
        If (laibixi) Then
            onceexp = onceexp * 1.1
        End If
        If (bread) Then
            onceexp = onceexp * 1.1
        End If
        If (ke) Then
            onceexp = onceexp * 2
        End If
        If (baiyan And baiyane) Then
            onceexp = onceexp * 1.1
        End If
        If (baiyan And baiyannoe) Then
            onceexp = onceexp * 1.06
        End If
        If (xiangqu) Then
            onceexp = onceexp * 1.07
        End If
        If (flagship) Then
            showtext1 = "旗舰"
        Else
            showtext1 = ""
        End If
        If (mvp) Then
            showtext2 = "MVP概率" & mvpcalc.Text & "%"
        Else
            showtext2 = ""
        End If
        If (shengjian) Then
            onceexp = onceexp * 1.5
            showtext3 = "经验加成15%"
        Else
            showtext3 = ""
        End If
        times = needexp / onceexp
        MsgBox("充满智慧的昆西掐指一算：" & "由等级" & textBoxfrom.Text & "升级至" & textBoxto.Text & "，共需经验值" & needexp & vbCrLf & "刷" & stage & "关卡的单个节点，在保持" & showtext1 & showtext2 & showtext3 & "战后" & showtext4 & "评价前提下," & vbCrLf & "一次经验" & onceexp & "，需要次数：" & times, vbInformation, "昆昆提示")
    End Sub
End Class