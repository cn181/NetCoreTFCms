using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class Label
	{
		//无参构造函数
		public Label() {}



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
		public string Readme { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Html { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
