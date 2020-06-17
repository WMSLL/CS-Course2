using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels
{
    public class UpdateCityViewModel
    {	
		[Required]
		[MaxLength(4095)]
		public string Description { get; set; }

		[Range(1, 100000000)]
		public int Population { get; set; }
	}
}
