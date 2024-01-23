using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Your.ProjectName.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
