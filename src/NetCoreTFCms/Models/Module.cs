using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Module
	{
		//无参构造函数
		public Module() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SiteId { get; set; }

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
		public byte IsAlbums { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsAttach { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsGroupPrice { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int SortId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public byte IsSpec { get; set; }

	}
}
