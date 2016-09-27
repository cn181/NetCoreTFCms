using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserGroupPrice
	{
		//无参构造函数
		public UserGroupPrice() {}



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
		public int GroupId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal Price { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int GoodsId { get; set; }

	}
}
