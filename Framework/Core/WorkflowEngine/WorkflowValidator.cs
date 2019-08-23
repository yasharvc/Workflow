using Models.User;
using Models.Workflow;
using System.Linq;

namespace WorkflowEngine
{
	public class WorkflowValidator
	{
		public bool CanUserSeeWorkflow(Workflow workflow,User user)
		{
			if (workflow.ForbidenGroupsTokens.Select(m => m.GroupToken).Intersect(user.UserGroups.Select(m => m.GroupToken)).Any() == false
				&& workflow.WorkflowGroups.Select(m => m.GroupToken).Intersect(user.UserGroups.Select(m => m.GroupToken)).Any())
				return true;
			return false;
		}
	}
}
