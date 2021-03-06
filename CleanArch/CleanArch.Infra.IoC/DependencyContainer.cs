﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Application layer
			services.AddScoped<ICourseService, CourseService>();

			// Data Layer Indra.Data
			services.AddScoped<ICourseRepository, CourseRepository>();

		}
	}
}
