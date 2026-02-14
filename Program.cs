using System.ComponentModel.DataAnnotations;
using IeltsMaster;
OveralBallCalculate();
static bool IsBallValid(decimal ball)
{
    return (ball < 0 || ball > 9);
}
static void OveralBallCalculate()
{   // Obyektlar
    Printer print = new Printer();
    Counter counter = new Counter();

    print.PrintLine("Assalomu alaykum IELTS-MASTER dasturimizga xush kelibsiz ");

    print.PrintLine("IELTS imtihonidagi 4 ta bo'lim bo'yicha ballaringizni kiriting: ");
    string[] ieltsSections = { "Reading", "Listening", "Writing", "Speaking" };

    for (int i = 0; i < ieltsSections.Length; i++)
    {
        print.Print($"{ieltsSections[i]} balingiz(0 - 9): ");
        try
        {
            decimal ball = decimal.Parse(Console.ReadLine());
            if (IsBallValid(ball))
            {
                print.PrintLine($"{ieltsSections[i]} balini xato kiritdingiz. Qaytadan kiring..!!");
                i--;
                continue;
            }
            counter.BallQosh(ball);
        }
        catch (FormatException)
        {
            print.PrintLine("Xatolik!(FormatExeption) Faqat son kiriting.(harf, belgi yoki boshqa narsa kiritmang)");
            i--;
        }
        catch(OverflowException)
        {
            print.PrintLine("Xatolik! Judayam katta kon kiritvordiz..");
            i--;
        }

    }
    print.PrintLine($"Sizning Overal balingiz: {counter.YigindiQaytar() / ieltsSections.Length}");
}
