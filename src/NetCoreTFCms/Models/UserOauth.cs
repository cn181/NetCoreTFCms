using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserOauth
	{
		//无参构造函数
		public UserOauth() {}



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
		public string OauthName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OauthAccessToken { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OauthOpenid { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
