using System;

class RemoteControlCar
{
  private int speed;
  private int batteryDrain;
  private int distance;
  private int battery = 100;

  // TODO: define the constructor for the 'RemoteControlCar' class
  public RemoteControlCar(int speed, int batteryDrain)
  {
    this.speed = speed;
    this.batteryDrain = batteryDrain;
  }

  public bool BatteryDrained()
  {
    return battery == 0 || battery < batteryDrain ? true : false;
  }

  public int DistanceDriven()
  {
    return distance;
  }

  public void Drive()
  {
    if (battery >= batteryDrain)
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
  private int distance;
  // TODO: define the constructor for the 'RaceTrack' class
  public RaceTrack(int distance)
  {
    this.distance = distance;
  }

  public bool TryFinishTrack(RemoteControlCar car)
  {
    bool raceFinished = false;
    while (!(car.BatteryDrained()))
    {
      car.Drive();
      if (car.DistanceDriven() == this.distance)
      {
        raceFinished = true;
        break;
      }
    }
    return raceFinished;
  }
}
