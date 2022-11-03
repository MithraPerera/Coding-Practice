using System;

class RemoteControlCar
{
  private static readonly int _distancePerDrive = 20;
  private static readonly int _batteryPerDrive = 1;
  private int _drivenDistance;
  private int _batteryRemaining;

  public RemoteControlCar()
  {
    _drivenDistance = 0;
    _batteryRemaining = 100;
  }

  public static RemoteControlCar Buy() => new RemoteControlCar();

  public string DistanceDisplay() => $"Driven {_drivenDistance} meters";

  public string BatteryDisplay()
  {
    if (_batteryRemaining == 0)
      return "Battery empty";

    return $"Battery at {_batteryRemaining}%";
  }

  public void Drive()
  {
    if (_batteryRemaining > 0)
    {
      _drivenDistance += _distancePerDrive;
      _batteryRemaining -= _batteryPerDrive;
    }
  }
}
