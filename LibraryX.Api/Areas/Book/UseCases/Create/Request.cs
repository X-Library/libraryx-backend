namespace LibraryX.Api.Areas.Book.UseCases.Create;

public class Request : IRequest
{
    [Display(Name = "Título")]
    [Required(ErrorMessage = "'Título' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Título' precisa conter um mínimo de 2 caracteres.")]
    [MaxLength(80, ErrorMessage = "'Título' pode conter um máximo de 80 caracteres.")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Descrição")]
    [MaxLength(160, ErrorMessage = "'Descrição' pode conter um máximo de 160 caracteres.")]
    public string Description { get; set; } = string.Empty;

    [Display(Name = "Resumo")]
    public string Summary { get; set; } = string.Empty;

    [Display(Name = "ISSN")]
    [Required(ErrorMessage = "'ISSN' é um campo obrigatório.")]
    [StringLength(13, ErrorMessage = "'ISSN' precisa conter um código de 13 caracteres.")]
    public string ISSN { get; set; } = string.Empty;
}