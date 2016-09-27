using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class DiyPage
	{
		//无参构造函数
		public DiyPage() {}



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
		public string FileName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string FilePath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MobileFilePath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Template { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Html { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string CharSet { get; set; }

	}
}
