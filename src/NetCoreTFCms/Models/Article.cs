using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Article
	{
		//无参构造函数
		public Article() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ModuleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string CallIndex { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string LinkUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SeoTitle { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SeoKeywords { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SeoDescription { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Zhaiyao { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Content { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SortId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Click { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte Status { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string GroupidsView { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int VoteId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsMsg { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsTop { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsRed { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsHot { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSlide { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSys { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

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
		public string Tags { get; set; }

	}
}
