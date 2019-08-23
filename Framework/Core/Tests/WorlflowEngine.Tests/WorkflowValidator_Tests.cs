using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.User;
using Models.Workflow;
using WorkflowEngine;

namespace WorlflowEngine.Tests
{
	[TestClass]
	public class WorkflowValidator_Tests
	{
		[TestMethod]
		public void UserIsInGroupButNotInForbiden_ValidTest()
		{
			//Arrange
			var group1 = new Group();
			var group2 = new Group();
			var user = new User();
			user.UserGroups = new System.Collections.Generic.List<UserGroup>
			{
				new UserGroup{UserToken=user.Token,GroupToken=group1.Token}
			};
			Workflow workflow = new Workflow();

			workflow.WorkflowGroups = new System.Collections.Generic.List<WorkflowGroup>
			{
				new WorkflowGroup{
					GroupToken = group1,
					WorkflowToken = workflow
				}
			};

			workflow.ForbidenGroupsTokens = new System.Collections.Generic.List<WorkflowGroup>
				{
					new WorkflowGroup{GroupToken = group2,WorkflowToken = workflow }
				};

			//Act
			var validator = new WorkflowValidator();
			var expected = true;

			//Assert
			Assert.AreEqual(expected, validator.CanUserSeeWorkflow(workflow, user));
		}

		[TestMethod]
		public void UserIsInForbidenListButNotInGroup_InValidTest()
		{
			//Arrange
			var group1 = new Group();
			var group2 = new Group();
			var user = new User();
			user.UserGroups = new System.Collections.Generic.List<UserGroup>
			{
				new UserGroup{UserToken=user.Token,GroupToken=group2.Token}
			};
			Workflow workflow = new Workflow();

			workflow.WorkflowGroups = new System.Collections.Generic.List<WorkflowGroup>
			{
				new WorkflowGroup{
					GroupToken = group1,
					WorkflowToken = workflow
				}
			};

			workflow.ForbidenGroupsTokens = new System.Collections.Generic.List<WorkflowGroup>
				{
					new WorkflowGroup{GroupToken = group2,WorkflowToken = workflow }
				};

			//Act
			var validator = new WorkflowValidator();
			var expected = false;

			//Assert
			Assert.AreEqual(expected, validator.CanUserSeeWorkflow(workflow, user));
		}

		[TestMethod]
		public void UserNotInGroupNotInForbiden_InValidTest()
		{
			//Arrange
			var group1 = new Group();
			var group2 = new Group();
			var group3 = new Group();
			var user = new User();
			user.UserGroups = new System.Collections.Generic.List<UserGroup>
			{
				new UserGroup{UserToken=user.Token,GroupToken=group3.Token}
			};
			Workflow workflow = new Workflow();

			workflow.WorkflowGroups = new System.Collections.Generic.List<WorkflowGroup>
			{
				new WorkflowGroup{
					GroupToken = group1,
					WorkflowToken = workflow
				}
			};

			workflow.ForbidenGroupsTokens = new System.Collections.Generic.List<WorkflowGroup>
				{
					new WorkflowGroup{GroupToken = group2,WorkflowToken = workflow }
				};

			//Act
			var validator = new WorkflowValidator();
			var expected = false;

			//Assert
			Assert.AreEqual(expected, validator.CanUserSeeWorkflow(workflow, user));
		}

		[TestMethod]
		public void UserIsInForbidenAndInGroup_ValidTest()
		{
			//Arrange
			var group1 = new Group();
			var group2 = new Group();
			var user = new User();
			user.UserGroups = new System.Collections.Generic.List<UserGroup>
			{
				new UserGroup{UserToken=user.Token,GroupToken=group1.Token},
				new UserGroup{UserToken=user.Token,GroupToken=group2.Token},
			};
			Workflow workflow = new Workflow();

			workflow.WorkflowGroups = new System.Collections.Generic.List<WorkflowGroup>
			{
				new WorkflowGroup{
					GroupToken = group1,
					WorkflowToken = workflow
				}
			};

			workflow.ForbidenGroupsTokens = new System.Collections.Generic.List<WorkflowGroup>
				{
					new WorkflowGroup{GroupToken = group2,WorkflowToken = workflow }
				};

			//Act
			var validator = new WorkflowValidator();
			var expected = false;

			//Assert
			Assert.AreEqual(expected, validator.CanUserSeeWorkflow(workflow, user));
		}
	}
}
