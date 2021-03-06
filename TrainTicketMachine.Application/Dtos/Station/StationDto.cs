using TrainTicketMachine.Application.Common.Mappings;

namespace TrainTicketMachine.Application.Dtos.Station;

public class StationDto : IMapFrom<Domain.Entities.Station>
{
    public string Id { get; set; }
    public string Name { get; set; }
}