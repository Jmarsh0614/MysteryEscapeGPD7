'Program Name: Mystery Escape GPD7
'Author:       Joshua Marshall
'Date:         March 26, 2017
'Purpose:      The Mystery Escape application determines the city and game types available and calculates the total team cost.



Option Strict On







Public Class frmEscape

    'CLASS VARIABLES'

    Private _intOneHour As Integer = 1
    Private _intTwoHour As Integer = 2
    Private _intFourHour As Integer = 4
    Private _strGame1 As String = "Spy in the Study"
    Private _strGame2 As String = "Hidden Cellar"
    Private _strGame3 As String = "Team Building"
    Private _strGame4 As String = "The Encounter"
    Private _strGame5 As String = "Library Larceny"
    Private _strGame6 As String = "Amazing Race"

    Private Sub cboCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCity.SelectedIndexChanged
        'This event hanlder allows the user to enter the ciy choice and then calls subprocedures to place the game types in the list.
        Dim intCityChoice As Integer

        intCityChoice = cboCity.SelectedIndex
        lstGame.Items.Clear()
        Select Case intCityChoice
            Case 0
                DallasTeam()
            Case 1
                ParisTeam()
            Case 2
                SingaporeTeam()

        End Select

        'Make items
        lblTeam.Visible = True
        txtTeam.Visible = True
        lblSelect.Visible = True
        lstGame.Visible = True
        btnFindCost.Visible = True
        btnClear.Visible = True
        lblGameType.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True
        'Clear The Labels
        lblGameType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        'Set focus on number in tiem text box
        txtTeam.Focus()
    End Sub

    Private Sub DallasTeam()
        'This procedure fills in the possible game types offered in Dallas 
        lstGame.Items.Add(_strGame1)
        lstGame.Items.Add(_strGame2)
        lstGame.Items.Add(_strGame3)
    End Sub

    Private Sub ParisTeam()
        'This procedures fills in the possible game types offered in Paris
        lstGame.Items.Add(_strGame4)
        lstGame.Items.Add(_strGame5)
    End Sub

    Private Sub SingaporeTeam()
        'This procedure fills in the possible game types offered in Singapore
        lstGame.Items.Add(_strGame2)
        lstGame.Items.Add(_strGame3)
        lstGame.Items.Add(_strGame6)

    End Sub

    Private Sub btnFindCost_Click(sender As Object, e As EventArgs) Handles btnFindCost.Click
        'This button event handler determines the cost of mystery escape experiences 
        ' and displays the size of the team, the cost, and the length

        Dim intTeamSize As Integer
        Dim blnNumberInTeamValid As Boolean = False
        Dim blnGameIsSelected As Boolean = False
        Dim intGameChoice As Integer
        Dim strSelectedItem As String = ""
        Dim intCityChoice As Integer
        Dim intLength As Integer = 0
        Dim decTotalCost As Decimal

        'Call a function to ensure that the number of people in the team is valid
        blnNumberInTeamValid = ValidateNumberInTeam()
        'Call a function to ensure a game type is selected 
        intGameChoice = ValidateGameSelection(blnGameIsSelected, strSelectedItem)

        If (blnNumberInTeamValid And blnGameIsSelected) Then
            intTeamSize = CInt(txtTeam.Text)
            intCityChoice = cboCity.SelectedIndex
            Select Case intCityChoice
                Case 0
                    decTotalCost = DallasFindCost(intGameChoice, intTeamSize, intLength)
                Case 1
                    decTotalCost = ParisFindCost(intGameChoice, intTeamSize, intLength)
                Case 2
                    decTotalCost = SingaporeFindCost(intGameChoice, intTeamSize, intLength)
            End Select
            'Display the cost of the ocean Team
            lblGameType.Text = "Game: " & strSelectedItem
            lblCost.Text = "Cost: " & decTotalCost.ToString("C")
            lblLength.Text = "Length: " & intLength.ToString() & " hour(s)"

        End If
    End Sub

    Private Function ValidateNumberInTeam() As Boolean
        'This procedure validates the value entered for the team size

        Dim intTeamSize As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberInTeamMessage = "Please enter the number of people in your team (2-6)"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTeamSize = CInt(txtTeam.Text)
            If intTeamSize >= 2 And intTeamSize <= 6 Then
                blnValidityCheck = True

            Else
                MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
                txtTeam.Focus()
                txtTeam.Clear()
            End If

        Catch Exception As FormatException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()
        Catch Exception As SystemException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()



        End Try
        Return blnValidityCheck
    End Function

    Private Function ValidateGameSelection(ByRef blnGame As Boolean, ByRef strGame As String) As Integer
        'This function ensure the user selected a game type

        Dim intGameType As Integer
        Try
            intGameType = CInt(lstGame.SelectedIndex)
            strGame = lstGame.SelectedItem.ToString()
            blnGame = True

        Catch Exception As Exception
            'Detects if a game type is not selected
            MsgBox("Select A Game Type", , "Error")
            blnGame = False
        End Try

        Return intGameType
    End Function

    Private Function DallasFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'This function calculates the cost of the team in Dallas
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decDallasGame1 As Decimal = 32D
        Dim decDallasGame2 As Decimal = 39D
        Dim decDallasGame3 As Decimal = 55D

        Select Case intGame
            Case 0
                decTeamCost = decDallasGame1
                intTime = _intOneHour
            Case 1
                decTeamCost = decDallasGame2
                intTime = _intOneHour
            Case 2
                decTeamCost = decDallasGame3
                intTime = _intTwoHour
        End Select
        decFinalCost = decTeamCost * intTeam
        Return decFinalCost

    End Function

    Private Function ParisFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'This function calculates the cost of the team in Paris

        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decParisGame4 As Decimal = 38D
        Dim decParisGame5 As Decimal = 45D

        Select Case intGame
            Case 0
                decTeamCost = decParisGame4
                intTime = _intOneHour
            Case 1
                decTeamCost = decParisGame5
                intTime = _intOneHour
        End Select
        decFinalCost = decTeamCost * intTeam
        Return decFinalCost


    End Function

    Private Function SingaporeFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'This function calculates the cost of the team in Singapore

        Dim decTeamCost As Decimal
        Dim decFinalCOst As Decimal
        Dim decSingaporeGame2 As Decimal = 45D
        Dim decSingaporeGame3 As Decimal = 65D
        Dim decSingaporeGame6 As Decimal = 75D

        Select Case intGame
            Case 0
                decTeamCost = decSingaporeGame2
                intTime = _intOneHour
            Case 1
                decTeamCost = decSingaporeGame3
                intTime = _intTwoHour
            Case 2
                decTeamCost = decSingaporeGame6
                intTime = _intFourHour
        End Select
        decFinalCOst = decTeamCost * intTeam
        Return decFinalCOst

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler clears the form and resets the form for reuse when the user clicks the Clear button.

        cboCity.Text = "Select City Selection"
        txtTeam.Clear()
        lstGame.Items.Clear()
        lblGameType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        lblTeam.Visible = False
        txtTeam.Visible = False
        lblSelect.Visible = False
        lstGame.Visible = False
        btnFindCost.Visible = False
        btnClear.Visible = False
        lblGameType.Visible = False
        lblCost.Visible = False
        lblLength.Visible = False
    End Sub

    Private Sub frmEscape_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hold the splash screen for 5 seconds

        Threading.Thread.Sleep(5000)
    End Sub
End Class
