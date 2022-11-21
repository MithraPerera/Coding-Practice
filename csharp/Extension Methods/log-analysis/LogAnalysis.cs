using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string del)
    {
        return str.Split(del)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string del1, string del2)
    {
        return str.Split(del1)[1].Split(del2)[0];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}