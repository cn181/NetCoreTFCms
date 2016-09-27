using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserAddrBook
	{
		//无参构造函数
		public UserAddrBook() {}



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
		public string AcceptName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Area { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Address { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Mobile { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Telphone { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Email { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PostCode { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsDefault { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
