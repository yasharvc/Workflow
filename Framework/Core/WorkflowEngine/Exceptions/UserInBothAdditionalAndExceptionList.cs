using Models.User;
using Models.Workflow;
using System;

namespace WorkflowEngine.Exceptions
{
	public class UserInBothAdditionalAndExceptionList : ApplicationException
	{
		public User User { get; set; }
		public Workflow Workflow { get; set; }
		public UserInBothAdditionalAndExceptionList(User user, Workflow workflow)
		{
			User = user;
			Workflow = workflow;
		}
	}
}