using MediatR;
using System.Collections.Generic;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Events
{
    public sealed class RegisteredClientEvent : INotification
    {
        #region Properties

        public string RazaoSocial { get; private set; }

        #endregion
        #region Constructor

        private RegisteredClientEvent() { }

        #endregion
        #region Factory

        public static RegisteredClientEvent Create(string razaoSocial) =>
            new RegisteredClientEvent
            {
                RazaoSocial = razaoSocial,
            };

        #endregion
    }
}
