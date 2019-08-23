using System;

namespace Models.User
{
	public class UserGroup : BaseEntity
	{
		public Guid UserToken { get; set; }
		public Guid GroupToken { get; set; }
	}
}