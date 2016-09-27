using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleTagsRelation
	{
		//无参构造函数
		public ArticleTagsRelation() {}



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
		public int TagId { get; set; }

	}
}
