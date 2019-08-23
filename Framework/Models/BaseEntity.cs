using System;

namespace Models
{
    public abstract class BaseEntity
    {
		public int Id { get; set; } = -1;
		public Guid Token { get; set; } = Guid.NewGuid();

		public static implicit operator Guid(BaseEntity entity) => entity.Token;
    }
}