using MediatR;

namespace MediatrDemo
{
    public class PingCommand : IRequest<PongResponse>
    {
        // nothing here
    }
}