using System;

static class Appointment
{
  public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

  public static bool HasPassed(DateTime appointmentDate) => appointmentDate <= DateTime.Now ? true : false;

  public static bool IsAfternoonAppointment(DateTime appointmentDate)
  {
    if (appointmentDate.TimeOfDay >= new TimeSpan(12, 0, 0) && appointmentDate.TimeOfDay < new TimeSpan(18, 0, 0))
    {
      return true;
    }
    return false;
  }

  public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

  public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
