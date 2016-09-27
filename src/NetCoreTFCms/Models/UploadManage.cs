using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UploadManage
	{
		//无参构造函数
		public UploadManage() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string CategoryName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string OriginalName { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UploadFile { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string FileType { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string UserIp { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
