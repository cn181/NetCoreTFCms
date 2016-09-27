using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Feedback
	{
		//无参构造函数
		public Feedback() {}



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
		public string Content { get; set; }

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
		public string UserQQ { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserEmail { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ReplyContent { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime ReplyTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsLock { get; set; }

	}
}
