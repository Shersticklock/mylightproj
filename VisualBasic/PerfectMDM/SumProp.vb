Module SumProp

    'Public itogDoc As Double


    Sub SummaString(ByRef Summa$, ByVal Source As Double, ByVal Rod%, ByVal w1$, ByVal w2to4$, ByVal w5to10$)

        ' Source = itogDoc

        'Source = 24567
        ' �������� ������:
        '  Source - ����� �� 0 �� 2147483647 (2^31-1)
        ' E��� ����� ����������� � ������� > 2 147 483 647
        ' �������� �������� ���������� Source � TempValue �� "AS DOUBLE"
        '    ����� ����� ������ ���������� � ������� ���������
        '  Rod%   = 1 - �������, = 2 - �������, = 3 - �������
        '     �������� ������� ���������:
        '  w1$     - ������������ ����� ������������ ����� (= 1)
        '  w2to4$  - ����������� ����� ������������ ����� (= 2-4)
        '  w5to10$ - ����������� ����� ������������� ����� ( = 5-10)
        '  Rod% ������ ���� ������ �����������, �������� ������� ����� ���� �� ������ = ""
        ' ���������������-
        ' ���������: Summa$ - ������ ��������
        '================================

        Dim TempValue As Long
        '
        If Source = 0 Then
            Summa$ = RTrim$("���� " + w5to10$) : Exit Sub
        End If
        '
        TempValue = Source : Summa$ = ""
        ' �������
        Call SummaStringThree(Summa$, TempValue, Rod%, w1$, w2to4$, w5to10$)
        'Call SummaStringThree(Summa$, TempValue, 1, "�����", "�����", "������")
        If TempValue = 0 Then Exit Sub
        ' ������
        Call SummaStringThree(Summa$, TempValue, 2, "������", "������", "�����")
        If TempValue = 0 Then Exit Sub
        ' ��������
        Call SummaStringThree(Summa$, TempValue, 1, "�������", "��������", "���������")
        If TempValue = 0 Then Exit Sub
        ' ����������
        Call SummaStringThree(Summa$, TempValue, 1, "��������", "���������", "����������")
        If TempValue = 0 Then Exit Sub

    End Sub

    Sub SummaStringThree(ByRef Summa$, ByRef TempValue As Long, ByVal Rod%, ByVal w1$, ByVal w2to4$, ByVal w5to10$)

        Dim Rest%, Rest1%, EndWord$, s1$, s10$, s100$
        '
        s100 = ""
        s10 = ""
        Rest% = TempValue& Mod 1000
        TempValue& = TempValue& \ 1000
        If Rest% = 0 Then    ' ��������� ��� ����� �������
            If Summa$ = "" Then Summa$ = w5to10$ + " "
            Exit Sub
        End If
        '
        ' �������� ������� � Rest
        EndWord$ = w5to10$
        ' �����
        Select Case Rest% \ 100
            Case 0 : s100$ = ""
            Case 1 : s100$ = "��� "
            Case 2 : s100$ = "������ "
            Case 3 : s100$ = "������ "
            Case 4 : s100$ = "��������� "
            Case 5 : s100$ = "������� "
            Case 6 : s100$ = "�������� "
            Case 7 : s100$ = "������� "
            Case 8 : s100$ = "��������� "
            Case 9 : s100$ = "��������� "
        End Select
        '
        ' �������
        Rest% = Rest% Mod 100 : Rest1% = Rest% \ 10
        s1$ = ""
        Select Case Rest1%
            Case 0 : s10$ = ""
            Case 1  ' ������ ������
                Select Case Rest%
                    Case 10 : s10$ = "������ "
                    Case 11 : s10$ = "����������� "
                    Case 12 : s10$ = "���������� "
                    Case 13 : s10$ = "���������� "
                    Case 14 : s10$ = "������������ "
                    Case 15 : s10$ = "���������� "
                    Case 16 : s10$ = "����������� "
                    Case 17 : s10$ = "���������� "
                    Case 18 : s10$ = "������������ "
                    Case 19 : s10$ = "������������ "
                End Select
            Case 2 : s10$ = "�������� "
            Case 3 : s10$ = "�������� "
            Case 4 : s10$ = "����� "
            Case 5 : s10$ = "��������� "
            Case 6 : s10$ = "���������� "
            Case 7 : s10$ = "��������� "
            Case 8 : s10$ = "����������� "
            Case 9 : s10$ = "��������� "
        End Select
        '
        If Rest1% <> 1 Then  ' �������
            Select Case Rest% Mod 10
                Case 1
                    Select Case Rod%
                        Case 1 : s1$ = "���� "
                        Case 2 : s1$ = "���� "
                        Case 3 : s1$ = "���� "
                    End Select
                    EndWord$ = w1$
                Case 2
                    If Rod% = 2 Then s1$ = "��� " Else s1$ = "��� "
                    EndWord$ = w2to4$
                Case 3 : s1$ = "��� " : EndWord$ = w2to4$
                Case 4 : s1$ = "������ " : EndWord$ = w2to4$
                Case 5 : s1$ = "���� "
                Case 6 : s1$ = "����� "
                Case 7 : s1$ = "���� "
                Case 8 : s1$ = "������ "
                Case 9 : s1$ = "������ "
            End Select
        End If
        '
        ' ������ ������
        Summa$ = RTrim$(RTrim$(s100$ + s10$ + s1$ + EndWord$) + " " + Summa$)
    End Sub

End Module
