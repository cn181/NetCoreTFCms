using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserToken
	{
		//无参构造函数
		public UserToken() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int UserId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Token { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime Expired { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Ip { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string DeviceId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
