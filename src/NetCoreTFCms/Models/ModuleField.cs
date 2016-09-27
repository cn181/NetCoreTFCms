using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTFCms.Models
{
	///<summary>
	///
	///<summary>
	public class ModuleField
	{
		//无参构造函数
		public ModuleField() {}



		/// <summary>
		/// 
		/// <summary>
		public int Id { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int ModuleId { get; set; }

		/// <summary>
		/// 
		/// <summary>
		public int FieldId { get; set; }

	}
}
