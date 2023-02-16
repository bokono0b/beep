 int[] DO = new int[] { 131, 262, 523, 1046 };
 int[] RE = new int[] { 147, 294, 587, 1174 };
 int[] MI = new int[] { 165, 330, 659, 1318 };
 int[] FA = new int[] { 175, 349, 698, 1396 };
 int[] SO = new int[] { 196, 392, 784, 1568 };
 int[] LA = new int[] { 220, 440, 880, 1760 };
 int[] TI = new int[] { 247, 494, 988, 1976 };

void sweetChild()
{
    int oct1 = 0;
    int oct2 = 1;
    int oct3 = 2;
    int oct4 = 3;
    for (int i = 0; i < 2; i++)
    {
        Console.Beep(SO[oct2], 250);
        Console.Beep(SO[oct3], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(DO[oct3], 250);
        Console.Beep(DO[oct4], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(TI[oct3], 250);
        Console.Beep(RE[oct3], 250);
    }


    for (int i = 0; i < 2; i++)
    {
        Console.Beep(LA[oct2], 250);
        Console.Beep(SO[oct3], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(DO[oct3], 250);
        Console.Beep(DO[oct4], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(TI[oct3], 250);
        Console.Beep(RE[oct3], 250);
    }

    for (int i = 0; i < 2; i++)
    {
        Console.Beep(DO[oct3], 250);
        Console.Beep(SO[oct3], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(DO[oct3], 250);
        Console.Beep(DO[oct4], 250);
        Console.Beep(RE[oct3], 250);
        Console.Beep(TI[oct3], 250);
        Console.Beep(RE[oct3], 250);
    }

    Console.Beep(SO[oct2], 250);
    Console.Beep(SO[oct3], 250);
    Console.Beep(RE[oct3], 250);
    Console.Beep(DO[oct3], 250);
    Console.Beep(DO[oct4], 250);
    Console.Beep(RE[oct3], 250);
    Console.Beep(TI[oct3], 250);
    Console.Beep(RE[oct3], 250);
}


sweetChild();