using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleImagesSize
	{
		//无参构造函数
		public ArticleImagesSize() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Height { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Width { get; set; }

	}
}
