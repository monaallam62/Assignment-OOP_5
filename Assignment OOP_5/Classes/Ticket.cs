using Assignment_OOP_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_5.Classes
{
    #region Ticket Class 
    //public class Ticket : IPrintable, IBookable, ICloneable
    //{
    //    private static int counter = 1;

    //    public int TicketId { get; }

    //    public string MovieName { get; set; }

    //    public decimal Price { get; set; }

    //    protected bool isBooked;

    //    public decimal PriceAfterTax => Price * 1.14m;

    //    public Ticket(string movie, decimal price)
    //    {
    //        TicketId = counter++;
    //        MovieName = movie;
    //        Price = price;
    //    }

    //    public virtual void Print()
    //    {
    //        Console.Write($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
    //    }

    //    public bool Book()
    //    {
    //        if (isBooked)
    //            return false;

    //        isBooked = true;
    //        return true;
    //    }

    //    public bool Cancel()
    //    {
    //        if (!isBooked)
    //            return false;

    //        isBooked = false;
    //        return true;
    //    }

    //    public virtual object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}   
    #endregion
}
