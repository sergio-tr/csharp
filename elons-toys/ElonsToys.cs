using System;

class RemoteControlCar
{

    private static readonly int METERS_PER_DRIVE = 20;
    private static readonly int BATTERY_LOSS_PER_DRIVE = 1;

    private int DrivenMeters = 0;
    private int Battery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven " + DrivenMeters + " meters";
    }

    public string BatteryDisplay()
    {

        if(Battery == 0){
            return "Battery empty";
        }

        return "Battery at " + Battery + '%';
    }

    public void Drive()
    {

        if(Battery > 0){
            DrivenMeters += METERS_PER_DRIVE;
            Battery -= BATTERY_LOSS_PER_DRIVE;
        }
    }
}
