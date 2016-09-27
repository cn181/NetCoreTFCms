using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class UpdateReg
	{
		//无参构造函数
		public UpdateReg() {}



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
		public string Name { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PublicKey { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string PrivateKey { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Password { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Users { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public string Config { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int TryDays { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public decimal Price { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public DateTime AddTime { get; set; }

	}
}
