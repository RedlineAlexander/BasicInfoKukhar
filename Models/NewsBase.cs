using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public static class NewsBase
    {
        public static List<News> ListNews = new List<News>
        {
             new News { Id = 0, Title = "Humanity finally colonized the Mercury!!", Text = "", AuthorName = "Jeremy Clarkson", IsFake = true},
            new News { Id = 1, Title = "Increase your lifespan by 10 years, every morning you need...", Text = "", AuthorName = "Svetlana Sokolova", IsFake = true},
            new News { Id = 2, Title = "Scientists estimed the time of the vaccine invension: it is a summer of 2021", Text = "", AuthorName = "John Jones", IsFake = false},
            new News { Id = 3, Title = "Ukraine reduces the cost of its obligations!", Text = "", AuthorName = "Cerol Denvers", IsFake = false},
            new News { Id = 4, Title = "A species were discovered in Africa: it is blue legless cat", Text = "", AuthorName = "Jimmy Felon", IsFake = true}

        };
    }
}
