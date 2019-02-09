Class MainWindow
    Dim expfrom, expto, needexp, onceexp, onceexp1, onceexp2, times As Long
    Dim jianniangexp(111) As Long
    Dim tiduexp(252) As Long
    Dim flagship, train, mvp, shengjian, bread, laibixi, ke, baiyan, baiyane, baiyannoe, lanli, lanliu, lanlinou, xiangqu As Boolean

    Private Sub button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click
        MsgBox("接下来会打开本软件的Github页面，请按页面提示寻找软件最新版本哦！ 0v0", vbInformation, "昆昆提示")
        System.Diagnostics.Process.Start("https://github.com/mhggpo/WSGR_expcalc")
    End Sub

    Private Sub type1_Checked(sender As Object, e As RoutedEventArgs) Handles type1.Checked
        textBoxto.Text = "110"
    End Sub

    Private Sub type2_Checked(sender As Object, e As RoutedEventArgs) Handles type2.Checked
        MsgBox("提督经验不受任何加成哦！ 0v0" & vbCrLf & "(当前版本提督等级上限为251级)", vbInformation, "昆昆提示")
        textBoxto.Text = "251"
    End Sub

    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        End
    End Sub
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        MsgBox("程序开发:mhggpo 0v0" & vbCrLf & "经验表来源于舰Rwiki,感谢dalao 0v0" & vbCrLf & "计算原理来自舰少资料库,感谢dalao 0v0" & vbCrLf & "软件最新版本参见Github 0v0", vbInformation, "昆昆提示")
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
        If type1.IsChecked = True Then
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
                textBoxfrom.Text = 1
                Exit Sub
            End If
            If Val(textBoxto.Text) <= 110 And Val(textBoxfrom.Text) <= Val(textBoxto.Text) Then
            Else
                MsgBox(“输入有误，请重新输入！”, vbInformation)
                textBoxto.Text = 110
                Exit Sub
            End If
            If Val(mvpcalc.Text) >= 0 And Val(mvpcalc.Text) <= 100 Then
            Else
                MsgBox(“输入有误，请重新输入！”, vbInformation)
                Exit Sub
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
            End Select
            Dim showtext4 As String
            Dim winrate As Integer
            winrate = comboBox1.SelectedIndex
            Select Case winrate
                Case 0
                    showtext4 = "SS"
                    onceexp = onceexp * 1.2
                Case 1
                    showtext4 = "S"
                    onceexp = onceexp * 1.2
                Case 2
                    showtext4 = "A"
                    onceexp = onceexp * 1
                Case 3
                    showtext4 = "B"
                    onceexp = onceexp * 0.8
                Case 4
                    showtext4 = "C"
                    onceexp = onceexp * 0.7
                Case 5
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
            Dim tempforke As Long
            tempforke = onceexp
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
                tempforke = tempforke * 1.5
                showtext3 = "经验加成15%"
            Else
                showtext3 = ""
            End If
            If (ke) Then
                onceexp = onceexp + tempforke
            End If
            times = needexp / onceexp
            MsgBox("充满智慧的昆西掐指一算：" & "舰娘由等级" & textBoxfrom.Text & "升级至" & textBoxto.Text & "，共需经验值" & needexp & vbCrLf & "刷" & stage & "关卡的单个节点，在保持" & showtext1 & showtext2 & showtext3 & "战后" & showtext4 & "评价前提下," & vbCrLf & "一次经验" & onceexp & "，需要次数：" & times, vbInformation, "昆昆提示")
        Else
            tiduexp(0) = 0
            tiduexp(1) = 0
            tiduexp(2) = 50
            tiduexp(3) = 110
            tiduexp(4) = 180
            tiduexp(5) = 260
            tiduexp(6) = 360
            tiduexp(7) = 480
            tiduexp(8) = 620
            tiduexp(9) = 790
            tiduexp(10) = 990
            tiduexp(11) = 1220
            tiduexp(12) = 1490
            tiduexp(13) = 1800
            tiduexp(14) = 2150
            tiduexp(15) = 2550
            tiduexp(16) = 3000
            tiduexp(17) = 3500
            tiduexp(18) = 4060
            tiduexp(19) = 4680
            tiduexp(20) = 5360
            tiduexp(21) = 6110
            tiduexp(22) = 6930
            tiduexp(23) = 7820
            tiduexp(24) = 8790
            tiduexp(25) = 9840
            tiduexp(26) = 10970
            tiduexp(27) = 12190
            tiduexp(28) = 13500
            tiduexp(29) = 14900
            tiduexp(30) = 16400
            tiduexp(31) = 18000
            tiduexp(32) = 19700
            tiduexp(33) = 21510
            tiduexp(34) = 23430
            tiduexp(35) = 25460
            tiduexp(36) = 27610
            tiduexp(37) = 29880
            tiduexp(38) = 32270
            tiduexp(39) = 34790
            tiduexp(40) = 37440
            tiduexp(41) = 40220
            tiduexp(42) = 43140
            tiduexp(43) = 46200
            tiduexp(44) = 49400
            tiduexp(45) = 52750
            tiduexp(46) = 56250
            tiduexp(47) = 59900
            tiduexp(48) = 63710
            tiduexp(49) = 67680
            tiduexp(50) = 71810
            tiduexp(51) = 76110
            tiduexp(52) = 80670
            tiduexp(53) = 85490
            tiduexp(54) = 90580
            tiduexp(55) = 95940
            tiduexp(56) = 101580
            tiduexp(57) = 107500
            tiduexp(58) = 113710
            tiduexp(59) = 120210
            tiduexp(60) = 127010
            tiduexp(61) = 134110
            tiduexp(62) = 141520
            tiduexp(63) = 149240
            tiduexp(64) = 157280
            tiduexp(65) = 165640
            tiduexp(66) = 174330
            tiduexp(67) = 183350
            tiduexp(68) = 192710
            tiduexp(69) = 202410
            tiduexp(70) = 212460
            tiduexp(71) = 222860
            tiduexp(72) = 233980
            tiduexp(73) = 245830
            tiduexp(74) = 258420
            tiduexp(75) = 271760
            tiduexp(76) = 285860
            tiduexp(77) = 300730
            tiduexp(78) = 316380
            tiduexp(79) = 332820
            tiduexp(80) = 350060
            tiduexp(81) = 368110
            tiduexp(82) = 386980
            tiduexp(83) = 406680
            tiduexp(84) = 427220
            tiduexp(85) = 448610
            tiduexp(86) = 470860
            tiduexp(87) = 493980
            tiduexp(88) = 517980
            tiduexp(89) = 542870
            tiduexp(90) = 568660
            tiduexp(91) = 595360
            tiduexp(92) = 623900
            tiduexp(93) = 654300
            tiduexp(94) = 686580
            tiduexp(95) = 720760
            tiduexp(96) = 756860
            tiduexp(97) = 794900
            tiduexp(98) = 834900
            tiduexp(99) = 876880
            tiduexp(100) = 920860
            tiduexp(101) = 966860
            tiduexp(102) = 1016940
            tiduexp(103) = 1071140
            tiduexp(104) = 1129500
            tiduexp(105) = 1192060
            tiduexp(106) = 1258860
            tiduexp(107) = 1329940
            tiduexp(108) = 1405340
            tiduexp(109) = 1485100
            tiduexp(110) = 1569260
            tiduexp(111) = 1657860
            tiduexp(112) = 1750940
            tiduexp(113) = 1848540
            tiduexp(114) = 1950700
            tiduexp(115) = 2057460
            tiduexp(116) = 2168860
            tiduexp(117) = 2284940
            tiduexp(118) = 2405740
            tiduexp(119) = 2531300
            tiduexp(120) = 2661660
            tiduexp(121) = 2796860
            tiduexp(122) = 2936940
            tiduexp(123) = 3081940
            tiduexp(124) = 3231900
            tiduexp(125) = 3386860
            tiduexp(126) = 3546860
            tiduexp(127) = 3711940
            tiduexp(128) = 3882140
            tiduexp(129) = 4057500
            tiduexp(130) = 4238060
            tiduexp(131) = 4423860
            tiduexp(132) = 4614940
            tiduexp(133) = 4811340
            tiduexp(134) = 5013100
            tiduexp(135) = 5220260
            tiduexp(136) = 5432860
            tiduexp(137) = 5650940
            tiduexp(138) = 5874540
            tiduexp(139) = 6103700
            tiduexp(140) = 6338460
            tiduexp(141) = 6578860
            tiduexp(142) = 6824940
            tiduexp(143) = 7076740
            tiduexp(144) = 7334300
            tiduexp(145) = 7597660
            tiduexp(146) = 7866860
            tiduexp(147) = 8141940
            tiduexp(148) = 8422940
            tiduexp(149) = 8709900
            tiduexp(150) = 9002860
            tiduexp(151) = 9301860
            tiduexp(152) = 9606940
            tiduexp(153) = 9918140
            tiduexp(154) = 10235500
            tiduexp(155) = 10559060
            tiduexp(156) = 10888860
            tiduexp(157) = 11224940
            tiduexp(158) = 11567340
            tiduexp(159) = 11916100
            tiduexp(160) = 12271260
            tiduexp(161) = 12632860
            tiduexp(162) = 13000940
            tiduexp(163) = 13375540
            tiduexp(164) = 13756700
            tiduexp(165) = 14144460
            tiduexp(166) = 14538860
            tiduexp(167) = 14939940
            tiduexp(168) = 15347740
            tiduexp(169) = 15762300
            tiduexp(170) = 16183660
            tiduexp(171) = 16611860
            tiduexp(172) = 17046940
            tiduexp(173) = 17488940
            tiduexp(174) = 17937900
            tiduexp(175) = 18393860
            tiduexp(176) = 18856860
            tiduexp(177) = 19326940
            tiduexp(178) = 19804140
            tiduexp(179) = 20288500
            tiduexp(180) = 20780060
            tiduexp(181) = 21278860
            tiduexp(182) = 21784940
            tiduexp(183) = 22298340
            tiduexp(184) = 22819100
            tiduexp(185) = 23347260
            tiduexp(186) = 23882860
            tiduexp(187) = 24425940
            tiduexp(188) = 24976540
            tiduexp(189) = 25534700
            tiduexp(190) = 26100460
            tiduexp(191) = 26673860
            tiduexp(192) = 27254940
            tiduexp(193) = 27843740
            tiduexp(194) = 28440300
            tiduexp(195) = 29044660
            tiduexp(196) = 29656860
            tiduexp(197) = 30276940
            tiduexp(198) = 30904940
            tiduexp(199) = 31540900
            tiduexp(200) = 32184860
            tiduexp(201) = 32836860
            tiduexp(202) = 33496940
            tiduexp(203) = 34165140
            tiduexp(204) = 34841500
            tiduexp(205) = 35526060
            tiduexp(206) = 36218860
            tiduexp(207) = 36919940
            tiduexp(208) = 37629340
            tiduexp(209) = 38347100
            tiduexp(210) = 39073260
            tiduexp(211) = 39807860
            tiduexp(212) = 40550940
            tiduexp(213) = 41302540
            tiduexp(214) = 42062700
            tiduexp(215) = 42831460
            tiduexp(216) = 43608860
            tiduexp(217) = 44394940
            tiduexp(218) = 45189740
            tiduexp(219) = 45993300
            tiduexp(220) = 46805660
            tiduexp(221) = 47626860
            tiduexp(222) = 48456940
            tiduexp(223) = 49295940
            tiduexp(224) = 50143900
            tiduexp(225) = 51000860
            tiduexp(226) = 51866860
            tiduexp(227) = 52741940
            tiduexp(228) = 53626140
            tiduexp(229) = 54519500
            tiduexp(230) = 55422060
            tiduexp(231) = 56333860
            tiduexp(232) = 57254940
            tiduexp(233) = 58185340
            tiduexp(234) = 59125100
            tiduexp(235) = 60074260
            tiduexp(236) = 61032860
            tiduexp(237) = 62000940
            tiduexp(238) = 62978540
            tiduexp(239) = 63965700
            tiduexp(240) = 64962460
            tiduexp(241) = 65968860
            tiduexp(242) = 66984940
            tiduexp(243) = 68010740
            tiduexp(244) = 69046300
            tiduexp(245) = 70091660
            tiduexp(246) = 71146860
            tiduexp(247) = 72211940
            tiduexp(248) = 73286940
            tiduexp(249) = 74371900
            tiduexp(250) = 75466860
            tiduexp(251) = 76571860
            If Val(textBoxfrom.Text) >= 1 And Val(textBoxfrom.Text) <= Val(textBoxto.Text) Then
            Else
                MsgBox(“输入有误，请重新输入！”, vbInformation)
                textBoxfrom.Text = 1
                Exit Sub
            End If
            If Val(textBoxto.Text) <= 251 And Val(textBoxfrom.Text) <= Val(textBoxto.Text) Then
            Else
                MsgBox(“输入有误，请重新输入！”, vbInformation)
                textBoxto.Text = 251
                Exit Sub
            End If
            If Val(mvpcalc.Text) >= 0 And Val(mvpcalc.Text) <= 100 Then
            Else
                MsgBox(“输入有误，请重新输入！”, vbInformation)
                Exit Sub
            End If
            Dim level2 As Integer
            level2 = comboBox.SelectedIndex
            Select Case level2
                Case 0
                    stage = "1-1"
                    onceexp = 10
                Case 1
                    stage = "1-2"
                    onceexp = 20
                Case 2
                    stage = "1-3"
                    onceexp = 30
                Case 3
                    stage = "1-4"
                    onceexp = 40
                Case 4
                    stage = "1-5"
                    onceexp = 1
                    MsgBox("兄弟你何苦为难自己呢，苦海无涯，回头是岸啊！", vbExclamation, “唉”)
                    End
                Case 5
                    stage = "2-1"
                    onceexp = 20
                Case 6
                    stage = "2-2"
                    onceexp = 30
                Case 7
                    stage = "2-3"
                    onceexp = 40
                Case 8
                    stage = "2-4"
                    onceexp = 60
                Case 9
                    stage = "2-5"
                    onceexp = 100
                Case 10
                    stage = "2-6"
                    onceexp = 120
                Case 11
                    stage = "3-1"
                    onceexp = 30
                Case 12
                    stage = "3-2"
                    onceexp = 50
                Case 13
                    stage = "3-3"
                    onceexp = 70
                Case 14
                    stage = "3-4"
                    onceexp = 90
                Case 15
                    stage = "4-1"
                    onceexp = 40
                Case 16
                    stage = "4-2"
                    onceexp = 60
                Case 17
                    stage = "4-3"
                    onceexp = 80
                Case 18
                    stage = "4-4"
                    onceexp = 100
                Case 19
                    stage = "5-1"
                    onceexp = 90
                Case 20
                    stage = "5-2"
                    onceexp = 100
                Case 21
                    stage = "5-3"
                    onceexp = 110
                Case 22
                    stage = "5-4"
                    onceexp = 120
                Case 23
                    stage = "5-5"
                    onceexp = 150
                Case 24
                    stage = "6-1"
                    onceexp = 100
                Case 25
                    stage = "6-2"
                    onceexp = 110
                Case 26
                    stage = "6-3"
                    onceexp = 120
                Case 27
                    stage = "6-4"
                    onceexp = 150
                Case 28
                    stage = "7-1"
                    onceexp = 150
                Case 29
                    stage = "7-2"
                    onceexp = 160
                Case 30
                    stage = "7-3"
                    onceexp = 170
                Case 31
                    stage = "7-4"
                    onceexp = 180
                Case 32
                    stage = "7-5"
                    onceexp = 190
                Case 33
                    stage = "自定义"
                    Dim temp1 As String
Input3:
                    temp1 = InputBox("请输入关卡基础经验(即SS胜经验)", "昆昆提示")
                    If temp1 = "" Then MsgBox("哼，居然想用空白的条件来忽悠昆西╭(╯^╰)╮，不可原谅！", vbInformation) : GoTo Input3
                    If temp1 = "0" Then MsgBox("这样的条件下是没有提督经验的哦(⊙o⊙)", vbInformation) : GoTo Input3
                    onceexp = Val(temp1)
                    If onceexp = 0 Then MsgBox("这样的条件下是没有提督经验的哦(⊙o⊙)", vbInformation) : GoTo Input3
            End Select
            Dim showtext4 As String
            Dim winrate As Integer
            winrate = comboBox1.SelectedIndex
            Select Case winrate
                Case 0
                    showtext4 = "SS"
                    onceexp = onceexp * 1
                Case 1
                    showtext4 = "S"
                    onceexp = onceexp * 0.8
                Case 2
                    showtext4 = "A"
                    onceexp = onceexp * 0.5
                Case 3
                    showtext4 = "B"
                    onceexp = onceexp * 0
                Case 4
                    showtext4 = "C"
                    onceexp = onceexp * 0
                Case 5
                    showtext4 = "D"
                    onceexp = onceexp * 0
            End Select
            expfrom = tiduexp(CInt(textBoxfrom.Text))
            expto = tiduexp(CInt(textBoxto.Text))
            needexp = expto - expfrom
            If onceexp = 0 Then
                MsgBox("这样的条件下是没有提督经验的哦(⊙o⊙)", vbInformation, "昆昆提示")
            Else
                times = needexp / onceexp
                MsgBox("充满智慧的昆西掐指一算：" & "提督由等级" & textBoxfrom.Text & "升级至" & textBoxto.Text & "，共需经验值" & needexp & vbCrLf & "刷" & stage & "关卡的单个节点，在保持战后" & showtext4 & "评价前提下," & vbCrLf & "一次经验" & onceexp & "，需要次数：" & times, vbInformation, "昆昆提示")
            End If
        End If
    End Sub
End Class