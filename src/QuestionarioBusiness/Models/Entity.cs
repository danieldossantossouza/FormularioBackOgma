using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionarioBusiness.Models
{
	public class Entity
	{
		protected Entity() 
		{
			Id = Guid.NewGuid();
		}
		public Guid Id { get; set; }
	}
}
