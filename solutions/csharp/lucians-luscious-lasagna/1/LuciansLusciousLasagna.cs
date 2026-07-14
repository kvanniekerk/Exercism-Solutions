class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesIn) => ExpectedMinutesInOven() - minutesIn;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutesIn) => PreparationTimeInMinutes(layers) + minutesIn;
}