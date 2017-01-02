using WJ.MovieWorld.Models.DomainObjects;
using System.Data.Entity.ModelConfiguration;

namespace WJ.MovieWorld.Data.Mappers
{
    public class PassengerMap : EntityTypeConfiguration<Passenger>
    {
        public PassengerMap()
        {
            ToTable("Passenger");
            HasKey(p => p.Id);
            Property(p => p.FirstName);
            Property(p => p.LastName);
            Property(p => p.RecordLocatorId);
            HasRequired(p => p.RecordLocator);
        }
    }
}
