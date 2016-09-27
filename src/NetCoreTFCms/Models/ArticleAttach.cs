using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleAttach
	{
		//无参构造函数
		public ArticleAttach() {}



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
		public string FileName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string FilePath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int FileSize { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string FileExt { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int DownNum { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Point { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
