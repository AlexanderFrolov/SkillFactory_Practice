using System;


namespace AdoNetLib
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLEXPRESS01;Database=testing;Encrypt=False;Trusted_Connection=True;";
    }
}
