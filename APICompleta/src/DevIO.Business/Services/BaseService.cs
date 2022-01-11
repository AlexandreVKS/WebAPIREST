using System.ComponentModel.DataAnnotations;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Notifications;
using FluentValidation;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            if (validationResult.ErrorMessage is not null)
            Notificar(validationResult.ErrorMessage);
            // foreach (var error in validationResult.Errors)
            // {
            //     Notificar(error);
            // }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if(validator.IsValid) return true;

            // Notificar(validator);
            foreach (var error in validator.Errors)
            {
                Notificar(error.ErrorMessage);
            }

            return false;
        }
        
    }
}