using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Manager
	{
		//无参构造函数
		public Manager() {}



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
		public int RoleType { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Password { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Salt { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RealName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Telephone { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Email { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsLock { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
