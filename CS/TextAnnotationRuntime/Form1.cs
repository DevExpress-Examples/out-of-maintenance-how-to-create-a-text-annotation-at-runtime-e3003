using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace TextAnnotationRuntime {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e) {
            SeriesPoint sp = this.chartControl1.Series["Series 1"].Points[1];
            TextAnnotation annotation = new TextAnnotation("Annotation 1", "test");
            annotation.AnchorPoint = new SeriesPointAnchorPoint(sp);
            annotation.ShapePosition = new RelativePosition();
            RelativePosition position = annotation.ShapePosition as RelativePosition;
            position.ConnectorLength = 50;
            position.Angle = 270;
            annotation.RuntimeMoving = true;
            this.chartControl1.AnnotationRepository.Add(annotation);
        }
    }
}
