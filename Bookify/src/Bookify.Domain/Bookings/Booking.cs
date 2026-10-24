using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public sealed class Booking : Entity
{
    public Booking(Guid id) 
        : base(id)
    {
    }
    
}