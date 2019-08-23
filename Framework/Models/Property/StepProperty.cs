using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Property
{
	public class StepProperty : BaseEntity
	{
		public BaseProperty Property { get; set; }
		public object Value { get; set; }
	}
}
