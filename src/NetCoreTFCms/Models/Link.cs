using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Link
	{
		//无参构造函数
		public Link() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserTel { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Email { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SiteUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsImage { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SortId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsRed { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int IsLock { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
