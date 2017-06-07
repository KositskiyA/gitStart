using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;



namespace WindowsFormsApp2
{
    delegate void HelpMovment(Button btn);
    public partial class MainForm : Form
    {
        static Random R;
        HelpMovment HM;
        Button[] massButton;
        List<Button> listButtons;
        Thread[] massThread;

        public MainForm()
        {
            InitializeComponent();
            R = new Random();
            HM = new HelpMovment(Movment);
            massButton = new Button[3];
            massButton[0] = btn1;
            massButton[1] = btn2;
            massButton[2] = btn3;

            listButtons = new List<Button>();
            listButtons.AddRange(massButton);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (massThread != null)
                ThreadResume(massThread);
            else
                ThreadInit();
            Start_Button.Enabled = false;
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            ThreadSuspend(massThread);
            Start_Button.Enabled = true;
        }
        private void Stope_Click(object sender, EventArgs e)
        {
            Pause_Click(sender, e);
            DefaultButtonParams(massButton);
        }

        void DefaultButtonParams(params Button[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i].Location = new Point(25, list[i].Location.Y);
                list[i].BackColor = Color.White;
            }
        }

        void MoveButtonMethod1()
        {
            while (true)
            {
                Thread.Sleep(500);
                Invoke(HM, btn1);
            }
        }
        void MoveButtonMethod2()
        {
            while (true)
            {
                Thread.Sleep(500);
                Invoke(HM, btn2);
            }
        }
        void MoveButtonMethod3()
        {
            while (true)
            {
                Thread.Sleep(500);
                Invoke(HM, btn3);
            }
        }

        void Movment(Button btn)
        {
            btn.Location = new Point(btn.Location.X + R.Next(0, 30), btn.Location.Y);
            var query = from buttonNomber in listButtons
                        orderby buttonNomber.Location.X
                        select buttonNomber;

            massButton = query.ToArray();
            SetColorForWiner(Color.Yellow, massButton);
            Finish(btn);
        }

        private void Finish(Button btn)
        {
            if (btn.Location.X > (pictureBox1.Location.X))
            {
                this.Pause_Click(new object(), new EventArgs());
                MessageBox.Show("Выиграла кнопка "+btn.Text);
                Start_Button.Enabled = false;
            }
        }

        void SetColorForWiner(Color color, params Button[] list)
        {
            list[list.Length - 1].BackColor = color;
            for (int i = 0; i < list.Length - 1; i++)
            {
                list[i].BackColor = Color.White;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stope_Click(sender, e);
        }
        void ThreadInit()
        {
            massThread = new Thread[3];
            massThread[0] = new Thread(MoveButtonMethod1);
            massThread[1] = new Thread(MoveButtonMethod2);
            massThread[2] = new Thread(MoveButtonMethod3);

            massThread[0].Start();
            massThread[1].Start();
            massThread[2].Start();
        }
        void ThreadResume(Thread[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i].Resume();
            }
        }
        void ThreadSuspend(Thread[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i].Suspend();
            }
        }
    }
}