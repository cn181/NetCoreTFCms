using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Site
	{
		//无参构造函数
		public Site() {}



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
		public string BuildPath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string TempletPath { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Domain { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsDefault { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SortId { get; set; }

	}
}
