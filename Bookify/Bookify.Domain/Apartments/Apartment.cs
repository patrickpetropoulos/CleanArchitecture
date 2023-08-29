using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments;
public sealed class Apartment : Entity
{
  public Apartment( 
    Guid id, 
    Name name, 
    Description description, 
    Address address, 
    Money price, 
    Money cleaningPrice,
    List<Amenity> amenities) : base( id )
  {
    Name = name;
    Description = description;
    Address = address;
    Price = price;
    CleaningPrice = cleaningPrice;
    Amenities = amenities;
  }

  public Name Name { get; private set; }
  public Description Description { get; private set; }
  public Address Address { get; private set; }
  public Money Price { get; private set; }
  public Money CleaningPrice { get; private set; }
  public DateTime? LastBookedOnUtc { get; private set; }
  public List<Amenity> Amenities { get; set; } = new();

}
