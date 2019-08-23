using Models.Property;
using Models.Workflow.Step;
using System.Collections.Generic;

namespace Models.Workflow
{
	public class Workflow : BaseEntity
	{
		public string Title { get; set; }
		public List<WorkflowGroup> ForbidenGroupsTokens { get; set; }
		public List<WorkflowGroup> WorkflowGroups { get; set; }
		public List<BaseProperty> Properties { get; set; }
		public List<WorkflowStep> Steps { get; set; }
	}
}