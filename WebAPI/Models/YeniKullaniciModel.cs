﻿using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
	public class YeniKullaniciModel
	{
		// react formuna göre belirlenecek
		public string? PhotoByte { get; set; }

        public string FirstName { get; set; } = null!;
		public string? SecondName { get; set; }

		public string LastName { get; set; } = null!;
		public string? SecondLastName { get; set; }

		public string Gender { get; set; } = null!;

		public string? Job { get; set; }

		public string? Department { get; set; }

		public string? Email { get; set; } = null!;
		public DateOnly BirthDate { get; set; }
		public string? BirthPlace { get; set; }
		public string IdentityNumber { get; set; } = null!;
		public DateOnly DateOfRecruitment { get; set; }
		public DateOnly? DateOfDismissal { get; set; }

		public string? Address { get; set; }

		[Precision(18, 2)]
		public decimal? Salary { get; set; }

		public string? SalaryType { get; set; }

		public string? CompanyName { get; set; } = null!;

		public string? Contact { get; set; }
	}
}
