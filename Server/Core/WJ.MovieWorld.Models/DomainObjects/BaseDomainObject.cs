using System;

namespace WJ.MovieWorld.Models.DomainObjects
{
    public abstract class BaseDomainObject : IIdentity
    {
        public Guid Id { get; set; }
    }
}
