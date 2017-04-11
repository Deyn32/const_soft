using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Bot.Enums
{
    //Михайлов 11.04.2017 Сделал класс перечислений состояния бота
    public enum StatEnum
    {
        ///Начальная информация
        Begin,
        ///При нажатии на Старт
        Start,
        ///При закрытии формы
        Exit,
        ///Ошибка в работе
        Error
    }
}
