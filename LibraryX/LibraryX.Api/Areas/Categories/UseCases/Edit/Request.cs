using System.ComponentModel.DataAnnotations;

namespace LibraryX.Api.Areas.Categories.UseCases.Edit;

public class Request : IRequest
{
    [Required(ErrorMessage = "'Id' é um campo obrigatório.")]
    public Guid Id { get; set; }
    
    [Display(Name = "Título")]
    [Required(ErrorMessage = "'Título' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Título' precisa conter um mínimo de 2 caracteres.")]
    [MaxLength(80, ErrorMessage = "'Título' pode conter um máximo de 80 caracteres.")]
    public string Title { get; set; } = string.Empty;
    
    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "'Descrição' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Descrição' precisa conter um mínimo de 2 caracteres.")]
    public string Description { get; set; } = string.Empty;
}