Imports System.Speech.AudioFormat
Imports System.Speech.Synthesis
Imports System.Speech
Public Class FrmPrincipal
    Public sintetizadorDescarga As New Synthesis.SpeechSynthesizer
    Dim textolenght As Integer
    Dim posText As Integer
    Public Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim current = sintetizador.GetCurrentlySpokenPrompt()
        sintetizador.Volume = TbVolumen.Value
        sintetizador.Rate = TbVelocidad.Value
        'para que solo aparezcan las voces de un idioma en especifico
        'For Each InstalledVoice In sintetizador.GetInstalledVoices(New CultureInfo("en-US"))
        For Each InstalledVoice In sintetizador.GetInstalledVoices()
            Dim info = InstalledVoice.VoiceInfo()
            CbVoz.Items.Add(info.Name)
        Next
        TxtTitulo.Text = "Lorem de prueba"
        TxtTexto.Text = "Hola: Necesito seleccionar todo el texto de un textbox, para ello uso el método Tb.SelectAll en el evento GotFocus. Cuando el textbox recibe el foco mediante teclado, teclas Tab o Enter, funciona perfectamente, el problema surge  cuando el foco lo recibe clicando sobre él con el ratón, en este caso no se selecciona nada.Lo he intentado sin conserguirlo con:Tb.SelectionStart=0Tb.selectionLength=10También he probado con otros eventos ,Enter, Leave, y tampoco.¿Hay alguna forma de que cuando se clique sobre el tb con el ratón se seleccione todo el texto que?Gracias."
        '10
        'textoRead.AppendTextWithPronunciation("DuBois", "duˈbwɑ")
        textoRead.AppendText(TxtTexto.Text)
        'BtnStop.Enabled = False
        CbVoz.Text = CbVoz.Items.Item(0).ToString()
        'sintetizador.SetOutputToDefaultAudioDevice()
        AddHandler sintetizador.StateChanged, AddressOf ESTADO
        AddHandler sintetizador.SpeakProgress, AddressOf EstadoProgreso
        AddHandler sintetizador.SpeakCompleted, AddressOf EstadoCompleto
        'AddHandler sintetizador.SpeakProgress, New EventHandler(Of SpeakProgressEventArgs)(AddressOf synth_SpeakProgress)
        textoRead.AppendText(TxtTexto.Text.ToString())
    End Sub
    Public Sub ESTADO()
        If sintetizador.State = SynthesizerState.Paused Then
            BtnHablar.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources._continue
        End If
        If sintetizador.State = SynthesizerState.Speaking Then
            'hacer que no se pueda editar el texto mientras habla
            BtnHablar.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources.pause
        End If
        If sintetizador.State = SynthesizerState.Ready Then
            BtnHablar.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources.play
        End If
    End Sub
    Public Sub CbVoz_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbVoz.SelectedValueChanged
        Try
            sintetizador.SelectVoice(CbVoz.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TbVelocidad_Scroll(sender As Object, e As EventArgs) Handles TbVelocidad.Scroll
        'falta que al iniciar de leer no se desactive
        'que se pueda modificar aun asi este reproduciendose el texto
        sintetizador.Rate = TbVelocidad.Value
    End Sub
    Private Sub CbVoz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVoz.SelectedIndexChanged
        Try
            sintetizador.SpeakAsyncCancelAll()
            sintetizador.SelectVoice(CbVoz.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnHablar_Click_1(sender As Object, e As EventArgs) Handles BtnHablar.Click
        Try
            textolenght = TxtTexto.Text.Length
            If sintetizador.State = SynthesizerState.Ready Then
                sintetizador.SetOutputToDefaultAudioDevice()
                sintetizador.SpeakAsync(TxtTexto.Text)
                TxtTexto.ReadOnly = True
            ElseIf sintetizador.State = SynthesizerState.Speaking Then
                sintetizador.Pause()
                TxtTexto.ReadOnly = False
            ElseIf sintetizador.State = SynthesizerState.Paused Then
                sintetizador.Resume()
                TxtTexto.ReadOnly = True
            End If
            'principal, si el sintetizador esta en modo stop o se reinicia
            'falta saber cuando ya se acabo de reproducir un texto
            'sintetizador.SpeakAsync(TxtTexto.Text)
            'Esta opcion es como el buscador de voces, pero solo con parametros de sexo y edad
            'sintetizador.SelectVoiceByHints(VoiceGender.Female, VoiceAge.NotSet) ' To change VoiceGender And VoiceAge check out those links below
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnStop_Click_1(sender As Object, e As EventArgs) Handles BtnStop.Click
        ProgressBar1.Value = 0
        sintetizador.SpeakAsyncCancelAll()
        'BtnHablar.BackgroundImage = My.Resources.play
    End Sub
    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'determinamos con un if si tiene titulo definido el proyecto
            'si no lo tiene le agrega uno default
            If TxtTitulo.Text = "" Then
                SaveFileDialog1.FileName = "Default Title"
            Else
                SaveFileDialog1.FileName = TxtTitulo.Text
            End If

            'determina a el dialogo de guardar archivo la extension default que la vdd nose como funciona y pone de extensiones poosibles las de wav y mp3
            SaveFileDialog1.DefaultExt = ".mp3"
            SaveFileDialog1.Filter = "Archivos de audio |*.wav" + "|Archivos de audio |*.mp3"

            'aqui es cuando el usuario da click en guardar en el cuadro de dialogo
            'y estas son las propiedades de el archivo que se va a generar
            'el nombre del archivo
            'nose porque pero debe llevar un speak pero probare porque lo lleva
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sintetizadorDescarga.SelectVoice(CbVoz.Text)
                sintetizadorDescarga.Volume = TbVolumen.Value
                sintetizadorDescarga.Rate = TbVelocidad.Value
                sintetizadorDescarga.SetOutputToWaveFile(SaveFileDialog1.FileName, New SpeechAudioFormatInfo(44100, AudioBitsPerSample.Sixteen, AudioChannel.Stereo))
                sintetizadorDescarga.Speak(TxtTexto.Text.ToLower)
                ' esta opcion es para que se pueda cerrar el archivo de audio despues que se ha creado
                sintetizadorDescarga.SetOutputToNull()
                sintetizadorDescarga.SpeakAsyncCancelAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EstadoProgreso(sender As Object, e As SpeakProgressEventArgs)
        Try
            ProgressBar1.Value = ((e.CharacterPosition + e.CharacterCount) / textolenght) * 100
            'TxtCall.Text = textolenght & " " & ((e.CharacterPosition + e.CharacterCount) / textolenght) * 100
            posText = e.CharacterPosition
            TxtTexto.SelectionStart = e.CharacterPosition
            TxtTexto.SelectionLength = e.CharacterCount
            TxtTexto.Select()
            'TxtTexto.SelectedText.CopyTo(10, TxtTexto.Text, 0, 100)
            'TxtCall.Text = (TxtTexto.Text.Length / (e.CharacterPosition + e.CharacterCount)) * 100
            'Console.WriteLine("CharPos: {0}   CharCount: {1}   AudioPos: {2}    ""{3}""", e.CharacterPosition, e.CharacterCount, e.AudioPosition, e.Text)
            'synth.SpeakProgress += New EventHandler < SpeakProgressEventArgs > (synth_SpeakProgress)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EstadoCompleto(ByVal sender As Object, ByVal e As SpeakCompletedEventArgs)
        ProgressBar1.Value = 100
        TxtTexto.ReadOnly = False
        sintetizador.SpeakAsyncCancelAll()
        'MsgBox("se acabo de leer el texto")
        'ProgressBar1.Value = 100
        ProgressBar1.Value = 0
    End Sub
End Class