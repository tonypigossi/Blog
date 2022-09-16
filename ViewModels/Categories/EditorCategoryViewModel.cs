using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(40, MinimumLength = 3, ErrorMessage ="O nome deve conter no mínimo 3 caracteres e no máximo 40 caracteres!")]
        public string Name { get; set; } 

        [Required(ErrorMessage = "O campo Slug é obrigatório!")]   
        public string Slug { get; set; }
        
    }
}