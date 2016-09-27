using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserAmountLog
	{
		//无参构造函数
		public UserAmountLog() {}



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
		public string OrderNo { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string TradeNo { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int PaymentId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal AmountValue { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Remark { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte Status { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime CompleteTime { get; set; }

	}
}
