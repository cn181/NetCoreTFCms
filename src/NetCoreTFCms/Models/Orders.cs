using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Orders
	{
		//无参构造函数
		public Orders() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

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
		public int UserId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int PaymentId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal PaymentFee { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte PaymentStatus { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime PaymentTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ExpressId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ExpressNo { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal ExpressFee { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte ExpressStatus { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime ExpressTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string AcceptName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PostCode { get; set; }

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
		public string Area { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Address { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Message { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Remark { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal PayableAmount { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal RealAmount { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal OrderAmount { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Point { get; set; }

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
		public DateTime ConfirmTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime CompleteTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsInvoice { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string InvoiceTitle { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal InvoiceTaxes { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Email { get; set; }

	}
}
