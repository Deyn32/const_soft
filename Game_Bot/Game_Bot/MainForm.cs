using Game_Bot.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Bot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Михайлов 11.04.2017 Гит не очень хочет работать с 2 языками, так что готовтесь чаще записывать изменения
            InitializeComponent();
            SetStat(StatEnum.Begin);
        }

        //Михайлов 12.04.2017 Метод внутренних состояний бота
        private void SetStat (StatEnum stat)
        {
            if (stat == StatEnum.Begin)
                rtbInfo.Text += string.Format("Здравствуй, пользователь! Можешь отдохнуть, я поиграю за тебя!/n");

            if (stat == StatEnum.Start)
                rtbInfo.Text += string.Format("Приготовся выигрывать!/n");

            if (stat == StatEnum.Exit)
                rtbInfo.Text += string.Format("Спасибо, что дал поиграть! Еще увидимся, пока!/n");

            if (stat == StatEnum.Error)
                rtbInfo.Text += string.Format("Ой, ошибка! Что-то пошло не так( Прости!/n");

            if (stat == StatEnum.Connect)
                rtbInfo.Text += string.Format("Подключаюсь к игре...");
        }

        //Михайлов 11.04.2017 Метод обработки кнопки
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetStat(StatEnum.Start);
        }
    }
}
