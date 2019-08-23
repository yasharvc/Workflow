namespace Models.Approvment
{
	public class ApproveItem : BaseEntity
	{
		public string Title { get; set; }
		public ApproveResultType ResultType { get; set; }
	}
}