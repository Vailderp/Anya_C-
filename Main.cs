using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //3 Для Ани
        enum Operation : ushort
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        static void Main(string[] args)
        {
            //Это создание кортежа, певое и второе числа равны нулю
            (int first, int second) number = (0, 0);
            //Это наш будущий результат в виде кортежа, все элементы которого пока что равны нулю
            (float firstNumber, float secondNumber, Operation operation, float result) result = (0, 0, 0, 0);

            //Просим ввести первое число
            Console.WriteLine("Введите первое число:");
            //Присваиваем полученное число первому числу нашего кортежа
            number.first = int.Parse(Console.ReadLine());

            //Просим ввести второе число
            Console.WriteLine("Введите второе число:");
            //Присваиваем полученное число второму числу нашего кортежа
            number.second = int.Parse(Console.ReadLine());
            
            //Просим ввести * или / или - или +
            Console.WriteLine("Введите операцию:");
            //Заводим переменную, которая содержит * или / или - или +
            string operation = Console.ReadLine();

            //Теперь мы должны выполнить операцию, которую ввёл пользователь (* или / или - или +)
            switch (operation)
            {
                //Если +, то мы передаём в функцию Operation.Add, чтобы получить результат сложения
                case "+":
                    result = MathOp(number, Operation.Add); //Это вызов нашей функции, мы передаём те самые два числа и тип операции
                    break;

                //Если -, то мы передаём в функцию Operation.Subtract, чтобы получить результат вычитания
                case "-":
                    result = MathOp(number, Operation.Subtract);
                    break;

                //Если *, то мы передаём в функцию Operation.Multiply, чтобы получить результат умножения
                case "*":
                    result = MathOp(number, Operation.Multiply);
                    break;

                //Если /, то мы передаём в функцию Operation.Divide, чтобы получить результат деления
                case "/":
                    result = MathOp(number, Operation.Divide);
                    break;
            }
            
            //Выводим результат операции
            Console.WriteLine("Результат операции:" + result.result);

            Console.ReadKey();
        }

        //Метод возвращает кортеж как сказано в конце задания
        //Принимает кортеж, состоящий из двух числе и тип операции, который нужно выполнить
        static (float firstNumber, float secondNumber, Operation operation, float result) MathOp((float x, float y) nums, Operation op)
        {
            //op - это тип операции, то есть Add или Subtract или Multiply или Divide
            //                               +          -             *         /
            switch (op)
            {
                //Если мы передали Operation.Add, то результатом выполнения мы возвращаем сложение двух числел
                //По заданию нам необходимо вернуть первое и второе числа, тип операции и результат
                case Operation.Add:
                    return (nums.x, nums.y, op, nums.x + nums.y);

                //Если мы передали Operation.Subtract, то результатом выполнения мы возвращаем вычитание
                //По заданию нам необходимо вернуть первое и второе числа, тип операции и результат
                case Operation.Subtract:
                    return (nums.x, nums.y, op, nums.x - nums.y);

                //Если мы передали Operation.Multiply, то результатом выполнения мы возвращаем умножение
                //По заданию нам необходимо вернуть первое и второе числа, тип операции и результат
                case Operation.Multiply:
                    return (nums.x, nums.y, op, nums.x * nums.y);

                //Если мы передали Operation.Divide, то результатом выполнения мы возвращаем деление
                //По заданию нам необходимо вернуть первое и второе числа, тип операции и результат
                case Operation.Divide:
                    return (nums.x, nums.y, op, nums.x / nums.y);
            }

            //Чтобы убрать ошибку, мы должны написать это. Так как по мнению компилятора метод должен всегда что-то возвращать
            return (nums.x, nums.y, op, 0);
        }
    }
}

