using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserGroups
	{
		//无参构造函数
		public UserGroups() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Grade { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int UpgradeExp { get; set; }

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
		public int Discount { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsDefault { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsUpgrade { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsLock { get; set; }

	}
}
