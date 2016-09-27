using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class AdvertBar
	{
		//无参构造函数
		public AdvertBar() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int Aid { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string FilePath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string LinkUrl { get; set; }

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
		public byte IsLock { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
