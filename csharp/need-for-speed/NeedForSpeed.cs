using System;

class RemoteControlCar
{
  private int speed { get; }
  private int batteryDrain { get; }
  private int distance;
  private int battery = 100;

  public RemoteControlCar(int speed, int batteryDrain)
  {
    this.speed = speed;
    this.batteryDrain = batteryDrain;
  }

  public bool BatteryDrained()
  {
    return battery == 0 || battery < batteryDrain;
  }

  public int DistanceDriven()
  {
    return distance;
  }

  public void Drive()
  {
    if (!BatteryDrained())
    {
      distance += speed;
      battery -= batteryDrain;
    }
  }

  public static RemoteControlCar Nitro()
  {
    int speed = 50;
    int batteryDrain = 4;

    return new RemoteControlCar(speed, batteryDrain);
  }
}

class RaceTrack
{
  private readonly int distance;
  public RaceTrack(int distance)
  {
    this.distance = distance;
  }

  public bool TryFinishTrack(RemoteControlCar car)
  {
    while (!(car.BatteryDrained()) && !(car.DistanceDriven() == this.distance))
    {
      car.Drive();
    }
    return car.DistanceDriven() == this.distance;
  }
}
