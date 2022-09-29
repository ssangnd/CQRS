using CQRS.Models;
using MediatR;

namespace CQRS.Queries
{
    public class GetStudentsListQuery:IRequest<List<Student>>
    {

    }
}
