using Real.Shared.Assemblers;
using Real.Shared.Dtos;
using Real.Shared.Extensions;
using Real.Shared.Models;

namespace Real.Shared.Assamblers
{
    public class SubjectAssambler : Assambler<Subject, SubjectDto>
    {
        public override SubjectDto ToDto(Subject model)
        {
            return model.ToDto();
        }

        public override Subject ToModel(SubjectDto dto)
        {
            return dto.ToModel();
        }
    }
}
