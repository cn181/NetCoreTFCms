using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleCategory
	{
		//无参构造函数
		public ArticleCategory() {}



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
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string CallIndex { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ClassList { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ClassLayer { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SortId { get; set; }

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
		public string Content { get; set; }

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
		public string ChannelTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ListTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ArticleTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MobileChannelTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MobileListTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MobileArticleTemplate { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ChannelRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ChannelListRule { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ArticleRule { get; set; }

	}
}
