using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuestionarioApp.ViewModels;
using QuestionarioBisiness.Interfaces;
using QuestionarioBisiness.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionarioApp.Controllers
{
	public class FormularioController : Controller
	{
		private readonly IFormularioRepository _formularioRepository;
		private readonly IMapper _mapper;

		public FormularioController(IFormularioRepository formularioRepository, IMapper mapper)
		{
			_formularioRepository = formularioRepository;
			_mapper = mapper;
		}

		// GET: FornecedorController
		public async Task<ActionResult> Index()
		{
			return View(_mapper.Map<IEnumerable<FormularioViewModel>>( await _formularioRepository.ObterTodos()));
		}

		// GET: FornecedorController/Details/5
		public async Task<ActionResult> Details(Guid id)
		{
			var formularioViewModel = await ObterFormularioResposta(id);
			if (formularioViewModel == null)
			{
				return NotFound();
			}
			return View(formularioViewModel);
		}

		// GET: FornecedorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: FornecedorController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(FormularioViewModel formularioViewModel)
		{
				if (!ModelState.IsValid) return View(formularioViewModel);
				var formulario = _mapper.Map<Formulario>(formularioViewModel);
				await _formularioRepository.Adicionar(formulario);

				return RedirectToAction(nameof(Index));
		}

		// GET: FornecedorController/Edit/5
		public async Task<ActionResult> Edit(Guid id)
		{
			var fornecedorViewModel = await _formularioRepository.ObterPerguntaResposta(id);
			if (fornecedorViewModel == null)
			{
				return View(fornecedorViewModel);
			}
			
			return NotFound();
		}

		// POST: FornecedorController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(Guid id, FormularioViewModel formularioViewModel)
		{
			if (id != formularioViewModel.Id) return NotFound();

			if(!ModelState.IsValid) return View(formularioViewModel);

			var formulario = _mapper.Map<Formulario>(formularioViewModel);
			await _formularioRepository.Atualizar(formulario);

			return RedirectToAction("Index");
			
				
			
		}

		// GET: FornecedorController/Delete/5
		public async Task<ActionResult> DeleteConfirmed(Guid id)
		{
			var formularioViewModel = await _formularioRepository.ObterPerguntaResposta(id);
			if (formularioViewModel == null) return NotFound();

			return View(formularioViewModel);
		}

		// POST: FornecedorController/Delete/5
		[HttpPost,ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Delete(Guid id)
		{
			var formularioViewModel = await ObterFormularioResposta(id);
			if (formularioViewModel == null) return NotFound();
			
			await _formularioRepository.Remover(id);

			return RedirectToAction("Index");
	
		}

		private async Task<FormularioViewModel> ObterFormularioResposta(Guid id)
		{
			var formulario = await _formularioRepository.ObterPerguntaResposta(id);
			return _mapper.Map<FormularioViewModel>(formulario);


			
		}
	}
}
