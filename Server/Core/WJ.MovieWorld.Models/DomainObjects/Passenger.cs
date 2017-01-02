
using System;

namespace WJ.MovieWorld.Models.DomainObjects
{
    public class Passenger : BaseDomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid RecordLocatorId { get; set; }
        public RecordLocator RecordLocator { get; set; }
    }
}
