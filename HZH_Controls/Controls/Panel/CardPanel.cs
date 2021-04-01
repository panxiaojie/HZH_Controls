using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HZH_Controls.Controls
{
    public class CardPanel : System.Windows.Forms.Panel
    {
        private bool _borderRadiusShow = false;
        private bool _BorderUpDown = false;
        private int _lineCount = 0;
        private string _Title = "";
        /// <summary>
        /// 是否显示圆角
        /// </summary>
        [Description("是否显示四个圆角"), Category("自定义")]
        public virtual bool BorderRadiusShow
        {
            get
            {
                return this._borderRadiusShow;
            }
            set
            {
                this._borderRadiusShow = value;
                Refresh();
            }
        }
        /// <summary>
        /// 是否显示圆角
        /// </summary>
        [Description("ture上圆角，false下圆角"), Category("自定义")]
        public virtual bool BorderUpDown
        {
            get
            {
                return this._BorderUpDown;
            }
            set
            {
                this._BorderUpDown = value;
                Refresh();
            }
        }
        [Description("线条数量"), Category("自定义")]
        public virtual int LineCount
        {
            get
            {
                return this._lineCount;
            }
            set
            {
                this._lineCount = value;
                Refresh();
            }

        }
        [Description("卡片标题"), Category("自定义")]
        public virtual string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this._Title = value;
                Refresh();
            }
        }
        /// <summary>
        /// The head selected border color
        /// </summary>
        private Color _TitleBackColor = Color.LightBlue;
        /// <summary>
        /// Gets or sets the color of the head selected border.
        /// </summary>
        /// <value>The color of the head selected border.</value>
        [DefaultValue(typeof(Color), "232, 232, 232")]
        [Description("标题的背景颜色")]
        public Color TitleBackColor
        {
            get { return _TitleBackColor; }
            set { _TitleBackColor = value; Refresh(); }
        }
        /// <summary>
        /// The head selected border color
        /// </summary>
        private Color _TitleFontColor = Color.Gray;
        /// <summary>
        /// Gets or sets the color of the head selected border.
        /// </summary>
        /// <value>The color of the head selected border.</value>
        [Description("标题的字体颜色")]
        public Color TitleFontColor
        {
            get { return _TitleFontColor; }
            set { _TitleFontColor = value; Refresh(); }
        }
        /// <summary>
        /// The head selected border color
        /// </summary>
        private Font _TitleFont= new Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        /// <summary>
        /// Gets or sets the color of the head selected border.
        /// </summary>
        /// <value>The color of the head selected border.</value>
        [Description("标题字体类型")]
        public Font TitleFont
        {
            get { return _TitleFont; }
            set { _TitleFont = value; Refresh(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;//使绘图质量最高，即消除锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            GraphicsPath pathBounds = new GraphicsPath();
            GraphicsPath TitlePath = new GraphicsPath();
            int borderwidth = 10;
            int nWidth = base.Width - 1;
            int nHeight = base.Height - 1;
            if (!_borderRadiusShow && _BorderUpDown)
            {
                pathBounds.AddArc(0, 0, borderwidth, borderwidth, 180f, 90f);
                pathBounds.AddLine(new Point(borderwidth, 0), new Point(nWidth - borderwidth, 0));
                pathBounds.AddArc(nWidth - borderwidth, 0, borderwidth, borderwidth, 270f, 90f);
                pathBounds.AddLine(new Point(nWidth, borderwidth), new Point(nWidth, nHeight));
                pathBounds.AddLine(new Point(nWidth, nHeight), new Point(0, nHeight));
                pathBounds.AddLine(new Point(0, nHeight), new Point(0, borderwidth / 2));



            }
            else if (!_borderRadiusShow && !_BorderUpDown)
            {
                borderwidth = 5;
                // pathBounds.AddLine(new Point(0, 0), new Point(nWidth, 0));
                pathBounds.AddLine(new Point(nWidth, 0), new Point(nWidth, nHeight - borderwidth));
                pathBounds.AddArc(nWidth - borderwidth - 1, nHeight - borderwidth - 1, borderwidth, borderwidth, 0f, 90f);
                pathBounds.AddLine(new Point(nWidth - borderwidth, nHeight), new Point(borderwidth, nHeight));
                pathBounds.AddArc(0, nHeight - borderwidth - 1, borderwidth, borderwidth, 90f, 90f);
                pathBounds.AddLine(new Point(0, nHeight - borderwidth), new Point(0, 0));
            }
            else
            {
                pathBounds.AddArc(0, 0, borderwidth, borderwidth, 180f, 90f);
                pathBounds.AddLine(new Point(borderwidth, 0), new Point(nWidth - borderwidth, 0));
                pathBounds.AddArc(nWidth - borderwidth - 1, 0, borderwidth, borderwidth, 270f, 90f);
                pathBounds.AddLine(new Point(nWidth, borderwidth), new Point(nWidth, nHeight - borderwidth));
                pathBounds.AddArc(nWidth - borderwidth - 1, nHeight - borderwidth - 1, borderwidth, borderwidth, 0f, 90f);
                pathBounds.AddLine(new Point(nWidth - borderwidth, nHeight), new Point(borderwidth, nHeight));
                pathBounds.AddArc(0, nHeight - borderwidth - 1, borderwidth, borderwidth, 90f, 90f);
                pathBounds.AddLine(new Point(0, nHeight - borderwidth), new Point(0, borderwidth / 2));
                for (int i = 0; i < _lineCount; i++)
                {
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(201, 204, 209), 1), new Point(0, 30 * (i + 1)), new Point(300, 30 * (i + 1)));
                }
            }
            if (!string.IsNullOrEmpty(_Title))
            {
                using (SolidBrush brush = new SolidBrush(_TitleBackColor))
                {
                    int TitleHight = TitleFont.Height  + TitleFont.Height/3*2;//+ borderwidth
                    TitlePath.AddArc(0, 0, borderwidth, borderwidth, 180f, 90f);
                    TitlePath.AddLine(new Point(borderwidth, 0), new Point(nWidth - borderwidth, 0));
                    TitlePath.AddArc(nWidth - borderwidth - 1, 0, borderwidth, borderwidth, 270f, 90f);
                    TitlePath.AddLine(new Point(nWidth, borderwidth), new Point(nWidth, TitleHight));
                    TitlePath.AddLine(new Point(nWidth, TitleHight), new Point(borderwidth, TitleHight));
                    TitlePath.AddLine(new Point(0, TitleHight), new Point(0, borderwidth / 2));

                    e.Graphics.FillPath(brush, TitlePath);
                    brush.Color = _TitleFontColor;
                    e.Graphics.DrawString(_Title, TitleFont, brush,new Point(borderwidth+3, TitleFont.Height / 3));
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;//抗锯齿

                }
            }
            e.Graphics.DrawPath(new Pen(Color.FromArgb(201, 204, 209), 1), pathBounds);
            // e.Graphics.DrawPath(new Pen(Color.Red, 1), pathBounds);
        }

    }
}
