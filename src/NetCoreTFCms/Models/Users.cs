using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Users
	{
		//无参构造函数
		public Users() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int GroupId { get; set; }

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
		public string Email { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string NickName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Avatar { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Sex { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime Birthday { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Telphone { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Mobile { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Qq { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Address { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SafeQuestion { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SafeAnswer { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal Amount { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Point { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Exp { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte Status { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime RegTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RegIp { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Area { get; set; }

	}
}
