using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mereo.Domain.Validation;

namespace Mereo.Domain.Entity
{
    public class UrlGoogle
    {
        public string? URL { get; private set; }

        public bool TituloValido { get; private set; }

        public UrlGoogle(string? url, bool tituloValido)
        {
            Validation(url);
            URL = url;
            TituloValido = tituloValido; 
        }

        public void Validation(string? url)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(url), "Erro ao criar url, não pode ser vazia ou nula");
            DomainExceptionValidation.When(url != "https://google.com", "Erro, não é a url do google");
        }
    }
}