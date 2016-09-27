using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class MailTemplate
	{
		//无参构造函数
		public MailTemplate() {}



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
		public string CallIndex { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string MailTitle { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Content { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSys { get; set; }

	}
}
