using System;

namespace CbasHome3Task
{       /// <summary>
///  Тут не впевнений чи правильно
///  Структура - значимый тип. Класс - ссылочный тип.
/// </summary>
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }

    /* Задание 3 

            Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change. 
    В классе Program создайте два метода:  static void ClassTaker(MyClass myClass), который присваивает 
    полю change экземпляра myClass значение «изменено».  static void StruktTaker(MyStruct myStruct),
    который присваивает полю change экземпляра myStruct значение «изменено». Продемонстрируйте разницу
    в использовании классов и структур, создав в методе Main() экземпляры структуры и класса. Измените,
    значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker. 
    Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.  */
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Змiнено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Змiнено";
        }

        static void Main(string[] args)
        {
           MyClass myClass = new MyClass();
            myClass.change = "Не Змiнено";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "Не Змiнено";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine(myStruct.change); 
            Console.WriteLine(myClass.change);

            Console.ReadKey();



        }
    }
}
