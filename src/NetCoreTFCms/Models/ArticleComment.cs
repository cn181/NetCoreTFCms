using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ArticleComment
	{
		//无参构造函数
		public ArticleComment() {}



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
		public int ArticleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int UserId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserIp { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Content { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsLock { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsReply { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ReplyContent { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime ReplyTime { get; set; }

	}
}
