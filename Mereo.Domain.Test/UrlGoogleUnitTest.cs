using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Mereo.Domain.Entity;
using Mereo.Domain.Validation;
using Xunit;

namespace Mereo.Domain.Test
{
    public class UrlGoogleUnitTest
    {
        [Fact(DisplayName = "Create UrlGoogle With Valid State")]
        public void CreateUrlGoogle_WithValidParamters_ResultObjectValidState()
        {
            Action action = () => new UrlGoogle("https://google.com", true);
            action.Should().NotThrow<DomainExceptionValidation>();
        }
        [Fact]
        public void CreateUrlGoogle_EmptyUrl_DomainExceptionValidation()
        {
            Action action = () => new UrlGoogle("", true);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Erro ao criar url, não pode ser vazia ou nula");
        }
        [Fact]
        public void CreateUrlGoogle_NullUrl_DomainExceptionValidation()
        {
            Action action = () => new UrlGoogle(null, true);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Erro ao criar url, não pode ser vazia ou nula");
        }

        [Fact]
        public void CreateUrlGoogle_IsNotGoogleUrl_DomainExceptionValidation()
        {
            Action action = () => new UrlGoogle("https://youtube.com", true);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Erro, não é a url do google");
        }
    }
}