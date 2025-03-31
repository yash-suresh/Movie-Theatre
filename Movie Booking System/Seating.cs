using System.Dynamic;
using MovieTheatre;
namespace MovieTheatre
{



public class Seating
{

    public string seatNumber {get; private set;}
    public bool isBooked {get; private set;}

    public Seating(string seat)
    //constructor which initialises all the variables.
    {
        seatNumber = seat;
        isBooked = false;
    }

}

}




    
