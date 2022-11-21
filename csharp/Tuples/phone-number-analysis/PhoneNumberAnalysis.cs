using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = phoneNumber.StartsWith("212") ? true : false;
        bool IsFake = phoneNumber.Remove(0,4).StartsWith("555") ? true : false;
        string LocalNumber = phoneNumber.Remove(0, 8);

        return (IsNewYork, IsFake, LocalNumber);

    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
