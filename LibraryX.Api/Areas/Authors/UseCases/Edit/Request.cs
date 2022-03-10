namespace LibraryX.Api.Areas.Authors.UseCases.Edit;

public class Request : IRequest
{
    [Required(ErrorMessage = "'Id' é um campo obrigatório.")]
    public Guid Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "'Nome' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Nome' precisa conter um mínimo de 2 caracteres.")]
    [MaxLength(80, ErrorMessage = "'Nome' pode conter um máximo de 80 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Display(Name = "Sobrenome")]
    [Required(ErrorMessage = "'Sobrenome' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Sobrenome' precisa conter um mínimo de 2 caracteres.")]
    [MaxLength(80, ErrorMessage = "'Sobrenome' pode conter um máximo de 80 caracteres.")]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Nacionalidade")]
    [Required(ErrorMessage = "'Nacionalidade' é um campo obrigatório.")]
    [MinLength(2, ErrorMessage = "'Nacionalidade' precisa conter um mínimo de 2 caracteres.")]
    [MaxLength(80, ErrorMessage = "'Nacionalidade' pode conter um máximo de 80 caracteres.")]
    public string Nationality { get; set; } = string.Empty;

    [Display(Name = "E-mail")]
    [Required(ErrorMessage = "'E-mail' é um campo obrigatório.")]
    [MinLength(8, ErrorMessage = "'E-mail' precisa conter um mínimo de 8 caracteres.")]
    [MaxLength(160, ErrorMessage = "'E-mail' pode conter um máximo de 160 caracteres.")]
    [DataType(DataType.EmailAddress, ErrorMessage = "O 'E-mail' é invalido.")]
    public string Email { get; set; } = string.Empty;
}