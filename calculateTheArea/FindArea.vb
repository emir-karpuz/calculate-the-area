Module FindArea
#Region "Shapes"
    Public Class Shapes
        Public ReadOnly Property length As Integer
        Public ReadOnly Property width As Integer

        Public Sub New(length As Integer, width As Integer)
            Me.length = length
            Me.width = width
        End Sub

        Public Overridable Function getArea() As Integer
            Console.WriteLine("Çevre: " & Me.length * Me.width)
            Return Me.length * Me.width
        End Function

    End Class
#End Region

#Region "Volume"
    Public Class Volume : Inherits Shapes

        Private Property height As Integer

        Public Sub New(length As Integer, width As Integer, height As Integer)
            MyBase.New(length, width)
            Me.height = height
        End Sub

        Public Overrides Function getArea() As Integer
            Console.WriteLine("Hacim: " & Me.height * (length + width))
            Return Me.height * (length + width)
        End Function

    End Class
#End Region

    Sub Main()
        Dim rectangular = New Shapes(30, 20)
        rectangular.getArea()

        Dim rectanguleVolume = New Volume(10, 20, 30)
        rectanguleVolume.getArea()

        Console.ReadLine()
    End Sub

End Module