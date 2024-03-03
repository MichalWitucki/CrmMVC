﻿using CrmMVC.Application.Interfaces;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.Project;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CrmMVC.Web.Controllers
{
	public class ProjectController : Controller
	{
		private readonly IProjectService _projectService;
		private readonly ILogger<ProjectController> _logger;

		public ProjectController(IProjectService projectService, ILogger<ProjectController> logger)
        {
            _projectService = projectService;
			_logger = logger;
        }

		[HttpGet]
		public IActionResult Index()
		{
			ListProjectVm projects = _projectService.GetAllForList(10, 1, "", "", "", "");
			return View(projects);
		}

		[HttpGet]
		public IActionResult Create()
		{
			var voivodeships = _projectService.GetVoivodeships().ToList();
			var statuses = _projectService.GetStatuses().ToList();
			var types = _projectService.GetTypes().ToList();
			var vm = new AddProjectVm()
			{
				Voivodeships = voivodeships,
				Statuses = statuses,
				Types = types
			};
			return View(vm);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(AddProjectVm project)
		{
			_projectService.AddProject(project);
			return RedirectToAction(nameof(Index));
		}
	}
}