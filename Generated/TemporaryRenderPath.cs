#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
#endregion
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls
{
    internal class TemporaryRenderPath : IRenderPath
    {
        public TemporaryRenderPath()
        {
            Path = new GraphicsPath();
        }
        public TemporaryRenderPath(PointF[] points, byte[] pathTypes)
        {
            Path = new GraphicsPath(points, pathTypes);
        }

        public GraphicsPath Path { get; set; }
        private float _cursorX;
        private float _cursorY;

        public void Close()
        {
            Path.CloseFigure();
        }

        public void Cubic(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Path.AddBezier(_cursorX, _cursorY, x1, y1, x2, y2, x3, y3);
            _cursorX = x3;
            _cursorY = y3;
        }

        public void Line(float x, float y)
        {
            Path.AddLine(_cursorX, _cursorY, x, y);
            _cursorX = x;
            _cursorY = y;

        }

        public void Move(float x, float y)
        {
            _cursorX = x;
            _cursorY = y;
        }

        const double pi3 = Math.PI / 3.0f;
        const double tau = Math.PI * 2.0f;
        const double tau3 = tau / 3;

        double Cbrt(double v)
        {
            // todo: better use Math.Cbrt. But that does not exist?
            if (v < 0)
                return -Math.Pow(1.0 / 3.0, -v);
            else
                return Math.Pow(1.0 / 3.0, v);
        }

        private bool approximately(double v, double comp, double epsilon = 1.0E-4F)
        {
            double diff = v - comp;
            return (-epsilon < diff) && (diff < epsilon);
        }

        private double[] SolvePolynom(double a, double b)
        {
            // 0 = a*x + b
            if (approximately(a, 0))
                return new double[0];

            return new double[1] { -b / a };
        }
        // ---------------------------------------------------------------------------

        private double[] SolvePolynom(double a, double b, double c)
        {
            // 0 = a*x² + bx + c
            if (approximately(a, 0.0f))
                return SolvePolynom(b, c);

            double s = b * b - 4 * a * c;

            if (s < 0.0)
                return new double[0];

            double sq = Math.Sqrt(s);

            return new double[2] {
                (-b - sq) / (2 * a),
                (-b + sq) / (2 * a) };
        }
        // ---------------------------------------------------------------------------

        private double [] SolvePolynom(double a, double b, double c, double d)
        {
            // 0 = a*x³ + bx² + cx + d
            if (approximately(a, 0.0f))
                return SolvePolynom(b, c, d);

            if (approximately(d, 0.0))
            {
                var tmp = SolvePolynom(a, b, c);
                // 0.0 is also a solution in this case, so add that to the result
                // todo: How do I do this in C#? tmp.Append(0.0);

                double[] result= new double[tmp.Length + 1];
                for (int i = 0; i < tmp.Length; i++)
                    result[i] = tmp[i];
                result[tmp.Length] = 0.0;

                return result;
            }

            // really cubic: Cardano

            double ba = b / a;
            double ca = c / a;
            double da = d / a;
            double a3 = ba / 3;
            double p = ca - ba * a3;
            double p3 = p / 3;
            double p33 = p3* p3 *p3;
            double q = a3* a3 *a3 - a3 * ca / 2 + da / 2;
            double discr = q* q +p33;

            if (discr > 0) // 1 solution
            {
                double sd = Math.Sqrt(discr);
                double u1 = Cbrt(-q + sd);
                double v1 = Cbrt(q + sd);
                return new double[1] { u1 - v1 - a3 };
            }
            else if (approximately(discr, 0.0f)) // 2 solutions
            {
                double u1 = -Cbrt(q);

                return new double[2] {
                    2 * u1 - a3,
                    -u1 - a3 };
            }

            double r = Math.Sqrt(-p33);
            double t1 = 2 * Math.Sqrt(-p3);
            double t = -q / r;

            double phi3;
            if (t < -1.0)
                phi3 = pi3;
            else if (t > 1.0)
                phi3 = 0;
            else
                phi3 = Math.Acos(t) / 3.0;

            return new double[3] {
                t1 * Math.Cos(phi3) - a3,
                t1 * Math.Cos(phi3 + tau3) - a3,
                t1 * Math.Cos(phi3 + 2 * tau3) - a3
            };
        }
        private double[] BezierGetFor(double p0, double p1, double p2, double p3)
        {
            return SolvePolynom(
                  -p0 + 3.0 * p1 - 3.0 * p2 + p3,
                 3 * p0 - 6.0 * p1 + 3.0 * p2,
                -3 * p0 + 3.0 * p1,
                   p0);
        }
        private double LinearInterpol(double t, double p0, double p1)
        {
            double t1 = 1.0 - t;
            return t1 * p0 + t * p1;
        }

        private double BezierInterpol(double t, double p0, double p1, double p2, double p3)
        {
            double t1 = 1.0 - t;
            return
                  t1 * t1 * t1 * p0 +
                3 * t1 * t1 * t * p1 +
                3 * t1 * t * t * p2 +
                   t * t * t * p3;
        }

        private float FindYforX(double x, PointF p0, PointF p1, PointF p2, PointF p3 )
        {
            // this will calc "t" values that correspond to "x"
            double[] ts = BezierGetFor(p0.X - x,
            p1.X - x,
            p2.X - x,
            p3.X - x);

            for (int i = 0; i < ts.Length; i++)
            {
                double t = ts[i];
                if ((t >= 0.0) && (t <= 1.0))
                    return (float)BezierInterpol(t, p0.Y, p1.Y, p2.Y, p3.Y);
            }
            // no solution? shouldn't happen
            return p0.Y;
        }

        public float GetYForX(float xvalue)
        {
            if (Path == null) return xvalue;

            int cnt = Path.PointCount;
            if (cnt < 2) return xvalue;

            double minX = 10000.0;
            double minY = 10000.0;
            double maxX = -10000.0;
            double maxY = -10000.0;

            int curves = (cnt - 1) / 3;
            var dp = Path.PathPoints;

            // note:
            // this only works if all points are in curves
            // (the code generator might take care of this)
            // Expectation: We don't need to solve this at runtime.
            // Of course, linear interpolation is also simple to do.
            // but the code was written for the monitor already

            for (int i = 0; i <= curves; i++)
            {
                double xv = dp[i * 3].X;
                double yv = dp[i * 3].Y;

                if (xv < minX) minX = xv;
                if (yv < minY) minY = yv;
                if (xv > maxX) maxX = xv;
                if (yv > maxY) maxY = yv;
            }

            double x = LinearInterpol(xvalue, minX, maxX);

            int curve = 0;
            for (curve = 0; curve < curves; curve++)
            {
                if ((x >= dp[curve * 3].X) &&
                    (x <= dp[curve * 3 + 3].X)) break;
            }
            if (curve >= curves) return 1.0f;

            double y = FindYforX(x, dp[curve * 3], dp[curve * 3 + 1], dp[curve * 3 + 2], dp[curve * 3 + 3]);

            double ty = (maxY - y) / (maxY - minY);

            return (float)ty;
        }
    }


}