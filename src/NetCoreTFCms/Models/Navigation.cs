using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Navigation
	{
		//无参构造函数
		public Navigation() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string NavType { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Title { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string SubTitle { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string LinkUrl { get; set; }

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
		public string Remark { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ClassList { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ClassLayer { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ModuleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string ActionType { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSys { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string IconUrl { get; set; }

	}
}
