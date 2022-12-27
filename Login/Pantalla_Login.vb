Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Pantalla_Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btnRound)

        'TextBox2.AutoSize = False
        'TextBox2.Size = New Size(200, 46)
        'TextBox1.AutoSize = False
        'TextBox1.Size = New Size(200, 46)
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim rect As New Rectangle(-10, 0, 540, 489)
        Using br As New LinearGradientBrush(
        rect, Color.FromArgb(61, 90, 128), Color.FromArgb(61, 90, 128),
         LinearGradientMode.ForwardDiagonal)
            e.Graphics.FillRectangle(br, rect)
            e.Graphics.DrawRectangle(Pens.White, rect)
        End Using

    End Sub

    Private Sub RoundButton(btn As Button)


        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(41, 50, 65)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14, style:=FontStyle.Bold)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnRound.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnRound.Region = New Region(Raduis)
    End Sub

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click

        Dim box = New Registro_de_Ventas
        box.Show()

        Me.Hide()

    End Sub
End Class

'PANEL CUADRADO PARA EL FORMS
Public Class ShapedPanel
    Inherits Panel

    Private pen As Pen = New Pen(_borderColor, penWidth)
    Private Shared ReadOnly penWidth As Single = 2.0F

    Public Sub New()

    End Sub

    Private _borderColor As Color = Color.White
    <Browsable(True)>
    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal Value As Color)
            _borderColor = Value
            pen = New Pen(_borderColor, penWidth)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ExtendedDraw(e)
        DrawBorder(e.Graphics)
    End Sub

    Private _edge As Integer = 50
    <Browsable(True)>
    Public Property Edge() As Integer
        Get
            Return _edge
        End Get
        Set(ByVal Value As Integer)
            _edge = Value
            Invalidate()
        End Set
    End Property


    Private Function GetLeftUpper(ByVal e As Integer) As Rectangle
        Return New Rectangle(0, 0, e, e)
    End Function

    Private Function GetRightUpper(ByVal e As Integer) As Rectangle
        Return New Rectangle(Width - e, 0, e, e)
    End Function

    Private Function GetRightLower(ByVal e As Integer) As Rectangle
        Return New Rectangle(Width - e, Height - e, e, e)
    End Function

    Private Function GetLeftLower(ByVal e As Integer) As Rectangle
        Return New Rectangle(0, Height - e, e, e)
    End Function

    Private Sub ExtendedDraw(ByVal e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As GraphicsPath = New GraphicsPath()
        path.StartFigure()
        path.AddArc(GetLeftUpper(Edge), 180, 90)
        path.AddLine(Edge, 0, Width - Edge, 0)
        path.AddArc(GetRightUpper(Edge), 270, 90)
        path.AddLine(Width, Edge, Width, Height - Edge)
        path.AddArc(GetRightLower(Edge), 0, 90)
        path.AddLine(Width - Edge, Height, Edge, Height)
        path.AddArc(GetLeftLower(Edge), 90, 90)
        path.AddLine(0, Height - Edge, 0, Edge)
        path.CloseFigure()
        Region = New Region(path)
    End Sub

    Private Sub DrawSingleBorder(ByVal graphics As Graphics)
        graphics.DrawArc(pen, New Rectangle(0, 0, Edge, Edge),
                       180, 90)
        graphics.DrawArc(pen, New Rectangle(Width - Edge - 1, -1,
                       Edge, Edge), 270, 90)
        graphics.DrawArc(pen, New Rectangle(Width - Edge - 1,
                       Height - Edge - 1, Edge, Edge), 0, 90)
        graphics.DrawArc(pen, New Rectangle(0, Height - Edge - 1,
                       Edge, Edge), 90, 90)
        graphics.DrawRectangle(pen, 0.0F, 0.0F, CType((Width - 1),
                             Single), CType((Height - 1), Single))
    End Sub

    Private Sub Draw3DBorder(ByVal graphics As Graphics)
        'TODO Implement 3D border
    End Sub

    Private Sub DrawBorder(ByVal graphics As Graphics)
        DrawSingleBorder(graphics)
    End Sub
End Class

Public Class TextBoxWithBorder
    Inherits TextBox

    Public Const WM_NCPAINT As Integer = &H85

    <Flags()>
    Private Enum RedrawWindowFlags As UInteger
        Invalidate = &H1
        InternalPaint = &H2
        [Erase] = &H4
        Validate = &H8
        NoInternalPaint = &H10
        NoErase = &H20
        NoChildren = &H40
        AllChildren = &H80
        UpdateNow = &H100
        EraseNow = &H200
        Frame = &H400
        NoFrame = &H800
    End Enum

    <DllImport("User32.dll")>
    Private Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function RedrawWindow(hWnd As IntPtr, lprcUpdate As IntPtr, hrgnUpdate As IntPtr, flags As RedrawWindowFlags) As Boolean
    End Function

    Public Sub New()
        MyBase.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e)
        RedrawWindow(Me.Handle, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Frame Or RedrawWindowFlags.UpdateNow Or RedrawWindowFlags.Invalidate)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCPAINT Then
            Dim hDC As IntPtr = GetWindowDC(m.HWnd)
            Using g As Graphics = Graphics.FromHdc(hDC)
                If Me.Focused Then
                    g.DrawRectangle(Pens.CornflowerBlue, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
                Else
                    g.DrawRectangle(Pens.Gainsboro, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
                End If
                g.DrawRectangle(SystemPens.Window, New Rectangle(1, 1, Me.Width - 3, Me.Height - 3))
            End Using
            ReleaseDC(m.HWnd, hDC)
        End If

    End Sub
End Class


<DesignerCategory("Code")>
Public Class CustomTextBox
    Inherits TextBox

    Private Const WM_NCPAINT As Integer = &H85
    Private m_BorderColor As Color = Color.Blue
    Private m_BorderSize As Integer = 1
    Private m_BorderStyle As ButtonBorderStyle = ButtonBorderStyle.Solid
    Private m_BorderSides As BorderSideOptions = BorderSideOptions.All

    Public Sub New()
    End Sub

    <DefaultValue(BorderSideOptions.All)>
    Public Property BorderSides As BorderSideOptions
        Get
            Return m_BorderSides
        End Get
        Set
            If m_BorderSides <> Value Then
                m_BorderSides = Value
                Parent?.Invalidate(Bounds, True)
            End If
        End Set
    End Property

    <DefaultValue(KnownColor.Blue)>
    Public Property BorderColor As Color
        Get
            Return m_BorderColor
        End Get
        Set
            If m_BorderColor <> Value Then
                m_BorderColor = Value
                Parent?.Invalidate(Bounds, True)
            End If
        End Set
    End Property

    <DefaultValue(1)>
    Public Property BorderSize As Integer
        Get
            Return m_BorderSize
        End Get
        Set
            Dim newValue = Math.Max(Math.Min(Value, 2), 1)
            If m_BorderSize <> newValue Then
                m_BorderSize = newValue
                Parent?.Invalidate(Bounds, True)
            End If
        End Set
    End Property

    <DefaultValue(ButtonBorderStyle.Solid)>
    Public Overloads Property BorderStyle As ButtonBorderStyle
        Get
            Return m_BorderStyle
        End Get
        Set
            If m_BorderStyle <> Value Then
                m_BorderStyle = Value
                Parent?.Invalidate(Bounds, True)
            End If
        End Set
    End Property

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        MyBase.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case WM_NCPAINT
                If Not IsHandleCreated Then Return
                Dim rect = New Rectangle(0, 0, Width, Height)
                Dim hDC = GetWindowDC(Handle)
                Try
                    Using g = Graphics.FromHdc(hDC),
                       p As New Pen(BackColor, 2)
                        g.DrawRectangle(p, rect)
                        Select Case BorderSides
                            Case BorderSideOptions.All
                                ControlPaint.DrawBorder(g, rect, m_BorderColor, m_BorderSize, m_BorderStyle, m_BorderColor, m_BorderSize, m_BorderStyle, m_BorderColor, m_BorderSize, m_BorderStyle, m_BorderColor, m_BorderSize, m_BorderStyle)
                            Case BorderSideOptions.Bottom
                                ControlPaint.DrawBorder(g, rect, Nothing, 0, 0, Nothing, 0, 0, Nothing, 0, 0, m_BorderColor, m_BorderSize, m_BorderStyle)
                            Case BorderSideOptions.Left
                                ControlPaint.DrawBorder(g, rect, m_BorderColor, m_BorderSize, m_BorderStyle, Nothing, 0, 0, Nothing, 0, 0, Nothing, 0, 0)
                            Case BorderSideOptions.Right
                                ControlPaint.DrawBorder(g, rect, Nothing, 0, 0, Nothing, 0, 0, m_BorderColor, m_BorderSize, m_BorderStyle, Nothing, 0, 0)
                            Case BorderSideOptions.Top
                                ControlPaint.DrawBorder(g, rect, Nothing, 0, 0, m_BorderColor, m_BorderSize, m_BorderStyle, Nothing, 0, 0, Nothing, 0, 0)
                        End Select
                    End Using
                Finally
                    ReleaseDC(Handle, hDC)
                End Try
                m.Result = IntPtr.Zero
        End Select
    End Sub

    ' This could use a file of its own
    Public Enum BorderSideOptions
        Left
        Right
        Top
        Bottom
        All
    End Enum

    ' Native methods
    <DllImport("user32")>
    Private Shared Function GetWindowDC(hwnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32")>
    Private Shared Function ReleaseDC(hwnd As IntPtr, hDc As IntPtr) As Integer
    End Function
End Class



Public Class RoundButton
    Inherits Button

    'Propiedad para establecer el radio del botón
    Public Property Radius As Integer = 20

    'Sobrescribir el método OnPaint para dibujar el botón redondo
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        'Obtener el objeto Graphics del control
        Dim g As Graphics = e.Graphics

        'Dibujar el botón redondo
        g.FillEllipse(New SolidBrush(Me.BackColor), 0, 0, Me.Width, Me.Height)

        'Dibujar el texto del botón en el centro
        Dim textSize As SizeF = g.MeasureString(Me.Text, Me.Font)
        Dim textX As Single = (Me.Width - textSize.Width) / 2
        Dim textY As Single = (Me.Height - textSize.Height) / 2
        g.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textX, textY)
    End Sub
End Class