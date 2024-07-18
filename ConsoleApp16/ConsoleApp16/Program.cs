// Создаем свой тип исключения
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив из пяти различных видов исключений
        Exception[] exceptions = {
new DivideByZeroException("Деление на ноль"),
new IndexOutOfRangeException("Индекс вне диапазона"),
new NullReferenceException("Ссылка на null"),
new CustomException("Пользовательское исключение"),
new ArgumentException("Недопустимый аргумент")
};

        // Реализуем конструкцию TryCatchFinally
        foreach (var exception in exceptions)
        {
            try
            {
                ThrowException(exception);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
        }
    }

    static void ThrowException(Exception exception)
    {
        throw exception;
    }
}
