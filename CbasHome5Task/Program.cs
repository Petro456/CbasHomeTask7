using System;

namespace CbasHome5Task
{
    internal class Program
    {
        struct Notebook
        {
            string model;
            int progress;
            int cina;

            public Notebook(string model, int progress, int cina)
            {
                this.model = model;
                this.progress = progress;
                this.cina = cina;
               
            }

            public void Show()
            {
                Console.WriteLine($"Модель: {model} Продуктивність: {progress}  Ціна: {cina}");
            }
        }
       

        /*Задание 5

        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Создайте структуру с именем - Notebook. Поля структуры: модель, производитель, цена.
        В структуре должен быть реализован конструктор для инициализации полей и метод для вывода 
        содержимого полей на экран.*/
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Самсунг", 100, 15000);
            

            notebook.Show();

            Console.ReadKey();
        }
    }
}
