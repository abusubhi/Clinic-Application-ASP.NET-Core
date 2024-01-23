using Your.ProjectName.Web.ContributorEndpoints;

namespace Your.ProjectName.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
