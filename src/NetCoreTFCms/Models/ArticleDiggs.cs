using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleDiggs
	{
		//无参构造函数
		public ArticleDiggs() {}



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
		public int DiggGood { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int DiggBad { get; set; }

	}
}
