using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UpdateRegUsers
	{
		//无参构造函数
		public UpdateRegUsers() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SoftId { get; set; }

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
		public string Ip { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MachineCode { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RegCode { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime UpdateTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Remark { get; set; }

	}
}
