using System.Collections;
using MovieTheatre;

public class Theatre
{

    private Stack<Seating> seatStack = new Stack<Seating>();
    private int availableSeats;
    
    public void Run()
    {
        InitialiseSeats();
    }

    private void InitialiseSeats()
    //initialsing seat numbers for all seats
    {
        for(char i = 'H'; i >= 'A'; i --)
        {
            for(int j = 10; j >= 1; j --)
            {
                
                string seatNum = i + j.ToString();
                seatStack.Push(new Seating(seatNum));
                availableSeats ++;

            }
        }
    }

    public List<string> AssignSeats(int requestedSeats)
    {
        List<string> bookings = new List<string>();

        if(requestedSeats > availableSeats)
        {
            throw new InvalidOperationException("Not enough seats available");

        }
        else
        {

            while(requestedSeats > 0)
            {
                bookings.Add(seatStack.Pop().seatNumber);
                requestedSeats --;
                availableSeats --;
            }
        

       return bookings;

        }

        
            
    
    }

}

