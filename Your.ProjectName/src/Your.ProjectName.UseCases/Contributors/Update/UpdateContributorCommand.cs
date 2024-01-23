using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Your.ProjectName.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
