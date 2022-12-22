// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на страте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] fillingResultArray(string[] startArray, ref string[] resultArray) {
    int index = 0;
    foreach(string el in startArray) {
        if(el.Length <= 3) {
            resultArray[index] = el;
            index++;
        }
    }
    return resultArray;
}

int countSizeResultArray(string[] array) {
    int size = 0;
    foreach(string el in array) {
        if(el.Length <= 3) {
            size++;
        }
    }
    return size;
}

void printArray(string[] array) {
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

string[] startArray = {"Russia", "Denmark", "Kazan", "hello", "2", "world", ":-)"};
printArray(startArray);
int sizeResultArray = countSizeResultArray(startArray);
string[] resultArray = new string[sizeResultArray];
resultArray = fillingResultArray(startArray, ref resultArray);
printArray(resultArray);