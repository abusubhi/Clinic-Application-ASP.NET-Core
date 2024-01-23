using System.ComponentModel.DataAnnotations;

namespace Your.ProjectName.Web.Endpoints.ContributorEndpoints;

public class CreateContributorRequest
{
  public const string Route = "/Contributors";

  [Required]
  public string? Name { get; set; }
}
