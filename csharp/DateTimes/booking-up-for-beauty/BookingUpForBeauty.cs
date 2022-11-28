using System;

static class Appointment
{
  public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

  public static bool HasPassed(DateTime appointmentDate) => appointmentDate <= DateTime.Now;

  public static bool IsAfternoonAppointment(DateTime appointmentDate)
  {
    // return appointmentDate.TimeOfDay >= new TimeSpan(12, 0, 0) && appointmentDate.TimeOfDay < new TimeSpan(18, 0, 0);
    // Less code version using DateTime property
    return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
  }

  public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

  //public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
  //Dont need the 0's as those are defaults
  public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);

}
