using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleGoods
	{
		//无参构造函数
		public ArticleGoods() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ArticleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string GoodsNo { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SpecIds { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SpecText { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int StockQuantity { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal MarketPrice { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal SellPrice { get; set; }

	}
}
