using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Gather
	{
		//无参构造函数
		public Gather() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RuleName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Charset { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Count { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsDownPic { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsEmptyGather { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsTitleSameGather { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsAudit { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsReverse { get; set; }

		/// <summary>
		/// 是否POST数据
		/// <summary>
		public int IsPost { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListUrlArea { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListIndexUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string RefererUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListUrlStartVar { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListUrlEndVar { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsListUrlReverse { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ContentUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string TitleRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ContentRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ContentNextRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ClearHtml { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OldStr { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ReplaceStr { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OtherField { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OtherRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string CookieStr { get; set; }

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
		public string ContentUrlReplace { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PicUrl { get; set; }

	}
}
