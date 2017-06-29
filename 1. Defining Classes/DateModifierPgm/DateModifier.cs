using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateModifier
{
    private int difference;

    public int Difference
    {
        get { return this.difference; }
    }

    public void CalculateDifference(string firstDate, string secondDate)
    {
        DateTime first = DateTime.ParseExact(firstDate, "yyyy MM dd", null);
        DateTime second = DateTime.ParseExact(secondDate, "yyyy MM dd", null);
        TimeSpan period = first - second;
        this.difference = Math.Abs(period.Days);
    }
}

