// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] CreateArray(int size, Int32 min, Int32 max)  
{ 
System.Console.WriteLine("Задайте длину массива");
size = int.Parse(Console.ReadLine());
double [] array = new double [size];  
for (int i = 0; i < size; i++)   
    { 
    array[i] = Convert.ToDouble(new Random().Next(min, max)) / 100;
    i = i++;   
    }
    return array; 
} 
string GetArray(double[] array)  
{      
string sum = string.Empty;      
for (int i = 0; i < array.Length; i++)      
    {
      sum = sum + $"{array[i]}, ";      
    }                   
    return sum;  
} 
double ArrayRaznica(double [] array)  
{
double rezult = 0;
int minn = int.MaxValue;     
int maxx = int.MinValue; 
foreach (int element in array)     
{         
    if (minn > element) minn = element; 
    if (maxx < element) maxx = element;  
    rezult = maxx - minn; 
}     
return rezult; 
} 
double[] array = CreateArray(0, Int32.MinValue, Int32.MaxValue);
System.Console.WriteLine(GetArray(array));
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {ArrayRaznica(array)}");