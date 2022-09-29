using CQRS.DataAccess;
using CQRS.Models;
using MediatR;

namespace CQRS.Queries
{
    public class GetStudentListHandler : IRequestHandler<GetStudentsListQuery, List<Student>>
    {
        private readonly IDataAccess _data;
        public GetStudentListHandler(IDataAccess data )
        {
            _data = data;
        }
        public Task<List<Student>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudents());
        }
    }
}
