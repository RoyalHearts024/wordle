using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConsoleKeyInfo bt;
        int sat = 0, sut = 0;
        string kelime,kelime1;
        char[] kel1;
        char[] kel2;
        bool h_var_mi=false;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            kelime = "KELAM";
            kel2 = kelime.ToCharArray();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
            button26.BackColor = Color.White;
            button27.BackColor = Color.White;
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
            button31.BackColor = Color.White;
            button32.BackColor = Color.White;
            button33.BackColor = Color.White;
            button34.BackColor = Color.White;
            button35.BackColor = Color.White;
            button36.BackColor = Color.White;
            button37.BackColor = Color.White;
            button38.BackColor = Color.White;
            button39.BackColor = Color.White;
            button40.BackColor = Color.White;
            button41.BackColor = Color.White;
            button42.BackColor = Color.White;
            button43.BackColor = Color.White;
            button44.BackColor = Color.White;
            button45.BackColor = Color.White;
            button46.BackColor = Color.White;
            button47.BackColor = Color.White;
            button48.BackColor = Color.White;
            button49.BackColor = Color.White;
            button50.BackColor = Color.White;
            button51.BackColor = Color.White;
            button52.BackColor = Color.White;
            button53.BackColor = Color.White;
            button54.BackColor = Color.White;
            button55.BackColor = Color.White;
            button56.BackColor = Color.White;
            button57.BackColor = Color.White;
            button58.BackColor = Color.White;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (sat == 0)
                {
                    switch (sut)
                    {
                        case 1: button1.Text = ""; sut--; break;
                        case 2: button2.Text = ""; sut--; break;
                        case 3: button3.Text = ""; sut--; break;
                        case 4: button4.Text = ""; sut--; break;
                        case 5: button5.Text = ""; sut--; break;
                    }
                }
                else if (sat == 1)
                {
                    switch (sut)
                    {
                        case 1: button6.Text = ""; sut--; break;
                        case 2: button7.Text = ""; sut--; break;
                        case 3: button8.Text = ""; sut--; break;
                        case 4: button9.Text = ""; sut--; break;
                        case 5: button10.Text = ""; sut--; break;
                    }
                }
                else if (sat == 2)
                {
                    switch (sut)
                    {
                        case 1: button11.Text = ""; sut--; break;
                        case 2: button12.Text = ""; sut--; break;
                        case 3: button13.Text = ""; sut--; break;
                        case 4: button14.Text = ""; sut--; break;
                        case 5: button15.Text = ""; sut--; break;
                    }
                }
                else if (sat == 3)
                {
                    switch (sut)
                    {
                        case 1: button16.Text = ""; sut--; break;
                        case 2: button17.Text = ""; sut--; break;
                        case 3: button18.Text = ""; sut--; break;
                        case 4: button19.Text = ""; sut--; break;
                        case 5: button20.Text = ""; sut--; break;
                    }
                }
                else if (sat == 4)
                {
                    switch (sut)
                    {
                        case 0: button21.Text = ""; sut--; break;
                        case 1: button22.Text = ""; sut--; break;
                        case 2: button23.Text = ""; sut--; break;
                        case 3: button24.Text = ""; sut--; break;
                        case 4: button25.Text = ""; sut--; break;
                    }
                }
            }
            if (e.KeyCode == Keys.Enter && sut == 5)
            {
                switch (sat)
                {
                    case 0:kelime1 = button1.Text + button2.Text + button3.Text + button4.Text + button5.Text; break;
                    case 1: kelime1 = button6.Text + button7.Text + button8.Text + button9.Text + button10.Text; break;
                    case 2: kelime1 = button11.Text + button12.Text + button13.Text + button14.Text + button15.Text; break;
                    case 3: kelime1 = button16.Text + button17.Text + button18.Text + button19.Text + button20.Text; break;
                    case 4: kelime1 = button21.Text + button22.Text + button23.Text + button24.Text + button25.Text; break;
                }
                kel1 = kelime1.ToCharArray();
                if (kel1[0] == kel2[0])
                {
                    switch (sat)
                    {
                        case 0: button1.BackColor = Color.Green; renk(kel2[0].ToString(), "Green"); break;
                        case 1: button6.BackColor = Color.Green; renk(kel2[0].ToString(), "Green"); break;
                        case 2: button11.BackColor = Color.Green; renk(kel2[0].ToString(), "Green"); break;
                        case 3: button16.BackColor = Color.Green; renk(kel2[0].ToString(), "Green"); break;
                        case 4: button21.BackColor = Color.Green; renk(kel2[0].ToString(), "Green"); break;
                    }
                }
                if (kel1[0] == kel2[1])
                {
                    switch (sat)
                    {
                        case 0: if (button1.BackColor != Color.Green) {button1.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 1: if (button6.BackColor != Color.Green) {button6.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 2: if (button11.BackColor != Color.Green){ button11.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 3: if (button16.BackColor != Color.Green){ button16.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 4: if (button21.BackColor != Color.Green) { button21.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[0] == kel2[2])
                {
                    switch (sat)
                    {
                        case 0: if (button1.BackColor != Color.Green) {button1.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 1: if (button6.BackColor != Color.Green) {button6.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 2: if (button11.BackColor != Color.Green){ button11.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 3: if (button16.BackColor != Color.Green){ button16.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 4: if (button21.BackColor != Color.Green) { button21.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[0] == kel2[3])
                {
                    switch (sat)
                    {
                        case 0: if (button1.BackColor != Color.Green) {button1.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 1: if (button6.BackColor != Color.Green) {button6.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 2: if (button11.BackColor != Color.Green){ button11.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 3: if (button16.BackColor != Color.Green){ button16.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 4: if (button21.BackColor != Color.Green) { button21.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[0] == kel2[4])
                {
                    switch (sat)
                    {
                        case 0: if (button1.BackColor != Color.Green) {button1.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 1: if (button6.BackColor != Color.Green) {button6.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 2: if (button11.BackColor != Color.Green){ button11.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 3: if (button16.BackColor != Color.Green){ button16.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 4: if (button21.BackColor != Color.Green) { button21.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[1] == kel2[0])
                {
                    switch (sat)
                    {
                        case 0: if (button2.BackColor != Color.Green) {button2.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 1: if (button7.BackColor != Color.Green) {button7.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 2: if (button12.BackColor != Color.Green){ button12.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 3: if (button17.BackColor != Color.Green){ button17.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 4: if (button22.BackColor != Color.Green) { button22.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[1] == kel2[1])
                {
                    switch (sat)
                    {
                        case 0: button2.BackColor = Color.Green; renk(kel2[1].ToString(), "Green"); break;
                        case 1: button7.BackColor = Color.Green; renk(kel2[1].ToString(), "Green"); break;
                        case 2: button12.BackColor = Color.Green; renk(kel2[1].ToString(), "Green"); break;
                        case 3: button17.BackColor = Color.Green; renk(kel2[1].ToString(), "Green"); break;
                        case 4: button22.BackColor = Color.Green; renk(kel2[1].ToString(), "Green"); break;
                    }
                }
                if (kel1[1] == kel2[2])
                {
                    switch (sat)
                    {
                        case 0: if (button2.BackColor != Color.Green) {button2.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 1: if (button7.BackColor != Color.Green) {button7.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 2: if (button12.BackColor != Color.Green){ button12.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 3: if (button17.BackColor != Color.Green){ button17.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 4: if (button22.BackColor != Color.Green) { button22.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[1] == kel2[3])
                {
                    switch (sat)
                    {
                        case 0: if (button2.BackColor != Color.Green) {button2.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 1: if (button7.BackColor != Color.Green) {button7.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 2: if (button12.BackColor != Color.Green){ button12.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 3: if (button17.BackColor != Color.Green){ button17.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 4: if (button22.BackColor != Color.Green) { button22.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[1] == kel2[4])
                {
                    switch (sat)
                    {
                        case 0: if (button2.BackColor != Color.Green) {button2.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 1: if (button7.BackColor != Color.Green) {button7.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 2: if (button12.BackColor != Color.Green){ button12.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 3: if (button17.BackColor != Color.Green){ button17.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 4: if (button22.BackColor != Color.Green) { button22.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[2] == kel2[0])
                {
                    switch (sat)
                    {
                        case 0: if (button3.BackColor != Color.Green) { button3.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 1: if (button8.BackColor != Color.Green)  {button8.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 2: if (button13.BackColor != Color.Green) {button13.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 3: if (button18.BackColor != Color.Green) {button18.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 4: if (button23.BackColor != Color.Green) { button23.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[2] == kel2[1])
                {
                    switch (sat)
                    {
                        case 0: if (button3.BackColor != Color.Green) {button3.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 1: if (button8.BackColor != Color.Green) {button8.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 2: if (button13.BackColor != Color.Green){ button13.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 3: if (button18.BackColor != Color.Green){ button18.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 4: if (button23.BackColor != Color.Green) { button23.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[2] == kel2[2])
                {
                    switch (sat)
                    {
                        case 0: button3.BackColor = Color.Green; renk(kel2[2].ToString(), "Green"); break;
                        case 1: button8.BackColor = Color.Green; renk(kel2[2].ToString(), "Green"); break;
                        case 2: button13.BackColor = Color.Green; renk(kel2[2].ToString(), "Green"); break;
                        case 3: button18.BackColor = Color.Green; renk(kel2[2].ToString(), "Green"); break;
                        case 4: button23.BackColor = Color.Green; renk(kel2[2].ToString(), "Green"); break;
                    }
                }
                if (kel1[2] == kel2[3])
                {
                    switch (sat)
                    {
                        case 0: if (button3.BackColor != Color.Green) {button3.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 1: if (button8.BackColor != Color.Green) {button8.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 2: if (button13.BackColor != Color.Green){ button13.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 3: if (button18.BackColor != Color.Green){ button18.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 4: if (button23.BackColor != Color.Green) { button23.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[2] == kel2[4])
                {
                    switch (sat)
                    {
                        case 0: if (button3.BackColor != Color.Green) {button3.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 1: if (button8.BackColor != Color.Green) {button8.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 2: if (button13.BackColor != Color.Green){ button13.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 3: if (button18.BackColor != Color.Green){ button18.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 4: if (button23.BackColor != Color.Green) { button23.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[3] == kel2[0])
                {
                    switch (sat)
                    {
                        case 0: if (button4.BackColor != Color.Green) {button4.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 1: if (button9.BackColor != Color.Green) {button9.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 2: if (button14.BackColor != Color.Green){ button14.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 3: if (button19.BackColor != Color.Green){ button19.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 4: if (button24.BackColor != Color.Green) { button24.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[3] == kel2[1])
                {
                    switch (sat)
                    {
                        case 0: if (button4.BackColor != Color.Green) {button4.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 1: if (button9.BackColor != Color.Green) {button9.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 2: if (button14.BackColor != Color.Green){ button14.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 3: if (button19.BackColor != Color.Green){ button19.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 4: if (button24.BackColor != Color.Green) { button24.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                    }
                }
                
                if (kel1[3] == kel2[2])
                {
                    switch (sat)
                    {
                        case 0: if (button4.BackColor != Color.Green) {button4.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 1: if (button9.BackColor != Color.Green) {button9.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 2: if (button14.BackColor != Color.Green){ button14.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 3: if (button19.BackColor != Color.Green){ button19.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 4: if (button24.BackColor != Color.Green) { button24.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[3] == kel2[3])
                {
                    switch (sat)
                    {
                        case 0: button4.BackColor = Color.Green; renk(kel2[3].ToString(), "Green"); break;
                        case 1: button9.BackColor = Color.Green; renk(kel2[3].ToString(), "Green"); break;
                        case 2: button14.BackColor = Color.Green; renk(kel2[3].ToString(), "Green"); break;
                        case 3: button19.BackColor = Color.Green; renk(kel2[3].ToString(), "Green"); break;
                        case 4: button24.BackColor = Color.Green; renk(kel2[3].ToString(), "Green"); break;
                    }
                }
                if (kel1[3] == kel2[4])
                {
                    switch (sat)
                    {
                        case 0: if (button4.BackColor != Color.Green) {button4.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 1: if (button9.BackColor != Color.Green) {button9.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 2: if (button14.BackColor != Color.Green){ button14.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 3: if (button19.BackColor != Color.Green){ button19.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                        case 4: if (button24.BackColor != Color.Green) { button24.BackColor = Color.Yellow; renk(kel2[4].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[4] == kel2[0])
                {
                    switch (sat)
                    {
                        case 0: if (button5.BackColor != Color.Green) {button5.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 1: if (button10.BackColor != Color.Green){ button10.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 2: if (button15.BackColor != Color.Green){ button15.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 3: if (button20.BackColor != Color.Green){ button20.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                        case 4: if (button25.BackColor != Color.Green) { button25.BackColor = Color.Yellow; renk(kel2[0].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[4] == kel2[1])
                {
                    switch (sat)
                    {
                        case 0: if (button5.BackColor != Color.Green) {button5.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 1: if (button10.BackColor != Color.Green){ button10.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 2: if (button15.BackColor != Color.Green){ button15.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 3: if (button20.BackColor != Color.Green){ button20.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                        case 4: if (button25.BackColor != Color.Green) { button25.BackColor = Color.Yellow; renk(kel2[1].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[4] == kel2[2])
                {
                    switch (sat)
                    {
                        case 0: if (button5.BackColor != Color.Green) {button5.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 1: if (button10.BackColor != Color.Green){ button10.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 2: if (button15.BackColor != Color.Green){ button15.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 3: if (button20.BackColor != Color.Green){ button20.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                        case 4: if (button25.BackColor != Color.Green) { button25.BackColor = Color.Yellow; renk(kel2[2].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[4] == kel2[3])
                {
                    switch (sat)
                    {
                        case 0: if (button5.BackColor != Color.Green) {button5.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 1: if (button10.BackColor != Color.Green){ button10.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 2: if (button15.BackColor != Color.Green){ button15.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 3: if (button20.BackColor != Color.Green){ button20.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                        case 4: if (button25.BackColor != Color.Green) { button25.BackColor = Color.Yellow; renk(kel2[3].ToString(), "Yellow"); } break;
                    }
                }
                if (kel1[4] == kel2[4])
                {
                    switch (sat)
                    {
                        case 0: button5.BackColor = Color.Green; renk(kel2[4].ToString(), "Green"); break;
                        case 1: button10.BackColor = Color.Green; renk(kel2[4].ToString(), "Green"); break;
                        case 2: button15.BackColor = Color.Green; renk(kel2[4].ToString(), "Green"); break;
                        case 3: button20.BackColor = Color.Green; renk(kel2[4].ToString(), "Green"); break;
                        case 4: button25.BackColor = Color.Green; renk(kel2[4].ToString(), "Green"); break;
                    }
                }
                if (kelime == kelime1)
                {
                    MessageBox.Show("Kazandýn");
                }
                sat++;
                sut = 0;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sat == 0)
            {
                switch (sut)
                {
                    case 0: if (char.IsLetter(e.KeyChar)) { button1.Text = e.KeyChar.ToString().ToUpper(); sut++;} break;
                    case 1: if (char.IsLetter(e.KeyChar)) { button2.Text = e.KeyChar.ToString().ToUpper(); sut++;} break;
                    case 2: if (char.IsLetter(e.KeyChar)) { button3.Text = e.KeyChar.ToString().ToUpper(); sut++;} break;
                    case 3: if (char.IsLetter(e.KeyChar)) { button4.Text = e.KeyChar.ToString().ToUpper(); sut++;} break;
                    case 4: if (char.IsLetter(e.KeyChar)) { button5.Text = e.KeyChar.ToString().ToUpper(); sut++;} break;
                }
            }
            else if (sat == 1)
            {
                switch (sut)
                {
                    case 0: if (char.IsLetter(e.KeyChar)) { button6.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 1: if (char.IsLetter(e.KeyChar)) { button7.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 2: if (char.IsLetter(e.KeyChar)) { button8.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 3: if (char.IsLetter(e.KeyChar)) { button9.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 4: if (char.IsLetter(e.KeyChar)) { button10.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                }
            }
            else if (sat == 2)
            {
                switch (sut)
                {
                    case 0: if (char.IsLetter(e.KeyChar)) { button11.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 1: if (char.IsLetter(e.KeyChar)) { button12.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 2: if (char.IsLetter(e.KeyChar)) { button13.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 3: if (char.IsLetter(e.KeyChar)) { button14.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 4: if (char.IsLetter(e.KeyChar)) { button15.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                }
            }
            else if (sat == 3)
            {
                switch (sut)
                {
                    case 0: if (char.IsLetter(e.KeyChar)) { button16.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 1: if (char.IsLetter(e.KeyChar)) { button17.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 2: if (char.IsLetter(e.KeyChar)) { button18.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 3: if (char.IsLetter(e.KeyChar)) { button19.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 4: if (char.IsLetter(e.KeyChar)) { button20.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                }
            }
            else if (sat == 4)
            {
                switch (sut)
                {
                    case 0: if (char.IsLetter(e.KeyChar)) { button21.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 1: if (char.IsLetter(e.KeyChar)) { button22.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 2: if (char.IsLetter(e.KeyChar)) { button23.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 3: if (char.IsLetter(e.KeyChar)) { button24.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                    case 4: if (char.IsLetter(e.KeyChar)) { button25.Text = e.KeyChar.ToString().ToUpper(); sut++; } break;
                }
            }
        }
        public void renk(string harf, string reng)
        {
            if (harf == "S")
            {
                if (reng == "Green")
                {
                    button39.BackColor = Color.Green;
                }
                else if (reng == "Yellow" && button39.BackColor != Color.Green)
                {
                    button39.BackColor = Color.Yellow;
                }
                else if (button39.BackColor != Color.Green || button39.BackColor != Color.Yellow)
                { 
                    button39.BackColor = Color.Gray;
                }
            }
            
        }
    }
    
}

