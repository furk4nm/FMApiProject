﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMData.Entity {
	public class User:BaseEntity {
		public string Email { get; set; }
		public string Password { get; set; }
		public string? FirstName {  get; set; }
		public string?  LastName { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}
