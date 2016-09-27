using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserMessage
	{
		//无参构造函数
		public UserMessage() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte Type { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PostUserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string AcceptUserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsRead { get; set; }

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
		public DateTime PostTime { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime ReadTime { get; set; }

	}
}
