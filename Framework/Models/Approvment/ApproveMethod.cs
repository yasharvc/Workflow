using System.Collections.Generic;

namespace Models.Approvment
{
	public class ApproveMethod : BaseEntity
	{
		public string Title { get; set; }
		public List<ApproveItem> Items { get; set; }
	}
}
