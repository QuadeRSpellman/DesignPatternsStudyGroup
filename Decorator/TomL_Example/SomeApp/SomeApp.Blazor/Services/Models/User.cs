using System;

namespace SomeApp.Blazor.Services.Models
{
	public class User
	{
		public string Name {  get; set; }
		public Guid Identifier {  get; set; }

		public override string ToString()
		{
				return $"User - {Name} - {Identifier}";
		}
	}
}
