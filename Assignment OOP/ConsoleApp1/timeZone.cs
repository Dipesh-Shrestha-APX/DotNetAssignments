using System;
using System.Text.RegularExpressions;

class timeZone
{
    static void Main()
    {
        string[] filenames = new string[]
        {
            "c71d1cd4-252e-48a5-94bf-c71ca7f68e4a_CustomerName.C1.D20230115-T082015",
            "f335d3e8-7ddc-42d2-9dc1-e456c80fd758_CustomerName.C2.D20201015-T120511",
            "f3e26374-fe23-459f-8567-c586715d18ae_CustomerName.C4.D20210414-T111220"
        };

        // Calculate Nepal Time: UTC + 5 hours 45 minutes
        DateTime utcNow = DateTime.UtcNow;
        TimeSpan nptOffset = new TimeSpan(5, 45, 0);
        DateTime nptNow = utcNow.Add(nptOffset);

        // Format timestamp as DyyyyMMdd-Thhmmss
        string currentTimestamp = "D" + nptNow.ToString("yyyyMMdd") + "-T" + nptNow.ToString("HHmmss");

        // Regex pattern to find existing timestamp in filename
        string pattern = @"D\d{8}-T\d{6}";

        Console.WriteLine("Filenames with current Nepal Time timestamp:");

        foreach (var filename in filenames)
        {
            // Replace old timestamp with new NPT timestamp
            string updatedFilename = Regex.Replace(filename, pattern, currentTimestamp);
            Console.WriteLine(updatedFilename);
        }
    }
}
