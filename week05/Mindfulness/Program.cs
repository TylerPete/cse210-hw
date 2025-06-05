using System;

class Program
{
    static void Main(string[] args)
    {
        Activity testActivity = new Activity(30);
        // testActivity.ShowSpinner(30);

        testActivity.ShowCountDown(15);
    }
}