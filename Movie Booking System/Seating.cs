using System.Dynamic;
namespace MovieTheatre
{



public class Seating
{

    public string seatNumber {get; private set;}
    public bool isBooked {get; private set;}

    public Seating(string seat)
    {
        seatNumber = seat;
        isBooked = false;
    }

}

}





    
