using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CncDrill
{
    public class ExcellonViewer : Panel
    {
        public List<Coordinate> Coordinates { get; set; }

        public float ZoomDelta { get; set; }



        public ExcellonViewer()
        {
        }

        public void Traaa()
        {
            Rectangle r = this.ClientRectangle;
            // Subtract 100 pixels from each side of the Rectangle.
            r.Inflate(-100, -100);
            this.Bounds = this.RectangleToScreen(r);
        }





        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen m_TestPen = new Pen(Brushes.Red, 1.0f);
            e.Graphics.DrawEllipse(m_TestPen, new Rectangle(0, 0, 5, 5));



            // Resize the form.


            if (this.Coordinates != null && this.Coordinates.Count > 0)
            {
                Point m_Thereshold = FindLowestCoordinates();


                int m_Index = 0;

                MainForm m_Main = Application.OpenForms[0] as MainForm;
                this.Coordinates.ForEach(delegate(Coordinate m_Coordinate)
                {
                    if (m_Coordinate != null)
                    {
                        Pen m_Pen = null;

                        if (m_Index == 0)
                        {
                            if (m_Main.FirstPadOffsetted == true)
                                m_Pen = new Pen(Brushes.LimeGreen, 1.0F);
                            else
                                m_Pen = new Pen(Brushes.Red, 1.0f);
                        }

                        else if (m_Index == 1)
                        {
                            
                            if (m_Main.SecondPadOffsetted == true)
                                m_Pen = new Pen(Brushes.LimeGreen, 1.0F);
                            else
                                m_Pen = new Pen(Brushes.White, 1.0f);
                        }

                        else if (m_Index == 2)
                        {
                            if (m_Main.ThirdPadOffsetted == true)
                                m_Pen = new Pen(Brushes.LimeGreen, 1.0F);
                            else
                                m_Pen = new Pen(Brushes.Aquamarine, 1.0f);
                        }

                        else
                            m_Pen = new Pen(Brushes.Yellow, 1.0F);



                        m_Coordinate.X += Math.Abs(m_Thereshold.X);
                        m_Coordinate.Y += Math.Abs(m_Thereshold.Y);

                        Rectangle m_Rectange = new Rectangle((int)(m_Coordinate.X * 0.02542), (int)(m_Coordinate.Y * 0.02542), 4, 4);

                        if (this.ZoomDelta > 0)
                        {
                            m_Rectange.X = (int)(m_Rectange.X * this.ZoomDelta);
                            m_Rectange.Y = (int)(m_Rectange.Y * this.ZoomDelta);
                            m_Rectange.Width = (int)(m_Rectange.Width * this.ZoomDelta);
                            m_Rectange.Height = (int)(m_Rectange.Height * this.ZoomDelta);
                        }

                        e.Graphics.DrawEllipse(m_Pen, m_Rectange);
                        e.Graphics.FillEllipse(m_Pen.Brush, m_Rectange);

                        m_Index++;
                    }

                });
            }

        }


        private Point FindLowestCoordinates()
        {
            int m_LowestX = 0;
            int m_LowestY = 0;

            this.Coordinates.ForEach(delegate(Coordinate m_Coordinate)
            {
                if (m_Coordinate.X <= m_LowestX)
                    m_LowestX = m_Coordinate.X;

                if (m_Coordinate.Y <= m_LowestY)
                    m_LowestY = m_Coordinate.Y;

            });

            return new Point(m_LowestX, m_LowestY);
        }


    }
}
