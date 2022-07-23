/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int vkube = Convert.ToInt32(Console.ReadLine());

void Vkube(int[] vkube)
{
  int count = 1;
  int length = vkube.Length;
  while (count <  length)
  {
    vkube[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}
void PrintArray(int[] cool)
{
  int count = cool.Length;
  int number = 1;
  while(number < count)
  {
    Console.WriteLine(cool[number]+ " ");
    number++;
  }
} 

int[] array = new int[vkube+1];
Vkube(array);
PrintArray(array);