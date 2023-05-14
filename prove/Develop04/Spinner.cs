using System;
using System.Collections.Generic;
using System.Threading;

public class Spinner
{
    private List<string> spin = new List<string>(new string[] { "/", "|", "\\", "--" });
    private int duration;

    public Spinner(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        DateTime end = DateTime.Now.AddSeconds(duration);
        int i = 0;

        while (DateTime.Now < end)
        {
            string s = spin[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= spin.Count)
            {
                i = 0;
            }
        }
    }
}