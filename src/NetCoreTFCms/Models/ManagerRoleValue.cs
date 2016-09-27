using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ManagerRoleValue
	{
		//无参构造函数
		public ManagerRoleValue() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int RoleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string NavName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ActionType { get; set; }

	}
}
