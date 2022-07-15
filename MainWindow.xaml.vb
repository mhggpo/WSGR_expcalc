Class MainWindow
    Dim expfrom, expto, needexp, onceexp, onceexp1, onceexp2, times As Long
    Dim jianniangexp(111) As Long
    Dim tiduexp(252) As Long
    Dim flagship, train, mvp, shengjian, bread, laibixi, ke, baiyan, baiyane, baiyannoe, lanli, lanliu, lanlinou, xiangqu, equip1, equip2, equip3, teacher1 As Boolean
    Public Sub setupexp(ByVal str1 As String, ByVal num1 As Integer)
        stage = str1
        onceexp = num1
    End Sub
    Private Sub teacher_Checked(sender As Object, e As RoutedEventArgs) Handles teacher.Checked
        teacher1 = True
    End Sub
    Private Sub teacher_unChecked(sender As Object, e As RoutedEventArgs) Handles teacher.Unchecked
        teacher1 = False
    End Sub
    Private Sub weapons_Checked(sender As Object, e As RoutedEventArgs) Handles weapon.Checked
        weapon1.IsEnabled = True
        weapon2.IsEnabled = True
        weapon3.IsEnabled = True
    End Sub
    Private Sub weapons_Unchecked(sender As Object, e As RoutedEventArgs) Handles weapon.Unchecked
        weapon1.IsEnabled = False
        weapon1.IsChecked = False
        weapon2.IsEnabled = False
        weapon2.IsChecked = False
        weapon3.IsEnabled = False
        weapon3.IsChecked = False
    End Sub

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
            jianniangexp = {0, 0, 100, 300, 600, 1000, 1500, 2100, 2800, 3600, 4500,
5500, 6600, 7800, 9100, 10500, 12000, 13600, 15300,
17100, 19000, 21000, 23100, 25300, 27600, 30000,
32500, 35100, 37800, 40600, 43500, 46500, 49600,
52800, 56100, 59500, 63000, 66600, 70300, 74100,
78000, 82000, 86100, 90300, 94600, 99000, 103500,
108100, 112800, 117600, 122500, 127500, 132700,
138100, 143700, 149500, 155500, 161700, 168100,
174700, 181500, 188500, 195800, 203400, 211300,
219600, 228300, 237400, 247000, 257100, 267800,
279100, 291100, 303800, 317300, 331700, 347000,
363300, 380700, 399300, 419100, 440200, 462700,
486700, 512300, 539600, 568700, 599700, 632700,
667900, 705400, 745300, 787700, 832800, 880700,
931600, 985600, 1042800, 1103400, 1167600, 1235500,
1307300, 1379100, 1450900, 1522700, 1594500, 1666300,
1738100, 1809900, 1881700, 1953500}
            Dim levelExp(36) As Integer
            levelExp = {30, 50, 80, 120, 0, 100, 120, 150, 200, 400, 420, 150, 180, 220, 300, 250, 300, 330,
360, 350, 370, 400, 420, 450, 400, 410, 420, 500, 450, 480, 520, 560, 560, 600, 600, 600, 600, 600, 720}
            Dim levelText As ListBoxItem
            levelText = CType(comboBox.SelectedItem, ListBoxItem)
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
            If comboBox.SelectedIndex = 36 Then
                stage = "自定义"
                Dim temp1 As String
Input1:
                temp1 = InputBox("请输入关卡基础经验(即A胜经验)", "昆昆提示")
                If temp1 = "" Then MsgBox("哼，居然想用空白的条件来忽悠昆西╭(╯^╰)╮，不可原谅！", vbInformation) : GoTo Input1
                If temp1 = "0" Then MsgBox("昆昆才不会被骗去1-5吃土呢！", vbInformation) : GoTo Input1
                onceexp = Val(temp1)
                If onceexp = 0 Then MsgBox("昆昆才不会被骗去1-5吃土呢！", vbInformation) : GoTo Input1
            ElseIf comboBox.SelectedIndex = 4 Then
                stage = "1-5"
                onceexp = 1
                MsgBox("兄弟你何苦为难自己呢，苦海无涯，回头是岸啊！", vbExclamation, “唉”)
                End
            Else
                setupexp(levelText.Content.ToString, levelExp(comboBox.SelectedIndex))
            End If
            Dim showtext4 As String
                showtext4 = ""
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
                Dim teachers As Integer
                teachers = combobox2.SelectedIndex
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
                equip1 = weapon1.IsChecked And weapon.IsEnabled
                equip2 = weapon2.IsChecked And weapon.IsEnabled
                equip3 = weapon3.IsChecked And weapon.IsEnabled
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
                If (gewasi.IsChecked) Then
                    onceexp *= 2
                End If
                If (equip1) Then
                    onceexp = onceexp * 1.01
                ElseIf (equip2) Then
                    onceexp = onceexp * 1.05
                ElseIf (equip3) Then
                    onceexp = onceexp * 1.07
                End If
                Dim tempfortea As Long
                tempfortea = 0
                If (teacher1) Then
                    Select Case teacherwho.SelectedIndex
                        Case 0
                            tempfortea = needexp - (onceexp * 1.5 * teachers)
                        Case 1
                            tempfortea = needexp - (onceexp * 1.75 * teachers)
                        Case 2
                            tempfortea = needexp - (onceexp * 2 * teachers)
                    End Select
                End If
                If (tempfortea > 0 And teacher1) Then
                    times = (tempfortea / onceexp) + teachers
                ElseIf (tempfortea <= 0 And teacher1) Then
                    While (tempfortea <= 0)
                        MsgBox("昆西稍稍思考，发现当前条件下经验溢出，将自动提升一个目标等级计算！", vbInformation, "昆昆提示")
                        textBoxto.Text = textBoxto.Text + 1
                        If (textBoxto.Text > 90) Then
                            MsgBox("目标等级大于上限！", vbCritical, "昆昆提示")
                            Exit Sub
                        End If
                        expto = jianniangexp(CInt(textBoxto.Text))
                        needexp = expto - expfrom
                        tempfortea = needexp - (onceexp * 1.5 * teachers)
                    End While
                    times = (tempfortea / onceexp) + teachers
                Else times = (needexp / onceexp)
                End If
                MsgBox("充满智慧的昆西掐指一算：" & "舰娘由等级" & textBoxfrom.Text & "升级至" & textBoxto.Text & "，共需经验值" & needexp & vbCrLf & "刷" & stage & "关卡的单个节点，在保持" & showtext1 & showtext2 & showtext3 & "战后" & showtext4 & "评价前提下," & vbCrLf & "一次经验" & onceexp & "，需要次数：" & times, vbInformation, "昆昆提示")
            Else
                tiduexp = {0, 0, 50, 110, 180, 260, 360, 480, 620, 790, 990, 1220, 1490, 1800, 2150,
2550, 3000, 3500, 4060, 4680, 5360, 6110, 6930, 7820, 8790, 9840,
10970, 12190, 13500, 14900, 16400, 18000, 19700, 21510, 23430,
25460, 27610, 29880, 32270, 34790, 37440, 40220, 43140, 46200,
49400, 52750, 56250, 59900, 63710, 67680, 71810, 76110, 80670,
85490, 90580, 95940, 101580, 107500, 113710, 120210, 127010,
134110, 141520, 149240, 157280, 165640, 174330, 183350, 192710,
202410, 212460, 222860, 233980, 245830, 258420, 271760, 285860,
300730, 316380, 332820, 350060, 368110, 386980, 406680, 427220,
448610, 470860, 493980, 517980, 542870, 568660, 595360, 623900,
654300, 686580, 720760, 756860, 794900, 834900, 876880, 920860,
966860, 1016940, 1071140, 1129500, 1192060, 1258860, 1329940,
1405340, 1485100, 1569260, 1657860, 1750940, 1848540, 1950700,
2057460, 2168860, 2284940, 2405740, 2531300, 2661660, 2796860,
2936940, 3081940, 3231900, 3386860, 3546860, 3711940, 3882140,
4057500, 4238060, 4423860, 4614940, 4811340, 5013100, 5220260,
5432860, 5650940, 5874540, 6103700, 6338460, 6578860, 6824940,
7076740, 7334300, 7597660, 7866860, 8141940, 8422940, 8709900,
9002860, 9301860, 9606940, 9918140, 10235500, 10559060, 10888860,
11224940, 11567340, 11916100, 12271260, 12632860, 13000940, 13375540,
13756700, 14144460, 14538860, 14939940, 15347740, 15762300, 16183660,
16611860, 17046940, 17488940, 17937900, 18393860, 18856860, 19326940,
19804140, 20288500, 20780060, 21278860, 21784940, 22298340, 22819100,
23347260, 23882860, 24425940, 24976540, 25534700, 26100460, 26673860,
27254940, 27843740, 28440300, 29044660, 29656860, 30276940, 30904940,
31540900, 32184860, 32836860, 33496940, 34165140, 34841500, 35526060,
36218860, 36919940, 37629340, 38347100, 39073260, 39807860, 40550940,
41302540, 42062700, 42831460, 43608860, 44394940, 45189740, 45993300,
46805660, 47626860, 48456940, 49295940, 50143900, 51000860, 51866860,
52741940, 53626140, 54519500, 55422060, 56333860, 57254940, 58185340,
59125100, 60074260, 61032860, 62000940, 62978540, 63965700, 64962460,
65968860, 66984940, 68010740, 69046300, 70091660, 71146860, 72211940,
73286940, 74371900, 75466860, 76571860}
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
            Dim levelExp(36) As Integer
            levelExp = {10, 20, 30, 40, 0, 20, 30, 40, 60, 100, 120, 30, 50, 70, 90, 40, 60, 80, 100, 90,
100, 110, 120, 150, 100, 110, 120, 150, 150, 160, 170, 180, 190, 190, 190, 190}
            Dim levelText As ListBoxItem
            levelText = CType(comboBox.SelectedItem, ListBoxItem)
            If comboBox.SelectedIndex = 36 Then
                stage = "自定义"
                Dim temp1 As String
Input3:
                temp1 = InputBox("请输入关卡基础经验(即SS胜经验)", "昆昆提示")
                If temp1 = "" Then MsgBox("哼，居然想用空白的条件来忽悠昆西╭(╯^╰)╮，不可原谅！", vbInformation) : GoTo Input3
                If temp1 = "0" Then MsgBox("这样的条件下是没有提督经验的哦(⊙o⊙)", vbInformation) : GoTo Input3
                onceexp = Val(temp1)
                If onceexp = 0 Then MsgBox("这样的条件下是没有提督经验的哦(⊙o⊙)", vbInformation) : GoTo Input3
            ElseIf comboBox.SelectedIndex = 4 Then
                stage = "1-5"
                onceexp = 1
                MsgBox("兄弟你何苦为难自己呢，苦海无涯，回头是岸啊！", vbExclamation, “唉”)
                End
            Else
                setupexp(levelText.Content.ToString, levelExp(comboBox.SelectedIndex))
            End If
            Dim showtext4 As String
            showtext4 = ""
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
