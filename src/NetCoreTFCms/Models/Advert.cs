using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Advert
	{
		//无参构造函数
		public Advert() {}



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
		public byte Type { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal Price { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Remark { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ViewNum { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ViewWidth { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ViewHeight { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Target { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
