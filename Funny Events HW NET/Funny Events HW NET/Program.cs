﻿using System;

/*Створити класи для Агенції Розважальних Заходів
--------------------------------------------------
Клієнт(Client)     
    ім'я    
    номер телефону
Визначити конструктор(и) та  властивості для полів класу
*Перевіряти правильність телефону
Перевизначити(override) метод  ToString()
 

Захід(Event)
    назва
    кількість осіб заходу
    місце проведення
    час проведення(стандартна структура DateTime)
    ІД події(автоматично присвоюється 1, 2, 3, ...), формується на основі статичного поля counter
    counter - статичне поле, що рахує кількість створених екземплярів 
    клієнт(посилання на Клієнта, що замовив захід)
Методи 
    конструктор(и)
    перенесення події на певне число днів вперед( метод AddDay структури DateTime )
    перенесення події на певне число тижнів вперед

Визначити  властивості для полів класу. 
*Перевіряти правильність дати події( не раніше сьогоднішньої), властивості DateTime.Today, DateTime.Now
Перевизначити(override) метод  ToString()
 
EventService
    список запланованих(замовлених) заходів, List<Event>
Методи
    додавання події до списку подій
    видалення події
    очищення списку подій(Clear)
    пошук(вивід) подій замовлених на певну дату
    пошук(вивід) подій замовлених на певний діапазон дат(дати можна порівнювати операціями >, <, методом CompareTo)
    пошук(вивід) подій замовлених певним клієнтом*/

namespace Funny_Events_HW_NET
{
    class Program
    {
        static void Main()
        {
            m
        }
    }
}