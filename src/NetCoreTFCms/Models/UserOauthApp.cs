using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UserOauthApp
	{
		//无参构造函数
		public UserOauthApp() {}



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
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string AppId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string AppKey { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Remark { get; set; }

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
		public string ApiPath { get; set; }

	}
}
