using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace TextAnnotationRuntime {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Create a text annotation. 
            SeriesPoint sp = this.chartControl1.Series["Series 1"].Points[1];
            TextAnnotation annotation = new TextAnnotation("Annotation 1", "test");

            // Change the text annotation font style to bold.  
            if (annotation != null)
                annotation.Font = new Font(annotation.Font.FontFamily, annotation.Font.Size, FontStyle.Bold);

            // Specify the text annotation position. 
            annotation.AnchorPoint = new SeriesPointAnchorPoint(sp);
            annotation.ShapePosition = new RelativePosition();
            RelativePosition position = annotation.ShapePosition as RelativePosition;
            position.ConnectorLength = 50;
            position.Angle = 270;
            annotation.RuntimeMoving = true;

            // Add an annotaion to the annotation repository. 
            this.chartControl1.AnnotationRepository.Add(annotation);
        }
    }
}
