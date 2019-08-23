using System;
using System.Collections.Generic;

namespace Models.User
{
	public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
		public List<UserGroup> UserGroups { get; set; }
	}
}
