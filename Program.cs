using System.ComponentModel.DataAnnotations;
OveralBallCalculate();
static void OveralBallCalculate()
{
    Console.WriteLine("Assalomu alaykum IELTS-MASTER dasturimizga xush kelibsiz ");

    System.Console.WriteLine("IELTS imtihonidagi 4 ta bo'lim bo'yicha ballaringizni kiriting: ");
    string[] ieltsSections = { "Reading", "Listening", "Writing", "Speaking" };
    decimal yigindi = 0;
    for (int i = 0; i < ieltsSections.Length; i++)
    {
        Console.Write($"{ieltsSections[i]} balingiz(0 - 9): ");
        decimal ball = decimal.Parse(Console.ReadLine());
        if (ball < 0 || ball > 9)
        {
            System.Console.WriteLine($"{ieltsSections[i]} balini xato kiritdingiz. Qaytadan kiring..!!");
            i--;
            continue;
        }
        yigindi += ball;
    }
    System.Console.WriteLine($"Sizning Overal balingiz: {yigindi/4}");
}

