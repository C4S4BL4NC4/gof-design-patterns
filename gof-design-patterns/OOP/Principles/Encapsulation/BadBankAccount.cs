using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Encapsulation
{
    internal class BadBankAccount
    {
        // Exposing the balance field publicly violates the principle of encapsulation, as it allows direct access to the internal state of the object. This can lead to unintended modifications and compromise the integrity of the data.
        public decimal balance = 0;
    }
}
