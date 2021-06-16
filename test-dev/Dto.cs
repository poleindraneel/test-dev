using System;
using System.Collections.Generic;
using System.Text;

namespace test_dev
{
	public class Dto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedAt { get; set; }
		public double ReferenceNumber { get; set; }
		public List<string> Values { get; set; }
	}
}
