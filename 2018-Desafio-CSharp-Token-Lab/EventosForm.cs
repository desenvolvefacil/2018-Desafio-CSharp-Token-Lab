using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2018_Desafio_CSharp_Token_Lab
{
    public partial class EventosForm : Form
    {
        MyMonthCalendar myMonthCalendar;

        public EventosForm()
        {
            InitializeComponent();

            myMonthCalendar = new MyMonthCalendar();

            Font f = new Font(FontFamily.GenericSansSerif, 22);

            myMonthCalendar.Font = f;

            myMonthCalendar.MaxSelectionCount = 1;


            myMonthCalendar.DoubleClick += Calendar_Double_Click;

            this.Controls.Add(myMonthCalendar);

            MarcarEventos();

        }

        private void Calendar_Double_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = myMonthCalendar.SelectionStart;

            //int a = 10;
        }


        private void MarcarEventos()
        {

        }
    }


    //cria um calendario sem estilo
    public class MyMonthCalendar : MonthCalendar
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, string.Empty, string.Empty);
            base.OnHandleCreated(e);
        }

        private Point LastClickPosition = Point.Empty;
        private long LastClickTime = 0;
        private bool LastClickRaisedDoubleClick = false;

        public event EventHandler DoubleClick;

        protected override void OnDoubleClick(EventArgs e)
        {
            if (this.DoubleClick != null)
                this.DoubleClick(this, EventArgs.Empty);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.LastClickRaisedDoubleClick &&
                  DateTime.Now.Ticks - this.LastClickTime <= SystemInformation.DoubleClickTime * 10000 &&
                  this.IsInDoubleClickArea(this.LastClickPosition, Cursor.Position))
                {
                    if (this.DoubleClick != null)
                        this.DoubleClick(this, EventArgs.Empty);
                    this.LastClickRaisedDoubleClick = true;
                }
                else
                    this.LastClickRaisedDoubleClick = false;

                this.LastClickPosition = Cursor.Position;
                this.LastClickTime = DateTime.Now.Ticks;
            }
            base.OnMouseDown(e);
        }

        private bool IsInDoubleClickArea(Point point1, Point point2)
        {
            return
             Math.Abs(point1.X - point2.X) <= SystemInformation.DoubleClickSize.Width &&
             Math.Abs(point1.Y - point2.Y) <= SystemInformation.DoubleClickSize.Height;
        }
    }


}
