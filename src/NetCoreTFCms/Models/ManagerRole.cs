using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ManagerRole
	{
		//无参构造函数
		public ManagerRole() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RoleName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte RoleType { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSys { get; set; }

	}
}
