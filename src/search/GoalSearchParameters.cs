namespace Aidbox.FHIR.Search;

public class GoalSearchParameters : DomainResourceSearchParameters
{
    public string? AchievementStatus { get; set; }
    public string? Category { get; set; }
    public string? Identifier { get; set; }
    public string? LifecycleStatus { get; set; }
    public string? Patient { get; set; }
    public string? StartDate { get; set; }
    public string? Subject { get; set; }
    public string? TargetDate { get; set; }
    public string? WorkflowBarrierCode { get; set; }
    public string? WorkflowBarrierRef { get; set; }
    public string? WorkflowProtectiveFactorCode { get; set; }
    public string? WorkflowProtectiveFactorRef { get; set; }
}