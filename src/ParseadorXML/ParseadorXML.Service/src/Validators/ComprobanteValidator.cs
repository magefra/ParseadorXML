using FluentValidation;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Service.src.Validators
{
    public class ComprobanteValidator : AbstractValidator<Comprobante>
    {
        public ComprobanteValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });
        }
    }
}
