public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private const int PEN_WIDTH = 3;
      private const LineCap START_CAP = LineCap.ArrowAnchor;
      private const LineCap END_CAP = LineCap.ArrowAnchor;
      Point mAnchorPoint = new Point(10, 10);
      Point mPreviousPoint = Point.Empty;

      private void panel1_MouseMove(object sender, MouseEventArgs e)
      {
         using (Graphics g = panel1.CreateGraphics())
         {
            // Clear last line drawn
            using (Pen clear_pen = new Pen(panel1.BackColor, PEN_WIDTH))
            {
              clear_pen.StartCap = START_CAP;
               clear_pen.EndCap = END_CAP;
               g.DrawLine(clear_pen, mAnchorPoint, mPreviousPoint);
            }

            // Update previous point
            mPreviousPoint = e.Location;
