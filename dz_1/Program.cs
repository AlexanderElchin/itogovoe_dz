// 1. Создать репозиторй на GitHub (+)
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
// если вы выделяете ее в отдельный метод) (+)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md) (+)
// 4. Написать программу, решающую поставленную задачу. (+)
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, 
// как минимум этапы 2,3 и 4 должны быть расположенны в разных коммитах) (+)
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоночальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется ползьоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["Hello","2","World", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "Computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
Console.Clear();

void Itog()
{
    Console.Write("Введите массив строк через запятую: "); //если после запятой будет пробел, то программа сичает его за элемент.
    string text = Console.ReadLine()!;
    string[] Array = text.Split(",");
    string[] SplitArray = Array.Where(text => text.Length <= 3).ToArray();

    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3:  ");
    Console.WriteLine(String.Join(",", SplitArray));
}
Itog();
