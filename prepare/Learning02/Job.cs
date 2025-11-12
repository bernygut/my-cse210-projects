public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 1900;
    public int _endYear = 1901; 


    public void Display()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, {_startYear} - {_endYear}");      
    }
}