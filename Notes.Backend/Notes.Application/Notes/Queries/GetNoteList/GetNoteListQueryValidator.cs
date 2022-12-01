using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(x => x.UserId).NotEqual(Guid.Parse("00000000-0000-0000-0000-120000000001"));
        }
    }
}