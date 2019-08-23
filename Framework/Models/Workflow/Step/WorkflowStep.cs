using Models.Approvment;
using Models.Property;
using Models.User;
using System;
using System.Collections.Generic;

namespace Models.Workflow.Step
{
	public abstract class WorkflowStep : BaseEntity
	{
		public Guid WorkflowToken { get; set; }
		public string Title { get; set; }
		public string Path { get; set; }
		public float Percentage { get; set; }
		public List<Group> ApproverGroups { get; set; }
		public ApproveMethod Approvement { get; set; }
		public bool Abstainable { get; set; }
		public List<BaseProperty> Properties { get; set; }
		public event WorkflowArgs StepIntoNext;
	}
}
