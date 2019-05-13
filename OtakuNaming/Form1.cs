using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        //MessageBoxButtons mbb1;
        //MessageBoxButtons mbb2;
        String month;
        String day;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                month = "츠키노";
            }
            else if(this.radioButton2.Checked)
            {
                month = "아이노";
            }
            else if (this.radioButton3.Checked)
            {
                month = "소라노";
            }
            else if (this.radioButton4.Checked)
            {
                month = "미즈노";
            }
            else if (this.radioButton5.Checked)
            {
                month = "하나노";
            }
            else if (this.radioButton6.Checked)
            {
                month = "우츄-우노";
            }
            else if (this.radioButton7.Checked)
            {
                month = "타이요오노";
            }
            else if (this.radioButton8.Checked)
            {
                month = "호시노";
            }
            else if (this.radioButton9.Checked)
            {
                month = "오오모리노";
            }
            else if (this.radioButton10.Checked)
            {
                month = "카게노";
            }
            else if (this.radioButton11.Checked)
            {
                month = "텐노";
            }
            else if (this.radioButton12.Checked)
            {
                month = "유키노";
            }


            if (this.radioButton13.Checked)
            {
                day = "카케라";
            }
            else if (this.radioButton14.Checked)
            {
                day = "텐시";
            }
            else if (this.radioButton15.Checked)
            {
                day = "나미다";
            }
            else if (this.radioButton16.Checked)
            {
                day = "차카시";
            }
            else if (this.radioButton17.Checked)
            {
                day = "유메";
            }
            else if (this.radioButton18.Checked)
            {
                day = "코코로";
            }
            else if (this.radioButton19.Checked)
            {
                day = "시즈쿠";
            }
            else if (this.radioButton20.Checked)
            {
                day = "요-오세이";
            }
            else if (this.radioButton21.Checked)
            {
                day = "온가쿠";
            }
            else if (this.radioButton22.Checked)
            {
                day = "하카리";
            }
            else if (this.radioButton23.Checked)
            {
                day = "사메";
            }
            else if (this.radioButton24.Checked)
            {
                day = "켓쇼오";
            }
            if (this.radioButton25.Checked)
            {
                day = "사사야키";
            }
            else if (this.radioButton26.Checked)
            {
                day = "오츠케";
            }
            else if (this.radioButton27.Checked)
            {
                day = "오마지나이";
            }
            else if (this.radioButton28.Checked)
            {
                day = "이츠와리";
            }
            else if (this.radioButton29.Checked)
            {
                day = "이노리";
            }
            else if (this.radioButton30.Checked)
            {
                day = "네코";
            }
            else if (this.radioButton31.Checked)
            {
                day = "미치시루베";
            }
            else if (this.radioButton32.Checked)
            {
                day = "쿠마";
            }
            else if (this.radioButton33.Checked)
            {
                day = "호고샤";
            }
            else if (this.radioButton34.Checked)
            {
                day = "마호";
            }
            else if (this.radioButton35.Checked)
            {
                day = "타카라";
            }
            else if (this.radioButton36.Checked)
            {
                day = "타마시이";
            }
            if (this.radioButton37.Checked)
            {
                day = "요오카이";
            }
            else if (this.radioButton38.Checked)
            {
                day = "키츠네";
            }
            else if (this.radioButton39.Checked)
            {
                day = "오오카미";
            }
            else if (this.radioButton40.Checked)
            {
                day = "츠바사";
            }
            else if (this.radioButton41.Checked)
            {
                day = "오미야게";
            }
            else if (this.radioButton42.Checked)
            {
                day = "카이토오";
            }
            else if (this.radioButton43.Checked)
            {
                day = "하카이샤";
            }

            if (this.month == null || this.day == "")
            {
                MessageBox.Show(
                    "태어난 날짜를 선택해 주세요", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((
                    this.radioButton4.Checked ||
                    this.radioButton6.Checked ||
                    this.radioButton8.Checked ||
                    this.radioButton10.Checked ||
                    this.radioButton12.Checked)
                     &&
                     (this.radioButton43.Checked))
                {
                    MessageBox.Show(
                   "해당 날짜에 태어난사람은 없습니다!", "신탁",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show("당신의 이름은 " + month + " " + day, "알림");
            }
        }
    }
}
