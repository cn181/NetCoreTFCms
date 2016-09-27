using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class OrderGoods
	{
		//无参构造函数
		public OrderGoods() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int GoodsId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string GoodsTitle { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal GoodsPrice { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal RealPrice { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Quantity { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Point { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ArticleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SpecText { get; set; }

	}
}
