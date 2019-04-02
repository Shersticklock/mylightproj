Module SumProp

    'Public itogDoc As Double


    Sub SummaString(ByRef Summa$, ByVal Source As Double, ByVal Rod%, ByVal w1$, ByVal w2to4$, ByVal w5to10$)

        ' Source = itogDoc

        'Source = 24567
        ' »сходные данные:
        '  Source - число от 0 до 2147483647 (2^31-1)
        ' Eсли нужно оперировать с числами > 2 147 483 647
        ' замените описание переменных Source и TempValue на "AS DOUBLE"
        '    далее нужно задать информацию о единице изменени€
        '  Rod%   = 1 - мужской, = 2 - женский, = 3 - средний
        '     название единицы изменени€:
        '  w1$     - именительный падеж единственное число (= 1)
        '  w2to4$  - родительный падеж единственное число (= 2-4)
        '  w5to10$ - родительный падеж множественное число ( = 5-10)
        '  Rod% должен быть задано об€зательно, название единицы может быть не задано = ""
        ' ЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧ-
        ' –езультат: Summa$ - запись прописью
        '================================

        Dim TempValue As Long
        '
        If Source = 0 Then
            Summa$ = RTrim$("ноль " + w5to10$) : Exit Sub
        End If
        '
        TempValue = Source : Summa$ = ""
        ' единицы
        Call SummaStringThree(Summa$, TempValue, Rod%, w1$, w2to4$, w5to10$)
        'Call SummaStringThree(Summa$, TempValue, 1, "рубль", "рубл€", "рублей")
        If TempValue = 0 Then Exit Sub
        ' тыс€чи
        Call SummaStringThree(Summa$, TempValue, 2, "тыс€ча", "тыс€чи", "тыс€ч")
        If TempValue = 0 Then Exit Sub
        ' миллионы
        Call SummaStringThree(Summa$, TempValue, 1, "миллион", "миллиона", "миллионов")
        If TempValue = 0 Then Exit Sub
        ' миллиардов
        Call SummaStringThree(Summa$, TempValue, 1, "миллиард", "миллиарда", "миллиардов")
        If TempValue = 0 Then Exit Sub

    End Sub

    Sub SummaStringThree(ByRef Summa$, ByRef TempValue As Long, ByVal Rod%, ByVal w1$, ByVal w2to4$, ByVal w5to10$)

        Dim Rest%, Rest1%, EndWord$, s1$, s10$, s100$
        '
        s100 = ""
        s10 = ""
        Rest% = TempValue& Mod 1000
        TempValue& = TempValue& \ 1000
        If Rest% = 0 Then    ' последние три знака нулевые
            If Summa$ = "" Then Summa$ = w5to10$ + " "
            Exit Sub
        End If
        '
        ' начинаем подсчет с Rest
        EndWord$ = w5to10$
        ' сотни
        Select Case Rest% \ 100
            Case 0 : s100$ = ""
            Case 1 : s100$ = "сто "
            Case 2 : s100$ = "двести "
            Case 3 : s100$ = "триста "
            Case 4 : s100$ = "четыреста "
            Case 5 : s100$ = "п€тьсот "
            Case 6 : s100$ = "шестьсот "
            Case 7 : s100$ = "семьсот "
            Case 8 : s100$ = "восемьсот "
            Case 9 : s100$ = "дев€тьсот "
        End Select
        '
        ' дес€тки
        Rest% = Rest% Mod 100 : Rest1% = Rest% \ 10
        s1$ = ""
        Select Case Rest1%
            Case 0 : s10$ = ""
            Case 1  ' особый случай
                Select Case Rest%
                    Case 10 : s10$ = "дес€ть "
                    Case 11 : s10$ = "одиннадцать "
                    Case 12 : s10$ = "двенадцать "
                    Case 13 : s10$ = "тринадцать "
                    Case 14 : s10$ = "четырнадцать "
                    Case 15 : s10$ = "п€тнадцать "
                    Case 16 : s10$ = "шестнадцать "
                    Case 17 : s10$ = "семнадцать "
                    Case 18 : s10$ = "восемнадцать "
                    Case 19 : s10$ = "дев€тнадцать "
                End Select
            Case 2 : s10$ = "двадцать "
            Case 3 : s10$ = "тридцать "
            Case 4 : s10$ = "сорок "
            Case 5 : s10$ = "п€тьдес€т "
            Case 6 : s10$ = "шестьдес€т "
            Case 7 : s10$ = "семьдес€т "
            Case 8 : s10$ = "восемьдес€т "
            Case 9 : s10$ = "дев€носто "
        End Select
        '
        If Rest1% <> 1 Then  ' единицы
            Select Case Rest% Mod 10
                Case 1
                    Select Case Rod%
                        Case 1 : s1$ = "один "
                        Case 2 : s1$ = "одна "
                        Case 3 : s1$ = "одно "
                    End Select
                    EndWord$ = w1$
                Case 2
                    If Rod% = 2 Then s1$ = "две " Else s1$ = "два "
                    EndWord$ = w2to4$
                Case 3 : s1$ = "три " : EndWord$ = w2to4$
                Case 4 : s1$ = "четыре " : EndWord$ = w2to4$
                Case 5 : s1$ = "п€ть "
                Case 6 : s1$ = "шесть "
                Case 7 : s1$ = "семь "
                Case 8 : s1$ = "восемь "
                Case 9 : s1$ = "дев€ть "
            End Select
        End If
        '
        ' сборка строки
        Summa$ = RTrim$(RTrim$(s100$ + s10$ + s1$ + EndWord$) + " " + Summa$)
    End Sub

End Module
