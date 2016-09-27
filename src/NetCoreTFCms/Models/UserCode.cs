using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserCode
	{
		//无参构造函数
		public UserCode() {}



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
		public string Type { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string StrCode { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Count { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte Status { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime EffTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
