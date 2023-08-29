﻿using Bookify.Domain.Abstractions;
using Bookify.Domain.Users.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Users;
public sealed class User : Entity
{
  private User( Guid id, FirstName firstName, LastName lastName, Email email ) : base( id )
  {
    FirstName = firstName;
    LastName = lastName;
    Email = email;
  }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }

  public static User Create( FirstName firstName, LastName lastName, Email email )
  {
    var user = new User( Guid.NewGuid(), firstName, lastName, email );

    //Will raise event when user created, can trigger email send, other work, whatever we want
    user.RaiseDomainEvent(new UserCreatedDomainEvent( user.Id ) );

    return user;
  }
}
