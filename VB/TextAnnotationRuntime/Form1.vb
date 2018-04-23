Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace TextAnnotationRuntime
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' Create a text annotation. 
            Dim sp As SeriesPoint = Me.chartControl1.Series("Series 1").Points(1)
            Dim annotation As New TextAnnotation("Annotation 1", "test")

            ' Change the text annotation font style to bold.  
            If annotation IsNot Nothing Then
                annotation.Font = New Font(annotation.Font.FontFamily, annotation.Font.Size, FontStyle.Bold)
            End If

            ' Specify the text annotation position. 
            annotation.AnchorPoint = New SeriesPointAnchorPoint(sp)
            annotation.ShapePosition = New RelativePosition()
            Dim position As RelativePosition = TryCast(annotation.ShapePosition, RelativePosition)
            position.ConnectorLength = 50
            position.Angle = 270
            annotation.RuntimeMoving = True

            ' Add an annotaion to the annotation repository. 
            Me.chartControl1.AnnotationRepository.Add(annotation)
        End Sub
    End Class
End Namespace
