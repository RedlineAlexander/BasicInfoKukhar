using System;
/*
Практика: 0. 
1)В вашем репозитории с ДЗ содайте новый проект по шаблону MVC
2)и скопируйте туда модель News и статический класс NewsBase из моего проекта.
3)Создайте NewsController.

4)В контроллер NewsController добавьте action Index,
5)при его вызове должны вывестись все News из NewsBase в виде HTML таблицы.

6)Вынесите таблицу из прошлого задания в отдельную секцию.
7)С помощью @RenderSection добавьте эту секцию в _Layout.
8)В navigation bar, который определен у вас в _Layout(с использованием тега nav),
9)добавьте элемент News,
10)при нажатии на него вы должны будете обращаться к action Index
11)контроллера News
12)и соответственно будет отображена таблица с новостями из прошлого задания.
Задача от Бердичева
Скажешь как картинки загружать, и передавать с вебформы в контроллер
Вы верстку проходили?
Вам рассказывали как работают кнопки на вебформе?
*/
namespace BasicInfoKukhar.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
