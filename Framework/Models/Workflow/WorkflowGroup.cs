using System;

namespace Models.Workflow
{
	public class WorkflowGroup : BaseEntity
	{
		public Guid WorkflowToken { get; set; }
		public Guid GroupToken { get; set; }
	}
}