using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Your.ProjectName.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
