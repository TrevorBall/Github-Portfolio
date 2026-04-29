/*
 * Trevor Ball
 * CPT-206-A01H
 * Network Pinger Lab 7
 */
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

string[] websites =
{
    "https://google.com",
    "https://youtube.com",
    "https://amazon.com",
    "https://hbomax.com",
    "https://microsoft.com",
    "https://github.com",
    "https://netflix.com",
    "https://espn.com",
    "https://leetcode.com",
    "https://facebook.com"
};

string fileName = "PingResults.txt";
string fullPath = Path.GetFullPath(fileName);

using (StreamWriter writer = new StreamWriter(fileName))
{
    foreach (string site in websites)
    {
        try
        {
            Uri uri = new Uri(site);

            writer.WriteLine("==================================");
            writer.WriteLine("Website: " + site);
            writer.WriteLine("Scheme: " + uri.Scheme);
            writer.WriteLine("Host: " + uri.Host);
            writer.WriteLine("Port: " + uri.Port);
            writer.WriteLine("Path: " + uri.AbsolutePath);

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            writer.WriteLine("IP Addresses:");
            foreach (IPAddress address in entry.AddressList)
            {
                writer.WriteLine("   " + address);
            }

            Ping ping = new Ping();
            PingReply reply = ping.Send(uri.Host);

            writer.WriteLine("Ping Status: " + reply.Status);

            if (reply.Status == IPStatus.Success)
            {
                writer.WriteLine("Reply From: " + reply.Address);
                writer.WriteLine("Roundtrip Time: " + reply.RoundtripTime + " ms");
            }
        }
        catch (Exception ex)
        {
            writer.WriteLine("Website: " + site);
            writer.WriteLine("Error: " + ex.Message);
        }

        writer.WriteLine();
    }
}

Console.WriteLine("Program is done. Results were written to " + fileName);
Console.WriteLine("Located at: " + fullPath);