int days = int.Parse(Console.ReadLine());
int treated = 0;
int untreated = 0;
int doctors = 7;
if(days>0 && days < 1001)
{
    for (int i = 0; i < days; i++)
    {
        int patients = int.Parse(Console.ReadLine());
        if (patients < 10000)
        {
            if(patients < 8)
            {
                treated = treated + patients;
            }
            if (patients > 7 && (i+2) % 3 != 0)
            {
                treated += doctors;
                untreated += (patients - doctors);
            }
            if (patients > 7 && (i+2) % 3 == 0)
            {
                treated += doctors;
                untreated += (patients - doctors);
                doctors++;
            }

        }
    }
}
Console.WriteLine("Treated patients: " + treated);
Console.WriteLine("Untreated patients: " + untreated);
