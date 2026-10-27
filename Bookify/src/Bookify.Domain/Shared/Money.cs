using System.ComponentModel;

namespace Bookify.Domain.Apartments;

public record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money a, Money b)
    {
        return a.Currency != b.Currency ? 
            throw new InvalidOperationException("Currencies have to be equal.") 
            : new Money(a.Amount + b.Amount, a.Currency);
    }

    public static Money Zero() => new(0, Currency.None);
    public static Money Zero(Currency currency) => new(0, currency);
    public bool IsZero() => this == Zero(Currency);
}