class RemoteControlCar
{
    private int distanceDriven = 0;
    private int batteryPercentage = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {distanceDriven} meters";

    public string BatteryDisplay()
    {
        if (batteryPercentage == 0)
            return "Battery empty";
        else
            return $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            this.distanceDriven += 20;
            this.batteryPercentage -= 1;
        }
    }
}
