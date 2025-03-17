// See https://aka.ms/new-console-template for more information


int[] arrays = new int[5];
    for(int i = 0; i < 5; i++)
{
    Console.Write(i+1 + ". Sayıyı giriniz : ");
    int number = int.Parse(Console.ReadLine());
    arrays[i] = number;

}

double sum = 0;
    foreach(int number in arrays)
{
    sum += number;
}

Console.WriteLine("Ortalama Sonucu : "+sum/arrays.Length);
